Imports System.Windows.Forms
Imports DataDynamics.ActiveReports
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient


Module ModMain
    Public D0 As String = Chr(249)
    Public D As String = Chr(250) ' ú
    Public L As String = Chr(255) ' ÿ
    Public D1 As String = Chr(251) ' û
    Public D2 As String = Chr(252) ' ü
    Public D3 As String = Chr(253) ' ý
    Public D4 As String = Chr(254) ' þ
    Public D20 As String = Chr(200) ' È
    Public SpecDir As String = GetADSCommandDirectory() & "\Specs\"
    Private image As Net.Mime.MediaTypeNames.Image
    Private page As Integer
    Private close As Boolean
    Private TreeInfo As String
    Private index As Integer
    Private DataDB As SqlClient.SqlConnection
    Private dtCompareHW As DataTable
    Private dtMissingHW As DataTable
    Private dtNoMatchHW As DataTable
    Public METRIC_OUTPUT As Integer
    Public METRIC_INPUT As Integer
    Public METRIC_CONV As Double
    Public sAddedDoors As String = ""
    Public sRemovedDoors As String = ""
    Public AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
    'Public DBServerPort As String = "SQL2005B\SQL2005B,1433"   'Live Server
    'Public DBServerPort As String = "SQL2005C"  'Beta Server
    Public DBServerPort As String = "segbgsdb05.ad.global\sql2" 'EMEA
    'Private DBServerPort As String = "10.90.9.175,1433"   'new live server
    Private DBPass As String = "8@n@^a5Z"
    Private DBUser As String = "ADAUser"
    Private ADSDBName As String = "ADS_UAT_UK"
    Private AAOSDBName As String = "AAOS_UAT_UK"
    Private ReportLangISO As String = "EN"
    Private ImagesPath As String = "\\segbgsis103\AlanT\Collateral Data UK\"






    Public bTestMode As Boolean = False

    Sub Main()
        'On Error GoTo ErrHandler
        Try
            'LoadFieldDescTable()

            'Arguments
            '1 - Report Name
            '2 - UOM - Imperial or Metric
            '3 - ProjectID 1
            '4 - ProjectID 2
            '5 - Save To Path
            '6 - File Format - PDF or EXCEL
            '7 - SQL Statement or Where clause
            '8 - Report Title
            Dim sPath As String = AppPath
            If sPath.Substring(sPath.Length - 1, 1) <> "\" Then sPath &= "\"
            If My.Computer.FileSystem.FileExists(sPath & "NetInfo.ini") = True Then
                Dim readText() As String = File.ReadAllLines(sPath & "NetInfo.ini")
                If readText.Count >= 3 Then
                    DBServerPort = readText(0)
                    DBPass = readText(1)
                    DBUser = readText(2)
                End If
                If readText.Count >= 6 Then
                    ADSDBName = readText(3).Trim
                    AAOSDBName = readText(4).Trim
                    ReportLangISO = readText(5).Trim
                End If

                If readText.Count >= 7 Then
                    ImagesPath = readText(6).Trim
                End If
            End If

            ' Append a backslash to the root images path so it's in a standard format when appended with the images path later
            If Right$(ImagesPath, 1) <> "\" Then ImagesPath = ImagesPath & "\"

            Dim commands As String = Microsoft.VisualBasic.Interaction.Command()
            If bTestMode = True Then
                commands = Chr(34) & "COMPAREDOORSúIMPERIALú11949ú12486úC:\CompareReport.pdfúPDFúúú" & Chr(34)
                'commands = Chr(34) & "COMPAREDOORSúIMPERIALú18978ú18979úC:\CompareReport.pdfúPDFúúú" & Chr(34)

                'commands = Chr(34) & "DOORSCHEDULEúIMPERIALúúúC:\DoorAndFrameSchedule.pdfúPDFúSELECT * FROM AAOSDoors WHERE (ProjectID = 10221) AND (DoorMaterial LIKE '%hollow metal%')úú" & Chr(34)

                'commands = Chr(34) & "HARDWAREESTIMATEúIMPERIALú13439úúC:\HardwareEstimate.pdfúPDFúúú" & Chr(34)
                'commands = Chr(34) & "HARDWAREESTIMATEúIMPERIALú15324úúC:\HardwareEstimate.pdfúPDFúúú" & Chr(34)
                'commands = Chr(34) & "HARDWAREESTIMATEúIMPERIALú10727úúC:\HardwareEstimate.pdfúPDFúúú" & Chr(34)

                'commands = Chr(34) & "HARDWAREESTIMATECOSTúIMPERIALú15324úúC:\HardwareEstimateCost.pdfúPDFúúú" & Chr(34)

                'commands = Chr(34) & "HARDWARESETESTIMATEúIMPERIALú14393úúC:\HardwareSetEstimate.pdfúPDFúúú" & Chr(34)

                'commands = Chr(34) & "HARDWARESETESTIMATECOSTúIMPERIALú14393úúC:\HardwareSetEstimateCost.pdfúPDFúúú" & Chr(34)
                'commands = Chr(34) & "HARDWARESETESTIMATECOSTúIMPERIALú12856úúC:\HardwareSetEstimateCost.pdfúPDFúúú" & Chr(34)

                'commands = Chr(34) & "DOORESTIMATEúIMPERIALú12836úB2CAAD30A5383DFCF527DB15C327E22A.tomcat1úC:\DoorEstimate.pdfúPDFúúHollow Metal Door Estimateú" & Chr(34)
                'commands = Chr(34) & "DOORESTIMATEúIMPERIALú12362ú47090C954AAB1E172785D155DC87EB21.tomcat1úC:\DoorEstimate.pdfúPDFúúHollow Metal Door Estimateú" & Chr(34)

                'commands = Chr(34) & "FRAMEESTIMATEúIMPERIALúFRMB2CAAD30A5383DFCF527DB15C327E22A.tomcat1úC:\FrameEstimate.pdfúPDFúúDoor Frame Estimateú" & Chr(34)
                'commands = Chr(34) & "FRAMEESTIMATEúIMPERIALú12572úFRM3091E818A0F1FECD31653274C7BAAD0B.tomcat1úC:\FrameEstimate.pdfúPDFúúHollow Metal Frame Estimateú" & Chr(34)
                'commands = Chr(34) & "FRAMEESTIMATEúIMPERIALú12362úFRMC796BC4926E762B38D8E983A368CD615.tomcat1úC:\FrameEstimate.pdfúPDFúúHollow Metal Frame Estimateú" & Chr(34)

                'commands = Chr(34) & "DOORSCHEDULEúIMPERIALúúúC:\DoorAndFrameSchedule.xlsúEXCELúSELECT * FROM AAOSDoors WHERE (ProjectID = 13369) AND (DoorMaterial LIKE '%wood%')ú" & Chr(34)

                'frm Reports

                'HARDWARESUMMARYúMETRICú28396úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28396\Hardware_Summary.pdfúPDFúúHardware Summaryú4344úfalse
                'DOORHARDWARESCHEDULEúMETRICú28396úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28396\Door_Hardware_Schedule.pdfúPDFúúDoor Hardware Scheduleú4344úfalse


                'frmDoorSchedule()

                'HARDWARESUMMARYúMETRICú28396úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28396\Hardware_Summary.pdfúPDFúúHardware Summaryú4344úfalse
                'HARDWARESUMMARYúMETRICú28396úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28396\Filtered_Hardware_Summary.pdfúPDFúúFiltered Hardware Summaryú4344útrue


                'rev version.
                'HARDWARESUMMARYúMETRICú28528úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28528\Hardware_Summary.pdfúPDFúúHardware Summaryú4344úfalseú76777


                ' New apac door hardware schedule with hide show uptions.
                'DOORHARDWARESCHEDULEúMETRICú28528úúC:\ADS\ADS\build\web\Projects\alan.tolmich@assaabloy.com\28528\Door_Hardware_Schedule.pdfúPDFúúDoor Hardware Scheduleú4344úfalseútrueþtrueþtrueþtrueþtrueþtrueþtrueþ1.08897

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                ' emea ironmongery set summary
                'IRONMONGERYSETSUMMARYúMETRICú28423úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Ironmongery_Set_Summary.pdfúPDFúúIronmongery Set Summaryú4344útrueúRev72

                ' emea ironmongery schedule
                'IRONMONGERYSCHEDULEúMETRICú28423úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Ironmongery_Schedule.pdfúPDFúúIronmongery Scheduleú4344ú2ú2útrueútrueútrueútrueúRev72

                ' emea ironmongery schedule summary
                'IRONMONGERYSCHEDULESUMMARYúMETRICú28423úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Ironmongery_Schedule_Summary.pdfúPDFúúIronmongery Schedule Summaryú4344ú2ú2útrueútrueútrueútrueúRev72

                ' emea door summary
                'DOORSUMMARYúMETRICú28423úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Door_Summary.pdfúPDFúúDoor Summaryú4344úRev72

                ' emea quotations terms
                'QUOTETERMSúMETRICú28423úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Quote_Terms.pdfúPDFúúú4344úRev72

                ' emea cover letter
                'COVERLETTERúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Cover_Letter.pdfúPDFúúú4344úTrueúFalseúFalseúRev72

                ' emea quotations terms doors
                'QUOTETERMSDOORSúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\UK_Quote_Terms.rtfúRTFúúú4344úRev72

                ' emea timber standard door sizes report
                'TIMBERSTDDOORSIZESúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\Timber_Std_Door_Sizes.pdfúPDFúúú4344úRev72

                ' emea door schedule summary report
                'DOORSCHEDULESUMMARYúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\Door_Schedule_Summary.rtfúRTFúúDoor Schedule Summaryú4344ú2ú2útrueútrueútrueútrueúRev72

                ' emea door schedule summary by door type report
                'DOORSCHEDULESUMMARYBYDOORTYPEúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\Door_Schedule_Summary_By_Door_Type.rtfúRTFúúDoor Schedule Summary By Door Typeú4344ú2ú2útrueútrueútrueútrueúRev72

                ' emea doors and ironmongery set summary report
                'DOORSANDIRONMONGERYSETSUMMARYúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\Doors_And_Ironmongery_Set_Summary.pdfúPDFúúDoors and Ironmongery Set Summaryú4344ú2ú2útrueútrueútrueútrueúRev72

                ' emea detail door schedule report
                'DETAILDOORSCHEDULEúMETRICú28478úúC:\Users\wrightj\Documents\CGI\AA\Output\Detail_Door_Schedule.xlsúXLSúúDetail Door Scheduleú4344ú2ú2útrueútrueútrueútrueúRev72

                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''



            End If

            If commands <> "" Then
                commands = commands.Trim
                If commands.Substring(0, 1) = Chr(34) Then commands = commands.Substring(1, commands.Length - 1)
                If commands.Substring(commands.Length - 1, 1) = Chr(34) Then commands = commands.Substring(0, commands.Length - 1)
                Dim args() As String = commands.Split("ú")
                If args Is Nothing Then
                    WriteToConsole("ERROR - SubMain - Invalid arguments.")
                    End
                End If
                If Not args Is Nothing AndAlso args.Count < 4 Then
                    Dim str1 As String = ""
                    For i As Integer = 0 To args.Count - 1
                        str1 &= args(i)
                    Next
                    WriteToConsole("ERROR - SubMain - Invalid arguments. " & str1)
                    End
                End If

                If args(1).ToUpper = "METRIC" Then
                    METRIC_OUTPUT = 1
                    METRIC_INPUT = 1
                    METRIC_CONV = 1 '25.4
                Else
                    METRIC_OUTPUT = 0
                    METRIC_INPUT = 0
                    METRIC_CONV = 1
                End If
                GenerateReport(args)

                End
            Else
                WriteToConsole("ERROR - SubMain - Invalid Script")
                End
            End If
GetOut:
            Exit Sub
        Catch ex As ApplicationException
            WriteToConsole("ERROR - SubMain " & ex.Message)
            End
            Exit Sub
        End Try
        'ErrHandler:
        '            'SafelyDisplayError(Err, "Main")
        '            WriteToConsole("ERROR - SubMain " & Err.Description)
        '            End
        '            Resume GetOut
        '            Resume
    End Sub

    Private Sub GenerateReport(ByVal arguments() As String)
        'On Error GoTo ErrHandler
        Try
            'MessageBox.Show("Report Name: " & arguments(0).ToUpper.Trim(), "", MessageBoxButtons.OK)
            Select Case arguments(0).ToUpper.Trim
                Case "COMPAREDOORS"
                    If arguments(2) = arguments(3) Then
                        WriteToConsole("ERROR - You cannot compare a project to itself.")
                        End
                    End If
                    CompareDoors(arguments)
                Case "COMPAREHAREDWARESETS"
                    'CompareHardwareSets(arguments)
                Case "WRITETOEXCEL"

                Case "BOM"

                Case "DOORSCHEDULE"
                    Select Case arguments(5).ToUpper
                        Case "PDF", "RTF"
                            CreateDoorFrameSchedulePDF(arguments)
                            'Case "EXCEL", "XLS"
                            '    CreateDoorFrameScheduleExcel(arguments)
                    End Select
                    End
                    Exit Sub

                Case "HARDWAREESTIMATE"
                    CreateHardwareEstimate(arguments)
                    End
                    Exit Sub

                Case "HARDWAREESTIMATECOST"
                    CreateHardwareEstimate(arguments, True)
                    End
                    Exit Sub

                Case "HARDWARESETESTIMATE"
                    CreateHardwareSetEstimate(arguments)
                    End
                    Exit Sub

                Case "HARDWARESETESTIMATECOST"
                    CreateHardwareSetEstimate(arguments, True)
                    End
                    Exit Sub

                Case "DOORESTIMATE"
                    CreateDoorEstimate(arguments, True)
                    End
                    Exit Sub

                Case "FRAMEESTIMATE"
                    CreateDoorEstimate(arguments, False)
                    End
                    Exit Sub

                Case "HARDWARESUMMARY"
                    CreateAPACHardwareEstimate(arguments)
                    End
                    Exit Sub

                Case "DOORHARDWARESCHEDULE"
                    CreateAPACDoorHardwareSchedule(arguments)
                    End
                    Exit Sub

                Case "IRONMONGERYSETSUMMARY"
                    CreateIronMongerySetSummary(arguments)
                    End
                    Exit Sub

                Case "IRONMONGERYSCHEDULE"
                    CreateIronMongerySchedule(arguments)
                    End
                    Exit Sub
                Case "COVERLETTER"
                    CreateCoverLetter(arguments)
                    End
                    Exit Sub
                Case "DOORSUMMARY"
                    CreateDoorSummary(arguments)
                    End
                    Exit Sub
                Case "IRONMONGERYSCHEDULESUMMARY"
                    CreateIronMongeryScheduleSummary(arguments)
                    End
                    Exit Sub
                Case "QUOTETERMS"
                    CreateQuoteTerms(arguments)
                    End
                    Exit Sub
                Case "QUOTETERMSDOORS"
                    CreateQuoteTerms(arguments)
                    End
                    Exit Sub
                Case "HARDWARESCHEDULE"
                    CreateHardwareSchedule(arguments)
                    End
                    Exit Sub
                Case "RFIREPORT"
                    'CreateRFI(arguments)
                    End
                    Exit Sub
                Case "TIMBERSTDDOORSIZES"
                    CreateTimberStdDoorSizes(arguments)
                    End
                    Exit Sub
                Case "DOORSCHEDULESUMMARY"
                    CreateDoorScheduleSummary(arguments)
                    End
                    Exit Sub
                Case "DOORSCHEDULESUMMARYBYDOORTYPE"
                    CreateDoorScheduleSummaryByDoorType(arguments)
                    End
                    Exit Sub
                Case "DOORSANDIRONMONGERYSETSUMMARY"
                    CreateDoorsAndIronmongerySetSummary(arguments)
                    End
                    Exit Sub
                Case "DETAILDOORSCHEDULE"
                    CreateDetailDoorSchedule(arguments)
                    End
                    Exit Sub
                Case Else
                    WriteToConsole("ERROR - Invalid Report Name")
                    'MessageBox.Show("ERROR - In GenerateReport", "", MessageBoxButtons.OK)
                    End
            End Select
            Exit Sub
        Catch ex As Exception
            'MessageBox.Show("GenerateReport - " & ex.StackTrace & "", "ERROR", MessageBoxButtons.OK)

            WriteToConsole("ERROR - GenerateReport " & ex.Message)
            End
            Exit Sub
        End Try
        'ErrHandler:
        '            WriteToConsole("ERROR - Invalid Report Name")
        '            MessageBox.Show("ERROR - In GenerateReport", "", MessageBoxButtons.OK)
        '            End
    End Sub

    Private Function GetADSCommandDirectory() As String
        On Error GoTo ErrHandler

        Dim UserName = Environment.UserName
        Dim UserDir = Environment.GetEnvironmentVariable("UserProfile")
        If Not My.Computer.FileSystem.DirectoryExists(UserDir + "\MyOpeningsStudio") Then
            My.Computer.FileSystem.CreateDirectory(UserDir + "\MyOpeningsStudio")
        End If
        Return UserDir + "\MyOpeningsStudio"
GetOut:
        Exit Function
ErrHandler:
        SafelyDisplayError(Err, "GetADSCommandDirectory")
        Resume GetOut
        Resume
    End Function

    Private Sub SafeDelete(ByVal Path As String)

        Dim Success As Boolean = False
        Dim start As Double = DateAndTime.Timer
        Dim timeout As Double = 10.0
        While Not Success Or DateAndTime.Timer - start > timeout
            Try
                If My.Computer.FileSystem.FileExists(Path) Then
                    My.Computer.FileSystem.DeleteFile(Path)
                End If
                Success = True
            Catch ex As Exception
                Success = False
            End Try
        End While
    End Sub

    Private Sub SafeWrite(ByVal Path As String, ByVal response As String)

        Dim Success As Boolean = False
        Dim start As Double = DateAndTime.Timer
        Dim timeout As Double = 10.0
        While Not Success Or DateAndTime.Timer - start > timeout
            Try
                My.Computer.FileSystem.WriteAllText(Path, response, False)
                Success = True
            Catch ex As Exception
                Success = False
            End Try
        End While
    End Sub

    Private Function SafeRead(ByVal path As String, Optional ByVal encoding As System.Text.Encoding = Nothing) As String
        Dim Success As Boolean = False
        Dim start As Double = DateAndTime.Timer
        Dim timeout As Double = 10.0
        Dim RetVal As String = ""
        While Not Success Or DateAndTime.Timer - start > timeout
            Try
                If Not encoding Is Nothing Then
                    RetVal = My.Computer.FileSystem.ReadAllText(path, encoding)
                Else
                    RetVal = My.Computer.FileSystem.ReadAllText(path)
                End If
                Success = True
            Catch ex As Exception
                Success = False
            End Try
        End While
        Return RetVal
    End Function

    Private Sub ProcessAppletCommand()

    End Sub

    Public Sub Wait(ByVal WaitTime As Double)
        Dim Start As Double = DateAndTime.Timer
        Do
        Loop Until DateAndTime.Timer - Start > WaitTime
    End Sub

    Public Sub SafelyDisplayError(ByVal err As ErrObject, Optional ByVal ProcName As String = "")
        'SafeWrite(SpecDir & "Writing.tmp", "")
        'SafeWrite(SpecDir & "Response.ini", "Error in " & ProcName & ":  " & err.Description)  'My.Computer.FileSystem.WriteAllText(SpecDir & "Response.ini", "Error in " & ProcName & ": " & err.Description, False)
        'SafeDelete(SpecDir & "Writing.tmp")
        WriteToConsole("ERROR - " & err.Description)
    End Sub

    Private Sub CompareDoors(ByVal arguments() As String)
        On Error GoTo ErrHandler

        'Try
        Dim dr As DataRow
        Dim K1 As Integer
        Dim sPrevMark As String = ""
        Dim PrjID1 As Integer = CInt(arguments(2))
        Dim PrjID2 As Integer = CInt(arguments(3))
        Dim sPrjName1 As String
        Dim sPrjName2 As String
        Dim bHasMatch As Boolean = False
        Dim sField1 As String, sField2 As String
        Dim i As Integer

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim dcFieldDesc As New DataCls("SELECT * FROM FieldDescriptions WHERE (TableName = 'AAOSDoors') AND (ShowInReport = 1) ORDER BY FieldNo", DataDB)
        Dim dcAAOSProjects As New DataCls("SELECT * FROM AAOSProjects WHERE ID = " & PrjID1 & " OR ID = " & PrjID2 & " ORDER BY ID", DataDB)

        '********************************************************************

        Dim dtCompare As DataTable = CreateDataTable("PKeys,MarkNumbers,FieldName,Project1,Project2", "P,T,T,T,T")

        '********************************************************************

        'Get list of added and removed doors
        Dim dtAddRemove As DataTable = CreateDoorAddRemoveTable()
        Dim strQ As String = "SELECT * FROM AAOSDoors WHERE (Mark NOT IN (SELECT Mark FROM AAOSDoors AS AAOSDoors_1 WHERE (ProjectID = " & PrjID2.ToString & "))) AND (ProjectID = " & PrjID1.ToString & ") ORDER BY MARK"
        Dim dc1 As DataCls
        Dim sNoMatchList As String = ""
        Dim dvAddRemove As New DataView(dtAddRemove.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim dcAAOSDoors As New DataCls("SELECT * FROM AAOSDoors WHERE " & sNoMatchList & "(ProjectID = " & PrjID1 & " OR ProjectID = " & PrjID2 & ") ORDER BY MARK", DataDB)
        Dim dv1 As New DataView(dcAAOSDoors.DT, "ProjectID = " & PrjID1.ToString, "Mark", DataViewRowState.CurrentRows)
        Dim dv2 As New DataView(dcAAOSDoors.DT, "ProjectID = " & PrjID2.ToString, "Mark", DataViewRowState.CurrentRows)

        Dim colName As DataColumn
        colName = New DataColumn("AlreadyProcessed34")
        colName.DataType = GetType(Boolean)
        colName.DefaultValue = False
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "AlreadyProcessed34"  'Use ProjectName
        dv1.Table.Columns.Add(colName)

        colName = New DataColumn("MarkList")
        colName.DataType = GetType(String)
        colName.MaxLength = -1
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "MarkList"  'Use ProjectName
        dv1.Table.Columns.Add(colName)

        colName = New DataColumn("UniqueID")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "UniqueID"  'Use ProjectName
        dv1.Table.Columns.Add(colName)

        Dim str1 As String = ""
        For i = 0 To dv1.Count - 1
            If i >= dv1.Count Then Exit For
            If isRowDeletedOpening(NullCheckStr(dv1(i).Item("ChangeLog"))) = True Then
                dv1(i).Delete()
                i -= 1  'Row was removed, so the count has to be adjusted
            Else
                str1 = NullCheckStr(dv1(i).Item("RevitID"))
                dv1(i).Item("UniqueID") = str1.Substring(str1.LastIndexOf(Chr(251)) + 1).Trim
            End If
        Next

        For i = 0 To dv2.Count - 1
            If i >= dv2.Count Then Exit For
            If isRowDeletedOpening(NullCheckStr(dv2(i).Item("ChangeLog"))) = True Then
                dv2(i).Delete()
                i -= 1  'Row was removed, so the count has to be adjusted
            Else
                str1 = NullCheckStr(dv2(i).Item("RevitID"))
                dv2(i).Item("UniqueID") = str1.Substring(str1.LastIndexOf(Chr(251)) + 1).Trim
            End If
        Next

        Dim i1 As Integer
        Dim i2 As Integer
        Dim iGroupID As Integer
        Dim drv1 As DataRowView
        Dim bEqual As Boolean = False
        Dim iRemain1 As Integer = dv1.Count
        Dim iRemain2 As Integer = dv2.Count
        Dim sFieldName As String = ""
        Dim iStart1 As Integer = 0
        Dim iStart2 As Integer = 0
        Dim dvCompare As DataView = CreateDataView("PKeys,TypeDescription,Description,MarkNumbers,FieldNames,Project1,Project2,FoundMatch,ProjectID,DoorMarkNumbers", "P,S,S,T,T,T,T,B,I,T")
        Dim sFieldNames As New System.Text.StringBuilder("")
        Dim sPrj1 As New System.Text.StringBuilder("")
        Dim sPrj2 As New System.Text.StringBuilder("")
        Dim sMark As String
        Dim bContinueWhile As Boolean = False
        Dim dvFind(2) As System.Object
        Dim sFind2(1) As String

        sAddedDoors = ""
        sRemovedDoors = ""

        dvCompare.Sort = "FieldNames,Project1,Project2"

        While iRemain1 > 0 Or iRemain2 > 0
            sFieldNames.Length = 0
            sPrj1.Length = 0
            sPrj2.Length = 0

            i1 = -1
            i2 = -1

            For i = iStart1 To dv1.Count - 1
                If dv1(i).Item("AlreadyProcessed34") = False Then i1 = i : If i = iStart1 Then iStart1 += 1 : Exit For
            Next

            If i1 > -1 Then
                For i = iStart2 To dv2.Count - 1
                    If dv2(i).Item("AlreadyProcessed34") = False Then
                        If dv1(i1).Item("UniqueID").Equals(dv2(i).Item("UniqueID")) = True Then
                            i2 = i : If i = iStart2 Then iStart2 += 1 : Exit For
                        End If
                    End If
                Next
            Else
                For i = iStart2 To dv2.Count - 1
                    If dv2(i).Item("AlreadyProcessed34") = False Then i2 = i : If i = iStart2 Then iStart2 += 1 : Exit For
                Next

                If i2 > -1 Then
                    For i = iStart1 To dv1.Count - 1
                        If dv1(i).Item("AlreadyProcessed34") = False Then
                            If dv2(i2).Item("UniqueID").Equals(dv1(i).Item("UniqueID")) = True Then
                                i1 = i : If i = iStart1 Then iStart1 += 1 : Exit For
                            End If
                        End If
                    Next
                End If
            End If



            If i1 > -1 Or i2 > -1 Then
                If i1 = -1 Then
                    If sAddedDoors <> "" Then sAddedDoors &= ", "
                    sAddedDoors &= dv2(i2).Item("Mark")
                    dv2(i2).Item("AlreadyProcessed34") = True : iRemain2 -= 1
                    Continue While
                End If

                If i2 = -1 Then
                    If sRemovedDoors <> "" Then sRemovedDoors &= ", "
                    sRemovedDoors &= dv1(i1).Item("Mark")
                    dv1(i1).Item("AlreadyProcessed34") = True : iRemain1 -= 1
                    Continue While
                End If

                For j As Integer = 0 To dcFieldDesc.DT.Rows.Count - 1

                    sFieldName = dcFieldDesc.DT.Rows(j).Item("FieldName")
                    If Not ((i1 > -1 AndAlso NullCheckStr(dv1(i1).Item("FrameElevation")).ToUpper Like "*CUSTOM*") Or (i2 > -1 AndAlso NullCheckStr(dv2(i2).Item("FrameElevation")).ToUpper Like "*CUSTOM*")) AndAlso (sFieldName.ToUpper = "ELEVATIONPANELS" Or sFieldName.ToUpper = "ELEVATIONROWS") Then
                        Continue For
                    End If

                    sField1 = "" : sField2 = ""
                    If i1 > -1 Then sField1 = NullCheckStr(dv1(i1).Item(sFieldName))
                    If i2 > -1 Then sField2 = NullCheckStr(dv2(i2).Item(sFieldName))
                    If sField1 <> sField2 AndAlso sFieldName.ToUpper Like "*PRICE*" Then
                        If sField1.Trim = "||" Then sField1 = ""
                        If sField2.Trim = "||" Then sField2 = ""
                        If IsNumeric(sField1) = True Then sField1 = Math.Round(Val(sField1), 2).ToString
                        If IsNumeric(sField2) = True Then sField2 = Math.Round(Val(sField2), 2).ToString
                    End If

                    If sField1 <> sField2 AndAlso sFieldName.ToUpper = "LEAFSIZES" Then
                        If sField1.ToUpper Like "FALSE|*" Then sField1 = "" : dv1(i1).Item(sFieldName) = sField1
                        If sField2.ToUpper Like "FALSE|*" Then sField2 = "" : dv2(i2).Item(sFieldName) = sField2
                        If sField1.ToUpper Like "TRUE|*" Then sField1 = sField1.Replace("True|", "Unequal Pair|") : dv1(i1).Item(sFieldName) = sField1
                        If sField2.ToUpper Like "TRUE|*" Then sField2 = sField2.Replace("True|", "Unequal Pair|") : dv2(i2).Item(sFieldName) = sField2
                    End If

                    If Not (i1 > -1 And i2 > -1) OrElse sField1 <> sField2 Then
                        If sField1.Trim = sField2.Trim Then
                            LookForTrailingSpaces(sField1, sField2)
                            dv1(i1).Item(sFieldName) = sField1
                            dv2(i2).Item(sFieldName) = sField2
                        End If

                        If i1 > -1 And i2 > -1 Then
                            If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv1(i1).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" AndAlso dv2(i2).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                        Else
                            If i1 > -1 Then If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv1(i1).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                            If i2 > -1 Then If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv2(i2).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                        End If

                        sFieldNames.Append(dcFieldDesc.DT.Rows(j).Item("Description"))
                        sFieldNames.Append(Chr(250))
                        If i1 > -1 Then sPrj1.Append(dv1(i1).Item(sFieldName)) : sPrj1.Append(Chr(250))
                        If i2 > -1 Then sPrj2.Append(dv2(i2).Item(sFieldName)) : sPrj2.Append(Chr(250))
                    End If
                Next
                If i1 > -1 Then dv1(i1).Item("AlreadyProcessed34") = True : iRemain1 -= 1
                If i2 > -1 Then dv2(i2).Item("AlreadyProcessed34") = True : iRemain2 -= 1

                If i1 > -1 And i2 > -1 AndAlso dv1(i1).Item("Mark") <> dv2(i2).Item("Mark") Then
                    sMark = dv1(i1).Item("Mark") & ">>" & dv2(i2).Item("Mark")
                Else
                    If i1 > -1 Then
                        sMark = dv1(i1).Item("Mark")
                    Else
                        sMark = dv2(i2).Item("Mark")
                    End If
                End If
                If sFieldNames.ToString = "Mark" & Chr(250) Then  'If the only thing changed is the mark number then put it with Add / Removed Doors
                    dvAddRemove.Sort = "Mark1,Mark2"

                    sFind2(0) = dv1(i1).Item("Mark")
                    sFind2(1) = dv2(i2).Item("Mark")
                    iFind = dvAddRemove.Find(sFind2)
                    If iFind = -1 Then
                        drv = dvAddRemove.AddNew
                        drv("Mark1") = dv1(i1).Item("Mark")
                        drv("Mark2") = dv2(i2).Item("Mark")
                        drv("Change") = "Mark Number Changed"
                        drv.EndEdit()
                    End If
                Else
                    dvFind(0) = sFieldNames.ToString
                    dvFind(1) = sPrj1.ToString
                    dvFind(2) = sPrj2.ToString
                    K1 = dvCompare.Find(dvFind)
                    If K1 > -1 Then
                        dvCompare(K1).Item("MarkNumbers") &= dv1(i1).Item("Mark") & ","
                    Else
                        drv1 = dvCompare.AddNew
                        drv1("MarkNumbers") = sMark & ","
                        drv1("FieldNames") = sFieldNames.ToString
                        drv1("Project1") = sPrj1.ToString
                        drv1("Project2") = sPrj2.ToString
                        drv1.EndEdit()
                    End If
                End If
            Else
                iRemain1 = 0
                iRemain2 = 0
            End If
        End While

        Dim arrFields() As String
        Dim arrPrj1() As String
        Dim arrPrj2() As String
        For i = 0 To dvCompare.Count - 1
            sMark = dvCompare(i).Item("MarkNumbers")
            arrFields = dvCompare(i).Item("FieldNames").ToString.Split(Chr(250))
            arrPrj1 = dvCompare(i).Item("Project1").ToString.Split(Chr(250))
            arrPrj2 = dvCompare(i).Item("Project2").ToString.Split(Chr(250))

            For j As Integer = 0 To arrFields.Count - 2
                dr = dtCompare.NewRow
                If sMark.Substring(sMark.Length - 1) = "," Then sMark = sMark.Substring(0, sMark.Length - 1)
                dr("MarkNumbers") = sMark.Replace(",", ", ")
                If j < arrFields.Count Then dr("FieldName") = arrFields(j)
                If j < arrPrj1.Count Then dr("Project1") = arrPrj1(j)
                If j < arrPrj2.Count Then dr("Project2") = arrPrj2(j)
                dtCompare.Rows.Add(dr)
            Next
        Next

        dtAddRemove = dvAddRemove.ToTable
        CompareHardwareSets(arguments, dcAAOSProjects)

        'Create and export report to pdf
        Dim rpt As New rptCompareDoors()
        rpt.DataSource = dtCompare
        rpt.dtAddRemoveDoors = dtAddRemove
        rpt.dtHardwareSets = dtCompareHW
        rpt.dtAddRemoveHWSets = dtMissingHW
        rpt.dtUnmatchedHW = dtNoMatchHW
        Dim iRec1 As Integer = 0, iRec2 As Integer = 1
        If dcAAOSProjects.DT.Rows(0).Item("ID") = PrjID2 Then iRec1 = 1 : iRec2 = 0

        sPrjName1 = dcAAOSProjects.DT.Rows(iRec1).Item("ProjectName")
        sPrjName2 = dcAAOSProjects.DT.Rows(iRec2).Item("ProjectName")
        If NullCheckLong(dcAAOSProjects.DT.Rows(iRec1).Item("RevisionNumber")) > 0 Then
            sPrjName1 &= "-Revision " & NullCheckLong(dcAAOSProjects.DT.Rows(iRec1).Item("RevisionNumber"))
        End If
        If NullCheckLong(dcAAOSProjects.DT.Rows(iRec2).Item("RevisionNumber")) > 0 Then
            sPrjName2 &= "-Revision " & NullCheckLong(dcAAOSProjects.DT.Rows(iRec2).Item("RevisionNumber"))
        End If

        rpt.ProjName1 = sPrjName1  '"QC-C1500P"
        rpt.ProjName2 = sPrjName2  '"QC-C1500P-2"
        'Run the report, and set it to the viewer control on the form
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        'AlanT

        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")
GetOut:
        If Not dcAAOSDoors Is Nothing Then dcAAOSDoors.Dispose()
        dcAAOSDoors = Nothing
        If Not dcAAOSProjects Is Nothing Then dcAAOSProjects.Dispose()
        dcAAOSProjects = Nothing
        If Not dcFieldDesc Is Nothing Then dcFieldDesc.Dispose()
        dcFieldDesc = Nothing

        End
        Exit Sub
        'Catch ex As Exception
        '    MessageBox.Show("CompareDoors - " & ex.StackTrace & "", "ERROR", MessageBoxButtons.OK)
        '    WriteToConsole("ERROR - CompareDoors " & ex.Message)
        '    End
        '    Exit Sub
        '    Resume
        'End Try
        Exit Sub
ErrHandler:
        Debug.Print(Err.Description)
        WriteToConsole("ERROR - CompareDoors " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume
    End Sub

    'Private Sub CompareHardwareSets(ByVal arguments() As String, ByRef dcAAOSProjects As DataCls, ByRef dvDoorHWSetList As DataView)
    Private Sub CompareHardwareSets(ByVal arguments() As String, ByRef dcAAOSProjects As DataCls)
        On Error GoTo ErrHandler

        'Try
        Dim dr As DataRow
        Dim K1 As Integer
        Dim sPrevMark As String = ""
        Dim PrjID1 As Integer = CInt(arguments(2))
        Dim PrjID2 As Integer = CInt(arguments(3))
        Dim bHasMatch As Boolean = False
        Dim dcFieldDesc As New DataCls("SELECT * FROM FieldDescriptions WHERE (TableName = 'AAOSHWSets') AND (ShowInReport = 1) ORDER BY FieldNo", DataDB)

        '********************************************************************

        Dim PKeys(0) As DataColumn
        Dim colName As DataColumn
        Dim sField1 As String, sField2 As String

        Dim dtCompare As DataTable = CreateDataTable("PKeys,MarkNumbers,TypeDescription,FieldName,Project1,Project2,DoorMarkNumbers", "P,T,S,S,T,T,T")

        '********************************************************************

        'Get list of added and removed doors
        Dim dtAddRemove As DataTable = CreateDoorAddRemoveTable()
        Dim strQ As String = "SELECT * FROM AAOSHWSets WHERE (SetName NOT IN (SELECT SetName FROM AAOSHWSets AS AAOSHWSets_1 WHERE (ProjectID = " & PrjID2.ToString & "))) AND (ProjectID = " & PrjID1.ToString & ") ORDER BY ID"
        Dim dc1 As New DataCls(strQ, DataDB)
        Dim sNoMatchList As String = ""
        Dim dvAddRemove As New DataView(dtAddRemove.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView

        dvAddRemove.Sort = "Mark1"
        sNoMatchList = ""
        For i As Integer = 0 To dc1.DT.Rows.Count - 1
            sNoMatchList &= dc1.DT.Rows(i).Item("ID") & ","
            iFind = dvAddRemove.Find(dc1.DT.Rows(i).Item("SetName"))
            If iFind = -1 Then
                drv = dvAddRemove.AddNew
                drv("Mark1") = dc1.DT.Rows(i).Item("SetName")
                drv.EndEdit()
            End If
        Next
        dc1.Dispose()

        dvAddRemove.Sort = "Mark2"
        strQ = "SELECT * FROM AAOSHWSets WHERE (SetName NOT IN (SELECT SetName FROM AAOSHWSets AS AAOSHWSets_1 WHERE (ProjectID = " & PrjID1.ToString & "))) AND (ProjectID = " & PrjID2.ToString & ") ORDER BY ID"
        dc1 = New DataCls(strQ, DataDB)
        For i As Integer = 0 To dc1.DT.Rows.Count - 1
            sNoMatchList &= dc1.DT.Rows(i).Item("ID") & ","
            iFind = dvAddRemove.Find(dc1.DT.Rows(i).Item("SetName"))
            If iFind = -1 Then
                drv = dvAddRemove.AddNew
                drv("Mark2") = dc1.DT.Rows(i).Item("SetName")
                drv.EndEdit()
            End If
        Next
        dc1.Dispose()
        dc1 = Nothing

        dtAddRemove = dvAddRemove.ToTable

        If sNoMatchList <> "" Then
            If sNoMatchList.Substring(sNoMatchList.Length - 1, 1) = "," Then sNoMatchList = sNoMatchList.Substring(0, sNoMatchList.Length - 1)
            If sNoMatchList <> "" Then sNoMatchList = "(ID NOT IN (" & sNoMatchList & ")) AND "
        End If

        Dim dcAAOSHWSets As New DataCls("SELECT * FROM AAOSHWSets WHERE " & sNoMatchList & "(ProjectID = " & PrjID1 & " OR ProjectID = " & PrjID2 & ") ORDER BY ID", DataDB)

        Dim dv1 As New DataView(dcAAOSHWSets.DT, "ProjectID = " & PrjID1.ToString, "SetName, TypeDescription, Description, Mfr", DataViewRowState.CurrentRows)
        Dim dv2 As New DataView(dcAAOSHWSets.DT, "ProjectID = " & PrjID2.ToString, "SetName, TypeDescription, Description, Mfr", DataViewRowState.CurrentRows)


        'These add the columns to both dv1 and dv2 at the same time.
        colName = New DataColumn("AlreadyProcessed34")
        colName.DataType = GetType(Boolean)
        colName.DefaultValue = False
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "AlreadyProcessed34"  'Use ProjectName
        dv1.Table.Columns.Add(colName)

        colName = New DataColumn("MarkList")
        colName.DataType = GetType(String)
        colName.MaxLength = -1
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "MarkList"  'Use ProjectName
        dv1.Table.Columns.Add(colName)

        Dim i1 As Integer
        Dim i2 As Integer
        Dim iGroupID As Integer
        Dim drv1 As DataRowView
        Dim bEqual As Boolean = False
        Dim iRemain1 As Integer = dv1.Count
        Dim iRemain2 As Integer = dv2.Count
        Dim sFieldName As String = ""
        Dim iStart1 As Integer = 0
        Dim iStart2 As Integer = 0
        Dim dvCompare As DataView = CreateDataView("PKeys,TypeDescription,Description,MarkNumbers,FieldNames,Project1,Project2,FoundMatch,ProjectID,DoorMarkNumbers", "P,S,S,T,T,T,T,B,I,T")
        Dim sFieldNames As New System.Text.StringBuilder("")
        Dim sPrj1 As New System.Text.StringBuilder("")
        Dim sPrj2 As New System.Text.StringBuilder("")
        Dim sSetName As String
        Dim sTypeDesc As String
        Dim sDescription As String
        Dim bFoundMatch As Boolean = False

        Dim dvFind(3) As System.Object
        dvCompare.Sort = "TypeDescription,FieldNames,Project1,Project2"


        'Loop thru doors to get hardware set names (HWSet).
        While iRemain1 > 0 Or iRemain2 > 0
            sFieldNames.Length = 0
            sPrj1.Length = 0
            sPrj2.Length = 0
            'If dv1(i1).Item("SetName") = "19.0" Then Stop
            i1 = -1
            i2 = -1
            For i = iStart1 To dv1.Count - 1
                If dv1(i).Item("AlreadyProcessed34") = False Then i1 = i : If i = iStart1 Then iStart1 += 1 : Exit For
            Next

            If i1 > -1 Then
                'First look for match by SetName, TypeDescription, Description
                For i = iStart2 To dv2.Count - 1
                    If dv2(i).Item("AlreadyProcessed34") = False Then
                        If dv1(i1).Item("SetName").Equals(dv2(i).Item("SetName")) = True And dv1(i1).Item("TypeDescription").Equals(dv2(i).Item("TypeDescription")) = True And dv1(i1).Item("Description").Equals(dv2(i).Item("Description")) = True Then
                            i2 = i : If i = iStart2 Then iStart2 += 1 : Exit For
                        End If
                    End If
                Next

                'Second look for match by SetName, TypeDescription
                If i2 = -1 Then
                    For i = iStart2 To dv2.Count - 1
                        If dv2(i).Item("AlreadyProcessed34") = False Then
                            If dv1(i1).Item("SetName").Equals(dv2(i).Item("SetName")) = True And dv1(i1).Item("TypeDescription").Equals(dv2(i).Item("TypeDescription")) = True Then
                                i2 = i : If i = iStart2 Then iStart2 += 1 : Exit For
                            End If
                        End If
                    Next
                End If
            Else
                For i = iStart2 To dv2.Count - 1
                    If dv2(i).Item("AlreadyProcessed34") = False Then i2 = i : If i = iStart2 Then iStart2 += 1 : Exit For
                Next

                'First look for match by SetName, TypeDescription, Description
                If i2 > -1 Then
                    For i = iStart1 To dv1.Count - 1
                        If dv1(i).Item("AlreadyProcessed34") = False Then
                            If dv2(i2).Item("SetName").Equals(dv1(i).Item("SetName")) = True And dv2(i2).Item("TypeDescription").Equals(dv1(i).Item("TypeDescription")) = True And dv2(i2).Item("Description").Equals(dv1(i).Item("Description")) = True Then
                                i1 = i : If i = iStart1 Then iStart1 += 1 : Exit For
                            End If
                        End If
                    Next

                    'Second look for match by SetName, TypeDescription
                    If i1 = -1 Then
                        For i = iStart1 To dv1.Count - 1
                            If dv1(i).Item("AlreadyProcessed34") = False Then
                                If dv2(i2).Item("SetName").Equals(dv1(i).Item("SetName")) = True And dv2(i2).Item("TypeDescription").Equals(dv1(i).Item("TypeDescription")) = True Then
                                    i1 = i : If i = iStart1 Then iStart1 += 1 : Exit For
                                End If
                            End If
                        Next
                    End If
                End If
            End If

            If i1 > -1 Or i2 > -1 Then
                For j As Integer = 0 To dcFieldDesc.DT.Rows.Count - 1
                    sFieldName = dcFieldDesc.DT.Rows(j).Item("FieldName")
                    sField1 = "" : sField2 = ""
                    If i1 > -1 Then sField1 = NullCheckStr(dv1(i1).Item(sFieldName))
                    If i2 > -1 Then sField2 = NullCheckStr(dv2(i2).Item(sFieldName))
                    If sField1 <> sField2 AndAlso sFieldName.ToUpper Like "*PRICE*" Then
                        If IsNumeric(sField1) = True Then sField1 = Math.Round(Val(sField1), 2).ToString
                        If IsNumeric(sField2) = True Then sField2 = Math.Round(Val(sField2), 2).ToString
                    End If

                    If Not (i1 > -1 And i2 > -1) OrElse sField1 <> sField2 Then
                        If i1 > -1 And i2 > -1 Then
                            If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv1(i1).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" AndAlso dv2(i2).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                        Else
                            If i1 > -1 Then If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv1(i1).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                            If i2 > -1 Then If dv1.Table.Columns(dcFieldDesc.DT.Rows(j).Item("FieldName")).DataType.ToString.ToUpper = "System.String".ToUpper AndAlso dv2(i2).Item(dcFieldDesc.DT.Rows(j).Item("FieldName")) = "" Then Continue For
                        End If

                        sFieldNames.Append(dcFieldDesc.DT.Rows(j).Item("Description"))
                        sFieldNames.Append(Chr(250))
                        If i1 > -1 Then sPrj1.Append(dv1(i1).Item(sFieldName)) : sPrj1.Append(Chr(250))
                        If i2 > -1 Then sPrj2.Append(dv2(i2).Item(sFieldName)) : sPrj2.Append(Chr(250))
                    End If
                Next
                If i1 > -1 Then dv1(i1).Item("AlreadyProcessed34") = True : iRemain1 -= 1
                If i2 > -1 Then dv2(i2).Item("AlreadyProcessed34") = True : iRemain2 -= 1
                If sPrj1.ToString = "" And sPrj2.ToString = "" Then Continue While

                If i1 > -1 And i2 > -1 Then bFoundMatch = True Else bFoundMatch = False

                If i1 > -1 Then
                    sSetName = dv1(i1).Item("SetName").ToString.Trim
                    sTypeDesc = dv1(i1).Item("TypeDescription")
                    sDescription = dv1(i1).Item("Description")
                Else
                    sSetName = dv2(i2).Item("SetName").ToString.Trim
                    sTypeDesc = dv2(i2).Item("TypeDescription")
                    sDescription = dv2(i2).Item("Description")
                End If

                dvFind(0) = sTypeDesc
                'dvFind(1) = sDescription
                dvFind(1) = sFieldNames.ToString
                dvFind(2) = sPrj1.ToString
                dvFind(3) = sPrj2.ToString
                K1 = dvCompare.Find(dvFind)
                If K1 > -1 Then
                    If i1 > -1 Then
                        dvCompare(K1).Item("MarkNumbers") &= dv1(i1).Item("SetName") & ","
                    Else
                        dvCompare(K1).Item("MarkNumbers") &= dv2(i2).Item("SetName") & ","
                    End If
                Else
                    drv1 = dvCompare.AddNew
                    drv1("TypeDescription") = sTypeDesc
                    drv1("Description") = sDescription
                    drv1("MarkNumbers") = sSetName & ","
                    drv1("FieldNames") = sFieldNames.ToString
                    drv1("Project1") = sPrj1.ToString
                    drv1("Project2") = sPrj2.ToString
                    If bFoundMatch = False Then
                        If i1 > -1 Then
                            drv1("ProjectID") = PrjID1.ToString
                        Else
                            drv1("ProjectID") = PrjID2.ToString
                        End If
                    End If
                    drv1("FoundMatch") = bFoundMatch
                    drv1.EndEdit()
                End If


            Else
                iRemain1 = 0
                iRemain2 = 0
            End If
        End While

        dtNoMatchHW = CreateNoMatchHWTable()
        Dim dvNoMatchHW As New DataView(dtNoMatchHW.Clone)
        Dim dvFind2(3) As System.Object
        dvNoMatchHW.Sort = "TypeDescription, Description, Manufacturer, Change"

        Dim arrFields() As String
        Dim arrPrj1() As String
        Dim arrPrj2() As String
        Dim arrSetNames() As String
        For i = 0 To dvCompare.Count - 1
            sTypeDesc = dvCompare(i).Item("TypeDescription")
            sSetName = dvCompare(i).Item("MarkNumbers")
            arrFields = dvCompare(i).Item("FieldNames").ToString.Split(Chr(250))
            arrPrj1 = dvCompare(i).Item("Project1").ToString.Split(Chr(250))
            arrPrj2 = dvCompare(i).Item("Project2").ToString.Split(Chr(250))
            sSetName = sSetName.Substring(0, sSetName.Length - 1)
            arrSetNames = sSetName.Split(",")
            Array.Sort(arrSetNames)
            sSetName = String.Join(",", arrSetNames)
            sSetName = sSetName.Replace(",", ", ")
            For j As Integer = 0 To arrFields.Count - 2
                dr = dtCompare.NewRow
                dr("TypeDescription") = sTypeDesc
                dr("MarkNumbers") = sSetName.Trim
                If j < arrFields.Count Then dr("FieldName") = arrFields(j)
                If j < arrPrj1.Count Then dr("Project1") = arrPrj1(j)
                If j < arrPrj2.Count Then dr("Project2") = arrPrj2(j)
                dtCompare.Rows.Add(dr)
            Next
        Next

        If dtNoMatchHW IsNot Nothing AndAlso dtNoMatchHW.Rows.Count > 0 Then
            'Combine all records to find matches
            dvCompare.Table.Clear()
            dtNoMatchHW.DefaultView.Sort = "MarkNumber, TypeDescription, Description, Manufacturer, Change"
            dtNoMatchHW = dtNoMatchHW.DefaultView.ToTable
            Dim sPrevSet As String = ""
            sPrj1.Length = 0
            For i = 0 To dtNoMatchHW.Rows.Count - 1
                For j As Integer = 2 To 5
                    sPrj1.Append(dtNoMatchHW.Rows(i).Item(j)) : sPrj1.Append(Chr(250))
                Next
                sPrj1.Append(Chr(255))
                sPrevMark = dtNoMatchHW.Rows(i).Item("MarkNumber")

                If i <= dtNoMatchHW.Rows.Count - 1 Then
                    If i = dtNoMatchHW.Rows.Count - 1 OrElse sPrevMark <> dtNoMatchHW.Rows(i + 1).Item("MarkNumber") Then
                        drv1 = dvCompare.AddNew
                        drv1("MarkNumbers") = dtNoMatchHW.Rows(i).Item("MarkNumber")
                        drv1("Project1") = sPrj1.ToString
                        drv1.EndEdit()
                        sPrj1.Length = 0
                    End If
                End If
            Next

            'Group like sets together
            Dim dvCompare2 As New DataView(dvCompare.Table.Clone)
            dvCompare2.Sort = "Project1"
            For i = 0 To dvCompare.Count - 1
                K1 = dvCompare2.Find(dvCompare(i).Item("Project1"))
                If K1 > -1 Then
                    dvCompare2(K1).Item("MarkNumbers") &= dvCompare(i).Item("MarkNumbers") & ","
                Else
                    drv1 = dvCompare2.AddNew
                    drv1("MarkNumbers") = dvCompare(i).Item("MarkNumbers") & ","
                    drv1("Project1") = dvCompare(i).Item("Project1")
                    drv1.EndEdit()
                End If
            Next

            'Write back out to dtNoMatchHW
            dtNoMatchHW.Clear()
            For i = 0 To dvCompare2.Count - 1
                arrPrj1 = dvCompare2(i).Item("Project1").ToString.Split(Chr(255))
                sSetName = dvCompare2(i).Item("MarkNumbers")
                If sSetName.Substring(sSetName.Length - 1) = "," Then sSetName = sSetName.Substring(0, sSetName.Length - 1)
                sSetName = sSetName.Replace(",", ", ")
                For j = 0 To arrPrj1.Count - 2
                    arrPrj2 = arrPrj1(j).Split(Chr(250))
                    dr = dtNoMatchHW.NewRow
                    dr("MarkNumber") = sSetName
                    dr("TypeDescription") = arrPrj2(0)
                    dr("Description") = arrPrj2(1)
                    dr("Manufacturer") = arrPrj2(2)
                    dr("Change") = arrPrj2(3)
                    dtNoMatchHW.Rows.Add(dr)
                Next
            Next
        End If

        dtNoMatchHW.DefaultView.Sort = "MarkNumber, TypeDescription, Description, Manufacturer"
        dtNoMatchHW = dtNoMatchHW.DefaultView.ToTable
        dtCompareHW = dtCompare
        dtMissingHW = dtAddRemove
GetOut:
        If Not dc1 Is Nothing Then dc1.Dispose()
        dc1 = Nothing
        If Not dcAAOSHWSets Is Nothing Then dcAAOSHWSets.Dispose()
        dcAAOSHWSets = Nothing
        If Not dcFieldDesc Is Nothing Then dcFieldDesc.Dispose()
        dcFieldDesc = Nothing
        Exit Sub
        'Catch ex As Exception
        '    MessageBox.Show("CompareDoors - " & ex.StackTrace & "", "ERROR", MessageBoxButtons.OK)
        '    WriteToConsole("ERROR - CompareDoors " & ex.Message)
        '    End
        '    Exit Sub
        '    Resume
        'End Try
        Exit Sub
ErrHandler:
        Debug.Print(Err.Description)
        'Stop
        WriteToConsole("ERROR - CompareHardwareSets " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    Public Sub PrintDataTable(ByVal DT As DataTable)
        On Error GoTo ErrHandler
        Dim i As Integer
        Dim tstr As New System.Text.StringBuilder("")
        Dim tstr4 As String
        Dim ColWidths(DT.Columns.Count) As Integer
        Dim d1 As String = Chr(200) & Chr(255) & Chr(251)
        Dim d2 As String = Chr(201) & Chr(254) & Chr(253)

        For i = 0 To DT.Columns.Count - 1
            If ColWidths(i) < DT.Columns(i).ColumnName.Length Then ColWidths(i) = DT.Columns(i).ColumnName.Length
            tstr.Append(DT.Columns(i).ColumnName & d1)
        Next
        tstr.Append(d2)

        For j As Integer = 0 To DT.Rows.Count - 1
            For i = 0 To DT.Columns.Count - 1
                If ColWidths(i) < DT.Rows(j).Item(i).ToString.Length Then ColWidths(i) = DT.Rows(j).Item(i).ToString.Length
                tstr.Append(DT.Rows(j).Item(i) & d1)
            Next
            tstr.Append(d2)
        Next j

        For i = 0 To ColWidths.Count - 2
            If ColWidths(i) > 30 Then ColWidths(i) = 30
        Next

        Dim tstr2() As String = tstr.ToString.Split(New String() {d2}, StringSplitOptions.None)
        For i = 0 To tstr2.Count - 1
            tstr.Length = 0
            Dim tstr3() As String = tstr2(i).Split(New String() {d1}, StringSplitOptions.None)
            For j As Integer = 0 To tstr3.Count - 1
                If tstr3(j).PadRight(ColWidths(j)).Length > 30 Then
                    tstr4 = tstr3(j).Substring(0, 26) & "..."
                    tstr.Append(tstr4.PadRight(ColWidths(j) + 2))
                Else
                    tstr.Append(tstr3(j).PadRight(ColWidths(j) + 2))
                End If

            Next
            Debug.Print(tstr.ToString)
        Next

        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        Resume Next
        Resume

    End Sub

    Public Sub PrintDataView(ByVal DV As DataView)
        On Error GoTo ErrHandler
        Dim i As Integer
        Dim tstr As New System.Text.StringBuilder("")
        Dim tstr4 As String
        Dim ColWidths(DV.Table.Columns.Count) As Integer
        Dim d1 As String = Chr(200) & Chr(255) & Chr(251)
        Dim d2 As String = Chr(201) & Chr(254) & Chr(253)

        For i = 0 To DV.Table.Columns.Count - 1
            If ColWidths(i) < DV.Table.Columns(i).ColumnName.Length Then ColWidths(i) = DV.Table.Columns(i).ColumnName.Length
            tstr.Append(DV.Table.Columns(i).ColumnName & d1)
        Next
        tstr.Append(d2)

        For j As Integer = 0 To DV.Count - 1
            For i = 0 To DV.Table.Columns.Count - 1
                If ColWidths(i) < DV(j).Item(i).ToString.Length Then ColWidths(i) = DV(j).Item(i).ToString.Length
                tstr.Append(DV(j).Item(i) & d1)
            Next
            tstr.Append(d2)
        Next j

        For i = 0 To ColWidths.Count - 2
            If ColWidths(i) > 30 Then ColWidths(i) = 30
        Next

        Dim tstr2() As String = tstr.ToString.Split(New String() {d2}, StringSplitOptions.None)
        For i = 0 To tstr2.Count - 1
            tstr.Length = 0
            Dim tstr3() As String = tstr2(i).Split(New String() {d1}, StringSplitOptions.None)
            For j As Integer = 0 To tstr3.Count - 1
                If tstr3(j).PadRight(ColWidths(j)).Length > 30 Then
                    tstr4 = tstr3(j).Substring(0, 26) & "..."
                    tstr.Append(tstr4.PadRight(ColWidths(j) + 2))
                Else
                    tstr.Append(tstr3(j).PadRight(ColWidths(j) + 2))
                End If

            Next
            Debug.Print(tstr.ToString)
        Next

        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        Resume Next
        Resume

    End Sub

    Public Sub PrintDataRow(ByVal DR As DataRow)
        On Error GoTo ErrHandler
        Dim i As Integer
        Dim tstr As New System.Text.StringBuilder("")
        Dim tstr4 As String
        Dim ColWidths(DR.Table.Columns.Count) As Integer
        Dim d1 As String = Chr(200) & Chr(255) & Chr(251)
        Dim d2 As String = Chr(201) & Chr(254) & Chr(253)

        For i = 0 To DR.Table.Columns.Count - 1
            If ColWidths(i) < DR.Table.Columns(i).ColumnName.Length Then ColWidths(i) = DR.Table.Columns(i).ColumnName.Length
            tstr.Append(DR.Table.Columns(i).ColumnName & d1)
        Next
        tstr.Append(d2)

        For i = 0 To DR.Table.Columns.Count - 1
            If ColWidths(i) < DR.Item(i).ToString.Length Then ColWidths(i) = DR.Item(i).ToString.Length
            tstr.Append(DR.Item(i) & d1)
        Next
        tstr.Append(d2)

        For i = 0 To ColWidths.Count - 2
            If ColWidths(i) > 30 Then ColWidths(i) = 30
        Next

        Dim tstr2() As String = tstr.ToString.Split(New String() {d2}, StringSplitOptions.None) 'If delimeter is more than one character, it has to be done this way.
        For i = 0 To tstr2.Count - 1
            If tstr2(i) = "" Then Continue For
            tstr.Length = 0
            Dim tstr3() As String = tstr2(i).Split(New String() {d1}, StringSplitOptions.None)
            For j As Integer = 0 To tstr3.Count - 1
                'If tstr3(j) = "" Then Continue For
                If tstr3(j).PadRight(ColWidths(j)).Length > 30 Then
                    tstr4 = tstr3(j).Substring(0, 26) & "..."
                    tstr.Append(tstr4.PadRight(ColWidths(j) + 2))
                Else
                    tstr.Append(tstr3(j).PadRight(ColWidths(j) + 2))
                End If

            Next
            Debug.Print(tstr.ToString)
        Next

        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        Resume Next
        Resume

    End Sub

    Private Sub ExportCSV(ByVal dv As DataView)
        Dim dt As DataTable = dv.ToTable
        Dim sb As New System.Text.StringBuilder("")

        For Each col As DataColumn In dt.Columns
            sb.Append(col.ColumnName + ";")
        Next

        sb.Remove(sb.Length - 1, 1)
        sb.Append(Environment.NewLine)

        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dt.Columns.Count - 1
                sb.Append(row(i).ToString() & ";")
            Next

            sb.Append(Environment.NewLine)
        Next
        My.Computer.FileSystem.WriteAllText("C:\AAOSDoors.csv", sb.ToString, True)
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo("C:\AAOSDoors.csv")
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()
    End Sub

    Private Sub ExportToExcel2(ByVal dv As DataView)
        Dim dt As DataTable = dv.ToTable
        Dim sb As New System.Text.StringBuilder("")

        For Each col As DataColumn In dt.Columns
            sb.Append(col.ColumnName + ";")
        Next

        sb.Remove(sb.Length - 1, 1)
        sb.Append(Environment.NewLine)

        For Each row As DataRow In dt.Rows
            For i As Integer = 0 To dt.Columns.Count - 1
                sb.Append(row(i).ToString() & ";")
            Next

            sb.Append(Environment.NewLine)
        Next
        My.Computer.FileSystem.WriteAllText("C:\AAOSDoors.csv", sb.ToString, True)
        Dim p As New System.Diagnostics.Process
        Dim s As New System.Diagnostics.ProcessStartInfo("C:\AAOSDoors.csv")
        s.UseShellExecute = True
        s.WindowStyle = ProcessWindowStyle.Normal
        p.StartInfo = s
        p.Start()

    End Sub


    Private Function CreateDoorAddRemoveTable() As DataTable
        Dim dt As New DataTable

        Dim colName As DataColumn
        Dim PKeys(0) As DataColumn

        'Primary Key
        colName = New DataColumn("PKeys")
        colName.DataType = GetType(Integer)
        colName.Unique = True
        colName.AllowDBNull = False
        colName.Caption = "PKey"
        colName.AutoIncrement = True
        colName.AutoIncrementSeed = 1
        colName.AutoIncrementStep = 1
        dt.Columns.Add(colName)
        PKeys(0) = colName
        dt.PrimaryKey = PKeys

        'Mark1
        colName = New DataColumn("Mark1")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Mark1"
        dt.Columns.Add(colName)

        'Mark2
        colName = New DataColumn("Mark2")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Mark2"
        dt.Columns.Add(colName)

        'Mark1
        colName = New DataColumn("TypeDescription1")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "TypeDescription1"
        dt.Columns.Add(colName)

        'Mark2
        colName = New DataColumn("TypeDescription2")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "TypeDescription2"
        dt.Columns.Add(colName)

        'Change
        colName = New DataColumn("Change")
        colName.DataType = GetType(String)
        colName.MaxLength = 20
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Change"
        dt.Columns.Add(colName)


        Return dt

    End Function


    Private Function CreateNoMatchHWTable() As DataTable
        Dim dt As New DataTable

        Dim colName As DataColumn
        Dim PKeys(0) As DataColumn

        'Primary Key
        colName = New DataColumn("PKeys")
        colName.DataType = GetType(Integer)
        colName.Unique = True
        colName.AllowDBNull = False
        colName.Caption = "PKey"
        colName.AutoIncrement = True
        colName.AutoIncrementSeed = 1
        colName.AutoIncrementStep = 1
        dt.Columns.Add(colName)
        PKeys(0) = colName
        dt.PrimaryKey = PKeys

        'Description
        colName = New DataColumn("MarkNumber")
        colName.DataType = GetType(String)
        colName.MaxLength = -1
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "MarkNumber"
        dt.Columns.Add(colName)

        'TypeDescription
        colName = New DataColumn("TypeDescription")
        colName.DataType = GetType(String)
        colName.MaxLength = 200
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "TypeDEscription"
        dt.Columns.Add(colName)

        'Description
        colName = New DataColumn("Description")
        colName.DataType = GetType(String)
        colName.MaxLength = 400
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Description"
        dt.Columns.Add(colName)

        'Manufacturer
        colName = New DataColumn("Manufacturer")
        colName.DataType = GetType(String)
        colName.MaxLength = 400
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Manufacturer"
        dt.Columns.Add(colName)

        'Change
        colName = New DataColumn("Change")
        colName.DataType = GetType(String)
        colName.MaxLength = 20
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Change"
        dt.Columns.Add(colName)

        Return dt

    End Function

    Private Sub LoadFieldDescTable()
        On Error GoTo ErrHandler
        Dim DataDB As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim dc1 As New DataCls("SELECT TOP 1 * FROM AAOSHWSets", DataDB)
        Dim dr As DataRow
        Dim dc2 As New DataCls("SELECT * FROM FieldDescriptions WHERE PKey = 0", DataDB, True, True, True)
        For i As Integer = 0 To dc1.DT.Columns.Count - 1
            dr = dc2.DT.NewRow
            dr("TableName") = "AAOSHWSets"
            dr("FieldName") = dc1.DT.Columns(i).ColumnName
            dr("FieldNo") = i
            dr("Description") = dc1.DT.Columns(i).ColumnName
            dr("ShowInReport") = True
            dc2.AddRow(dr)
        Next

        dc1.Dispose()
        dc1 = Nothing
        dc2.Dispose()
        dc2 = Nothing
        DataDB.Close()
        DataDB.Dispose()
        DataDB = Nothing
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - LoadFieldDescTable " & Err.Description)
        End
        Exit Sub
        Resume Next
        Resume
    End Sub

    Public Function FRAC(ByVal RC9 As Double, Optional ByRef DECIMAL_PLACES As Integer = 0, _
Optional ByRef IGNORE_METRIC As Boolean = False, Optional ByRef USE_GLASS_TOLERANCE As Boolean = False) As String
        Dim TOLERANCE As Double = 1
        Dim DECIMAL_FLG As Integer = 0
        Dim GLASS_TOLERANCE As Double = 1 / 32
        Dim R2_ As String = ""
        Dim SIGN As Integer, K2 As Integer, KI As Integer
        If IGNORE_METRIC = False Then
            If METRIC_OUTPUT = 1 Or METRIC_INPUT = 1 Then
                FRAC = FORMAT_NUMBER(RC9, "METRIC")
                Exit Function
            End If
        End If

31740:  If DECIMAL_FLG = 1 Then
            If DECIMAL_PLACES > 0 Then
                FRAC = FORMAT_NUMBER(RC9, CStr(DECIMAL_PLACES) & "-DECIMALS")
                Exit Function
            End If

            FRAC = FORMAT_NUMBER(RC9, "5-DECIMALS")
            Exit Function
        End If
31770:  SIGN = 1
        If RC9 < 0 Then SIGN = -1
        RC9 = System.Math.Abs(RC9) : R2_ = ""

        If IGNORE_METRIC = False Then
31830:      If METRIC_OUTPUT Or METRIC_INPUT Then
                TOLERANCE = 1
                FRAC = FORMAT_NUMBER(RC9 * SIGN, "2-DECIMALS")
                Exit Function
            End If
        End If

        RC9 = RC9 + 0.0015

        If TOLERANCE = 0 Then RC9 = Int(RC9 * 16) / 16
        If USE_GLASS_TOLERANCE = True Then
            If GLASS_TOLERANCE > 0 Then RC9 = Int(RC9 * 16) / 16
        End If
        K2 = Int((RC9 - Int(RC9)) * 32) : KI = 1
        If Not (RC9 <= 0.03) Then GoTo 31890
31860:  R2_ = "0.0"
        FRAC = R2_
        Exit Function
31890:  If Not (K2 = 0) Then GoTo 31950
31920:  R2_ = FSTR_(Int(RC9))
        If SIGN = -1 Then R2_ = "-" & R2_
        FRAC = R2_
        Exit Function
31950:  If Not (K2 \ KI = 2 * ((K2 \ KI) \ 2) And KI < K2) Then GoTo 32010
31980:  KI = KI * 2 : GoTo 31950
32010:  If Int(RC9) > 0 Then R2_ = FSTR_(Int(RC9))
32040:  R2_ = R2_ & " " & FSTR_(K2 \ KI) & "/" & FSTR_(32 \ KI)
32041:  R2_ = R2_.Trim
        If SIGN = -1 Then R2_ = "-" & R2_
        FRAC = R2_
        Exit Function
    End Function

    Public Function FORMAT_NUMBER(ByRef RC9 As Double, Optional ByRef FORMAT_TYPE As String = "") As String

        Dim TEMPSTR As String = ""
        FORMAT_NUMBER = ""
        If FORMAT_TYPE = "" Then FORMAT_TYPE = "DOLLARS"

        Select Case FORMAT_TYPE
            Case "METRIC"
                'FORMAT_NUMBER = Format(RC9 * 25.4, "#.00")
                FORMAT_NUMBER = Format(RC9 * 1, "#.00")
                If METRIC_OUTPUT = 1 And FORMAT_NUMBER.EndsWith(".00") Then
                    FORMAT_NUMBER = Format(RC9, "#")
                End If
            Case "DOLLARS"
                FORMAT_NUMBER = Format(RC9, "#.00")
            Case "4-DECIMALS"
                FORMAT_NUMBER = Format(RC9, "#.0000")
            Case "5-DECIMALS"
                FORMAT_NUMBER = Format(RC9, "#.00000")
            Case "6-DECIMALS"
                FORMAT_NUMBER = Format(RC9, "#.000000")
            Case "3-DECIMALS"
                FORMAT_NUMBER = Format(RC9, "#.000")
            Case "2-DECIMALS"
                FORMAT_NUMBER = Format(RC9, "#.00")
                If METRIC_OUTPUT = 1 And FORMAT_NUMBER.EndsWith(".00") Then
                    FORMAT_NUMBER = Format(RC9, "#")
                End If
            Case "ROUND"
                TEMPSTR = CStr(RC9)
                If 0 = InStr(TEMPSTR, ".") Then
                    FORMAT_NUMBER = CStr(RC9)
                    Exit Function
                End If
                FORMAT_NUMBER = Format(RC9 + 0.5, "#######")

        End Select

    End Function


    Public Function FEETINCH(ByVal RC9 As Double) As String
        Dim RC8, CD As Double
        Dim C8_ As String

        If METRIC_OUTPUT = 1 Then
            If RC9 = 0 Then Return "0 mm"
            Return FORMAT_NUMBER(RC9 * METRIC_CONV, "2-DECIMALS") & " mm"
        Else
            RC8 = Int(RC9 / (1 * 12)) : CD = RC9 / 1 - 12 * RC8
            If CD > 0 Then
                If RC8 = 0 Then
                    C8_ = FRAC(CD, , True) & Chr(34)
                Else
                    C8_ = FSTR_(RC8) & Chr(39) & " " & FRAC(CD, , True) & Chr(34)
                End If
            Else
                C8_ = FSTR_(RC8) & Chr(39)
            End If

        End If

        Return C8_
    End Function

    Private Sub CreateDoorFrameSchedulePDF(ByVal arguments() As String)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer
        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        arguments(6) = arguments(6).Replace("*", "ID, ProjectID, Mark, Usage, UOM, Width, Height, Thickness, FireRating, DoorMaterial, DoorElevation, FrameMaterial, FrameElevation, HWSet, Qty, DoorPrice, FramePrice, Notes, ChangeLog, CustomPrice")
        Dim dc1 As New DataCls(arguments(6), DataDB, False, False, False)
        PrjID1 = dc1.DT.Rows(0).Item("ProjectID")
        Dim dcAAOSProjects As New DataCls("SELECT * FROM AAOSProjects WHERE ID = " & PrjID1 & " ORDER BY ID", DataDB)

        Dim rpt As New rptDoorFrameSchedule
        Dim dv1 As New DataView(dc1.DT)

        'For i As Integer = 0 To dv1.Count - 1
        '    If i >= dv1.Count Then Exit For
        '    If isRowDeletedOpening(NullCheckStr(dv1(i).Item("ChangeLog"))) = True Then
        '        'Debug.Print(dv1(i).Item(2))
        '        dv1(i).Delete()
        '        i -= 1  'Row was removed, so the count has to be adjusted
        '    End If
        'Next

        Dim customPrice As String = ""

        For i As Integer = 0 To dv1.Count - 1
            customPrice = NullCheckStr(dv1(i).Item("CustomPrice")).Trim
            If customPrice <> "" Then
                Dim custPrice() As String = customPrice.Replace("N/A|N/A|", "").Replace("||", "").Split("|")
                If custPrice.Length >= 1 Then
                    If custPrice(0) <> "N/A" And custPrice(0) <> "" Then
                        dv1(i).Item("DoorPrice") = Double.Parse(custPrice(0))
                    End If
                End If
                If custPrice.Length >= 2 Then
                    If custPrice(1) <> "N/A" And custPrice(1) <> "" Then
                        dv1(i).Item("FramePrice") = Double.Parse(custPrice(1))
                    End If
                End If
            End If
        Next


        'If dc1.DT.Rows.Count <> dv1.Count Then dc1.DT = dv1.ToTable
        'rpt.DataSource = dc1.DT
        rpt.DataSource = dv1.ToTable
        rpt.ProjName1 = dcAAOSProjects.DT.Rows(0).Item("ProjectName")  '"QC-C1500P"
        'Run the report, and set it to the viewer control on the form
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If
        'Alan T

        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")
GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If
        If dcAAOSProjects IsNot Nothing Then
            dcAAOSProjects.Dispose()
            dcAAOSProjects = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDoorFrameSchedulePDF " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    '    Private Sub CreateDoorFrameScheduleExcel(ByVal arguments() As String)
    '        On Error GoTo ErrHandler
    '        Dim PrjID1 As Integer
    '        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=ADS;Data Source=" & DBServerPort)
    '        DataDB.Open()
    '        arguments(6) = arguments(6).Replace("*", "ID, ProjectID, Mark, Usage, UOM, Width, Height, Thickness, FireRating, DoorMaterial, DoorElevation, FrameMaterial, FrameElevation, HWSet, Qty, DoorPrice, FramePrice, Notes, ChangeLog, CustomPrice")
    '        Dim dc1 As New DataCls(arguments(6), DataDB, False, False, False)

    '        ''Remove deleted rows
    '        'Dim dv1 As New DataView(dc1.DT)
    '        'For i As Integer = 0 To dv1.Count - 1
    '        '    If i >= dv1.Count Then Exit For
    '        '    If isRowDeletedOpening(NullCheckStr(dv1(i).Item("ChangeLog"))) = True Then
    '        '        'Debug.Print(dv1(i).Item(2))
    '        '        dv1(i).Delete()
    '        '        i -= 1  'Row was removed, so the count has to be adjusted
    '        '    End If
    '        'Next


    '        Dim customPrice As String = ""

    '        For i As Integer = 0 To dc1.DT.Rows.Count() - 1
    '            customPrice = NullCheckStr(dc1.DT.Rows(i).Item("CustomPrice")).Trim
    '            If customPrice <> "" Then
    '                Dim custPrice() As String = customPrice.Replace("N/A|N/A|", "").Replace("||", "").Split("|")
    '                If custPrice.Length >= 1 Then
    '                    If custPrice(0) <> "N/A" And custPrice(0) <> "" Then
    '                        dc1.DT.Rows(i).Item("DoorPrice") = Double.Parse(custPrice(0))
    '                    End If
    '                End If
    '                If custPrice.Length >= 2 Then
    '                    If custPrice(1) <> "N/A" And custPrice(1) <> "" Then
    '                        dc1.DT.Rows(i).Item("FramePrice") = Double.Parse(custPrice(1))
    '                    End If
    '                End If
    '            End If
    '        Next





    '        'If dc1.DT.Rows.Count <> dv1.Count Then dc1.DT = dv1.ToTable
    '        dc1.DT.Columns.RemoveAt(0) 'Remove ID
    '        dc1.DT.Columns.RemoveAt(dc1.DT.Columns.Count - 1) 'Remove ChangeLog

    '        ExportToExcel(dc1.DT, arguments)
    '        dc1.Dispose()
    '        dc1 = Nothing
    '        WriteToConsole("SUCCESSFUL")

    'GetOut:
    '        If dc1 IsNot Nothing Then
    '            dc1.Dispose()
    '            dc1 = Nothing
    '        End If

    '        If DataDB IsNot Nothing Then
    '            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
    '            DataDB.Dispose()
    '            DataDB = Nothing
    '        End If
    '        Exit Sub
    'ErrHandler:
    '        WriteToConsole("ERROR - CreateDoorFrameScheduleExcel " & Err.Description)
    '        GoTo GetOut
    '        Exit Sub
    '        Resume Next
    '        Resume
    '    End Sub

    '  // CreateAPACHardwareEstimate

    Private Sub CreateAPACHardwareEstimate(ByVal arguments() As String, Optional ByVal ShowCost As Boolean = False)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim isFiltered As Boolean = arguments(9)
        Dim RevNo As String = arguments(10)


        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String


        If isFiltered Then



            strQ = "SELECT AAOSProjects.ID,Cast(AAOSProjects.ID AS nvarchar(max)) + " + "'(" + RevNo + ")'" + " IDRev,AAOSProjects.ProjectName,AAOSProjects.ArchProjectID, AAOSProjects.KeyingSystem," & _
             "(AAOSProjects.Address1 + CHAR(13)+CHAR(10) + AAOSProjects.Address2 + CHAR(13)+ CHAR(10) + AAOSProjects.Address3) AS Address " & _
             ",AAOSProjects.Notes,Vnd.ABBR, Vnd.NAME, AAOSHWSets.Product, AAOSHWSets.Description AS Description, " & _
             "sum(Cast(AAOSHWSets.Qty as int) * AAOSDOORS.Qty) as Qty, AAOSHWSets.ProjectID,AAOSHWSets.TypeDescription , " & _
             "AAOSFirms.LastName as ArchCompany,(AAOSConsultants.FirstName + ' ' + AAOSConsultants.LastName) as SalesRep, " & _
             AAOSDBName & ".DBO.HardwareType.Description as HWType, " & _
             "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
             "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max)) " & _
             "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
             "FROM AAOSHWSets  " & _
             "LEFT OUTER JOIN  (select distinct name,abbr from " & AAOSDBName & ".dbo.vendor) Vnd on  AAOSHWSets.Mfr = Vnd.ABBR " & _
             "LEFT OUTER JOIN AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID  " & _
             "LEFT OUTER JOIN AAOSFirms ON AAOSProjects.Architect = AAOSFirms.ID  " & _
             "LEFT OUTER JOIN AAOSConsultants ON AAOSProjects.ArchConsultant = AAOSConsultants.ID " & _
             "LEFT OUTER JOIN " & AAOSDBName & ".DBO.HardwareType on SUBSTRING(Product,0,3) = " & AAOSDBName & ".DBO.HardwareType.HDW_TYPE_ID " & _
             "JOIN AAOSReportJoin on AAOSHWSets.ProjectID = AAOSReportJoin.ProjectID  " & _
             "JOIN AAOSDoors ON AAOSReportJoin.JoinValue =  AAOSDoors.UniqueMark  " & _
             "AND AAOSReportJoin.ProjectID = AAOSDoors.ProjectID and AAOSDoors.HWSet = AAOSHWSets.SetName  " & _
             "WHERE(AAOSHWSets.ProjectID = " & PrjID1.ToString & " And AAOSReportJoin.UserID = " & UsrID.ToString & " And AAOSHWSets.DHI <> 100000) " & _
             "Group By AAOSProjects.ID,AAOSProjects.OriginalProjectID,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName,AAOSProjects.ArchProjectID,AAOSProjects.KeyingSystem,AAOSProjects.Address1,AAOSProjects.Address2," & _
             "AAOSProjects.Address3, AAOSProjects.Notes, Vnd.NAME, Vnd.ABBR,AAOSHWSets.Product, AAOSHWSets.Description, " & _
             "AAOSHWSets.ProjectID, AAOSHWSets.TypeDescription, AAOSHWSets.DHI, " & _
             "AAOSFirms.LastName, AAOSConsultants.FirstName, AAOSConsultants.LastName, " & AAOSDBName & ".DBO.HardwareType.Description " & _
             "Order By AAOSHWSets.DHI"




        Else

            strQ = "SELECT AAOSProjects.ID,Cast(AAOSProjects.ID AS nvarchar(max)) + " + "'(" + RevNo + ")'" + " IDRev,AAOSProjects.ProjectName, AAOSProjects.ArchProjectID,AAOSProjects.KeyingSystem,  " & _
            "(AAOSProjects.Address1 + CHAR(13)+CHAR(10) + AAOSProjects.Address2 + CHAR(13)+ CHAR(10) + AAOSProjects.Address3) AS Address " & _
            ",AAOSProjects.Notes,AAOSHWSets.Mfr ,Vnd.ABBR, Vnd.NAME, AAOSHWSets.Product, AAOSHWSets.Description AS Description, " & _
            "sum(Cast(AAOSHWSets.Qty as int) * AAOSDOORS.Qty) as Qty, AAOSHWSets.ProjectID,AAOSHWSets.TypeDescription ,  " & _
            "AAOSFirms.LastName as ArchCompany,(AAOSConsultants.FirstName + ' ' + AAOSConsultants.LastName) as SalesRep,  " & _
             AAOSDBName & ".DBO.HardwareType.Description as HWType,  " & _
            "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
            "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max))  " & _
            "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
            "FROM AAOSHWSets  " & _
            "LEFT OUTER JOIN  (select distinct name,abbr from " & AAOSDBName & ".dbo.vendor) Vnd on  AAOSHWSets.Mfr = Vnd.ABBR " & _
            "LEFT OUTER JOIN AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID   " & _
            "LEFT OUTER JOIN AAOSFirms ON AAOSProjects.Architect = AAOSFirms.ID   " & _
            "LEFT OUTER JOIN AAOSConsultants ON AAOSProjects.ArchConsultant = AAOSConsultants.ID  " & _
            "LEFT OUTER JOIN " & AAOSDBName & ".DBO.HardwareType on SUBSTRING(Product,0,3) = " & AAOSDBName & ".DBO.HardwareType.HDW_TYPE_ID  " & _
            "JOIN AAOSDoors ON AAOSHWSets.ProjectID =  AAOSDoors.ProjectID   " & _
            "AND  AAOSDoors.HWSet = AAOSHWSets.SetName " & _
            "WHERE(AAOSHWSets.ProjectID = " & PrjID1.ToString & " And AAOSHWSets.DHI <> 100000) " & _
            "Group By AAOSProjects.ID,AAOSProjects.OriginalProjectID,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName,AAOSProjects.ArchProjectID,AAOSProjects.KeyingSystem,AAOSProjects.Address1,AAOSProjects.Address2,  " & _
            "AAOSProjects.Address3, AAOSProjects.Notes, Vnd.NAME, AAOSHWSets.Product, AAOSHWSets.Description, " & _
            "AAOSHWSets.ProjectID, AAOSHWSets.TypeDescription, AAOSHWSets.DHI, AAOSHWSets.Mfr, Vnd.ABBR, " & _
            "AAOSFirms.LastName, AAOSConsultants.FirstName, AAOSConsultants.LastName, " & AAOSDBName & ".DBO.HardwareType.Description " & _
            "Order By AAOSHWSets.DHI"




        End If

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        If dc1.DT.Rows.Count = 0 Then
            WriteToConsole("ERROR - There is no hardware in this project.")
            End
            Exit Sub
        End If
        Dim rpt As New rptAPACBuildingSummary
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.tbRevision.Text = RevNo
        rpt.sPgFooterProjID = NullCheckStr(dc1.DT.Rows(0)("NewProjID"))
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateAPACHardwareEstimate " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub
    ' // CreateAPACHardwareEstimate


    ' //CreateAPACDoorHardwareSchedule
    Private Sub CreateAPACDoorHardwareSchedule(ByVal arguments() As String, Optional ByVal ShowCost As Boolean = False)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim isFiltered As Boolean = arguments(9)
        Dim otherArgs() As String = arguments(10).Split("þ") ' this is the D4 (char 254)
        Dim showHeight As Boolean = otherArgs(0)
        Dim showWidth As Boolean = otherArgs(1)
        Dim showThickness As Boolean = otherArgs(2)
        Dim showHanding As Boolean = otherArgs(3)
        Dim showDoorType As Boolean = otherArgs(4)
        Dim showFrameType As Boolean = otherArgs(5)
        Dim showHWSet As Boolean = otherArgs(6)
        Dim RevNo As String = otherArgs(7)



        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        If isFiltered Then
            strQ = "SELECT AAOSProjects.ID, Cast(AAOSProjects.ID AS nvarchar(max)) + " + "'(" + RevNo + ")'" + " IDRev, AAOSProjects.ProjectName,AAOSProjects.ArchProjectID, AAOSProjects.KeyingSystem," & _
           "(AAOSProjects.Address1 +  ' ' + AAOSProjects.Address2 +  ' '  + AAOSProjects.Address3 + ' ' + AAOSProjects.City  + ' ' + AAOSProjects.State  + ' ' + AAOSPROJECTS.Zip) AS Address " & _
           ",AAOSProjects.Notes, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description AS Description,  AAOSHWSets.SetDesc," & _
           "AAOSHWSets.Qty * AAOSDoors.Qty as Qty, AAOSHWSets.ProjectID,AAOSHWSets.TypeDescription ,AAOSHWSets.SetNotes, " & _
           "AAOSFirms.LastName as ArchCompany,(AAOSConsultants.FirstName + ' ' + AAOSConsultants.LastName) as SalesRep, " & _
           "AAOSDoors.Level, AAOSDoors.Height, AAOSDoors.Width, AAOSDoors.DoorMaterial, AAOSDoors.Thickness, " & _
           "AAOSDoors.Handing, AAOSDoors.FrameMaterial,  CONVERT(nvarchar(max),AAOSDoors.Notes) as DoorNotes, Case when AAOSDoors.Qty = 1 then AAOSDoors.Mark else AAOSDoors.Mark + ' x '+ Cast(AAOSDoors.Qty as VARCHAR(5))  end Mark, AAOSDoors.ToRoom, AAOSHWSets.Finish,AAOSDoors.HWSet, " & _
           "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
           "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max))  " & _
           "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
           "WHERE(AAOSHWSets.ProjectID = " & PrjID1.ToString & " And AAOSReportJoin.UserID = " & UsrID.ToString & " And AAOSHWSets.DHI <> 100000) " & _
           "Group By AAOSProjects.ID,AAOSProjects.OriginalProjectID,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName,AAOSProjects.ArchProjectID, AAOSProjects.KeyingSystem,AAOSProjects.Address1, AAOSProjects.Address2,AAOSProjects.Address3,AAOSProjects.City, " & _
           "AAOSProjects.State, AAOSProjects.Zip, AAOSProjects.Notes, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description, " & _
           "AAOSHWSets.Price, AAOSHWSets.Qty, AAOSHWSets.ProjectID, AAOSHWSets.TypeDescription, AAOSHWSets.SetNotes,AAOSHWSets.DHI, AAOSHWSets.SetDesc,  " & _
           "AAOSFirms.LastName, AAOSConsultants.FirstName, AAOSConsultants.LastName," & _
           "AAOSDoors.Level, AAOSDoors.Height, AAOSDoors.Width, AAOSDoors.DoorMaterial, AAOSDoors.Thickness, " & _
           "AAOSDoors.Handing, AAOSDoors.FrameMaterial,  CONVERT(nvarchar(max),AAOSDoors.Notes) , AAOSDoors.Mark, AAOSDoors.Qty, AAOSDoors.ToRoom, AAOSHWSets.Finish,AAOSDoors.HWSet,AAOSDoors.id " & _
           "Order By AAOSDoors.id, AAOSHWSets.DHI"
        Else




            strQ = "SELECT AAOSProjects.ID, Cast(AAOSProjects.ID AS nvarchar(max)) + " + "'(" + RevNo + ")'" + " IDRev, AAOSProjects.ProjectName,AAOSProjects.ArchProjectID,AAOSProjects.KeyingSystem, " & _
                   "(AAOSProjects.Address1 +  ' ' + AAOSProjects.Address2 +  ' '  + AAOSProjects.Address3 + ' ' + AAOSProjects.City  + ' ' + AAOSProjects.State  + ' ' + AAOSPROJECTS.Zip) AS Address " & _
                   ",AAOSProjects.Notes, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description AS Description, AAOSHWSets.SetDesc, " & _
                   "AAOSHWSets.Qty * AAOSDoors.Qty as Qty , AAOSHWSets.ProjectID,AAOSHWSets.TypeDescription , AAOSHWSets.SetNotes, " & _
                   "AAOSFirms.LastName as ArchCompany,(AAOSConsultants.FirstName + ' ' + AAOSConsultants.LastName) as SalesRep, " & _
                   "AAOSDoors.Level, AAOSDoors.Height, AAOSDoors.Width, AAOSDoors.DoorMaterial, AAOSDoors.Thickness, " & _
                   "AAOSDoors.Handing, AAOSDoors.FrameMaterial, CONVERT(nvarchar(max),AAOSDoors.Notes) as DoorNotes," & _
                   " Case when AAOSDoors.Qty = 1 then AAOSDoors.Mark else AAOSDoors.Mark + ' x '+ Cast(AAOSDoors.Qty as VARCHAR(5))  end Mark, AAOSDoors.ToRoom, AAOSHWSets.Finish,AAOSDoors.HWSet,  " & _
                   "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                   "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max))  " & _
                   "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
                   "FROM AAOSHWSets  LEFT OUTER JOIN  " & AAOSDBName & ".dbo.Vendor ON AAOSHWSets.Mfr = " & AAOSDBName & ".dbo.Vendor.ABBR  " & _
                   "LEFT OUTER JOIN AAOSDoors ON  AAOSHWSets.ProjectID = AAOSDoors.ProjectID and AAOSHWSets.SetName = AAOSDoors.HWSet " & _
                   "LEFT OUTER JOIN AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID  " & _
                   "LEFT OUTER JOIN AAOSFirms ON AAOSProjects.Architect = AAOSFirms.ID  " & _
                   "LEFT OUTER JOIN AAOSConsultants ON AAOSProjects.ArchConsultant = AAOSConsultants.ID " & _
                   "INNER JOIN AAOSReportJoin ON AAOSDoors.ProjectID = AAOSReportJoin.ProjectID  AND AAOSDoors.UniqueMark = AAOSReportJoin.JoinValue " & _
                   "WHERE( AAOSHWSets.ProjectID = " & PrjID1.ToString & " and AAOSReportJoin.UserID = " & UsrID.ToString & " And AAOSHWSets.DHI <> 100000 AND (CHARINDEX('deleted', ChangeLog) < 1)) " & _
                   "Group By AAOSProjects.ID,AAOSProjects.OriginalProjectID,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName,AAOSProjects.ArchProjectID,AAOSProjects.KeyingSystem,AAOSProjects.Address1,AAOSProjects.Address2,AAOSProjects.Address3,AAOSProjects.City, " & _
                   "AAOSProjects.State, AAOSProjects.Zip, AAOSProjects.Notes, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description, AAOSHWSets.SetNotes, " & _
                   "AAOSHWSets.Qty, AAOSHWSets.ProjectID, AAOSHWSets.TypeDescription, AAOSHWSets.DHI, AAOSHWSets.SetDesc, " & _
                   "AAOSFirms.LastName, AAOSConsultants.FirstName, AAOSConsultants.LastName, " & _
                   "AAOSDoors.Level, AAOSDoors.Height, AAOSDoors.Width, AAOSDoors.DoorMaterial, AAOSDoors.Thickness, " & _
                   "AAOSDoors.Handing, AAOSDoors.FrameMaterial, CONVERT(nvarchar(max),AAOSDoors.Notes) ," & _
                   " AAOSDoors.Mark,AAOSDoors.Qty, AAOSDoors.ToRoom, AAOSHWSets.Finish,AAOSDoors.HWSet,AAOSDoors.id " & _
                   "Order By AAOSDoors.id, AAOSHWSets.DHI"

        End If

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        If dc1.DT.Rows.Count = 0 Then
            WriteToConsole("ERROR - There is no hardware in this project.")
            End
            Exit Sub
        End If
        Dim rpt As New rptAPACDoorHardwareSchedule
        rpt.sReportTitle = arguments(7)
        rpt.showHeight = showHeight
        rpt.showWidth = showWidth
        rpt.showThickness = showThickness
        rpt.showHanding = showHanding
        rpt.showDoorType = showDoorType
        rpt.showFrameType = showFrameType
        rpt.showHWSet = showHWSet
        rpt.tbRevision.Text = RevNo
        rpt.sPgFooterProjID = NullCheckStr(dc1.DT.Rows(0)("NewProjID"))


        rpt.DataSource = dc1.DT
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateAPACDoorHardwareSchedule " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    ' //CreateAPACDoorHardwareSchedule


    Private Sub CreateHardwareEstimate(ByVal arguments() As String, Optional ByVal ShowCost As Boolean = False)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim isFiltered As Boolean = arguments(9)


        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String


        If isFiltered Then

            strQ = "SELECT AAOSProjects.ProjectName, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, " & _
                    " AAOSHWSets.Description AS Description,AAOSHWSets.Price, AAOSHWSets.SetName, " & _
                    "AAOSHWSets.Qty, AAOSHWSets.ProjectID, " & _
                    "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                    "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max))  " & _
                    "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
                    "FROM AAOSHWSets " & _
                    "LEFT OUTER JOIN  " & AAOSDBName & ".dbo.Vendor ON AAOSHWSets.Mfr = " & AAOSDBName & ".dbo.Vendor.ABBR " & _
                    "LEFT OUTER JOIN AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID " & _
                    "JOIN AAOSReportJoin on AAOSHWSets.ProjectID = AAOSReportJoin.ProjectID " & _
                    "JOIN AAOSDoors ON AAOSReportJoin.JoinValue =  AAOSDoors.UniqueMark " & _
                    "AND AAOSReportJoin.ProjectID = AAOSDoors.ProjectID and AAOSDoors.HWSet = AAOSHWSets.SetName " & _
                    "WHERE(AAOSHWSets.ProjectID =" & PrjID1.ToString & " and AAOSReportJoin.UserID =" & UsrID.ToString & "AND AAOSHWSets.DHI <> 100000)" & _
                    "Group By AAOSProjects.ID,AAOSProjects.OriginalProjectID,AAOSProjects.RevisionNumber," & _
                    "AAOSProjects.ProjectName, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description, " & _
                    "AAOSHWSets.Price, AAOSHWSets.SetName, AAOSHWSets.Qty, AAOSHWSets.ProjectID " & _
                    "ORDER BY AAOSProjects.ProjectName, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, Description,Price,SetName"
        Else

            strQ = "SELECT AAOSProjects.ProjectName, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description, AAOSHWSets.Price, AAOSHWSets.SetName, AAOSHWSets.Qty, AAOSHWSets.ProjectID, " & _
                    "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                    "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max))  " & _
                    "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
                    "FROM AAOSHWSets LEFT OUTER JOIN  " & _
                    AAOSDBName & ".dbo.Vendor ON AAOSHWSets.Mfr = " & AAOSDBName & ".dbo.Vendor.ABBR LEFT OUTER JOIN " & _
                    "AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID " & _
                    "WHERE (AAOSHWSets.SetName in (select distinct HWSet from AAOSDOORS where ProjectID = " & PrjID1.ToString & ") AND AAOSHWSets.ProjectID = " & PrjID1.ToString & " AND AAOSHWSets.DHI <> 100000 AND " & AAOSDBName & ".dbo.Vendor.VENDOR_TYPE_ID = 3)" & _
                    "ORDER BY AAOSProjects.ProjectName, " & AAOSDBName & ".dbo.Vendor.NAME, AAOSHWSets.Product, AAOSHWSets.Description,SetName"


        End If



        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        strQ = "SELECT HWSet, SUM(Qty) AS TotalQty FROM AAOSDoors WHERE (ProjectID = " & PrjID1.ToString & ") GROUP BY HWSet ORDER BY HWSet"
        Dim dc2 As New DataCls(strQ, DataDB, False, False, False)
        Dim dv2 As New DataView(dc2.DT)
        dv2.Sort = "HWSet"
        dc2.Dispose()
        dc2 = Nothing

        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim dvFind(dc1.DT.Columns.Count - 5) As System.Object
        Dim str1 As String = ""
        Dim dValue As Double
        For i As Integer = 0 To dc1.DT.Columns.Count - 1
            If dc1.DT.Columns(i).ColumnName.ToUpper = "QTY" Then Continue For
            If dc1.DT.Columns(i).ColumnName.ToUpper = "PROJECTID" Then Continue For
            If dc1.DT.Columns(i).ColumnName.ToUpper = "SETNAME" Then Continue For
            If dc1.DT.Columns(i).ColumnName.ToUpper = "NEWPROJID" Then Continue For
            str1 &= dc1.DT.Columns(i).ColumnName & ","
        Next
        str1 = str1.Substring(0, str1.Length - 1)
        dv1.Sort = str1

        'Divide total extended price by quantity
        For i As Integer = 0 To dc1.DT.Rows.Count - 1
            If NullCheckStr(dc1.DT.Rows(i).Item("Price")).Trim = "" Then
                dValue = 0
            Else
                dValue = Double.Parse(NullCheckStr(dc1.DT.Rows(i).Item("Price")), Globalization.NumberStyles.Any)
            End If
            dc1.DT.Rows(i).Item("Price") = (dValue / Val(NullCheckStr(dc1.DT.Rows(i).Item("Qty")))).ToString("#.00")
            iFind = dv2.Find(NullCheckStr(dc1.DT.Rows(i).Item("SetName")))
            If iFind > -1 Then
                dc1.DT.Rows(i).Item("Qty") = NullCheckNum(dc1.DT.Rows(i).Item("Qty")) * NullCheckNum(dv2(iFind).Item("TOTALQTY"))
            End If
            If NullCheckStr(dc1.DT.Rows(i).Item("NAME")).Trim = "" Then
                dc1.DT.Rows(i).Item("NAME") = "Unspecified Vendor"
            End If
        Next

        For i As Integer = 0 To dc1.DT.Rows.Count - 1
            If NullCheckNum(dc1.DT.Rows(i).Item("QTY")) = 0 Then Continue For
            For j As Integer = 0 To dc1.DT.Columns.Count - 1
                If dc1.DT.Columns(j).ColumnName.ToUpper = "QTY" Then Continue For

                If dc1.DT.Columns(j).ColumnName.ToUpper = "PROJECTID" Then Continue For
                If dc1.DT.Columns(j).ColumnName.ToUpper = "SETNAME" Then Continue For
                If dc1.DT.Columns(j).ColumnName.ToUpper = "NEWPROJID" Then Continue For

                dvFind(j) = dc1.DT.Rows(i).Item(j)
            Next
            iFind = dv1.Find(dvFind)
            If iFind = -1 Then
                drv = dv1.AddNew
                For j As Integer = 0 To dc1.DT.Columns.Count - 1
                    drv(j) = dc1.DT.Rows(i).Item(j)
                Next
                drv.EndEdit()
            Else
                dv1(iFind).Item("Qty") = CStr(Val(NullCheckStr(dc1.DT.Rows(i).Item("Qty"))) + Val(NullCheckStr(dv1(iFind).Item("Qty"))))
            End If
        Next

        If dv1.Count = 0 Then
            WriteToConsole("ERROR - There is no hardware in this project.")
            End
            Exit Sub
        End If
        Dim rpt As New rptHWEstimate
        rpt.DataSource = dv1.ToTable
        rpt.ShowCost = ShowCost
        rpt.sReportTitle = arguments(7)
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If
        'Alan T


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateHardwareEstimate " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    Private Sub CreateHardwareSchedule(ByVal arguments() As String)
        On Error GoTo ErrHandler
        Dim projectID As Integer = arguments(2)

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)

        Dim query As String = "SELECT AAOSHWSets.SetName, " +
                                "AAOSHWSets.Qty, AAOSHWSets.SetDesc, AAOSHWSets.TypeDescription, AAOSHWSets.Description, AAOSHWSets.Finish, " +
                                "MAX(" + AAOSDBName + ".dbo.Vendor.NAME) [Manufacturer], AAOSHWSets.SetNotes " +
                            "FROM AAOSHWSets LEFT JOIN " + AAOSDBName + ".dbo.Vendor " +
                            "ON AAOSHWSets.Mfr = " + AAOSDBName + ".dbo.Vendor.ABBR " +
                            "WHERE AAOSHWSets.ProjectID = " + arguments(2) + " And DHI <> 100000 " +
                            "GROUP BY AAOSHWSets.ProjectID, AAOSHWSets.SetName, AAOSHWSets.Qty, AAOSHWSets.SetDesc, AAOSHWSets.TypeDescription, " +
                                "AAOSHWSets.Description, AAOSHWSets.Finish, AAOSHWSets.SetNotes, AAOSHWSets.DHI " +
                            "ORDER BY AAOSHWSets.SetName, AAOSHWSets.DHI"

        Dim dtable As New DataTable
        DataDB.Open()
        Using dataAdapter As New SqlDataAdapter(query, DataDB)
            dataAdapter.Fill(dtable)
        End Using

        ' Get list of doors for each set
        dtable.Columns.Add("Doors")
        Dim lastSet As String = ""
        Dim lastValue As String = ""
        For Each row As DataRow In dtable.Rows
            If Not row("SetName").Equals(lastSet) Then
                lastSet = row("SetName")
                Dim command As New SqlCommand
                command = DataDB.CreateCommand
                command.CommandText = "SELECT DISTINCT REVERSE(STUFF(REVERSE( " + _
                                        "(SELECT Mark + ', ' AS 'data()' " + _
                                        "FROM AAOSDoors " + _
                                        "WHERE AAOSDoors.ProjectID = " + arguments(2) + " And AAOSDoors.HWSet = '" + lastSet + "' " + _
                                        "FOR XML PATH(''))), 1, 2, '')) [Doors] FROM AAOSDoors"
                Dim reader As SqlDataReader
                reader = command.ExecuteReader
                Do While reader.Read
                    If Not reader(0).Equals(DBNull.Value) Then
                        lastValue = reader.GetString(0)
                    End If
                Loop
                reader.Close()
            End If

            row("Doors") = lastValue
        Next

        Dim rpt As New rptHWSchedule
        rpt.DataSource = dtable
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select

        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFULL")

GetOut:
        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - HWSchedule " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '    Private Sub CreateRFI(ByVal arguments() As String)
    '        On Error GoTo ErrHandler
    '        Dim projectID As Integer = arguments(2)

    '        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)

    '        Dim query As String = "SELECT AAOSProjects.ProjectName, Mark, RFI FROM AAOSDoors INNER JOIN AAOSProjects ON AAOSDoors.ProjectID = AAOSProjects.ID WHERE ProjectID = " & projectID & " AND (CHARINDEX('deleted', ChangeLog) < 1) AND RFI <> ''"

    '        Dim dtable As New DataTable
    '        DataDB.Open()
    '        Using dataAdapter As New SqlDataAdapter(query, DataDB)
    '            dataAdapter.Fill(dtable)
    '        End Using

    '        Dim newTable As New DataTable
    '        newTable.Columns.Add("ProjectName")
    '        newTable.Columns.Add("Mark")
    '        newTable.Columns.Add("User")
    '        newTable.Columns.Add("Comment")
    '        For Each row As DataRow In dtable.Rows
    '            Dim rfi() As String = Split(row("RFI"), D3)
    '            For Each s As String In rfi
    '                If s <> "" Then
    '                    Dim newRow As DataRow = newTable.NewRow
    '                    newRow("ProjectName") = row("ProjectName")
    '                    newRow("Mark") = row("Mark")
    '                    Dim userComment() As String = Split(s, D2)
    '                    Dim user As String = ""
    '                    Dim comment As String = ""
    '                    If userComment.Length >= 3 Then
    '                        user = userComment(1).Replace(" - ", vbCrLf)
    '                        comment = userComment(2)
    '                    Else
    '                        user = userComment(0).Replace(" - ", vbCrLf)
    '                        comment = userComment(1)
    '                    End If
    '                    newRow("User") = user
    '                    newRow("Comment") = comment
    '                    newTable.Rows.Add(newRow)
    '                End If
    '            Next
    '        Next

    '        Dim rpt As New rptRFI
    '        rpt.DataSource = newTable
    '        rpt.Run()

    '        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
    '            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
    '        End If

    '        Select Case arguments(5).ToUpper
    '            Case "PDF"
    '                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
    '                rptexp.Export(rpt.Document, arguments(4))
    '                rptexp.Dispose()
    '                rptexp = Nothing
    '            Case "XLS", "EXCEL"
    '                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
    '                rptxls.Export(rpt.Document, arguments(4))
    '                rptxls.Dispose()
    '                rptxls = Nothing
    '            Case "RTF"
    '                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
    '                rptrtf.EnableShapes = True
    '                rptrtf.Export(rpt.Document, arguments(4))
    '                rptrtf.Dispose()
    '                rptrtf = Nothing
    '        End Select

    '        rpt.Dispose()
    '        rpt = Nothing

    '        WriteToConsole("SUCCESSFULL")

    'GetOut:
    '        If DataDB IsNot Nothing Then
    '            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
    '            DataDB.Dispose()
    '            DataDB = Nothing
    '        End If
    '        Exit Sub
    'ErrHandler:
    '        WriteToConsole("ERROR - RFI " & Err.Description)
    '        GoTo GetOut
    '        Exit Sub
    '        Resume Next
    '        Resume
    '        'End Sub


    Private Sub CreateHardwareSetEstimate(ByVal arguments() As String, Optional ByVal ShowCost As Boolean = False)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim isFiltered As Boolean = arguments(9)

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()


        Dim strQ As String


        If isFiltered Then

            strQ = "SELECT AAOSProjects.ProjectName, AAOSProjects.JobName, AAOSProjectHardware.DHI," & _
                    "Cast(AAOSProjects.Description AS nvarchar(max)) ProjectDescription" & _
                    ", AAOSHWSets.Price, AAOSHWSets.Product, " & _
                    "AAOSHWSets.Qty, AAOSHWSets.SetName, " & _
                    "AAOSHWSets.Description, " & _
                    "AAOSHWSets.TypeDescription, " & _
                    "AAOSHWSets.Finish, AAOSHWSets.ProjectID, " & _
                    "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                    "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max)) " & _
                    "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
                    "FROM AAOSProjectHardware RIGHT OUTER JOIN AAOSHWSets " & _
                    "ON AAOSProjectHardware.Item = AAOSHWSets.Product AND  AAOSProjectHardware.ProjectID = AAOSHWSets.ProjectID " & _
                    "LEFT JOIN AAOSProjects ON AAOSProjectHardware.ProjectID = AAOSProjects.ID " & _
                    "JOIN AAOSReportJoin on AAOSProjectHardware.ProjectID = AAOSReportJoin.ProjectID " & _
                    "JOIN AAOSDoors ON AAOSReportJoin.JoinValue =  AAOSDoors.UniqueMark AND AAOSReportJoin.ProjectID = AAOSDoors.ProjectID " & _
                    "and AAOSDoors.HWSet = AAOSHWSets.SetName " & _
                    "WHERE(AAOSProjectHardware.ProjectID =" & PrjID1.ToString & " and AAOSReportJoin.UserID =" & UsrID.ToString & ")" & _
                    "group by AAOSProjects.ProjectName,AAOSProjects.JobName, AAOSProjects.ID, AAOSProjects.OriginalProjectID, AAOSProjects.RevisionNumber, " & _
                    "AAOSHWSets.Price, AAOSHWSets.Product,Cast(AAOSProjects.Description AS nvarchar(max)), AAOSHWSets.Price," & _
                    "AAOSHWSets.Product,AAOSHWSets.Qty,AAOSHWSets.SetName, AAOSHWSets.Description, " & _
                    "AAOSHWSets.TypeDescription,AAOSHWSets.Finish, AAOSHWSets.ProjectID,AAOSProjectHardware.DHI order by AAOSProjectHardware.DHI"
        Else
            strQ = "SELECT AAOSProjects.ProjectName, AAOSProjects.JobName,AAOSProjectHardware.DHI, AAOSProjects.Description AS ProjectDescription, AAOSHWSets.Price, AAOSHWSets.Product, AAOSHWSets.Qty, " & _
            "AAOSHWSets.SetName, AAOSHWSets.Description, AAOSHWSets.TypeDescription, AAOSHWSets.Finish, AAOSHWSets.ProjectID, " & _
            "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
            "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max)) " & _
            "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID " & _
            "FROM AAOSProjectHardware RIGHT OUTER JOIN " & _
            "AAOSHWSets ON AAOSProjectHardware.Item = AAOSHWSets.Product LEFT OUTER JOIN " & _
            "AAOSProjects ON AAOSHWSets.ProjectID = AAOSProjects.ID " & _
            "WHERE (AAOSHWSets.ProjectID = " & PrjID1.ToString & ") AND (AAOSProjects.ID = " & PrjID1.ToString & ") AND (AAOSProjectHardware.ProjectID = " & PrjID1.ToString & ") order by AAOSProjectHardware.DHI"


        End If


        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        strQ = "SELECT HWSet, Mark, SUM(Qty) AS TotalMarks FROM AAOSDoors WHERE (ProjectID = " & PrjID1.ToString & ") GROUP BY HWSet, Mark ORDER BY HWSet"
        Dim dc2 As New DataCls(strQ, DataDB, False, False, False)
        Dim colName As DataColumn
        'TotalSetCount
        colName = New DataColumn("TotalSetCount")
        colName.DataType = GetType(Integer)
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "TotalSetCount"
        dc1.DT.Columns.Add(colName)

        'Marks
        colName = New DataColumn("Marks")
        colName.DataType = GetType(String)
        colName.MaxLength = -1
        colName.Unique = False
        colName.AllowDBNull = True
        colName.Caption = "Marks"
        dc1.DT.Columns.Add(colName)

        Dim dv2 As New DataView(dc2.DT)
        dv2.Sort = "HWSet, Mark"
        dc2.Dispose()
        dc2 = Nothing

        Dim Marks As String = ""
        Dim iTotal As Integer
        Dim sPrevSet As String = ""
        Dim sPrevProduct As String = ""
        Dim dv1 As New DataView(dc1.DT)

        'Dim dt3 As DataTable = New DataTable()

        dc1.Dispose()
        dc1 = Nothing
        dv1.Sort = "SetName, DHI, TypeDescription, Description, Finish"

        If dv1.Count = 0 Then
            WriteToConsole("ERROR - There are no hardware sets on any doors in this project.")
            End
            Exit Sub
        End If



        For i As Integer = 0 To dv1.Count - 1
            If sPrevSet <> dv1(i).Item("SetName") Then
                sPrevSet = dv1(i).Item("SetName")
                sPrevProduct = dv1(i).Item("Product")
                Marks = "" : iTotal = 0
                dv2.RowFilter = "HWSet = '" & dv1(i).Item("SetName") & "'"
                For j As Integer = 0 To dv2.Count - 1
                    If Marks = "" Then
                        Marks &= dv2(j).Item("Mark")
                    Else
                        Marks &= ", " & dv2(j).Item("Mark")
                    End If
                    iTotal += dv2(j).Item("TotalMarks")
                Next
            End If
            dv1(i).Item("Marks") = Marks
            dv1(i).Item("TotalSetCount") = iTotal
            dv1(i).Item("Description") &= " " & NullCheckStr(dv1(i).Item("Finish"))
        Next


        Dim rpt As New rptHWSetEstimate
        rpt.DataSource = dv1.ToTable
        rpt.ShowCost = ShowCost
        rpt.sReportTitle = arguments(7)
        'Run the report, and set it to the viewer control on the form
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If
        'Alan T

        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing
        'ExportToExcel(dc1.DT, arguments)

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - HWSetEstimate " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    Private Sub CreateDoorEstimate(ByVal arguments() As String, ByVal IsDoor As Boolean)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim ReportID As String = arguments(3)
        Dim sWhere As String
        sWhere = "WHERE (AAOSDoorEstimate.ProjectID = " & PrjID1.ToString & ") AND (AAOSProjects.ID = " & PrjID1.ToString & ") AND (AAOSDoorEstimate.ReportID = '" & ReportID.ToString & "')"
        If arguments(6).Trim <> "" Then
            sWhere &= " AND " & arguments(6).Replace("WHERE", "")
        End If
        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String


        If IsDoor Then

            strQ = "SELECT AAOSProjects.ProjectName, AAOSProjects.JobName, AAOSDoorEstimate.ReportID, AAOSDoorEstimate.ProjectID, AAOSDoorEstimate.Category, " & _
                          "AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc, " & _
                          "AAOSDoorEstimate.Series, AAOSDoorEstimate.Gauge, AAOSDoorEstimate.SteelType, AAOSDoorEstimate.List, AAOSDoorEstimate.NC, " & _
                          "AAOSDoorEstimate.Adj, AAOSDoorEstimate.Adj1, AAOSDoorEstimate.Adj2, AAOSDoorEstimate.Adj3, AAOSDoorEstimate.Adj4, AAOSDoorEstimate.Material, " & _
                          "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                          "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max)) " & _
                          "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID," & _
                          "SUM(AAOSDoorEstimate.Qty) AS TotalQty, AAOSDoorEstimate.Net AS TotalNet, SUM(AAOSDoorEstimate.Extended) AS TotalExtended " & _
                "FROM AAOSDoorEstimate LEFT OUTER JOIN " & _
                "AAOSProjects ON AAOSDoorEstimate.ProjectID = AAOSProjects.ID " & sWhere & _
                "GROUP BY AAOSProjects.id,AAOSProjects.OriginalProjectID ,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName, AAOSProjects.JobName, AAOSDoorEstimate.ReportID, AAOSDoorEstimate.ProjectID, AAOSDoorEstimate.Category, " & _
                          "AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc,  " & _
                          "AAOSDoorEstimate.Series, AAOSDoorEstimate.Gauge, AAOSDoorEstimate.SteelType, AAOSDoorEstimate.List, AAOSDoorEstimate.NC, " & _
                          "AAOSDoorEstimate.Adj, AAOSDoorEstimate.Adj1, AAOSDoorEstimate.Adj2, AAOSDoorEstimate.Adj3, AAOSDoorEstimate.Adj4, AAOSDoorEstimate.Material, AAOSDoorEstimate.Net " & _
                "ORDER BY AAOSDoorEstimate.Material, AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Category, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc"




        Else
            strQ = "SELECT AAOSProjects.ProjectName, AAOSProjects.JobName, AAOSDoorEstimate.ReportID, AAOSDoorEstimate.ProjectID, AAOSDoorEstimate.Category, " & _
                                                  "AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc, AAOSDoorEstimate.FrameDesign, AAOSDoorEstimate.FrameHead, " & _
                                                  "AAOSDoorEstimate.FrameFace, AAOSDoorEstimate.Series, AAOSDoorEstimate.Gauge, AAOSDoorEstimate.SteelType, AAOSDoorEstimate.List, AAOSDoorEstimate.NC, " & _
                                                  "AAOSDoorEstimate.Adj, AAOSDoorEstimate.Adj1, AAOSDoorEstimate.Adj2, AAOSDoorEstimate.Adj3, AAOSDoorEstimate.Adj4, AAOSDoorEstimate.Material, " & _
                                                  "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                                                  "THEN CAST(AAOSProjects.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AAOSProjects.RevisionNumber AS nvarchar(max)) " & _
                                                  "ELSE CAST(AAOSProjects.ID AS nvarchar(max)) END as NewProjID," & _
                                                  "SUM(AAOSDoorEstimate.Qty) AS TotalQty, AAOSDoorEstimate.Net AS TotalNet, SUM(AAOSDoorEstimate.Extended) AS TotalExtended " & _
                                        "FROM AAOSDoorEstimate LEFT OUTER JOIN " & _
                                        "AAOSProjects ON AAOSDoorEstimate.ProjectID = AAOSProjects.ID " & sWhere & _
                                        "GROUP BY AAOSProjects.id,AAOSProjects.OriginalProjectID ,AAOSProjects.RevisionNumber,AAOSProjects.ProjectName, AAOSProjects.JobName, AAOSDoorEstimate.ReportID, AAOSDoorEstimate.ProjectID, AAOSDoorEstimate.Category, " & _
                                                  "AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc, AAOSDoorEstimate.FrameDesign, AAOSDoorEstimate.FrameHead, " & _
                                                  "AAOSDoorEstimate.FrameFace, AAOSDoorEstimate.Series, AAOSDoorEstimate.Gauge, AAOSDoorEstimate.SteelType, AAOSDoorEstimate.List, AAOSDoorEstimate.NC, " & _
                                                  "AAOSDoorEstimate.Adj, AAOSDoorEstimate.Adj1, AAOSDoorEstimate.Adj2, AAOSDoorEstimate.Adj3, AAOSDoorEstimate.Adj4, AAOSDoorEstimate.Material, AAOSDoorEstimate.Net " & _
                                        "ORDER BY AAOSDoorEstimate.Material, AAOSDoorEstimate.CategorySort, AAOSDoorEstimate.Category, AAOSDoorEstimate.Name, AAOSDoorEstimate.SizeDesc"

        End If


        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        dc1.DT.DefaultView.Sort = "Material, CategorySort, Category, Name, SizeDesc"
        dc1.DT = dc1.DT.DefaultView.ToTable

        Dim rpt As New rptDoorEstimateReport
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)

        rpt.IsDoorReport = IsDoor
        'Run the report, and set it to the viewer control on the form
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If
        'Alan T

        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing
        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDoorEstimate " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    '// Ironmongery set summary

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - User ID
    '10 - Show costs
    '11 - Rev No

    '// Ironmongery set summary
    Private Sub CreateIronMongerySetSummary(ByVal arguments() As String)
        On Error GoTo ErrHandler
        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim ShowCost As Boolean = arguments(9)
        Dim RevisionText As String = arguments(10)


        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start


        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEAHWSetSummary','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEAHWSetSummary') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String


        strQ = " DECLARE @PROJECTID INT" & _
       " SET @PROJECTID = " & PrjID1.ToString & _
       " SET ARITHABORT ON" & _
       " SELECT AP.PROJECTNAME," & _
       " AP.ID ProjectReference," & _
       "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
       "THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
       "ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID," & _
       " HW.SETNAME,HW.SETDESC," & _
       " Max(TOTALS.PRICE) AS Price," & _
       " Max(DOORS.QTY) AS Qty," & _
       " Max(TOTALS.PRICE)*Max(DOORS.QTY) AS ExtendedPrice," & _
       " (ACS.FIRSTNAME+' '+ACS.LASTNAME) AS SalesRep," & _
       " ACS.EMAIL as Email," & _
       " CASE WHEN Day(Getdate()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'st ' WHEN Day(Getdate()) IN ( 2, 22 ) " & _
                " THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd ' WHEN Day(Getdate()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd ' " & _
                " ELSE CONVERT(VARCHAR, Day(Getdate())) + 'th ' END+Datename(MONTH, Getdate())+' ' " & _
                " +CONVERT(VARCHAR, Year(Getdate())) as TodaysDateEN, " & _
       " getdate() as TodaysDate,Ltrim(NOTES.LIST) SetNotes, " & _
                " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
         " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
         " ACS.Email AS PrjOwnEmail ," & _
         " CS.Email AS SpecConEmail ," & _
         " ACS.Phone PrjOwnNumber, " & _
         " CS.Phone SpecConNumber, " & _
         " ACS.Title PrjOwnTitle, " & _
         " CS.Title SpecConTitle " & _
       " FROM   AAOSHWSETS HW " & _
       " LEFT OUTER JOIN AAOSPROJECTS AP ON HW.PROJECTID=AP.ID " & _
       " LEFT OUTER JOIN AAOSCONSULTANTS ACS ON AP.ARCHCONSULTANT=ACS.ID " & _
         " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
       " LEFT OUTER JOIN AAOSDOORS AD ON AD.PROJECTID=@PROJECTID AND AD.HWSET=HW.SETNAME " & _
       " LEFT OUTER JOIN (SELECT DISTINCT (PROJECTID) ProjectID,Stuff((SELECT '  '+Char(13),+SETNOTES [text()] " & _
                        " FROM   (SELECT DISTINCT (PROJECTID),CASE WHEN Len(SETNOTES)>0 THEN (SETNAME+' : ' " & _
                                    " +Replace(Replace(SETNOTES, Char(13), ' '), Char(10), ' ')) " & _
                                    " ELSE NULL " & _
                                   " END AS SetNotes " & _
                                   " FROM   AAOSHWSETS T " & _
                                   " WHERE  PROJECTID=@PROJECTID AND " & _
                                   " SETNOTES!='' " & _
                                   " GROUP  BY PROJECTID,SETNAME,SETNOTES) A " & _
                            " WHERE  PROJECTID=@PROJECTID " & _
                            " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
                            " FROM   AAOSHWSETS T " & _
                           " WHERE  PROJECTID=@PROJECTID " & _
                           " GROUP  BY PROJECTID,SETNOTES) NOTES ON NOTES.PROJECTID=HW.PROJECTID " & _
       " LEFT OUTER JOIN (SELECT PROJECTID,HWSET,Sum(QTY) Qty,Stuff((SELECT ', '+Cast(MARK AS VARCHAR(250)) [text()] " & _
                                    " FROM   AAOSDOORS " & _
                                    " WHERE  HWSET=T.HWSET AND " & _
                                    " PROJECTID=@PROJECTID " & _
                                    " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
                            " FROM   AAOSDOORS T " & _
                            " WHERE  PROJECTID=@PROJECTID AND " & _
                            " (Charindex('deleted', CHANGELOG)<1) " & _
                        " GROUP  BY PROJECTID,HWSET) DOORS ON DOORS.HWSET=HW.SETNAME AND " & _
                        " DOORS.PROJECTID=HW.PROJECTID " & _
       " LEFT OUTER JOIN (SELECT PROJECTID,SETNAME,Sum(Cast (QTY AS INT)) Qty," & _
                        "" & _
                        " SUM(CASE WHEN LEN(AAOSHWSets.Price) = 0 THEN '0.00' ELSE CAST(AAOSHWSets.Price AS DECIMAL(18,2)) END * CAST (Qty AS INT)) Price" & _
                        "" & _
                        " FROM   AAOSHWSETS " & _
                        " WHERE  AAOSHWSETS.PROJECTID=@PROJECTID " & _
                        " GROUP  BY AAOSHWSETS.PROJECTID,SETNAME) TOTALS ON TOTALS.PROJECTID=HW.PROJECTID AND TOTALS.SETNAME=HW.SETNAME " & _
       " WHERE  HW.PROJECTID=@PROJECTID " & _
       " GROUP  BY AP.PROJECTNAME,AP.ID,AP.OriginalProjectID, AP.RevisionNumber, HW.SETNAME,HW.SETDESC,ACS.FIRSTNAME,ACS.LASTNAME,ACS.EMAIL,NOTES.LIST, ACS.firstname + ' ' + ACS.lastname, CS.firstname + ' ' + CS.lastname, ACS.Email, CS.Email, ACS.Phone, CS.Phone, ACS.Title, CS.Title "





        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        strQ = "SELECT HWSet, SUM(Qty) AS Qty FROM AAOSDoors WHERE ProjectID = " & PrjID1.ToString & " AND (CHARINDEX('deleted', ChangeLog) < 1) GROUP BY HWSet ORDER BY HWSet"
        Dim dc2 As New DataCls(strQ, DataDB, False, False, False)
        Dim dv2 As New DataView(dc2.DT)
        dv2.Sort = "HWSet"
        ' dc2.Dispose()
        ' dc2 = Nothing

        If dv2.Count = 0 Then
            WriteToConsole("ERROR - There is no hardware in this project.")
            End
            Exit Sub
        End If
        Dim rpt As New rptEMEAHWSetSummary
        rpt.DataSource = dc1.DT
        rpt.ShowCost = ShowCost
        rpt.sRevisionText = RevisionText
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If dc2 IsNot Nothing Then
            dc2.Dispose()
            dc2 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEAIronMongerySummary " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    '// Ironmongery schedule


    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - User ID
    '10 - Option Cost
    '11 - Option HW Filter (0 for sets without doors, 1 for sets with doors, 2 for all)
    '12 - Option Show Images
    '13 - Option Show Product Code
    '14 - Option Show Unit Rate
    '15 - Option Show Totals
    '16 - Rev No

    ' emea ironmongery schedule

    Private Sub CreateIronMongerySchedule(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim optCost As String = arguments(9)
        Dim optHWSetFilter As String = arguments(10)
        Dim optShowImages As Boolean = arguments(11)
        Dim optShowProductCode As Boolean = arguments(12)
        Dim optShowUnitRate As Boolean = arguments(13)
        Dim optShowTotals As Boolean = arguments(14)
        Dim RevisionText As String = arguments(15)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start


        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEAHWSchedule','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEAHWSchedule') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @PROJECTID INT" & _
       " DECLARE @DOORFILTER INT" & _
       " SET @PROJECTID = " & PrjID1.ToString & _
       " SET @DOORFILTER = " & optHWSetFilter.ToString & _
       " SET ARITHABORT ON" & _
       " IF @DOORFILTER=2 " & _
       " SELECT " & _
       " '2' AS Filter," & _
       " HW.SETNAME,'" & ImagesPath & "' + CASE WHEN LEFT([FileName], 1) = '\' THEN RIGHT([FileName], LEN([FileName])-1) ELSE [FileName] END as Image," & _
       " CASE WHEN Len(HW.PRICE)=0 THEN '0' ELSE HW.PRICE END AS totSetItemPrice," & _
       " HW.PRODUCT," & _
       " CASE WHEN HW.QTY = '' THEN 0 ELSE ISNULL(HW.QTY,0) END AS QTY," & _
       " HW.DESCRIPTION," & _
       " HW.TYPEDESCRIPTION," & _
       " AP.PROJECTNAME," & _
       " AP.ID ProjectReference," & _
       " CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
       " THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
       " ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID, " & _
       " CASE WHEN Len(PH.PRICE)=0 THEN '0' ELSE PH.PRICE END AS singlePrice," & _
       " PH.UOM," & _
       " (ACS.FIRSTNAME+' ' +ACS.LASTNAME) as SalesRep," & _
       " ACS.EMAIL as Email, " & _
       " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
       " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
       " ACS.Email AS PrjOwnEmail ," & _
       " CS.Email AS SpecConEmail ," & _
       " ACS.Phone PrjOwnNumber, " & _
       " CS.Phone SpecConNumber, " & _
       " ACS.Title PrjOwnTitle, " & _
       " CS.Title SpecConTitle, " & _
       " HW.Finish as Finish,ISNULL(DOORS.QTY, 0) AS TotDoors," & _
       " TOTALS.PRICE TotSetPrice," & _
       " CASE " & _
       "    WHEN Day(Getdate()) IN ( 1, 21, 31 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'st '" & _
       "    WHEN Day(Getdate()) IN ( 2, 22 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd '" & _
       "    WHEN Day(Getdate()) IN ( 3, 23 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd '" & _
       " ELSE " & _
       "    CONVERT(VARCHAR, Day(Getdate())) + 'th ' END+Datename(MONTH, Getdate())+' '+CONVERT(VARCHAR, Year(Getdate())) TodaysDateEN," & _
       " getdate() TodaysDate," & _
       " ISNULL(DOORS.LIST, 'N/A') AS Mark," & _
       " CASE WHEN Len(HW.SETNOTES)>0 THEN (HW.SETNAME+' : ' +Replace(Replace(HW.SETNOTES, Char(13), ' '), Char(10), ' ')) ELSE NULL END AS SetNotes " & _
       " FROM   AAOSPROJECTHARDWARE PH" & _
       " RIGHT OUTER JOIN AAOSHWSETS HW ON PH.ITEM=HW.PRODUCT " & _
       " LEFT OUTER JOIN AAOSPROJECTS AP ON HW.PROJECTID=AP.ID " & _
       " LEFT OUTER JOIN AAOSCONSULTANTS ACS ON AP.ARCHCONSULTANT=ACS.ID " & _
       " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
       " LEFT OUTER JOIN (SELECT PROJECTID,SETNAME,Sum(Cast (QTY AS INT)) Qty,Sum(Cast(CASE WHEN Len(AAOSHWSETS.PRICE)=0 THEN '0' " & _
       "                    ELSE AAOSHWSETS.PRICE " & _
       "                    END AS DECIMAL(18, 2))*Cast (QTY AS INT)) Price " & _
       "                    FROM   AAOSHWSETS " & _
       "                    WHERE  AAOSHWSETS.PROJECTID=@PROJECTID " & _
       "                    GROUP  BY AAOSHWSETS.PROJECTID,SETNAME) TOTALS" &
       "                    ON TOTALS.PROJECTID=HW.PROJECTID AND TOTALS.SETNAME=HW.SETNAME " & _
       " LEFT OUTER JOIN (SELECT PROJECTID,HWSET,Sum(QTY) Qty,Stuff((SELECT ', '+Cast(MARK AS VARCHAR(250)) [text()] " & _
       "                    FROM   AAOSDOORS " & _
       "                    WHERE  HWSET=T.HWSET AND " & _
       "                    PROJECTID=@PROJECTID " & _
       "                    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
       "                    FROM   AAOSDOORS T " & _
       "                    WHERE  PROJECTID=@PROJECTID AND " & _
       "                    (Charindex('deleted', CHANGELOG)<1) " & _
       "                    GROUP  BY PROJECTID,HWSET) DOORS" & _
       "                    ON DOORS.HWSET=HW.SETNAME AND DOORS.PROJECTID=HW.PROJECTID " & _
       " LEFT OUTER JOIN (" & _
       " SELECT [Description], MIN(x.ImageID) AS ImageID, ProjectID FROM AAOSProjectHardware APH" & _
       " INNER JOIN (" & _
       " SELECT A.ID, Split.a.value('.', 'VARCHAR(MAX)') AS ImageID " & _
       " FROM  (" & _
       " SELECT ID,  CAST ('<M>' + REPLACE([imageids], ',', '</M><M>') + '</M>' AS XML) AS String" & _
       " FROM  AAOSProjectHardware" & _
       " WHERE ProjectID = @ProjectID)" & _
       " AS A CROSS APPLY String.nodes ('/M') AS Split(a)" & _
       " WHERE ISNULL(Split.a.value('.', 'VARCHAR(MAX)'),'') <> ''" & _
       " UNION" & _
       " SELECT ID,ImageIDs FROM AAOSProjectHardware where ProjectID = @ProjectID AND ISNULL(ImageIDs,'') ='' ) x" & _
       " INNER JOIN" & _
       " (SELECT Image_id, [Filename]" & _
       " FROM " & AAOSDBName & ".dbo.images img" & _
       " WHERE (NOT (UPPER([Filename]) LIKE '%.PDF') OR ISNULL([Filename],'') = '')) img" & _
       " ON  x.ImageID = img.Image_id" & _
       " ON x.ID = APH.ID  GROUP BY [Description], ProjectID ) APH" & _
       " ON  CAST(HW.[DESCRIPTION] AS VARBINARY(MAX)) =  CAST(APH.[description] AS VARBINARY(MAX)) AND APH.ProjectID=HW.PROJECTID " & _
       " LEFT OUTER JOIN " & AAOSDBName & ".dbo.images img ON APH.ImageID= img.Image_ID " & _
       "  WHERE  (HW.PROJECTID=@PROJECTID) " & _
       "  AND ( AP.ID=@PROJECTID)" & _
       "  AND (PH.PROJECTID=@PROJECTID) " & _
       "  ORDER  BY HW.SETNAME,PH.DHI " & _
       " ELSE BEGIN " & _
       "" & _
       "" & _
       "" & _
       "    IF @DOORFILTER=0 " & _
       " SELECT " & _
       " '1' AS Filter," & _
       " HW.SETNAME,'" & ImagesPath & "' + CASE WHEN LEFT([FileName], 1) = '\' THEN RIGHT([FileName], LEN([FileName])-1) ELSE [FileName] END as Image," & _
       " CASE WHEN Len(HW.PRICE)=0 THEN '0' ELSE HW.PRICE END AS totSetItemPrice," & _
       " HW.PRODUCT," & _
       " CASE WHEN HW.QTY = '' THEN 0 ELSE ISNULL(HW.QTY,0) END AS QTY," & _
       " HW.DESCRIPTION," & _
       " HW.TYPEDESCRIPTION," & _
       " AP.PROJECTNAME," & _
       " AP.ID ProjectReference," & _
       " CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
       " THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
       " ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID, " & _
       " CASE WHEN Len(PH.PRICE)=0 THEN '0' ELSE PH.PRICE END AS singlePrice," & _
       " PH.UOM," & _
       " (ACS.FIRSTNAME+' ' +ACS.LASTNAME) as SalesRep," & _
       " ACS.EMAIL as Email, " & _
       " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
       " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
       " ACS.Email AS PrjOwnEmail ," & _
       " CS.Email AS SpecConEmail ," & _
       " ACS.Phone PrjOwnNumber, " & _
       " CS.Phone SpecConNumber, " & _
       " ACS.Title PrjOwnTitle, " & _
       " CS.Title SpecConTitle, " & _
       " HW.Finish as Finish,ISNULL(DOORS.QTY, 0) AS TotDoors," & _
       " TOTALS.PRICE TotSetPrice," & _
       " CASE " & _
       "    WHEN Day(Getdate()) IN ( 1, 21, 31 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'st '" & _
       "    WHEN Day(Getdate()) IN ( 2, 22 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd '" & _
       "    WHEN Day(Getdate()) IN ( 3, 23 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd '" & _
       " ELSE " & _
       "    CONVERT(VARCHAR, Day(Getdate())) + 'th ' END+Datename(MONTH, Getdate())+' '+CONVERT(VARCHAR, Year(Getdate())) TodaysDateEN," & _
       " getdate() TodaysDate," & _
       " ISNULL(DOORS.LIST, 'N/A') AS Mark," & _
       " CASE WHEN Len(HW.SETNOTES)>0 THEN (HW.SETNAME+' : ' +Replace(Replace(HW.SETNOTES, Char(13), ' '), Char(10), ' ')) ELSE NULL END AS SetNotes " & _
       " FROM   AAOSPROJECTHARDWARE PH" & _
       " RIGHT OUTER JOIN AAOSHWSETS HW ON PH.ITEM=HW.PRODUCT " & _
       " LEFT OUTER JOIN AAOSPROJECTS AP ON HW.PROJECTID=AP.ID " & _
       " LEFT OUTER JOIN AAOSCONSULTANTS ACS ON AP.ARCHCONSULTANT=ACS.ID " & _
       " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
       " LEFT OUTER JOIN (SELECT PROJECTID,SETNAME,Sum(Cast (QTY AS INT)) Qty,Sum(Cast(CASE WHEN Len(AAOSHWSETS.PRICE)=0 THEN '0' " & _
       "                    ELSE AAOSHWSETS.PRICE " & _
       "                    END AS DECIMAL(18, 2))*Cast (QTY AS INT)) Price " & _
       "                    FROM   AAOSHWSETS " & _
       "                    WHERE  AAOSHWSETS.PROJECTID=@PROJECTID " & _
       "                    GROUP  BY AAOSHWSETS.PROJECTID,SETNAME) TOTALS" &
       "                    ON TOTALS.PROJECTID=HW.PROJECTID AND TOTALS.SETNAME=HW.SETNAME " & _
       " LEFT OUTER JOIN (SELECT PROJECTID,HWSET,Sum(QTY) Qty,Stuff((SELECT ', '+Cast(MARK AS VARCHAR(250)) [text()] " & _
       "                    FROM   AAOSDOORS " & _
       "                    WHERE  HWSET=T.HWSET AND " & _
       "                    PROJECTID=@PROJECTID " & _
       "                    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
       "                    FROM   AAOSDOORS T " & _
       "                    WHERE  PROJECTID=@PROJECTID AND " & _
       "                    (Charindex('deleted', CHANGELOG)<1) " & _
       "                    GROUP  BY PROJECTID,HWSET) DOORS" & _
       "                    ON DOORS.HWSET=HW.SETNAME AND DOORS.PROJECTID=HW.PROJECTID " & _
       " LEFT OUTER JOIN (" & _
       " SELECT [Description], MIN(x.ImageID) AS ImageID, ProjectID FROM AAOSProjectHardware APH" & _
       " INNER JOIN (" & _
       " SELECT A.ID, Split.a.value('.', 'VARCHAR(MAX)') AS ImageID " & _
       " FROM  (" & _
       " SELECT ID,  CAST ('<M>' + REPLACE([imageids], ',', '</M><M>') + '</M>' AS XML) AS String" & _
       " FROM  AAOSProjectHardware" & _
       " WHERE ProjectID = @ProjectID)" & _
       " AS A CROSS APPLY String.nodes ('/M') AS Split(a)" & _
       " WHERE ISNULL(Split.a.value('.', 'VARCHAR(MAX)'),'') <> ''" & _
       " UNION" & _
       " SELECT ID,ImageIDs FROM AAOSProjectHardware where ProjectID = @ProjectID AND ISNULL(ImageIDs,'') ='' ) x" & _
       " INNER JOIN" & _
       " (SELECT Image_id, [Filename]" & _
       " FROM " & AAOSDBName & ".dbo.images img" & _
       " WHERE (NOT (UPPER([Filename]) LIKE '%.PDF') OR ISNULL([Filename],'') = '')) img" & _
       " ON  x.ImageID = img.Image_id" & _
       " ON x.ID = APH.ID  GROUP BY [Description], ProjectID ) APH" & _
       " ON  CAST(HW.[DESCRIPTION] AS VARBINARY(MAX)) =  CAST(APH.[description] AS VARBINARY(MAX)) AND APH.ProjectID=HW.PROJECTID " & _
       " LEFT OUTER JOIN " & AAOSDBName & ".dbo.images img ON APH.ImageID= img.Image_ID " & _
       "      WHERE  (HW.PROJECTID=@PROJECTID) AND " & _
       "      (AP.ID=@PROJECTID) AND " & _
       "      (PH.PROJECTID=@PROJECTID) AND " & _
       "      ISNULL(DOORS.QTY, 0)!=0 " & _
       "      ORDER  BY HW.SETNAME,PH.DHI " & _
       "    ELSE " & _
       "" & _
       "" & _
       "" & _
       " SELECT " & _
       " '0' AS Filter," & _
       " HW.SETNAME,'" & ImagesPath & "' + CASE WHEN LEFT([FileName], 1) = '\' THEN RIGHT([FileName], LEN([FileName])-1) ELSE [FileName] END as Image," & _
       " CASE WHEN Len(HW.PRICE)=0 THEN '0' ELSE HW.PRICE END AS totSetItemPrice," & _
       " HW.PRODUCT," & _
       " CASE WHEN HW.QTY = '' THEN 0 ELSE ISNULL(HW.QTY,0) END AS QTY," & _
       " HW.DESCRIPTION," & _
       " HW.TYPEDESCRIPTION," & _
       " AP.PROJECTNAME," & _
       " AP.ID ProjectReference," & _
       " CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
       " THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
       " ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID, " & _
       " CASE WHEN Len(PH.PRICE)=0 THEN '0' ELSE PH.PRICE END AS singlePrice," & _
       " PH.UOM," & _
       " (ACS.FIRSTNAME+' ' +ACS.LASTNAME) as SalesRep," & _
       " ACS.EMAIL as Email, " & _
       " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
       " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
       " ACS.Email AS PrjOwnEmail ," & _
       " CS.Email AS SpecConEmail ," & _
       " ACS.Phone PrjOwnNumber, " & _
       " CS.Phone SpecConNumber, " & _
       " ACS.Title PrjOwnTitle, " & _
       " CS.Title SpecConTitle, " & _
       " HW.Finish as Finish,ISNULL(DOORS.QTY, 0) AS TotDoors," & _
       " TOTALS.PRICE TotSetPrice," & _
       " CASE " & _
       "    WHEN Day(Getdate()) IN ( 1, 21, 31 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'st '" & _
       "    WHEN Day(Getdate()) IN ( 2, 22 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd '" & _
       "    WHEN Day(Getdate()) IN ( 3, 23 ) " & _
       "        THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd '" & _
       " ELSE " & _
       "    CONVERT(VARCHAR, Day(Getdate())) + 'th ' END+Datename(MONTH, Getdate())+' '+CONVERT(VARCHAR, Year(Getdate())) TodaysDateEN," & _
       " getdate() TodaysDate," & _
       " ISNULL(DOORS.LIST, 'N/A') AS Mark," & _
       " CASE WHEN Len(HW.SETNOTES)>0 THEN (HW.SETNAME+' : ' +Replace(Replace(HW.SETNOTES, Char(13), ' '), Char(10), ' ')) ELSE NULL END AS SetNotes " & _
       " FROM   AAOSPROJECTHARDWARE PH" & _
       " RIGHT OUTER JOIN AAOSHWSETS HW ON PH.ITEM=HW.PRODUCT " & _
       " LEFT OUTER JOIN AAOSPROJECTS AP ON HW.PROJECTID=AP.ID " & _
       " LEFT OUTER JOIN AAOSCONSULTANTS ACS ON AP.ARCHCONSULTANT=ACS.ID " & _
       " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
       " LEFT OUTER JOIN (SELECT PROJECTID,SETNAME,Sum(Cast (QTY AS INT)) Qty,Sum(Cast(CASE WHEN Len(AAOSHWSETS.PRICE)=0 THEN '0' " & _
       "                    ELSE AAOSHWSETS.PRICE " & _
       "                    END AS DECIMAL(18, 2))*Cast (QTY AS INT)) Price " & _
       "                    FROM   AAOSHWSETS " & _
       "                    WHERE  AAOSHWSETS.PROJECTID=@PROJECTID " & _
       "                    GROUP  BY AAOSHWSETS.PROJECTID,SETNAME) TOTALS" &
       "                    ON TOTALS.PROJECTID=HW.PROJECTID AND TOTALS.SETNAME=HW.SETNAME " & _
       " LEFT OUTER JOIN (SELECT PROJECTID,HWSET,Sum(QTY) Qty,Stuff((SELECT ', '+Cast(MARK AS VARCHAR(250)) [text()] " & _
       "                    FROM   AAOSDOORS " & _
       "                    WHERE  HWSET=T.HWSET AND " & _
       "                    PROJECTID=@PROJECTID " & _
       "                    FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
       "                    FROM   AAOSDOORS T " & _
       "                    WHERE  PROJECTID=@PROJECTID AND " & _
       "                    (Charindex('deleted', CHANGELOG)<1) " & _
       "                    GROUP  BY PROJECTID,HWSET) DOORS" & _
       "                    ON DOORS.HWSET=HW.SETNAME AND DOORS.PROJECTID=HW.PROJECTID " & _
       " LEFT OUTER JOIN (" & _
       " SELECT [Description], MIN(x.ImageID) AS ImageID, ProjectID FROM AAOSProjectHardware APH" & _
       " INNER JOIN (" & _
       " SELECT A.ID, Split.a.value('.', 'VARCHAR(MAX)') AS ImageID " & _
       " FROM  (" & _
       " SELECT ID,  CAST ('<M>' + REPLACE([imageids], ',', '</M><M>') + '</M>' AS XML) AS String" & _
       " FROM  AAOSProjectHardware" & _
       " WHERE ProjectID = @ProjectID)" & _
       " AS A CROSS APPLY String.nodes ('/M') AS Split(a)" & _
       " WHERE ISNULL(Split.a.value('.', 'VARCHAR(MAX)'),'') <> ''" & _
       " UNION" & _
       " SELECT ID,ImageIDs FROM AAOSProjectHardware where ProjectID = @ProjectID AND ISNULL(ImageIDs,'') ='' ) x" & _
       " INNER JOIN" & _
       " (SELECT Image_id, [Filename]" & _
       " FROM " & AAOSDBName & ".dbo.images img" & _
       " WHERE (NOT (UPPER([Filename]) LIKE '%.PDF') OR ISNULL([Filename],'') = '')) img" & _
       " ON  x.ImageID = img.Image_id" & _
       " ON x.ID = APH.ID  GROUP BY [Description], ProjectID ) APH" & _
       " ON  CAST(HW.[DESCRIPTION] AS VARBINARY(MAX)) =  CAST(APH.[description] AS VARBINARY(MAX)) AND APH.ProjectID=HW.PROJECTID " & _
       " LEFT OUTER JOIN " & AAOSDBName & ".dbo.images img ON APH.ImageID= img.Image_ID " & _
       "      WHERE  (HW.PROJECTID=@PROJECTID) AND " & _
       "      (AP.ID=@PROJECTID) AND " & _
       "      (PH.PROJECTID=@PROJECTID) AND " & _
       "      ISNULL(DOORS.QTY, 0)=0 " & _
       "      ORDER  BY HW.SETNAME,PH.DHI " & _
       " END "

        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\wrightj\Documents\test.txt", True)
        file.WriteLine(strQ)
        file.Close()

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim imgHash As Hashtable = New Hashtable()
        If (optShowImages = True) Then
            For i As Integer = 0 To dc1.DT.Rows.Count - 1
                Dim Desc As String = dc1.DT.Rows(i).Item("TypeDescription")
                Dim Path As String = NullCheckStr(dc1.DT.Rows(i).Item("Image"))
                If (String.IsNullOrEmpty(Path)) Then Continue For
                If (Not imgHash.ContainsKey(Desc)) Then
                    imgHash.Add(Desc, Path)
                End If
            Next
        End If


        strQ = "SELECT HWSet,Mark, Qty FROM AAOSDoors WHERE ProjectID = " & PrjID1.ToString & " AND (CHARINDEX('deleted', ChangeLog) < 1) ORDER BY HWSet, Mark"
        Dim dc2 As New DataCls(strQ, DataDB, False, False, False)
        Dim dv2 As New DataView(dc2.DT)

        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim str1 As String = ""
        Dim dValue As Double
        Dim curSet As String = ""
        Dim curQty As Integer = 0
        Dim curMarkList As String = ""
        Dim curTotPrice As Double

        If dv2.Count = 0 Then
            WriteToConsole("ERROR - There is no hardware in this project.")
            End
            Exit Sub
        End If
        Dim rpt As New rptEMEAHWSchedule
        rpt.DataSource = dc1.DT
        rpt.optCost = optCost
        rpt.optHWSetFilter = optHWSetFilter
        rpt.optShowImages = optShowImages
        rpt.optShowProductCode = optShowProductCode
        rpt.optShowUnitRate = optShowUnitRate
        rpt.sReportTitle = arguments(7)
        rpt.optShowTotals = optShowTotals
        rpt.sRevisionTxt = RevisionText
        rpt.sHash = Hash
        rpt.imgHash = imgHash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If dc2 IsNot Nothing Then
            dc2.Dispose()
            dc2 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEAIronMongerySchedule " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Cover Letter

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - User ID
    '10 - Recipient Architect
    '11 - Recipient Contractor
    '12 - Recipient Owner
    '13 - Rev No

    'ONLY ONE of 10, 11 or 12 can be used at any time

    Private Sub CreateCoverLetter(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim RcpArchitect As Boolean = arguments(9)
        Dim RcpContractor As Boolean = arguments(10)
        Dim RcpOwner As Boolean = arguments(11)
        Dim RevisionTxt As String = arguments(12)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEACoverLetter','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName  in ('rptPageFooters', 'rptEMEACoverLetter') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = "SELECT " & _
         " AP.id ProjectReference, " & _
         " CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
         " THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
         " ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID," & _
         " CAST(AP.RevisionNumber AS nvarchar(max)) AS Revision," & _
         " AP.projectname ProjectName, " & _
         " CASE WHEN DAY(getdate()) in (1,21,31) THEN convert(varchar,DAY(getdate())) + 'st '" & _
         " WHEN DAY(getdate()) IN (2,22) then convert(varchar,DAY(getdate())) + 'nd '" & _
         " WHEN DAY(getdate()) IN (3,23) then convert(varchar,DAY(getdate())) + 'rd ' " & _
         " ELSE convert(varchar,DAY(getdate())) + 'th ' end + " & _
         " DATENAME(month, getdate())  + ' ' + convert(varchar,year(getdate())) TodaysDateEN, getdate() TodaysDate," & _
         " AP.JobName  CompanyName," & _
         " AP.Address1 Address1," & _
         " AP.Address2 Address2," & _
         " AP.Address3 Address3," & _
         " AP.City City," & _
         " AP.Zip Postcode," & _
         " AA.firstname + ' ' + AA.lastname Architect, " & _
         " AC.firstname + ' ' + AC.lastname Contractor, " & _
         " AO.firstname + ' ' + AO.lastname Owner, " & _
         " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
         " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
         " ACS.Email AS PrjOwnEmail ," & _
         " CS.Email AS SpecConEmail ," & _
         " ACS.Phone PrjOwnNumber, " & _
         " CS.Phone SpecConNumber, " & _
         " ACS.Title PrjOwnTitle, " & _
         " CS.Title SpecConTitle " & _
         " FROM [AAOSProjects] AP" & _
         " left outer join AAOSConsultants ACS on AP.archconsultant = ACS.id" & _
         " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
         " left outer join AAOSFirms AA on AP.Architect = AA.id" & _
         " left outer join AAOSFirms AC on AP.Contractor = AC.id" & _
         " left outer join AAOSFirms AO on AP.Owner = AO.id" & _
         " where AP.id = " & PrjID1.ToString & " order by ap.id"


        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)


        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim str1 As String = ""
        Dim dValue As Double
        Dim curSet As String = ""
        Dim curQty As Integer = 0
        Dim curMarkList As String = ""
        Dim curTotPrice As Double


        Dim rpt As New rptEMEACoverLetter
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.optArchitect = RcpArchitect
        rpt.optContractor = RcpContractor
        rpt.optOwner = RcpOwner
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If


        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEACoverLetter " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    '// Door summary

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateDoorSummary(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim RevisionTxt As String = arguments(9)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEADoorSummary','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEADoorSummary') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT" & _
       " SET @ProjectID = " & PrjID1.ToString & _
       " SELECT AP.id   ProjectReference, " & _
       "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
       "THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
       "ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID," & _
       "AP.projectname ProjectName, " & _
       "AD.Mark DoorNumber, " & _
       "AH.setname     SetReference, " & _
       "CASE WHEN Day(Getdate()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'st ' WHEN Day(Getdate()) IN ( 2, 22 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd ' WHEN Day(Getdate()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd ' ELSE CONVERT(VARCHAR, Day(Getdate())) + 'th ' END + Datename(month, Getdate()) + ' ' " & _
       "+ CONVERT(VARCHAR, Year(Getdate())) TodaysDateEN, getdate() TodaysDate ," & _
       " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
         " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
         " ACS.Email AS PrjOwnEmail ," & _
         " CS.Email AS SpecConEmail ," & _
         " ACS.Phone PrjOwnNumber, " & _
         " CS.Phone SpecConNumber, " & _
         " ACS.Title PrjOwnTitle, " & _
         " CS.Title SpecConTitle " & _
       " FROM   [AAOSProjects] AP " & _
       " left outer join AAOSConsultants ACS on AP.archconsultant = ACS.id" & _
       " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
       " INNER JOIN AAOSDoors AD ON AP.id = AD.ProjectID " & _
       " LEFT OUTER JOIN AAOSHWSets AH ON AP.id = AH.ProjectID AND " & _
       "  AD.hwset = AH.setname " & _
       " WHERE  AP.id = @ProjectID " & _
       " GROUP  BY AP.id,AP.projectname,AP.OriginalProjectID,AP.RevisionNumber,AD.Mark,AH.setname,AD.id, ACS.firstname + ' ' + ACS.lastname, CS.firstname + ' ' + CS.lastname, ACS.Email, CS.Email, ACS.Phone, CS.Phone, ACS.Title, CS.Title" & _
       " ORDER  BY AD.id "




        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)


        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim str1 As String = ""
        Dim dValue As Double
        Dim curSet As String = ""
        Dim curQty As Integer = 0
        Dim curMarkList As String = ""
        Dim curTotPrice As Double



        Dim rpt As New rptEMEADoorSummary
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If


        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEADoorSummary " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Timber Std Door Sizes

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateTimberStdDoorSizes(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim RevisionTxt As String = arguments(9)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEATimberStdDoorSizes','rptGenericHeaders') and Usage2Name != 'Text Box' AND [Required] = 1"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEATimberStdDoorSizes') AND usage2name != 'SimpleView' AND [Required] = 1"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = "SELECT PARSENAME(FF.Usage1Value, 3) AS SetName, PARSENAME(FF.Usage1Value, 2) AS Thickness, PARSENAME(FF.Usage1Value, 1) AS Rating" & _
                "  FROM FormFields FF WHERE	FF.FormName = 'rptEMEATimberStdDoorSizes' AND FF.ColName LIKE 'STD_HW_SETS%' ORDER BY FF.Usage1Name "

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim strQ2 As String
        strQ2 = " SELECT PARSENAME(FF.Usage2Value, 1) AS Leaf, PARSENAME(FF.Usage1Value,4) AS ModuleSize, " & _
                "   PARSENAME(FF.Usage1Value,3) AS StructuralOpeningSize, PARSENAME(FF.Usage1Value,2) AS TimberFrameSize, " & _
                "   PARSENAME(FF.Usage1Value,2) AS DoorLeafSize, PARSENAME(FF.Usage2Value,3) AS KickPlateSize, " & _
                "   FF2.Usage1Value AS FrameDepthList, PARSENAME(FF.Usage2Value,2) AS DoorTypes " & _
                " FROM FormFields FF " & _
                "   INNER JOIN (SELECT FF.Usage1Value FROM FormFields FF WHERE FF.FormName = 'rptEMEATimberStdDoorSizes' " & _
                "   AND FF.ColName = 'STD_FRAME_DEPTHS') FF2 ON 1=1 " & _
                "   WHERE FF.FormName = 'rptEMEATimberStdDoorSizes' AND FF.ColName LIKE 'STD_DOOR_SIZES%' " & _
                "   ORDER BY FF.ColNumber, CAST (PARSENAME(FF.Usage1Value,4) AS INT) "

        Dim dc2 As New DataCls(strQ2, DataDB, False, False, False)

        Dim rpt As New rptEMEATimberStdDoorSizes
        rpt.DataSource = dc2.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.subDC = dc1
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEATimberStdDoorSizes " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Door Schedule Summary

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateDoorScheduleSummary(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim optShowUnitRate As Boolean = arguments(13)
        Dim RevisionTxt As String = arguments(15)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEADoorScheduleSummary','rptGenericHeaders') and Usage2Name != 'Text Box' AND [Required] = 1"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEADoorScheduleSummary') AND usage2name != 'SimpleView' AND [Required] = 1"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT SET @ProjectID = " & PrjID1.ToString & " SET ARITHABORT ON" & _
                " SELECT AP.ID, AP.ProjectName, CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                "   THEN CAST(AP.OriginalProjectID AS NVARCHAR(MAX))  +  '-'  +  CAST(AP.RevisionNumber AS NVARCHAR(MAX)) " & _
                "   ELSE CAST(AP.ID AS NVARCHAR(MAX)) END AS NewProjID, " & _
                "   CAST(AP.RevisionNumber AS NVARCHAR(MAX)) AS Revision, " & _
                "   ACS.FirstName + ' ' + ACS.LastName ProjectOwner, AD.Mark, AD.ToRoom, AD.FromRoom, " & _
                "   AD.DoorMaterial, CASE MAX(AH.Leaf) WHEN 'A' THEN 'Single' WHEN 'B' THEN 'Equal Pair' WHEN  'I' THEN 'Unequal Pairs'  " & _
                "   ELSE 'Single' END AS Leaf, AD.Qty, AD.FireRating, AD.AcousticRating, ROUND(AD.RoughWidth,1) AS FrameWidth, " & _
                "   ROUND(AD.RoughHeight,1) AS FrameHeight, AD.FrameDepth, " & _
                "   CAST((AD.DoorPrice/CASE WHEN AD.Qty = 0 THEN 1 ELSE AD.Qty END) AS DECIMAL(18, 2)) AS UnitRate, " & _
                "   CASE WHEN DAY(GETDATE()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'st ' WHEN DAY(GETDATE()) IN ( 2, 22 ) " & _
                "   THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'nd ' WHEN DAY(GETDATE()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'rd ' " & _
                "   ELSE CONVERT(VARCHAR, DAY(GETDATE())) + 'th ' END + DATENAME(MONTH, GETDATE()) + ' '  + CONVERT(VARCHAR, YEAR(GETDATE())) " & _
                "   TodaysDateEN, GETDATE() TodaysDate " & _
                " FROM AAOSDoors AD " & _
                " LEFT OUTER JOIN AAOSProjects AP ON AP.ID = AD.ProjectID " & _
                " LEFT OUTER JOIN AAOSConsultants ACS ON AP.ArchConsultant = ACS.ID " & _
                " LEFT OUTER JOIN AAOSHWSets AH ON AP.ID = AH.ProjectID AND AD.HWSet = AH.SetName " & _
                " WHERE AP.ID = @ProjectID " & _
                " GROUP BY AP.ID, AP.ProjectName, AP.OriginalProjectID, AP.RevisionNumber, ACS.FirstName, ACS.LastName, AD.Mark, AD.ToRoom, AD.FromRoom, " & _
                " AD.DoorMaterial, AD.UOM, AD.Qty, AD.FireRating, AD.AcousticRating, AD.RoughWidth, AD.RoughHeight, AD.FrameDepth, AD.DoorPrice, AD.Qty " & _
                " ORDER BY AD.Mark ASC "

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim rpt As New rptEMEADoorScheduleSummary
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.optShowUnitRate = optShowUnitRate
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDoorScheduleSummary " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub


    '// Doors And Ironmongery Set Summary

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateDoorsAndIronmongerySetSummary(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim optShowUnitRate As Boolean = arguments(13)
        Dim RevisionTxt As String = arguments(15)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEADoorsIronmongerySetSummary','rptGenericHeaders') and Usage2Name != 'Text Box' AND [Required] = 1"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEADoorsIronmongerySetSummary') AND usage2name != 'SimpleView' AND [Required] = 1"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT SET @ProjectID = " & PrjID1.ToString & " SET ARITHABORT ON" & _
                " SELECT AP.ID, AP.ProjectName, CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                "   THEN CAST(AP.OriginalProjectID AS NVARCHAR(MAX))  +  '-'  +  CAST(AP.RevisionNumber AS NVARCHAR(MAX)) " & _
                "   ELSE CAST(AP.ID AS NVARCHAR(MAX)) END AS NewProjID, " & _
                "   CAST(AP.RevisionNumber AS NVARCHAR(MAX)) AS Revision, " & _
                "   ACS.FirstName + ' ' + ACS.LastName ProjectOwner, AD.Mark, AH.SetDesc, AH.SetName, AD.Qty, " & _
                "   CAST((AD.DoorPrice/CASE WHEN AD.Qty = 0 THEN 1 ELSE AD.Qty END) AS DECIMAL(18, 2)) AS UnitRate, " & _
                "   CASE WHEN DAY(GETDATE()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'st ' WHEN DAY(GETDATE()) IN ( 2, 22 ) " & _
                "   THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'nd ' WHEN DAY(GETDATE()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'rd ' " & _
                "   ELSE CONVERT(VARCHAR, DAY(GETDATE())) + 'th ' END + DATENAME(MONTH, GETDATE()) + ' '  + CONVERT(VARCHAR, YEAR(GETDATE())) " & _
                "   TodaysDateEN, GETDATE() TodaysDate, " & _
                "   LTRIM(MAX(Notes.List)) AS SetNotes " & _
                " FROM AAOSDoors AD " & _
                " LEFT OUTER JOIN AAOSProjects AP ON AP.ID = AD.ProjectID " & _
                " LEFT OUTER JOIN AAOSConsultants ACS ON AP.ArchConsultant = ACS.ID " & _
                " LEFT OUTER JOIN AAOSHWSets AH ON AP.ID = AH.ProjectID AND AD.HWSet = AH.SetName " & _
                " LEFT OUTER JOIN ( " & _
                "   SELECT DISTINCT (ProjectID)ProjectID, STUFF(( " & _
                "       SELECT ' ',  Char(13),  +SetNotes [text()] " & _
                "       FROM   ( " & _
                "           SELECT DISTINCT (ProjectID), " & _
                "               CASE WHEN Len(SetNotes) > 0 THEN (SetName + ' : '  + Replace(Replace(SetNotes, Char(13), ' '), Char(10), ' ')) " & _
                "               ELSE NULL  END SetNotes  " & _
                "           FROM  AAOSHWSets T " & _
                "           WHERE ProjectID = @ProjectID AND SetNotes != '' " & _
                "           GROUP BY ProjectID,	SetName, SetNotes) A " & _
                "       WHERE ProjectID = @ProjectID  FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
                "   FROM AAOSHWSets T " & _
                "   WHERE ProjectID = @ProjectID " & _
                "   GROUP BY ProjectID,	SetNotes) Notes " & _
                " ON Notes.ProjectID = AP.ID " & _
                " WHERE AP.ID = @ProjectID " & _
                " GROUP BY AP.ID, AP.ProjectName, AP.OriginalProjectID, AP.RevisionNumber, ACS.FirstName, ACS.LastName, AD.Mark, AH.SetDesc, AH.SetName, " & _
                " AD.DoorPrice, AD.Qty " & _
                " ORDER BY AD.Mark ASC "

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim rpt As New rptEMEADoorsIronmongerySetSummary
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.optShowUnitRate = optShowUnitRate
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDoorsIronmongerySetSummary " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Door Schedule Summary By Door Type

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateDoorScheduleSummaryByDoorType(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim optShowUnitRate As Boolean = arguments(13)
        Dim RevisionTxt As String = arguments(15)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " AND FormName in ('rptEMEADoorScheduleSummaryByDoorType','rptGenericHeaders') and Usage2Name != 'Text Box' AND [Required] = 1"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEADoorScheduleSummaryByDoorType') AND usage2name != 'SimpleView' AND [Required] = 1"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT SET @ProjectID = " & PrjID1.ToString & " SET ARITHABORT ON" & _
                " SELECT AP.ID, AP.ProjectName, CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                "   THEN CAST(AP.OriginalProjectID AS NVARCHAR(MAX))  +  '-'  +  CAST(AP.RevisionNumber AS NVARCHAR(MAX)) " & _
                "   ELSE CAST(AP.ID AS NVARCHAR(MAX)) END AS NewProjID, " & _
                "   CAST(AP.RevisionNumber AS NVARCHAR(MAX)) AS Revision, " & _
                "   ACS.FirstName + ' ' + ACS.LastName ProjectOwner, AD.DoorElevation, AD.ArchDoorType, AD.DoorMaterial, " & _
                "   CASE MAX(AH.Leaf) WHEN 'A' THEN 'Single' WHEN 'B' THEN 'Equal Pair' WHEN  'I' THEN 'Unequal Pairs' " & _
                "   ELSE 'Single' END AS Leaf, AD.Qty, AD.FireRating, AD.AcousticRating, " & _
                "   CAST((AD.DoorPrice/CASE WHEN AD.Qty = 0 THEN 1 ELSE AD.Qty END) AS DECIMAL(18, 2)) AS UnitRate, " & _
                "   CASE WHEN DAY(GETDATE()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'st ' WHEN DAY(GETDATE()) IN ( 2, 22 ) " & _
                "   THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'nd ' WHEN DAY(GETDATE()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'rd ' " & _
                "   ELSE CONVERT(VARCHAR, DAY(GETDATE())) + 'th ' END + DATENAME(MONTH, GETDATE()) + ' '  + CONVERT(VARCHAR, YEAR(GETDATE())) " & _
                "   TodaysDateEN, GETDATE() TodaysDate " & _
                " FROM AAOSDoors AD " & _
                " LEFT OUTER JOIN AAOSProjects AP ON AP.ID = AD.ProjectID " & _
                " LEFT OUTER JOIN AAOSConsultants ACS ON AP.ArchConsultant = ACS.ID " & _
                " LEFT OUTER JOIN AAOSHWSets AH ON AP.ID = AH.ProjectID AND AD.HWSet = AH.SetName " & _
                " WHERE AP.ID = @ProjectID " & _
                " GROUP BY AP.ID, AP.ProjectName, AP.OriginalProjectID, AP.RevisionNumber, ACS.FirstName, ACS.LastName, AD.Mark, AD.DoorElevation, AD.ArchDoorType, " & _
                " AD.DoorMaterial, AD.UOM, AD.Qty, AD.FireRating, AD.AcousticRating, AD.Qty, AD.DoorPrice " & _
                " ORDER BY AD.DoorElevation ASC "

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim rpt As New rptEMEADoorScheduleSummaryByDoorType
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.optShowUnitRate = optShowUnitRate
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDoorScheduleSummaryByDoorType " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Detail Door Schedule

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - Project ID
    '10 - Rev No

    Private Sub CreateDetailDoorSchedule(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim RevisionTxt As String = arguments(9)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEADetailDoorSchedule','rptGenericHeaders') and Usage2Name != 'Text Box' AND [Required] = 1"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEADetailDoorSchedule') AND usage2name != 'SimpleView' AND [Required] = 1"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT SET @ProjectID = " & PrjID1.ToString & " SET ARITHABORT ON" & _
                " SELECT AP.ID, AP.ProjectName, CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
                "   THEN CAST(AP.OriginalProjectID AS NVARCHAR(MAX))  +  '-'  +  CAST(AP.RevisionNumber AS NVARCHAR(MAX)) " & _
                "   ELSE CAST(AP.ID AS NVARCHAR(MAX)) END AS NewProjID, " & _
                "   CAST(AP.RevisionNumber AS NVARCHAR(MAX)) AS Revision, " & _
                "   ACS.FirstName + ' ' + ACS.LastName ProjectOwner, AD.Mark, AD.ToRoom, AD.FromRoom, AD.DoorElevation, AD.FireRating, " & _
                "   AD.AcousticRating, AD.Undercut, AD.Thickness, AD.DoorFinish, AD.DoorEdge, AH.SetName, 'TBD' AS Glass, 'TBD' AS Aperture, " & _
                "   AD.FrameDepth, AD.Extra1, AD.Extra2,  ROUND(AD.RoughWidth,1) AS FrameWidth, ROUND(AD.RoughHeight,1) AS FrameHeight, " & _
                "   AD.ArchFrameFinish, AD.DoorSeries AS Threshold, AD.SpecifierRemarks, AD.Handing, " & _
                "   CAST((AD.DoorPrice/CASE WHEN AD.Qty = 0 THEN 1 ELSE AD.Qty END) AS DECIMAL(18, 2)) AS DoorNetPrice, " & _
                "   CAST((AH.PRICE/CASE WHEN AH.Qty = 0 THEN 1 ELSE AH.Qty END) AS DECIMAL(18, 2)) AS HWSetNetPrice, 'TBD' AS Fitting, " & _
                "   CAST((AD.DoorPrice/CASE WHEN AD.Qty = 0 THEN 1 ELSE AD.Qty END) AS DECIMAL(18, 2)) + " & _
                "   CAST((AH.PRICE/CASE WHEN AH.Qty = 0 THEN 1 ELSE AH.Qty END) AS DECIMAL(18, 2)) AS Total, " & _
                "   CASE WHEN DAY(GETDATE()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'st ' WHEN DAY(GETDATE()) IN ( 2, 22 ) " & _
                "   THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'nd ' WHEN DAY(GETDATE()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, DAY(GETDATE())) + 'rd ' " & _
                "   ELSE CONVERT(VARCHAR, DAY(GETDATE())) + 'th ' END + DATENAME(MONTH, GETDATE()) + ' '  + CONVERT(VARCHAR, YEAR(GETDATE())) " & _
                "   TodaysDateEN, GETDATE() TodaysDate " & _
                " FROM AAOSDoors AD " & _
                " LEFT OUTER JOIN AAOSProjects AP ON AP.ID = AD.ProjectID " & _
                " LEFT OUTER JOIN AAOSConsultants ACS ON AP.ArchConsultant = ACS.ID " & _
                " LEFT OUTER JOIN AAOSHWSets AH ON AP.ID = AH.ProjectID AND AD.HWSet = AH.SetName " & _
                " WHERE AP.ID = @ProjectID " & _
                " ORDER BY AD.Mark ASC "

        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim rpt As New rptEMEADetailDoorSchedule
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If

        Select Case arguments(5).ToUpper
            Case "PDF"
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If

        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateDetailDoorSchedule " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Ironmongery schedule summary

    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - User ID
    '10 - optHWCost (not used here)
    '11 - optHWSetFilter (not used here)
    '12 - option show images
    '13 - option show product code
    '14 - option show unit rate
    '15 - option show extended rate (and totals)
    '16 - Rev No

    Private Sub CreateIronMongeryScheduleSummary(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim optCost As String = arguments(9)
        Dim optHWSetFilter As String = arguments(10)
        Dim optShowImages As Boolean = arguments(11)
        Dim optShowProductCode As Boolean = arguments(12)
        Dim optShowUnitRate As Boolean = arguments(13)
        Dim optShowExtendedRate As Boolean = arguments(14)
        Dim RevisionTxt As String = arguments(15)

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEAHWScheduleSummary','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName   in ('rptPageFooters', 'rptEMEAHWScheduleSummary') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = " DECLARE @ProjectID INT" & _
        " DECLARE @DOORFILTER INT" & _
        " SET @ProjectID = " & PrjID1.ToString & _
        " SET @DOORFILTER = " & optHWSetFilter & _
        " SET ARITHABORT ON " & _
        "" & _
        " SELECT AP.ID ProjectReference, " & _
        " AP.ProjectName, " & _
         "CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
         "THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
         "ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID," & _
        " (ACS.FirstName + ' ' + ACS.LastName) AS ProjectOwner, " & _
        " CASE WHEN Day(Getdate()) IN ( 1, 21, 31 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'st ' WHEN Day(Getdate()) IN ( 2, 22 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'nd ' WHEN Day(Getdate()) IN ( 3, 23 ) THEN CONVERT(VARCHAR, Day(Getdate())) + 'rd ' ELSE CONVERT(VARCHAR, Day(Getdate())) + 'th ' END + Datename(month, Getdate()) + ' ' " & _
        " + CONVERT(VARCHAR, Year(Getdate()))TodaysDateEN, getdate() TodaysDate, " & _
        "'" & ImagesPath & "' + CASE WHEN LEFT([FileName], 1) = '\' THEN RIGHT([FileName], LEN([FileName])-1) ELSE [FileName] END as Image," & _
        " HW.Description ProductCode, " & _
        " HW.TypeDescription   ProductDescription, " & _
        " PH.UOM, " & _
        " Sum(ISNULL(NULLIF(HW.Qty, ''), 0) * ISNULL(NULLIF(Doors.Qty,''), 1)) Quantity, " & _
        " CAST((HW.PRICE/CASE WHEN HW.Qty = 0 THEN 1 ELSE HW.Qty END) AS DECIMAL(18, 2)) AS UnitRate, " & _
        " (Sum(ISNULL(NULLIF(HW.Qty, ''), 0) * ISNULL(NULLIF(Doors.Qty,''), 0))) * (CAST((HW.PRICE/CASE WHEN HW.Qty = 0 THEN 1 ELSE HW.Qty END) AS DECIMAL(18, 2))) AS ExtendedRate, " & _
        " Ltrim(Max(Notes.List)) AS SetNotes ," & _
        " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
        " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
        " ACS.Email AS PrjOwnEmail ," & _
        " CS.Email AS SpecConEmail ," & _
        " ACS.Phone PrjOwnNumber, " & _
        " CS.Phone SpecConNumber, " & _
        " ACS.Title PrjOwnTitle, " & _
        " CS.Title SpecConTitle " & _
        " FROM   AAOSProjectHardware PH " & _
        " RIGHT OUTER JOIN AAOSHWSets HW ON PH.Item = HW.Product " & _
        " LEFT OUTER JOIN AAOSProjects AP ON HW.ProjectID = AP.ID " & _
        " LEFT OUTER JOIN AAOSConsultants ACS ON AP.ArchConsultant = ACS.ID " & _
        " LEFT OUTER JOIN AAOSConsultants CS on AP.consultant = CS.id" & _
        " LEFT OUTER JOIN (" & _
        " SELECT [Description], MIN(x.ImageID) AS ImageID, ProjectID FROM AAOSProjectHardware APH" & _
        " INNER JOIN (" & _
        " SELECT A.ID, Split.a.value('.', 'VARCHAR(MAX)') AS ImageID " & _
        " FROM  (" & _
        " SELECT ID,  CAST ('<M>' + REPLACE([imageids], ',', '</M><M>') + '</M>' AS XML) AS String" & _
        " FROM  AAOSProjectHardware" & _
        " WHERE ProjectID = @ProjectID)" & _
        " AS A CROSS APPLY String.nodes ('/M') AS Split(a)" & _
        " WHERE ISNULL(Split.a.value('.', 'VARCHAR(MAX)'),'') <> ''" & _
        " UNION" & _
        " SELECT ID,ImageIDs FROM AAOSProjectHardware where ProjectID = @ProjectID AND ISNULL(ImageIDs,'') ='' ) x" & _
        " INNER JOIN" & _
        " (SELECT Image_id, [Filename]" & _
        " FROM " & AAOSDBName & ".dbo.images img" & _
        " WHERE (NOT (UPPER([Filename]) LIKE '%.PDF') OR ISNULL([Filename],'') = '')) img" & _
        " ON  x.ImageID = img.Image_id" & _
        " ON x.ID = APH.ID  GROUP BY [Description], ProjectID ) APH" & _
        " ON  CAST(HW.[DESCRIPTION] AS VARBINARY(MAX)) =  CAST(APH.[description] AS VARBINARY(MAX)) AND APH.ProjectID=HW.PROJECTID " & _
        " LEFT OUTER JOIN " & AAOSDBName & ".dbo.images img ON APH.ImageID= img.Image_ID " & _
        " LEFT OUTER JOIN (SELECT ProjectID, " & _
        " SetName, " & _
        " Sum(Cast (QTY AS INT)) Qty, " & _
        " Sum(Cast(CASE WHEN Len(AAOSHWSets.Price) = 0 THEN '0.00' " & _
        " ELSE AAOSHWSets.Price " & _
        " END AS DECIMAL(18, 2)) * Cast (QTY AS INT)) Price " & _
        " FROM   AAOSHWSets " & _
        " WHERE  AAOSHWSets.ProjectID = @ProjectID " & _
        " GROUP  BY AAOSHWsets.ProjectID,SetName) Totals ON Totals.ProjectID = HW.ProjectID AND " & _
        " Totals.SetName = HW.SetName " & _
        " LEFT OUTER JOIN (SELECT ProjectID, " & _
        " HWSet, " & _
        " Sum(QTY)   Qty, " & _
        " Stuff((SELECT ', ' + Cast(Mark AS VARCHAR(250)) [text()] " & _
        " FROM   AAOSDoors " & _
        " WHERE  HWSet = T.HWSet AND " & _
        " ProjectID = @ProjectID " & _
        " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
        " FROM   AAOSDoors T " & _
        " WHERE  ProjectID = @ProjectID AND " & _
        " (Charindex('deleted', ChangeLog) < 1) " & _
        " GROUP  BY ProjectID,HWSet) Doors ON Doors.HWSet = HW.SetName AND " & _
        " Doors.ProjectID = HW.ProjectID " & _
        " LEFT OUTER JOIN (SELECT DISTINCT (ProjectID)ProjectID, " & _
        " Stuff((SELECT ' ', " & _
        " Char(13), " & _
        " +SetNotes [text()] " & _
        " FROM   (SELECT DISTINCT (ProjectID), " & _
        " CASE WHEN Len(SetNotes) > 0 THEN (SetName + ' : ' " & _
        " + Replace(Replace(SetNotes, Char(13), ' '), Char(10), ' ')) " & _
        " ELSE NULL " & _
        " END SetNotes " & _
        " FROM   AAOSHWSets T " & _
        " WHERE  ProjectID = @ProjectID AND " & _
        " setnotes != '' " & _
        " GROUP  BY ProjectID,SetName,SetNotes) A " & _
        " WHERE  ProjectID = @ProjectID " & _
        " FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ' ') List " & _
        " FROM   AAOSHWSets T " & _
        " WHERE  ProjectID = @ProjectID " & _
        " GROUP  BY ProjectID,SetNotes) Notes ON Notes.ProjectID = AP.id " & _
        " WHERE  (HW.ProjectID = @ProjectID) " & _
        " AND (AP.ID = @ProjectID) " & _
        " AND (PH.ProjectID = @ProjectID) " & _
        " AND ISNULL(NULLIF(HW.Qty, ''), 0) != 0 " & _
        " AND ISNULL(CASE WHEN DOORS.QTY = 0 THEN 0 WHEN DOORS.QTY > 0 THEN 1 END, 0) = " & _
        " CASE @DOORFILTER WHEN 0 THEN 1 WHEN 1 THEN 0 ELSE ISNULL(CASE WHEN DOORS.QTY = 0 THEN 0 WHEN DOORS.QTY > 0 THEN 1 END, 0) END" & _
        " GROUP  BY AP.ID,AP.ProjectName,AP.OriginalProjectID,AP.RevisionNumber,PH.DHI, (ACS.FirstName + ' '  + ACS.LastName),HW.Description,HW.TypeDescription,CAST((HW.PRICE/CASE WHEN HW.Qty = 0 THEN 1 ELSE HW.Qty END) AS DECIMAL(18, 2)),PH.UOM, ACS.firstname + ' ' + ACS.lastname, CS.firstname + ' ' + CS.lastname, ACS.Email, CS.Email, ACS.Phone, CS.Phone, ACS.Title, CS.Title,[Filename]" & _
        " ORDER  BY PH.DHI "


        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)

        Dim imgHash As Hashtable = New Hashtable()
        If (optShowImages = True) Then
            For i As Integer = 0 To dc1.DT.Rows.Count - 1
                Dim Desc As String = dc1.DT.Rows(i).Item("ProductDescription")
                Dim Path As String = NullCheckStr(dc1.DT.Rows(i).Item("Image"))
                If (String.IsNullOrEmpty(Path)) Then Continue For
                If (Not imgHash.ContainsKey(Desc)) Then
                    imgHash.Add(Desc, Path)
                End If
            Next
        End If

        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim str1 As String = ""
        Dim dValue As Double
        Dim curSet As String = ""
        Dim curQty As Integer = 0
        Dim curMarkList As String = ""
        Dim curTotPrice As Double

        Dim rpt As New rptEMEAHWScheduleSummary
        rpt.DataSource = dc1.DT
        rpt.optCost = optCost
        rpt.optHWSetFilter = optHWSetFilter
        rpt.optShowImages = optShowImages
        rpt.optShowProductCode = optShowProductCode
        rpt.optShowUnitRate = optShowUnitRate
        rpt.optShowExtendedRate = optShowExtendedRate
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.imgHash = imgHash
        rpt.ISO = ReportLangISO
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If


        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEAIronMongeryScheduleSummary " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '// Quote Terms
    'Arguments
    '1 - Report Name
    '2 - UOM - Imperial or Metric
    '3 - ProjectID 1
    '4 - ProjectID 2
    '5 - Save To Path
    '6 - File Format - PDF or EXCEL
    '7 - SQL Statement or Where clause
    '8 - Report Title
    '9 - RevNo

    Private Sub CreateQuoteTerms(ByVal arguments() As String)
        On Error GoTo ErrHandler

        Dim PrjID1 As Integer = arguments(2)
        Dim UsrID As Integer = arguments(8)
        Dim RevisionTxt As String = arguments(9)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Translation Start

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQLang As String

        strQLang = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", VisibleColText" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptEMEAQuoteTerms','rptGenericHeaders') and Usage2Name != 'Text Box'"

        Dim dcLANG As New DataCls(strQLang, DataDB, False, False, False)

        Dim dvLANG As New DataView(dcLANG.DT)

        Dim Hash As Hashtable = New Hashtable()

        For Each rowView As DataRowView In dvLANG
            Hash.Add(rowView("ColName"), rowView("VisibleColText"))
        Next

        DataDB.Close()

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & AAOSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()

        Dim strQFooter As String

        strQFooter = "SELECT Locale" & _
        ", FormName" & _
        ", ColName" & _
        ", Usage2Value" & _
        " FROM dbo.FormFields" & _
        " WHERE Locale = '" & ReportLangISO.ToString & "'" & _
        " and FormName in ('rptPageFooters', 'rptEMEAQuoteTerms') AND usage2name != 'SimpleView'"

        Dim dcFOOT As New DataCls(strQFooter, DataDB, False, False, False)

        Dim dvFOOT As New DataView(dcFOOT.DT)

        For Each rowView As DataRowView In dvFOOT
            Hash.Add(rowView("ColName"), rowView("Usage2Value"))
        Next

        DataDB.Close()

        'Translation End
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        DataDB = New SqlClient.SqlConnection("Data Source=SQLOLEDB.1;Password=" & DBPass & ";Persist Security Info=True;User ID=" & DBUser & ";Initial Catalog=" & ADSDBName & ";Data Source=" & DBServerPort)
        DataDB.Open()
        Dim strQ As String

        strQ = "SELECT " & _
         " AP.id ProjectReference, " & _
         " AP.projectname ProjectName, " & _
         " CASE WHEN ISNULL(AP.OriginalProjectID, 0) <> 0 " & _
         " THEN CAST(AP.OriginalProjectID AS nvarchar(max))  +  '-'  +  CAST(AP.RevisionNumber AS nvarchar(max)) " & _
         " ELSE CAST(AP.ID AS nvarchar(max)) END as NewProjID," & _
         " CAST(AP.RevisionNumber AS nvarchar(max)) AS Revision, " & _
         " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
         " CASE WHEN DAY(getdate()) in (1,21,31) THEN convert(varchar,DAY(getdate())) + 'st '" & _
         " WHEN DAY(getdate()) IN (2,22) then convert(varchar,DAY(getdate())) + 'nd '" & _
         " WHEN DAY(getdate()) IN (3,23) then convert(varchar,DAY(getdate())) + 'rd ' " & _
         " ELSE convert(varchar,DAY(getdate())) + 'th ' end + " & _
         " DATENAME(month, getdate())  + ' ' + convert(varchar,year(getdate())) TodaysDateEN, getdate() TodaysDate," & _
         " AP.JobName  CompanyName," & _
         " AP.Address1 Address1," & _
         " AP.Address2 Address2," & _
         " AP.Address3 Address3," & _
         " AP.City City," & _
         " AP.Zip Postcode," & _
         " AA.firstname + ' ' + AA.lastname Architect, " & _
         " AC.firstname + ' ' + AC.lastname Contractor, " & _
         " AO.firstname + ' ' + AO.lastname Owner," & _
         " ACS.Phone ContactNumber," & _
         " ACS.Title Title, " & _
         " ACS.firstname + ' ' + ACS.lastname ProjectOwner, " & _
         " CS.firstname + ' ' + CS.lastname SpecConsult, " & _
         " ACS.Email AS PrjOwnEmail ," & _
         " CS.Email AS SpecConEmail ," & _
         " ACS.Phone PrjOwnNumber, " & _
         " CS.Phone SpecConNumber, " & _
         " ACS.Title PrjOwnTitle, " & _
         " CS.Title SpecConTitle " & _
         " FROM AAOSProjects AP" & _
         " left outer join AAOSConsultants ACS on AP.archconsultant = ACS.id" & _
         " left outer join AAOSConsultants CS on AP.consultant = CS.id" & _
         " left outer join AAOSFirms AA on AP.Architect = AA.id" & _
         " left outer join AAOSFirms AC on AP.Contractor = AC.id" & _
         " left outer join AAOSFirms AO on AP.Owner = AO.id" & _
         " where AP.id = " & PrjID1.ToString & " order by ap.id"




        Dim dc1 As New DataCls(strQ, DataDB, False, False, False)


        Dim iQty As Integer
        Dim dv1 As New DataView(dc1.DT.Clone)
        Dim iFind As Integer
        Dim drv As DataRowView
        Dim str1 As String = ""
        Dim dValue As Double
        Dim curSet As String = ""
        Dim curQty As Integer = 0
        Dim curMarkList As String = ""
        Dim curTotPrice As Double


        Dim rpt As New rptEMEAQuoteTerms
        rpt.DataSource = dc1.DT
        rpt.sReportTitle = arguments(7)
        rpt.sRevisionText = RevisionTxt
        rpt.sHash = Hash
        rpt.ISO = ReportLangISO
        rpt.sReportVariant = arguments(0)
        rpt.Run()

        If My.Computer.FileSystem.DirectoryExists(Path.GetDirectoryName(arguments(4))) = False Then
            My.Computer.FileSystem.CreateDirectory(Path.GetDirectoryName(arguments(4)))
        End If


        Select Case arguments(5).ToUpper
            Case "PDF"
                'Dim rptexp As New DataDynamics.ActiveReports.Export.Pdf.PdfExport
                Dim rptexp As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
                rptexp.Export(rpt.Document, arguments(4))
                rptexp.Dispose()
                rptexp = Nothing
            Case "XLS", "EXCEL"
                'Dim rptxls As New DataDynamics.ActiveReports.Export.Xls.XlsExport
                Dim rptxls As New GrapeCity.ActiveReports.Export.Excel.Section.XlsExport
                rptxls.Export(rpt.Document, arguments(4))
                rptxls.Dispose()
                rptxls = Nothing
            Case "RTF"
                'Dim rptrtf As New DataDynamics.ActiveReports.Export.Rtf.RtfExport
                Dim rptrtf As New GrapeCity.ActiveReports.Export.Word.Section.RtfExport
                rptrtf.EnableShapes = True
                rptrtf.Export(rpt.Document, arguments(4))
                rptrtf.Dispose()
                rptrtf = Nothing
        End Select
        rpt.Dispose()
        rpt = Nothing

        WriteToConsole("SUCCESSFUL")

GetOut:
        If dc1 IsNot Nothing Then
            dc1.Dispose()
            dc1 = Nothing
        End If


        If DataDB IsNot Nothing Then
            If DataDB.State <> ConnectionState.Closed Then DataDB.Close()
            DataDB.Dispose()
            DataDB = Nothing
        End If
        Exit Sub
ErrHandler:
        WriteToConsole("ERROR - CreateEMEAQuoteTerms " & Err.Description)
        GoTo GetOut
        Exit Sub
        Resume Next
        Resume
    End Sub

    '//
    Private Function getMarkListByHardwareSet(ByVal hwset As String, ByVal table As System.Data.DataTable) As String
        Dim markList As String = ""
        For j As Integer = 0 To table.Rows.Count - 1
            If NullCheckStr(table.Rows(j).Item("HWSet")).Trim = hwset Then
                markList += NullCheckStr(table.Rows(j).Item("Mark")) + ", "
            End If
        Next
        If markList.EndsWith(", ") Then
            markList = markList.Substring(0, markList.Length - 2)
        End If
        Return markList
    End Function

    Private Function getDoorQuantityByHardwareSet(ByVal hwset As String, ByVal table As System.Data.DataTable) As Integer
        Dim qty As Integer = 0
        For j As Integer = 0 To table.Rows.Count - 1
            If NullCheckStr(table.Rows(j).Item("HWSet")).Trim = hwset Then
                qty += Val(NullCheckStr(table.Rows(j).Item("Qty")))
            End If
        Next
        Return qty
    End Function

    '//


    Public Function NullCheckBool(ByVal Item As Object) As Boolean
        If IsDBNull(Item) Then
            NullCheckBool = False
        Else
            If TypeOf Item Is String Then
                Select Case Item.ToString.ToUpper
                    Case ""
                        NullCheckBool = False
                    Case "Y", "TRUE"
                        NullCheckBool = True
                    Case "N", "FALSE"
                        NullCheckBool = False
                    Case Else
                        NullCheckBool = False
                End Select
            Else
                NullCheckBool = CBool(Item)
            End If

        End If
    End Function


    Public Function NullCheckObj(ByVal Item As Object) As String
        If IsDBNull(Item) Then
            NullCheckObj = ""
        Else
            NullCheckObj = Item.ToString
        End If
    End Function

    Public Function NullCheckLong(ByVal Item As Object) As Integer
        If IsDBNull(Item) Then
            NullCheckLong = 0
        Else
            NullCheckLong = Item
        End If
    End Function

    Public Function NullCheckNum(ByVal Item As Object) As Double
        If IsDBNull(Item) Then
            NullCheckNum = 0.0
        Else
            NullCheckNum = Val(Item)
        End If
    End Function

    Public Function NullCheckStr(ByVal Item As Object) As String
        On Error GoTo GetOut
        If Item Is Nothing Then
            Return ""
        End If
        If IsDBNull(Item) Then
            NullCheckStr = ""
        Else
            NullCheckStr = Item
        End If
        Exit Function

GetOut:
        NullCheckStr = ""
    End Function

    Public Function isRowDeletedOpening(ByVal ChangeLog As String) As Boolean
        Dim D1 As String = Chr(251)
        Dim D2 As String = Chr(252)
        Dim Typ As String = "üDeletedü05/08/12 12:41 PMû"
        If ChangeLog.IndexOf(D2 & "Deleted" & D2) > 0 Then
            If ChangeLog.IndexOf(D2 & "Deleted" & D2) > ChangeLog.Length() - Typ.Length() - 5 Then
                Return True
            Else
                'look for acknowledged delete
                Dim lns() As String = ChangeLog.Split(D1)
                If lns.Length >= 2 Then
                    If lns(lns.Length - 1).IndexOf("Acknowledged") = 0 AndAlso lns(lns.Length - 2).IndexOf(D2 & "Deleted" & D2) > 0 Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function

    Private Sub LookForTrailingSpaces(ByRef str1 As String, ByRef str2 As String)
        On Error GoTo ErrHandler
        Dim NewStr1 As String = ""
        Dim NewStr2 As String = ""
        Dim i1 As Integer, i2 As Integer
        Dim iEnd As Integer = str1.Length
        If iEnd < str2.Length Then iEnd = str2.Length
        For i As Integer = 0 To iEnd - 1
            If str1.Length = i1 Or str2.Length = i2 Then
                If str1.Length < i1 Then
                    NewStr1 &= "[SPACE]"
                    i1 += 1
                Else
                    NewStr2 &= "[SPACE]"
                    i2 += 1
                End If
            Else
                Select Case True
                    Case str1.Substring(i1, 1) = " " And str2.Substring(i2, 1) <> " "
                        NewStr1 &= "[SPACE]"
                        i1 += 1
                    Case str1.Substring(i1, 1) <> " " And str2.Substring(i2, 1) = " "
                        NewStr2 &= "[SPACE]"
                        i2 += 1
                    Case Else
                        NewStr1 &= str1.Substring(i1, 1)
                        NewStr2 &= str1.Substring(i2, 1)
                        i1 += 1 : i2 += 1
                End Select
            End If
        Next
        str1 = NewStr1
        str2 = NewStr2
        Exit Sub
ErrHandler:
        Exit Sub
        Resume Next
        Resume
    End Sub

    Public Function CreateDataView(ByVal FieldNames As String, ByVal DataTypes As String) As DataView
        On Error GoTo ErrHandler
        Dim dv As New DataView

        Dim FieldNamesArr() As String = FieldNames.Split(",")  '"O4,PC,PFUNCTION,UOM,FWIDTH,FHEIGHT,SawCut,NoOfPockets,GlassBite1,GlassBite2,IXX,IYY,SXX,UnitWeight,AssemblyData,AssemblyDataChecked,PartList,PartListAllData,PartListAngles,GlassThickness".Split(",")
        Dim DataTypesArr() As String = DataTypes.Split(",")  '"I,S,S,S,D,D,D,I,D,D,D,D,D,D,T,B,T,T,T,D".Split(",")
        Dim PKeys(0) As DataColumn
        Dim colName As DataColumn
        Dim dt As New DataTable
        For i As Integer = 0 To FieldNamesArr.Count - 1
            colName = New DataColumn(FieldNamesArr(i))
            Select Case DataTypesArr(i)
                Case "I"
                    colName.DataType = GetType(Integer)
                Case "S"
                    colName.DataType = GetType(String)
                    colName.MaxLength = 200

                Case "D"
                    colName.DataType = GetType(Double)

                Case "T"
                    colName.DataType = GetType(String)
                    colName.MaxLength = -1

                Case "B"
                    colName.DataType = GetType(Boolean)
                    colName.DefaultValue = False

                Case "P"
                    colName.DataType = GetType(Integer)
                    colName.Unique = True
                    colName.AllowDBNull = False
                    colName.AutoIncrement = True
                    colName.AutoIncrementSeed = 1
                    colName.AutoIncrementStep = 1

            End Select
            If FieldNamesArr(i) = "O4" Or DataTypesArr(i) = "P" Then
                PKeys(0) = colName
                colName.Unique = True
            Else
                colName.Unique = False
            End If

            colName.AllowDBNull = True
            colName.Caption = FieldNamesArr(i)
            dt.Columns.Add(colName)
        Next
        dt.PrimaryKey = PKeys
        dv = New DataView(dt)
        dt.Dispose()
        dt = Nothing
        Return dv
        Exit Function
ErrHandler:
        SafelyDisplayError(Err)
        Exit Function
        Resume
    End Function

    Public Function CreateDataTable(ByVal FieldNames As String, ByVal DataTypes As String) As DataTable
        On Error GoTo ErrHandler
        Dim dv As New DataView

        Dim FieldNamesArr() As String = FieldNames.Split(",")
        Dim DataTypesArr() As String = DataTypes.Split(",")
        Dim PKeys(0) As DataColumn
        Dim colName As DataColumn
        Dim dt As New DataTable
        For i As Integer = 0 To FieldNamesArr.Count - 1
            colName = New DataColumn(FieldNamesArr(i))
            Select Case DataTypesArr(i)
                Case "I"
                    colName.DataType = GetType(Integer)
                Case "S"
                    colName.DataType = GetType(String)
                    colName.MaxLength = 200

                Case "D"
                    colName.DataType = GetType(Double)

                Case "T"
                    colName.DataType = GetType(String)
                    colName.MaxLength = -1

                Case "B"
                    colName.DataType = GetType(Boolean)
                    colName.DefaultValue = False

                Case "P"
                    colName.DataType = GetType(Integer)
                    colName.Unique = True
                    colName.AllowDBNull = False
                    colName.AutoIncrement = True
                    colName.AutoIncrementSeed = 1
                    colName.AutoIncrementStep = 1

            End Select
            If FieldNamesArr(i) = "O4" Or DataTypesArr(i) = "P" Then
                PKeys(0) = colName
                colName.Unique = True
            Else
                colName.Unique = False
            End If

            colName.AllowDBNull = True
            colName.Caption = FieldNamesArr(i)
            dt.Columns.Add(colName)
        Next
        dt.PrimaryKey = PKeys
        Return dt
        Exit Function
ErrHandler:
        SafelyDisplayError(Err)
        Exit Function
        Resume
    End Function

    Public Sub WriteToConsole(ByVal sMessage As String)
        On Error GoTo ErrHandler
        If sMessage Like "*ERROR*" Then
            'My.Computer.FileSystem.WriteAllText(AppPath & "ADSReportGenerator-Errors.txt", sMessage, True)
        End If
        Console.WriteLine(sMessage)
        Console.Read()
        Exit Sub
ErrHandler:
        SafelyDisplayError(Err)
        End
    End Sub

    Public Function FSTR_(ByVal RC9 As Double) As String
        Dim C9_ As String
4325:   C9_ = Str(RC9)

4326:   FSTR_ = C9_.Trim
        Exit Function
4327:
    End Function
End Module
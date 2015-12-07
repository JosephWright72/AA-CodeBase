Imports System
Imports System.IO
Imports System.Text

Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports
Imports System.Reflection





Public Class rptEMEAHWSchedule
    Private iDoorQty As Integer
    Public totDoorList As String = ""
    'Private dTotalListPrice As Double
    'Private dTotalExtended As Double
    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public optCost As String = "2"
    Public optHWSetFilter As String = "2"
    Public optShowImages As Boolean = False
    Public optShowProductCode As Boolean = False
    Public optShowUnitRate As Boolean = False
    Public optShowTotals As Boolean = False
    Public sRevisionTxt As String
    Public sReportTitle As String
    Public sHash As Hashtable
    Public ISO As String
    Public imgHash As Hashtable
    ' Public c2 As String = ""
    'Public c As String = ""
    'Public c3 As String = ""
    'Public c4 As String = ""
    'Public c5() As String
    'Public sHash2 As Hashtable = New Hashtable()
    'Public sHash3 As Hashtable = New Hashtable()
    'Public Arr As ArrayList
    'Public obj As Object
    'Public myUpdates As New Dictionary(Of String, Object)
    'Public propinfo As PropertyInfo

    




    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

        iDoorQty += CType(Val(txtTotDoors.Value), Integer)

        totDoorList += txtDoorList.Value + ", "



        'Dim str1 As String = txtUnits.Value.ToString.Replace("$", "")
        'str1 = str1.Replace(",", "")
        'dGrandTotalList += Val(str1)

        'str1 = txtExtended.Value.ToString.Replace("$", "")
        'str1 = str1.Replace(",", "")
        'dGrandTotalExtended += Val(str1)

    End Sub

    Private Sub ghManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsListFinished = False Then
            '        txtManufacturer.Text = txtManufacturer.Value & " - Continued"
        Else
            'dTotalListPrice = 0
            '  iDoorQty = 0
            'TotalExtended = 0
        End If
        IsListFinished = False


    End Sub

    Private Sub gfManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtTotalListPrice.Value = dTotalListPrice
        'txtTotDoors.Value = iDoorQty
        'txtDoorList.Value = totDoorList.Substring(0, totDoorList.Length - 2)

        'txtTotalExtended.Value = dTotalExtended
        IsListFinished = True
    End Sub

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        'lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

        Picture1.Image = Nothing
        If (imgHash.Count = 0) Then Exit Sub
        If (imgHash.ContainsKey(Me.txtDescription.Value)) Then
            Try
                Dim path = imgHash.Item(Me.txtDescription.Value)

                If (Not File.Exists(path)) Then
                    Console.WriteLine("Image not found for item " + Me.txtDescription.Value + "   Path:" + path)
                    Exit Sub
                End If


                Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(path)
                Picture1.Image = img
            Catch ex As Exception
                Console.WriteLine("Error Setting image" + ex.Message)
            End Try
        End If

    End Sub


    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart



        '      Dim c2 = Me.Sections
        '     For Each c As GrapeCity.ActiveReports.SectionReportModel.Section In c2
        'Dim countOfControls = c.Controls.Count
        'For i As Integer = 0 To countOfControls - 1
        'sHash2.Add(c.Controls(i).Name.ToString, sHash.Item(c.Controls(i).Name.ToString))
        'c3 = c.Controls(i).Name.ToString
        'c4 = sHash.Item(c.Controls(i).Name.ToString)
        'c.Controls(i).Tag = sHash.Item(c.Controls(i).Name.ToString)
        'Next
        'Next

        'For Each c As GrapeCity.ActiveReports.SectionReportModel.TextBox In c2
        ' Dim countOfControls = c.Tag.Count()
        'For i As Integer = 0 To countOfControls - 1
        'If c.GetType().ToString = "TextBox" Then
        'If c.Tag IsNot Nothing Then
        'c.Text = c.Tag.ToString
        'End If
        'End If
        'Next
        'Next

        lblTitle.Text = sReportTitle
        If Not optShowImages Then Detail1.Height = 0.15
        Picture1.Visible = optShowImages


        lblThumbnailImg.Visible = optShowImages

        lblProductCode.Visible = optShowProductCode
        txtProductCode.Visible = optShowProductCode

        lblUnitRate.Visible = optShowUnitRate
        txtUnitRate.Visible = optShowUnitRate

        lblCurSymbol.Visible = optShowTotals
        txtTotal.Visible = optShowTotals

        lblTitle.Text = sHash.Item("lblTitle")
        lblPrjName.Text = sHash.Item("lblPrjName")
        lblPrjRef.Text = sHash.Item("lblPrjRef")

        If ISO.Equals("EN") Then
            lblRev.Text = sHash.Item("lblRevNo")
            txtRev.Text = txtRev.DataField
            txtPrjRef.Visible = False
            txtPrjRef2.Visible = True
        Else
            lblRev.Text = sHash.Item("lblRev")
            txtRev.DataField = ""
            txtRev.Text = sRevisionTxt
            txtPrjRef.Visible = True
            txtPrjRef2.Visible = False
        End If

        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        lblSetNo.Text = sHash.Item("lblSetNo")

        lblNotes.Text = sHash.Item("lblNotes")
        lblCurSymbol.Text = sHash.Item("lblCurSymbol")
        lblDate.Text = sHash.Item("lblDate")
        lblThumbnailImg.Text = sHash.Item("lblThumbnailImg")
        lblDoorRefNums.Text = sHash.Item("lblDoorRefNums")
        lblProductCode.Text = sHash.Item("lblProductCode")
        lblProductDesc.Text = sHash.Item("lblProductDesc")
        lblUnit.Text = sHash.Item("lblUnit")
        lblUnitRate.Text = sHash.Item("lblUnitRate")
        lblTotDoors.Text = sHash.Item("lblTotDoors")
        lblDoorRefNums.Text = sHash.Item("lblDoorRefNums")
        lblFinish.Text = sHash.Item("lblFinish")

        txtFooter.Text = sHash.Item("txtFooter")


        If ISO.Equals("EN") Then
            txtDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            txtDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            txtDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("AU") Then
            txtDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            txtDate.OutputFormat = "MM.dd.yyyy"
            imgLogoEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If



        If ISO.Equals("BE") Then
            txtProjectOwner.DataField = "SpecConsult"
            txtContactNumber.DataField = "SpecConNumber"
            txtEmail.DataField = "SpecConEmail"
        End If

    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub GroupFooter1_Format(sender As Object, e As EventArgs) Handles GroupFooter1.Format

    End Sub
End Class

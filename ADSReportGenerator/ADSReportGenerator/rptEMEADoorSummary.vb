Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptEMEADoorSummary
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
    Public optShowExtendedRate As Boolean = False
    Public sRevisionText As String
    Public sHash As Hashtable
    Public ISO As String
    Public sReportTitle As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format




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

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        lblTitle.Text = sReportTitle

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
            txtRev.Text = sRevisionText
            txtPrjRef.Visible = True
            txtPrjRef2.Visible = False
        End If

        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        lblDoorNumber.Text = sHash.Item("lblDoorNumber")
        lblSetRef.Text = sHash.Item("lblSetRef")

        txtFooter.Text = sHash.Item("txtFooter")

        lblDoorNumber2.Text = lblDoorNumber.Text
        lblDoorNumber3.Text = lblDoorNumber.Text
        lblSetRef2.Text = lblSetRef.Text
        lblSetRef3.Text = lblSetRef.Text

        If ISO.Equals("BE") Then
            txtProjectOwner.DataField = "SpecConsult"
            txtContactNumber.DataField = "SpecConNumber"
            txtEmail.DataField = "SpecConEmail"
        End If

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



    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format


    End Sub
End Class

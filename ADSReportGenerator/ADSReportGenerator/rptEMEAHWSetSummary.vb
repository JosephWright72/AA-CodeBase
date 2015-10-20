Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports

Public Class rptEMEAHWSetSummary
    Private IsListFinished As Boolean = True
    Public ShowCost As Boolean = False
    Public ShowTotal As Boolean = False
    Public sReportTitle As String
    Public sRevisionText As String
    Public sSetNo As String
    Public sDescription As String
    Public sDoorQuantity As String
    Public sSetPrice As String
    Public sExtendedPrice As String
    Public sPrjName As String
    Public sPrjRef As String
    Public sRevNo As String
    Public sPrjOwner As String
    Public sHash As Hashtable
    Public ISO As String






    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        'lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text

    End Sub

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart


        lblSetPrice.Visible = ShowCost
        lblExtendedPrice.Visible = ShowCost
        txtPrice.Visible = ShowCost
        txtExtended.Visible = ShowCost
        lblCurSymbol.Visible = ShowCost
        txtTotExtended.Visible = ShowCost
        txtRev.Text = sRevisionText

        lblTitle.Text = sHash.Item("lblTitle")
        lblPrjName.Text = sHash.Item("lblPrjName")
        lblPrjRef.Text = sHash.Item("lblPrjRef")
        lblRevNo.Text = sHash.Item("lblRevNo")
        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        lblSetNo.Text = sHash.Item("lblSetNo")
        lblDescription.Text = sHash.Item("lblDescription")
        lblDoorQuantity.Text = sHash.Item("lblDoorQuantity")
        lblSetPrice.Text = sHash.Item("lblSetPrice")
        lblExtendedPrice.Text = sHash.Item("lblExtendedPrice")


        lblEmail.Text = sHash.Item("lblEmail")
        lblNotes.Text = sHash.Item("lblNotes")
        lblTotalSum.Text = sHash.Item("lblTotalSum")
        lblCurSymbol.Text = sHash.Item("lblCurSymbol")
        lblDate.Text = sHash.Item("lblDate")

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

End Class

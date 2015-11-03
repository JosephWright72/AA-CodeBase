Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptEMEADoorsIronmongerySetSummary
    Public sReportTitle As String
    Public sHash As Hashtable
    Public sRevisionText As String
    Public ISO As String
    Public optShowUnitRate As Boolean = False

    Private Sub rpt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        lblReportName.Text = sHash.Item("lblTitle")

        lblProjectName.Text = sHash.Item("lblPrjName")
        lblProjectRef.Text = sHash.Item("lblPrjRef")
        lblRevisionNo.Text = sHash.Item("lblRevNo")
        lblProjectOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")

        RevisionNoValue.Text = sRevisionText

        lblDoorRef.Text = sHash.Item("lblDoorRef")
        lblFunction.Text = sHash.Item("lblFunction")
        lblSetNo.Text = sHash.Item("lblSetNo")
        lblUnitRate.Text = sHash.Item("lblUnitRate")
        lblCurSymbol.Text = sHash.Item("lblCurSymbol")
        lblCurSymbolTotal.Text = sHash.Item("lblCurSymbol")
        lblTotalSum.Text = sHash.Item("lblTotalSum")
        lblTotDoors.Text = sHash.Item("lblTotDoors")
        lblNotes.Text = sHash.Item("lblNotes")

        Footer.Text = sHash.Item("txtFooter")

        If ISO.Equals("EN") Then
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            imgLogoEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("AU") Then
            imgLogoEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            imgLogoEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If

        If ISO.Equals("EN") Then
            DateValue.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            DateValue.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            DateValue.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If

        lblUnitRate.Visible = optShowUnitRate
        lblCurSymbol.Visible = optShowUnitRate
        UnitRateValue.Visible = optShowUnitRate

        lblTotalSum.Visible = optShowUnitRate
        TotalSumValue.Visible = optShowUnitRate
        lblCurSymbolTotal.Visible = optShowUnitRate

    End Sub

End Class

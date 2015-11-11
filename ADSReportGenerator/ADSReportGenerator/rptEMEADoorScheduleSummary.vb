Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptEMEADoorScheduleSummary
    Public sReportTitle As String
    Public sHash As Hashtable
    Public sRevisionText As String
    Public ISO As String
    Public optShowUnitRate As Boolean = False

    Private Sub rpt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        lblReportName.Text = sHash.Item("lblTitle")

        lblProjectName.Text = sHash.Item("lblPrjName")
        lblProjectRef.Text = sHash.Item("lblPrjRef")
        lblRev.Text = sHash.Item("lblRev")
        lblProjectOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")

        RevisionValue.Text = sRevisionText

        lblDoorRef.Text = sHash.Item("lblDoorRef")
        lblToRoom.Text = sHash.Item("lblToRoom")
        lblFromRoom.Text = sHash.Item("lblFromRoom")
        lblMaterial.Text = sHash.Item("lblMaterial")
        lblConfiguration.Text = sHash.Item("lblConfiguration")
        lblQuantity.Text = sHash.Item("lblQty")
        lblFireRating.Text = sHash.Item("lblFireRating")
        lblAcousticRating.Text = sHash.Item("lblAcousticRating")
        lblFrameWidth.Text = sHash.Item("lblFrameWidth")
        lblFrameHeight.Text = sHash.Item("lblFrameHeight")
        lblFrameDepth.Text = sHash.Item("lblFrameDepth")
        lblUnitRate.Text = sHash.Item("lblUnitRate")
        lblTotalSum.Text = sHash.Item("lblTotalSum")
        lblTotDoors.Text = sHash.Item("lblTotDoors")

        Footer.Text = sHash.Item("txtFooter")

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
        ElseIf ISO.Equals("AU") Then
            imgLogoEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            imgLogoEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If

        lblUnitRate.Visible = optShowUnitRate
        UnitRateValue.Visible = optShowUnitRate

        lblTotalSum.Visible = optShowUnitRate
        TotalSumValue.Visible = optShowUnitRate

        UnitRateValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"
        TotalSumValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"

        If METRIC_OUTPUT = 1 Then
            lblFrameWidth.Text = lblFrameWidth.Text + " (mm)"
            lblFrameHeight.Text = lblFrameHeight.Text + " (mm)"
            lblFrameDepth.Text = lblFrameDepth.Text + " (mm)"
        Else
            lblFrameWidth.Text = lblFrameWidth.Text + " (feet and inches)"
            lblFrameHeight.Text = lblFrameHeight.Text + " (feet and inches)"
            lblFrameDepth.Text = lblFrameDepth.Text + " (feet and inches)"
        End If

    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        If UnitRateValue.Text.Length < 8 Then UnitRateValue.Text = Space(8 - UnitRateValue.Text.Length) & UnitRateValue.Text
    End Sub

    Private Sub GroupFooter_Format(sender As Object, e As EventArgs) Handles GroupFooter.Format
        If TotalSumValue.Text.Length < 10 Then TotalSumValue.Text = Space(10 - TotalSumValue.Text.Length) & TotalSumValue.Text
    End Sub

End Class

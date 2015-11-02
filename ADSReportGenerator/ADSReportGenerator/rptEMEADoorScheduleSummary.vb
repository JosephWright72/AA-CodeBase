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
        lblCurSymbol.Text = sHash.Item("lblCurSymbol")
        lblCurSymbolTotal.Text = sHash.Item("lblCurSymbol")
        lblTotalSum.Text = sHash.Item("lblTotalSum")
        lblTotDoors.Text = sHash.Item("lblTotDoors")

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
        End If

        lblUnitRate.Visible = optShowUnitRate
        lblCurSymbol.Visible = optShowUnitRate
        UnitRateValue.Visible = optShowUnitRate

        lblTotalSum.Visible = optShowUnitRate
        TotalSumValue.Visible = optShowUnitRate
        lblCurSymbolTotal.Visible = optShowUnitRate

    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        FrameWidthValue.Text = FEETINCH(Val(FrameWidthValue.Text))
        FrameHeightValue.Text = FEETINCH(Val(FrameHeightValue.Text))
        FrameDepthValue.Text = FEETINCH(Val(FrameDepthValue.Text))
    End Sub

End Class

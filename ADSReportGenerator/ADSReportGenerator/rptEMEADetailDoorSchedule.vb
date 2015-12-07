Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptEMEADetailDoorSchedule
    Public sReportTitle As String
    Public sHash As Hashtable
    Public sRevisionText As String
    Public ISO As String
    Public optShowUnitRate As Boolean = False

    Private Sub rpt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        lblProjectName.Text = sHash.Item("lblPrjName")
        lblProjectRef.Text = sHash.Item("lblPrjRef")
        lblRevNo.Text = sHash.Item("lblRevNo")
        lblProjectOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")

        RevisionValue.Text = sRevisionText

        lblDoorRef.Text = sHash.Item("lblDoorRef")
        lblToRoom.Text = sHash.Item("lblToRoom")
        lblFromRoom.Text = sHash.Item("lblFromRoom")
        lblDoorType.Text = sHash.Item("lblDoorType")
        lblFireRating.Text = sHash.Item("lblFireRating")
        lblAcousticRating.Text = sHash.Item("lblAcousticRating")
        lblUndercut.Text = sHash.Item("lblUndercut")
        lblThickness.Text = sHash.Item("lblThickness")
        lblDoorFinish.Text = sHash.Item("lblDoorFinish")
        lblDoorEdge.Text = sHash.Item("lblDoorEdge")
        lblIronmongerySet.Text = sHash.Item("lblIronmongerySet")
        lblGlassType.Text = sHash.Item("lblGlassType")
        lblAperture.Text = sHash.Item("lblAperture")
        lblFrameDepth.Text = sHash.Item("lblFrameDepth")
        lblSOWidth.Text = sHash.Item("lblSOWidth")
        lblSOHeight.Text = sHash.Item("lblSOHeight")
        lblFrameWidth.Text = sHash.Item("lblFrameWidth")
        lblFrameHeight.Text = sHash.Item("lblFrameHeight")
        lblFrameFinish.Text = sHash.Item("lblFrameFinish")
        lblThreshold.Text = sHash.Item("lblThreshold")
        lblNotes.Text = sHash.Item("lblNotes")
        lblHanding.Text = sHash.Item("lblHanding")
        lblDoorset.Text = sHash.Item("lblDoorset")
        lblIronmongery.Text = sHash.Item("lblIronmongery")
        lblFitting.Text = sHash.Item("lblFitting")
        lblTotal.Text = sHash.Item("lblTotal")
        lblTotalSum.Text = sHash.Item("lblTotalSum")

        lblDoorHandingDiagram.Text = sHash.Item("lblDoorHandingDiagram")
        lblDrawingsUsed.Text = sHash.Item("lblDrawingsUsed")

        If ISO.Equals("EN") Then
            DateValue.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgDoorHandingDiagramEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            DateValue.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgDoorHandingDiagramEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            DateValue.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("BE")
            imgDoorHandingDiagramEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("AU") Then
            imgLogoEN.Visible = ISO.Equals("AU")
            imgDoorHandingDiagramEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            imgLogoEN.Visible = ISO.Equals("US")
            imgDoorHandingDiagramEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If

        DoorPriceValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"
        HWPriceValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"
        TotalValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"

        DoorsetSumValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"
        HWSumValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"
        GrandTotalValue.OutputFormat = sHash.Item("lblCurSymbol") + "#,##0.00"

        If METRIC_OUTPUT = 1 Then
            lblThickness.Text = lblThickness.Text + " (mm)"
            lblFrameDepth.Text = lblFrameDepth.Text + " (mm)"
            lblSOWidth.Text = lblSOWidth.Text + " (mm)"
            lblSOHeight.Text = lblSOHeight.Text + " (mm)"
            lblFrameWidth.Text = lblFrameWidth.Text + " (mm)"
            lblFrameHeight.Text = lblFrameHeight.Text + " (mm)"
        Else
            lblThickness.Text = lblThickness.Text + " (feet and inches)"
            lblFrameDepth.Text = lblFrameDepth.Text + " (feet and inches)"
            lblSOWidth.Text = lblSOWidth.Text + " (feet and inches)"
            lblSOHeight.Text = lblSOHeight.Text + " (feet and inches)"
            lblFrameWidth.Text = lblFrameWidth.Text + " (feet and inches)"
            lblFrameHeight.Text = lblFrameHeight.Text + " (feet and inches)"
        End If

    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format

        If DoorPriceValue.Text.Length < 8 Then DoorPriceValue.Text = Space(8 - DoorPriceValue.Text.Length) & DoorPriceValue.Text
        If HWPriceValue.Text.Length < 8 Then HWPriceValue.Text = Space(8 - HWPriceValue.Text.Length) & HWPriceValue.Text
        If TotalValue.Text.Length < 8 Then TotalValue.Text = Space(8 - TotalValue.Text.Length) & TotalValue.Text

    End Sub

    Private Sub GroupFooter_Format(sender As Object, e As EventArgs) Handles GroupFooter.Format

        If DoorsetSumValue.Text.Length < 10 Then DoorsetSumValue.Text = Space(10 - DoorsetSumValue.Text.Length) & DoorsetSumValue.Text
        If HWSumValue.Text.Length < 10 Then HWSumValue.Text = Space(10 - HWSumValue.Text.Length) & HWSumValue.Text
        If GrandTotalValue.Text.Length < 10 Then GrandTotalValue.Text = Space(10 - GrandTotalValue.Text.Length) & GrandTotalValue.Text

    End Sub

End Class

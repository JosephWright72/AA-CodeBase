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
        lblRevisionNo.Text = sHash.Item("lblRevNo")
        lblProjectOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")

        RevisionNoValue.Text = sRevisionText

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
    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        ThicknessValue.Text = FEETINCH(Val(ThicknessValue.Text))
        FrameDepthValue.Text = FEETINCH(Val(FrameDepthValue.Text))
        SOWidthValue.Text = FEETINCH(Val(SOWidthValue.Text))
        SOHeightValue.Text = FEETINCH(Val(SOHeightValue.Text))
        FrameWidthValue.Text = FEETINCH(Val(FrameWidthValue.Text))
        FrameHeightValue.Text = FEETINCH(Val(FrameHeightValue.Text))
    End Sub

End Class

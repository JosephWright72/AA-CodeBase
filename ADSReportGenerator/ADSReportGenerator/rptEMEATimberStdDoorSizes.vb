Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptEMEATimberStdDoorSizes
    Private iDoorQty As Integer
    Public totDoorList As String = ""
    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public sRevisionText As String
    Public optArchitect As Boolean = False
    Public optContractor As Boolean = False
    Public optOwner As Boolean = False
    Public sReportTitle As String
    Public sHash As Hashtable
    Public ISO As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

        If METRIC_OUTPUT <> 1 Then
            StructuralOpeningSizeValue.Text = FEETINCH(Val(StructuralOpeningSizeValue.Text.Substring(0, InStr(StructuralOpeningSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(StructuralOpeningSizeValue.Text.Substring(InStr(StructuralOpeningSizeValue.Text, "x") + 1, StructuralOpeningSizeValue.Text.Length - ((InStr(StructuralOpeningSizeValue.Text, "x") + 1)))))
            TimberFrameSizeValue.Text = FEETINCH(Val(TimberFrameSizeValue.Text.Substring(0, InStr(TimberFrameSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(TimberFrameSizeValue.Text.Substring(InStr(TimberFrameSizeValue.Text, "x") + 1, TimberFrameSizeValue.Text.Length - ((InStr(TimberFrameSizeValue.Text, "x") + 1)))))
            DoorLeafSizeValue.Text = FEETINCH(Val(DoorLeafSizeValue.Text.Substring(0, InStr(DoorLeafSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(DoorLeafSizeValue.Text.Substring(InStr(DoorLeafSizeValue.Text, "x") + 1, DoorLeafSizeValue.Text.Length - ((InStr(DoorLeafSizeValue.Text, "x") + 1)))))
        End If

    End Sub

    Dim rpt As rptEMEATimberStdDoorSizesSub
    Public subDC As DataCls

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        rpt = New rptEMEATimberStdDoorSizesSub()
        rpt.sHash = sHash

        lblReportName.Text = sHash.Item("lblTitle")
        txtStandardFrameDepths.Text = sHash.Item("txtStandardFrameDepths")
        lblModuleSize.Text = sHash.Item("lblModuleSize")
        lblStructuralOpeningSize.Text = sHash.Item("lblStructuralOpeningSize")
        lblTimberFrameSize.Text = sHash.Item("lblTimberFrameSize")
        lblDoorLeafSize.Text = sHash.Item("lblDoorLeafSize")
        lblKickplateSize.Text = sHash.Item("lblKickplateSize")
        lblDoorTypes.Text = sHash.Item("lblDoorTypes")
        txtAllSizesIn.Text = sHash.Item("txtAllSizesIn")

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

        If METRIC_OUTPUT = 1 Then
            txtAllSizesIn.Text = txtAllSizesIn.Text + FEETINCH(Val("1")).Replace("1", "")
        Else
            txtAllSizesIn.Text = txtAllSizesIn.Text + " feet and inches"
        End If

    End Sub

    Private Sub GroupHeader1_Format(sender As Object, e As EventArgs) Handles SubGroupHeader.Format
        rpt.DataSource = subDC.DT

        Me.EMEATimberStdDoorSizesSub.Report = rpt

        If METRIC_OUTPUT = 1 Then
            FrameDepthList.Text = FrameDepthList.Text + FEETINCH(Val("-1")).Replace("-1", "")
            txtSizeInfo.Text = sHash.Item("txtSizeInfo")
        Else
            Dim FrameDepthArray As Object
            Dim i As Long

            FrameDepthArray = Split(FrameDepthList.Text, ",")
            FrameDepthList.Text = ""
            For i = 0 To UBound(FrameDepthArray)
                FrameDepthList.Text = FrameDepthList.Text + FEETINCH(Val(FrameDepthArray(i))) + ", "
            Next i

            FrameDepthList.Text = FrameDepthList.Text.Substring(0, FrameDepthList.Text.Length - 2)

            txtSizeInfo.Text = sHash.Item("txtSizeInfo").ToString.Replace("63mm", FEETINCH(Val(63 * 0.0032808)))
        End If

    End Sub

End Class

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

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format

        If METRIC_OUTPUT <> 1 Then
            StructuralOpeningSizeValue.Text = FEETINCH(Val(StructuralOpeningSizeValue.Text.Substring(0, InStr(StructuralOpeningSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(StructuralOpeningSizeValue.Text.Substring(InStr(StructuralOpeningSizeValue.Text, "x") + 1, StructuralOpeningSizeValue.Text.Length - ((InStr(StructuralOpeningSizeValue.Text, "x") + 1)))))
            TimberFrameSizeValue.Text = FEETINCH(Val(TimberFrameSizeValue.Text.Substring(0, InStr(TimberFrameSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(TimberFrameSizeValue.Text.Substring(InStr(TimberFrameSizeValue.Text, "x") + 1, TimberFrameSizeValue.Text.Length - ((InStr(TimberFrameSizeValue.Text, "x") + 1)))))
            DoorLeafSizeValue.Text = FEETINCH(Val(DoorLeafSizeValue.Text.Substring(0, InStr(DoorLeafSizeValue.Text, "x") - 1))) + " x " + FEETINCH(Val(DoorLeafSizeValue.Text.Substring(InStr(DoorLeafSizeValue.Text, "x") + 1, DoorLeafSizeValue.Text.Length - ((InStr(DoorLeafSizeValue.Text, "x") + 1)))))
        End If

    End Sub

    Dim rpt As rptEMEATimberStdDoorSizesSub
    Public subDC As DataCls

    Private Sub rpt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

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
        lblDoorTypes2.Text = sHash.Item("lblDoorTypes2")
        txtAllSizesIn.Text = sHash.Item("txtAllSizesIn")
        lblPrimedPainted.Text = sHash.Item("lblPrimedPainted")
        lblHardwood.Text = sHash.Item("lblHardwood")
        lblVeneered.Text = sHash.Item("lblVeneered")
        txtNBRatings.Text = sHash.Item("txtNBRatings")

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
            FrameDepthListPrimedPainted.Text = FrameDepthListPrimedPainted.Text + FEETINCH(Val("-1")).Replace("-1", "")
            FrameDepthListHardwood.Text = FrameDepthListHardwood.Text + FEETINCH(Val("-1")).Replace("-1", "")
            FrameDepthListVeneered.Text = FrameDepthListVeneered.Text + FEETINCH(Val("-1")).Replace("-1", "")
            txtSizeInfo.Text = sHash.Item("txtSizeInfo")
        Else
            Dim FrameDepthArrayPrimedPainted As Object
            Dim FrameDepthArrayHardwood As Object
            Dim FrameDepthArrayVeneered As Object
            Dim i As Long

            FrameDepthArrayPrimedPainted = Split(FrameDepthListPrimedPainted.Text, ",")
            FrameDepthListPrimedPainted.Text = ""

            For i = 0 To UBound(FrameDepthArrayPrimedPainted)
                FrameDepthListPrimedPainted.Text = FrameDepthListPrimedPainted.Text + FEETINCH(Val(FrameDepthArrayPrimedPainted(i))) + ", "
            Next i

            FrameDepthListPrimedPainted.Text = FrameDepthListPrimedPainted.Text.Substring(0, FrameDepthListPrimedPainted.Text.Length - 2)

            FrameDepthArrayHardwood = Split(FrameDepthListHardwood.Text, ",")
            FrameDepthListHardwood.Text = ""

            For i = 0 To UBound(FrameDepthArrayHardwood)
                FrameDepthListHardwood.Text = FrameDepthListHardwood.Text + FEETINCH(Val(FrameDepthArrayHardwood(i))) + ", "
            Next i

            FrameDepthListHardwood.Text = FrameDepthListHardwood.Text.Substring(0, FrameDepthListHardwood.Text.Length - 2)

            FrameDepthArrayVeneered = Split(FrameDepthListVeneered.Text, ",")
            FrameDepthListVeneered.Text = ""

            For i = 0 To UBound(FrameDepthArrayVeneered)
                FrameDepthListVeneered.Text = FrameDepthListVeneered.Text + FEETINCH(Val(FrameDepthArrayVeneered(i))) + ", "
            Next i

            FrameDepthListVeneered.Text = FrameDepthListVeneered.Text.Substring(0, FrameDepthListVeneered.Text.Length - 2)

            txtSizeInfo.Text = sHash.Item("txtSizeInfo").ToString.Replace("62mm", FEETINCH(Val(6 * 0.0032808)))
        End If

    End Sub

End Class

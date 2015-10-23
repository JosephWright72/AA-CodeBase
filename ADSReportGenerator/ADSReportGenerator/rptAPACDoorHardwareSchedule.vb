Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptAPACDoorHardwareSchedule

    Public sReportTitle As String
    Public showHeight As Boolean
    Public showWidth As Boolean
    Public showThickness As Boolean
    Public showHanding As Boolean
    Public showDoorType As Boolean
    Public showFrameType As Boolean
    Public showHWSet As Boolean

    Property sPgFooterProjID As String



    Private Sub rptAPACDoorHardwareScheduleStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        lblReportTitle.Text = sReportTitle
    End Sub

    Private Sub rptAPACDoorHardwareGF(ByVal sender As Object, ByVal e As System.EventArgs) Handles gf.Format

        lblSetNotes.Visible = txtSetNotes.Text <> ""
        txtSetNotes.Visible = txtSetNotes.Text <> ""

        lblDoorNotes.Visible = txtDoorNotes.Text <> ""
        txtDoorNotes.Visible = txtDoorNotes.Text <> ""

        gf.Visible = txtSetNotes.Text <> "" Or txtDoorNotes.Text <> ""

    End Sub

    'Private Sub rptAPACDoorHardwarePageFooter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
    '    IDRev.Text = IDRev.Text.Replace("'", "")
    'End Sub

    Private Sub rptAPACDoorHardwareGHMark(ByVal sender As Object, ByVal e As System.EventArgs) Handles ghMark.Format
        tbHeight.Visible = showHeight
        tbWidth.Visible = showWidth
        tbThickness.Visible = showThickness
        tbHanding.Visible = showHanding
        tbDoorType.Visible = showDoorType
        tbFrameType.Visible = showFrameType
        tbHWSet.Visible = showHWSet
        lblHeight.Visible = showHeight
        lblWidth.Visible = showWidth
        lblThickness.Visible = showThickness
        lblHanding.Visible = showHanding
        lblDoorType.Visible = showDoorType
        lblFrameType.Visible = showFrameType
        lblHWSet.Visible = showHWSet
    End Sub


    Private Sub rptPageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PageStart
        Me.PageSettings.Margins.Top = 0.25F
        Me.PageSettings.Margins.Bottom = 0.25F
        Me.PageSettings.Margins.Left = 0.5F
        Me.PageSettings.Margins.Right = 0.5F
    End Sub

End Class

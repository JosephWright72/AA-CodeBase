Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptAPACBuildingSummary

    Public sReportTitle As String

    Private Sub rptAPACBuildingSummaryStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        lblReportTitle.Text = sReportTitle
    End Sub

    Private Sub rptPageStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PageStart
        Me.PageSettings.Margins.Top = 0.25F
        Me.PageSettings.Margins.Bottom = 0.25F
        Me.PageSettings.Margins.Left = 0.5F
        Me.PageSettings.Margins.Right = 0.5F
    End Sub

End Class

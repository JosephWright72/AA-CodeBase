Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptUnmatchHW
    Public ProjName1 As String
    Public ProjName2 As String

    Private Sub rptMissingItems_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.PageSettings.Margins.Top = 0.75
    End Sub
End Class

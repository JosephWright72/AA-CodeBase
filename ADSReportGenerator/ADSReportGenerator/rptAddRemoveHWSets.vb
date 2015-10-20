Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptAddRemoveHWSets
    Public ProjName1 As String
    Public ProjName2 As String

    Private Sub ghMarkNumbers_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ghMarkNumbers.Format
        ProjectName1.Text = ProjName1
        ProjectName2.Text = ProjName2
    End Sub

    Private Sub rptMissingItems_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.PageSettings.Margins.Top = 0.75
    End Sub
End Class

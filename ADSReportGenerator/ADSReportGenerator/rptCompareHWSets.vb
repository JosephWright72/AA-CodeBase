Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptCompareHWSets
    Public ProjName1 As String
    Public ProjName2 As String
    Private rptSubMissingItems As New rptAddRemoveHWSets

    Private Sub rptCompareProjects_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.PageSettings.Margins.Top = 0.75
    End Sub

    Private Sub gfMissingHardwareSets_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        ProjectName1.Text = ProjName1
        ProjectName2.Text = ProjName2
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        On Error GoTo ErrHandler
        If TextBox1.Text Is Nothing Then Exit Sub
        If TextBox1.Text.ToUpper Like "*PRICE*" Then
            If IsNumeric(TextBox2.Text) = True Then TextBox2.Text = Val(TextBox2.Text).ToString("c", New Globalization.CultureInfo("en-US", False))
            If IsNumeric(TextBox3.Text) = True Then TextBox3.Text = Val(TextBox3.Text).ToString("c", New Globalization.CultureInfo("en-US", False))
        End If

        If TextBox1.Text.ToUpper Like "*WIDTH*" Then
            If IsNumeric(TextBox2.Text) = True Then TextBox2.Text = FEETINCH(Val(TextBox2.Text))
            If IsNumeric(TextBox3.Text) = True Then TextBox3.Text = FEETINCH(Val(TextBox3.Text))
        End If

        If TextBox1.Text.ToUpper Like "*HEIGHT*" Then
            If IsNumeric(TextBox2.Text) = True Then TextBox2.Text = FEETINCH(Val(TextBox2.Text))
            If IsNumeric(TextBox3.Text) = True Then TextBox3.Text = FEETINCH(Val(TextBox3.Text))
        End If

        If TextBox1.Text.ToUpper Like "*DEPTH*" Then
            If IsNumeric(TextBox2.Text) = True Then TextBox2.Text = FEETINCH(Val(TextBox2.Text))
            If IsNumeric(TextBox3.Text) = True Then TextBox3.Text = FEETINCH(Val(TextBox3.Text))
        End If

        If TextBox1.Text.ToUpper Like "*THICKNESS*" Then
            If IsNumeric(TextBox2.Text) = True Then TextBox2.Text = FEETINCH(Val(TextBox2.Text))
            If IsNumeric(TextBox3.Text) = True Then TextBox3.Text = FEETINCH(Val(TextBox3.Text))
        End If
        Exit Sub
ErrHandler:
        Resume Next
        Exit Sub
        Resume
    End Sub
End Class

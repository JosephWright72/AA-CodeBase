Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptCompareDoors
    Public ProjName1 As String
    Public ProjName2 As String
    Public dtAddRemoveDoors As DataTable
    Public dtHardwareSets As DataTable
    Public dtAddRemoveHWSets As DataTable
    Public dtUnmatchedHW As DataTable
    Private rptSubAddRemoveDoors As New rptAddRemoveDoors
    Private rptSubCompareHWSets As New rptCompareHWSets
    Private rptSubAddRemoveHWSets As New rptAddRemoveHWSets
    Private rptSubUnmatchedHW As New rptUnmatchHW

    Private Sub rptCompareProjects_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        Me.PageSettings.Margins.Top = 0.75
    End Sub

    Private Sub gfAddRemoveDoors_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfAddRemoveDoors.Format
        If dtAddRemoveDoors Is Nothing OrElse dtAddRemoveDoors.Rows.Count = 0 Then
            'gfHardwareSets.Visible = False
            gfAddRemoveDoors.NewPage = NewPage.None
            gfHardwareSets.Height = 0
            Exit Sub
        End If
        rptSubAddRemoveDoors.DataSource = dtAddRemoveDoors
        rptSubAddRemoveDoors.ProjName1 = Me.ProjName1
        rptSubAddRemoveDoors.ProjName2 = Me.ProjName2
        SubReport1.Report = rptSubAddRemoveDoors
    End Sub

    Private Sub gfHardwareSets_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfHardwareSets.Format
        If dtHardwareSets Is Nothing OrElse dtHardwareSets.Rows.Count = 0 Then
            gfHardwareSets.NewPage = NewPage.None
            gfHardwareSets.Visible = False
            Exit Sub
        End If
        rptSubCompareHWSets.DataSource = dtHardwareSets
        rptSubCompareHWSets.ProjName1 = Me.ProjName1
        rptSubCompareHWSets.ProjName2 = Me.ProjName2
        SubReport2.Report = rptSubCompareHWSets
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        ProjectName1.Text = ProjName1
        ProjectName2.Text = ProjName2
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
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

        If TextBox1.Text.ToUpper = "DOOR ADD-ONS" Or TextBox1.Text.ToUpper = "FRAME ADD-ONS" Then
            TextBox2.Text = TextBox2.Text.Replace(Chr(251), ", ")
            TextBox3.Text = TextBox3.Text.Replace(Chr(251), ", ")
        End If

    End Sub

    Private Sub gfAddRemoveHW_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfAddRemoveHW.Format
        If dtAddRemoveHWSets Is Nothing OrElse dtAddRemoveHWSets.Rows.Count = 0 Then
            'gfMissingHardwareSets.Visible = False
            gfAddRemoveHW.NewPage = NewPage.None
            gfAddRemoveHW.Height = 0
            Exit Sub
        End If
        rptSubAddRemoveHWSets.DataSource = dtAddRemoveHWSets
        rptSubAddRemoveHWSets.ProjName1 = Me.ProjName1
        rptSubAddRemoveHWSets.ProjName2 = Me.ProjName2
        SubReport3.Report = rptSubAddRemoveHWSets
    End Sub

    Private Sub gfAddRemoveHWItems_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfAddRemoveHWItems.Format
        On Error GoTo ErrHandler

        If dtUnmatchedHW Is Nothing OrElse dtUnmatchedHW.Rows.Count = 0 Then
            'gfTypeDescriptions.Visible = False
            gfAddRemoveHWItems.Height = 0.3
            Exit Sub
        End If

        gfAddRemoveHWItems.Height = 0.5
        rptSubUnmatchedHW.DataSource = dtUnmatchedHW
        SubReport4.Report = rptSubUnmatchedHW
        Exit Sub
ErrHandler:
        Exit Sub
        Resume
    End Sub

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        lblDate.Text = Now
    End Sub

    Private Sub gfAddedDoors_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfAddedDoors.Format
        If sAddedDoors = "" Then
            lblDoorsAdded.Visible = False
            txtDoorsAdded.Visible = False
            gfAddedDoors.Height = 0
        Else
            txtDoorsAdded.Text = sAddedDoors
        End If

    End Sub

    Private Sub ghRemovedDoors_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ghRemovedDoors.Format
        If sRemovedDoors = "" Then
            lblDoorsRemoved.Visible = False
            txtDoorsRemoved.Visible = False
            gfRemovedDoors.Height = 0
        Else
            txtDoorsRemoved.Text = sRemovedDoors
        End If
    End Sub
End Class

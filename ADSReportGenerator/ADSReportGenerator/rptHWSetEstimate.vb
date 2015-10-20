Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptHWSetEstimate
    Private SubTotalPrice As Double
    Private dGrandSellPrice As Double
    Public ShowCost As Boolean = False
    Public sReportTitle As String

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If TextBox1.Text = "4" Then Stop
        Dim str1 As String = txtPrice.Value.ToString.Replace("$", "")
        str1 = str1.Replace(",", "")
        SubTotalPrice += Val(str1)

    End Sub

    Private Sub gfHardwareSet_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfHardwareSet.Format
        txtSubPrice.Value = SubTotalPrice
        txtTotalSetPrice.Value = SubTotalPrice * Val(txtSetQty.Value)
        dGrandSellPrice += SubTotalPrice * Val(txtSetQty.Value)
        SubTotalPrice = 0
    End Sub

    Private Sub rptHWSetEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        txtPrice.Visible = ShowCost
        lblReportTitle.Text = sReportTitle
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        txtGrandSellPrice.Value = dGrandSellPrice
    End Sub
End Class

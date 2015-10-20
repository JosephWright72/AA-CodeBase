Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptDoorFrameSchedule
    Public ProjName1 As String
    Private GrandTotal As Double

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format
        txtProjectName.Text = ProjName1
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        txtPrice.Text = Val(txtDoorPrice.Value) + Val(txtFramePrice.Value)
        GrandTotal += Val(txtPrice.Text).ToString("0.00")
        txtPrice.Text = Val(txtPrice.Text).ToString("c", New Globalization.CultureInfo("en-US", False))
        txtWidth.Text = FEETINCH(Val(txtWidth.Text))
        txtHeight.Text = FEETINCH(Val(txtHeight.Text))
        txtThickness.Text = FEETINCH(Val(txtThickness.Text))
    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
        lblDate.Text = Now
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtPriceTotal.Text = GrandTotal.ToString("$#,##0.00;($#,##0.00)")
    End Sub
End Class

Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptDoorEstimateReport

    Private TotalExtension As Double
    Private TotalQty As Integer
    Public sReportTitle As String
    Private iCatagoryCount As Integer
    Public IsDoorReport As Boolean = True
    Private GrandTotalExt As Double

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If txtExtension.Value Is Nothing Then Exit Sub
        Dim str1 As String = txtExtension.Value.ToString.Replace("$", "")
        str1 = str1.Replace(",", "")
        str1 = str1.Replace("*", "")
        TotalExtension += Val(str1)

        If NullCheckBool(txtNC.Value) = True Then
            chkNC.Checked = True
        Else
            chkNC.Checked = False
        End If

        TotalQty += Val(txtQty.Value)

        If iCatagoryCount > 0 Then
            txtAdj1.Visible = True
            txtAdj2.Visible = True
            txtAdj3.Visible = True
            txtAdj4.Visible = True
            txtElevType.Visible = False
            txtHeadFace.Visible = False
            txtJambFace.Visible = False
            txtSeries.Visible = False
            txtGa.Visible = False
            txtST.Visible = False
            txtDescComment.Width = 0.871 + 0.2
            txtSize.Left = 0.871 + 0.2
            txtSize.Width = 4
        Else
            txtAdj1.Visible = False
            txtAdj2.Visible = False
            txtAdj3.Visible = False
            txtAdj4.Visible = False
            If IsDoorReport = False Then
                txtElevType.Visible = True
                txtHeadFace.Visible = True
                txtJambFace.Visible = True
            End If
            txtSeries.Visible = True
            txtGa.Visible = True
            txtST.Visible = True
            txtDescComment.Width = 0.871
            txtSize.Left = 0.871
            txtSize.Width = 1.391
        End If

    End Sub

    Private Sub gfCategory_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles gfCategory.BeforePrint
        'iCatagoryCount = CInt(Val(txtCategorySort.Value))
        If iCatagoryCount > 0 Then
            txtAdj1.Visible = True
            txtAdj2.Visible = True
            txtAdj3.Visible = True
            txtAdj4.Visible = True
            txtElevType.Visible = False
            txtHeadFace.Visible = False
            txtJambFace.Visible = False
            txtSeries.Visible = False
            txtGa.Visible = False
            txtST.Visible = False
            txtDescComment.Width = 0.871 + 0.2
            txtSize.Left = 0.871 + 0.2
            txtSize.Width = 4
        Else
            txtAdj1.Visible = False
            txtAdj2.Visible = False
            txtAdj3.Visible = False
            txtAdj4.Visible = False
            If IsDoorReport = False Then
                txtElevType.Visible = True
                txtHeadFace.Visible = True
                txtJambFace.Visible = True
            End If
            txtSeries.Visible = True
            txtGa.Visible = True
            txtST.Visible = True
            txtDescComment.Width = 0.871
            txtSize.Left = 0.871
            txtSize.Width = 1.391
        End If
    End Sub

    Private Sub gfCatagory_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfCategory.Format
        txtTotalExtension.Value = TotalExtension
        txtTotalQty.Value = TotalQty
        GrandTotalExt += TotalExtension
        TotalExtension = 0
        TotalQty = 0
    End Sub



    Private Sub ghCatagory_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ghCategory.Format
        TotalExtension = 0
        TotalQty = 0

        iCatagoryCount = CInt(Val(txtCategorySort.Value))
        If iCatagoryCount > 0 Then
            txtAdj1.Visible = True
            txtAdj2.Visible = True
            txtAdj3.Visible = True
            txtAdj4.Visible = True
            txtElevType.Visible = False
            txtHeadFace.Visible = False
            txtJambFace.Visible = False
            txtSeries.Visible = False
            txtGa.Visible = False
            txtST.Visible = False
            txtDescComment.Width = 0.871 + 0.2
            txtSize.Left = 0.871 + 0.2
            txtSize.Width = 4
        Else
            txtAdj1.Visible = False
            txtAdj2.Visible = False
            txtAdj3.Visible = False
            txtAdj4.Visible = False
            If IsDoorReport = False Then
                txtElevType.Visible = True
                txtHeadFace.Visible = True
                txtJambFace.Visible = True
            End If
            txtSeries.Visible = True
            txtGa.Visible = True
            txtST.Visible = True
            txtDescComment.Width = 0.871
            txtSize.Left = 0.871
            txtSize.Width = 1.391
        End If

    End Sub

    Private Sub rptDoorEstimateReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        lblReportTitle.Text = sReportTitle
        If IsDoorReport = True Then
            lblElevType.Visible = False
            lblHeadFace.Visible = False
            lblJambFace.Visible = False
            txtElevType.Visible = False
            txtHeadFace.Visible = False
            txtJambFace.Visible = False
        Else
            lblElevType.Visible = True
            lblHeadFace.Visible = True
            lblJambFace.Visible = True
            txtElevType.Visible = True
            txtHeadFace.Visible = True
            txtJambFace.Visible = True
        End If

        If IsDoorReport = False Then
            lblSeries.Text = "Profile"
        End If
    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        txtGrandTotal.Value = GrandTotalExt
    End Sub
End Class

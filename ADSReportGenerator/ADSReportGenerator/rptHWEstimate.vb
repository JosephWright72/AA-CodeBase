Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptHWEstimate
    Private iTotalQty As Integer
    Private dTotalListPrice As Double
    Private dTotalExtended As Double
    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public ShowCost As Boolean = False
    Public sReportTitle As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim str1 As String = txtListPrice.Value.ToString.Replace("$", "")
        Dim str2 As String = ""
        str1 = str1.Replace(",", "")
        dTotalListPrice += Val(txtQuantity.Value) * Val(str1)
        dGrandTotalList += Val(txtQuantity.Value) * Val(str1)
        iTotalQty += Val(txtQuantity.Value)

        txtNetCost.Value = Val(str1) + ((Val(txtAdjustment1.Text) / 100) * Val(str1))

        'If ShowCost = True Then
        'We are not using cost for now per Tom
        'str1 = txtNetCost.Value.ToString.Replace("$", "")
        'str1 = str1.Replace(",", "")
        txtExtended.Value = Val(txtQuantity.Value) * Val(str1)
        dTotalExtended += Val(txtQuantity.Value) * Val(str1)
        dGrandTotalExtended += Val(txtQuantity.Value) * Val(str1)
        'Else
        '    txtExtended.Value = Val(txtQuantity.Value) * Val(str1)
        '    dTotalExtended += Val(txtQuantity.Value) * Val(str1)
        '    dGrandTotalExtended += Val(txtQuantity.Value) * Val(str1)
        'End If

    End Sub

    Private Sub ghManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ghManufacturer.Format
        If IsListFinished = False Then
            txtManufacturer.Text = txtManufacturer.Value & " - Continued"
        Else
            dTotalListPrice = 0
            iTotalQty = 0
            dTotalExtended = 0
        End If
        IsListFinished = False


    End Sub

    Private Sub gfManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gfManufacturer.Format
        txtTotalListPrice.Value = dTotalListPrice
        txtTotalQty.Value = iTotalQty
        txtTotalExtended.Value = dTotalExtended
        IsListFinished = True
    End Sub

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        'lblNetCost.Visible = ShowCost
        'txtNetCost.Visible = ShowCost
        lblReportTitle.Text = sReportTitle
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        txtGrandTotalListPrice.Value = dGrandTotalList
        txtGrandTotalExtended.Value = dGrandTotalExtended
    End Sub
End Class

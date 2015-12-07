Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptEMEATimberStdDoorSizesSub

    Public sHash As Hashtable

    Private Sub SectionReport1_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        Thickness.Text = FEETINCH(Val(Thickness.Text))

    End Sub

    Private Sub PageHeader_Format(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupFooter1_Format(sender As Object, e As EventArgs)

    End Sub
End Class

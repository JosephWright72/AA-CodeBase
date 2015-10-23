Imports GrapeCity.ActiveReports 
Imports GrapeCity.ActiveReports.Document 

Public Class rptEMEATimberStdDoorSizesSub

    Public sHash As Hashtable

    Private Sub SectionReport1_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        FrameDepthList.DataField = "FrameDepthList"

    End Sub

    Private Sub Detail_Format(sender As Object, e As EventArgs) Handles Detail.Format
        'lblPrjName.Text = sHash.Item("TIMBER")

    End Sub

    Private Sub PageHeader_Format(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupFooter1_Format(sender As Object, e As EventArgs) Handles GroupFooter1.Format
        FrameDepthList.Text = FEETINCH(Val(FrameDepthList.Text))


        If METRIC_OUTPUT = 1 Then
            FrameDepthList.Text = FrameDepthList.Text & " mm"
        Else
            'JW: TODO FEET INCHES CALCULATION

        End If

    End Sub
End Class

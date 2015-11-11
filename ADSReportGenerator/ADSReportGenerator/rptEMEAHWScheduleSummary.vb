Imports System
Imports System.IO
Imports System.Text
Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports




Public Class rptEMEAHWScheduleSummary
    Private iDoorQty As Integer
    Public totDoorList As String = ""
    'Private dTotalListPrice As Double
    'Private dTotalExtended As Double
    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public optCost As String = "2"
    Public optHWSetFilter As String = "2"
    Public optShowImages As Boolean = False
    Public optShowProductCode As Boolean = False
    Public optShowUnitRate As Boolean = False
    Public optShowExtendedRate As Boolean = False
    Public sRevisionText As String
    Public sHash As Hashtable
    Public imgHash As Hashtable
    Public ISO As String
    Public sReportTitle As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format

        Picture1.Image = Nothing
        If (imgHash.Count = 0) Then Exit Sub

        If (imgHash.ContainsKey(Me.txtDescription.Value)) Then
            Try
                Dim path = imgHash.Item(Me.txtDescription.Value)

                If (Not File.Exists(path)) Then
                    Console.WriteLine("Image not found for item " + Me.txtDescription.Value + "   Path:" + path)
                    Exit Sub
                End If

                Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(path)
                Picture1.Image = img
            Catch ex As Exception
                Console.WriteLine("Error Setting image" + ex.Message)
            End Try
        End If

    End Sub

    Private Sub ghManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If IsListFinished = False Then
            '        txtManufacturer.Text = txtManufacturer.Value & " - Continued"
        Else
            'dTotalListPrice = 0
            '  iDoorQty = 0
            'TotalExtended = 0
        End If
        IsListFinished = False


    End Sub

    Private Sub gfManufacturer_Format(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtTotalListPrice.Value = dTotalListPrice
        'txtTotDoors.Value = iDoorQty
        'txtDoorList.Value = totDoorList.Substring(0, totDoorList.Length - 2)

        'txtTotalExtended.Value = dTotalExtended
        IsListFinished = True
    End Sub

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter1.BeforePrint
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        'lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        lblTitle.Text = sReportTitle
        If Not optShowImages Then Detail1.Height = 0.15
        Picture1.Visible = optShowImages
        lblThumbnailImg.Visible = optShowImages

        lblProductCode.Visible = optShowProductCode
        txtProductCode.Visible = optShowProductCode

        lblUnitRate.Visible = optShowUnitRate
        txtUnitRate.Visible = optShowUnitRate

        lblExtendedRate.Visible = optShowExtendedRate
        txtExtendedRate.Visible = optShowExtendedRate

        lblTotalSum.Visible = optShowExtendedRate

        txtTotalForProject.Visible = optShowExtendedRate
        lblCurSymbol.Visible = optShowExtendedRate


        txtRev.Text = sRevisionText

        lblTitle.Text = sHash.Item("lblTitle")
        lblPrjName.Text = sHash.Item("lblPrjName")
        lblPrjRef.Text = sHash.Item("lblPrjRef")
        lblRevNo.Text = sHash.Item("lblRevNo")
        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        lblQuantity.Text = sHash.Item("lblQuantity")
        lblUnit.Text = sHash.Item("lblSetPrice")
        lblCurSymbol.Text = sHash.Item("lblCurSymbol")
        lblDate.Text = sHash.Item("lblDate")
        lblThumbnailImg.Text = sHash.Item("lblThumbnailImg")
        lblProductCode.Text = sHash.Item("lblProductCode")
        lblProductDesc.Text = sHash.Item("lblProductDesc")
        lblUnit.Text = sHash.Item("lblUnit")
        lblUnitRate.Text = sHash.Item("lblUnitRate")
        lblExtendedRate.Text = sHash.Item("lblExtendedRate")
        lblTotalSum.Text = sHash.Item("lblTotalSum")
        txtFooter.Text = sHash.Item("txtFooter")

        If ISO.Equals("EN") Then
            txtDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            txtDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            txtDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If

        If ISO.Equals("BE") Then
            txtProjectOwner.DataField = "SpecConsult"
            txtContactNumber.DataField = "SpecConNumber"
            txtEmail.DataField = "SpecConEmail"
        End If


    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format


    End Sub
End Class

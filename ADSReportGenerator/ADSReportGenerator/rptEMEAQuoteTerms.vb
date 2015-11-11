Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports




Public Class rptEMEAQuoteTerms
    Private iDoorQty As Integer
    Public totDoorList As String = ""
    'Private dTotalListPrice As Double
    'Private dTotalExtended As Double
    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public sRevisionText As String
    Public sReportTitle As String
    Public sHash As Hashtable
    Public ISO As String
    Public sReportVariant As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format




        'Dim str1 As String = txtUnits.Value.ToString.Replace("$", "")
        'str1 = str1.Replace(",", "")
        'dGrandTotalList += Val(str1)

        'str1 = txtExtended.Value.ToString.Replace("$", "")
        'str1 = str1.Replace(",", "")
        'dGrandTotalExtended += Val(str1)

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

    Private Sub PageFooter1_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.BeforePrint
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        'lblDateTime.Text = Now
        'lblPageNumber.Text = "Page " & txtPageNumber.Text & " of " & txtPageCount.Text
    End Sub

    Private Sub rptHWEstimate_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        ' lblCurSymbol2.Visible = optShowExtendedRate


        lblTitle.Text = sHash.Item("lblTitle")
        lblPrjName.Text = sHash.Item("lblPrjName")
        lblPrjRef.Text = sHash.Item("lblPrjRef")
        lblRev.Text = sHash.Item("lblRev")
        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        lblAddDet.Text = sHash.Item("lblAddDet")
        lblGenCon.Text = sHash.Item("lblGenCon")

        Select sReportVariant
            Case "QUOTETERMS"
                lblGenRem.Text = sHash.Item("lblGenRem")
                txtGenRem.Text = sHash.Item("txtGenRem")
                txtGenRem.Visible = True
                DrawingsUsedValue.Visible = False
            Case "QUOTETERMSDOORS"
                lblGenRem.Text = sHash.Item("lblDrawingsUsed")
                txtGenRem.Visible = False
                DrawingsUsedValue.Visible = True
        End Select

        lblTechNote.Text = sHash.Item("lblTechNote")

        txtFooter.Text = sHash.Item("txtFooter")
        txtAddDet.Text = sHash.Item("txtAddDet")
        txtGenCon.Text = sHash.Item("txtGenCon")
        txtTechNote.Text = sHash.Item("txtTechNote")

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
        ElseIf ISO.Equals("AU") Then
            txtDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            txtDate.OutputFormat = "MM.dd.yyyy"
            imgLogoEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If


        If ISO.Equals("BE") Then
            txtProjectOwner.DataField = "SpecConsult"
            txtContactNumber.DataField = "SpecConNumber"
            txtEmail.DataField = "SpecConEmail"
        End If

    End Sub

End Class

Imports GrapeCity.ActiveReports.Document

Imports GrapeCity.ActiveReports.Document.Section

Imports GrapeCity.ActiveReports.SectionReportModel

Imports GrapeCity.ActiveReports.Controls

Imports GrapeCity.ActiveReports
Imports System.Drawing


Public Class rptEMEAQuoteTermsDoors
    Private iDoorQty As Integer
    Public totDoorList As String = ""

    Private dGrandTotalList As Double
    Private dGrandTotalExtended As Double
    Private IsListFinished As Boolean = True
    Public sRevisionText As String
    Public sReportTitle As String
    Public sHash As Hashtable
    Public ISO As String
    Public sReportVariant As String
    Private sSpaces As String = "          "

    Private Sub rpt_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        lblTitle.Text = sHash.Item("lblTitle")
        lblPrjName.Text = sHash.Item("lblPrjName")
        lblPrjRef.Text = sHash.Item("lblPrjRef")
        lblRev.Text = sHash.Item("lblRevNo")
        lblPrjOwner.Text = sHash.Item("lblPrjOwner")
        lblOf.Text = sHash.Item("lblOf")
        lblPage.Text = sHash.Item("lblPage")
        lblDate.Text = sHash.Item("lblDate")
        lblContactNo.Text = sHash.Item("lblContactNo")
        lblEmail.Text = sHash.Item("lblEmail")

        Revision.Text = sRevisionText

        lblGeneralConditions.Text = sHash.Item("lblGenCon")
        lblTechnicalNotes.Text = sHash.Item("lblTechNote")
        lblSpecificationSummary.Text = sHash.Item("lblSpecificationSummary")
        lblAdditionalDetails.Text = sHash.Item("lblAddDet")
        lblRevisionNotes.Text = sHash.Item("lblRevisionNotes")
        lblDrawingsUsed.Text = sHash.Item("lblDrawingsUsed")

        GeneralConditions.Text = sHash.Item("txtGeneralConditions")
        TechnicalNotes.Text = sHash.Item("txtTechnicalNotes")
        SpecificationSummary.Text = sHash.Item("txtSpecificationSummary")
        AdditionalDetails.Text = vbTab
        DrawingsUsed.Text = vbTab

        Footer.Text = sHash.Item("txtFooter")

        If ISO.Equals("EN") Then
            TodaysDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("NO") Then
            TodaysDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("EN")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("BE") Then
            TodaysDate.OutputFormat = "dd.MM.yyyy"
            imgLogoEN.Visible = ISO.Equals("BE")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("AU") Then
            TodaysDate.DataField = "TodaysDateEN"
            imgLogoEN.Visible = ISO.Equals("AU")
            imgLogoNO.Visible = ISO.Equals("NO")
        ElseIf ISO.Equals("US") Then
            TodaysDate.OutputFormat = "MM.dd.yyyy"
            imgLogoEN.Visible = ISO.Equals("US")
            imgLogoNO.Visible = ISO.Equals("NO")
        End If


        If ISO.Equals("BE") Then
            ProjectOwner.DataField = "SpecConsult"
            ContactNumber.DataField = "SpecConNumber"
            Email.DataField = "SpecConEmail"
        End If

    End Sub

End Class

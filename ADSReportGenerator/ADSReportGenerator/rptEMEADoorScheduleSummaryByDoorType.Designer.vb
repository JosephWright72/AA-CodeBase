<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEMEADoorScheduleSummaryByDoorType
    Inherits GrapeCity.ActiveReports.SectionReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEMEADoorScheduleSummaryByDoorType))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.RevisionValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRev = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblProjectRef = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ProjectNameValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ProjectRefValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblProjectOwner = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ProjectOwnerValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblProjectName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.DateValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.CurrentPageNumber = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.lblOf = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblArchDoorType = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblMaterial = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblConfiguration = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFireRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblAcousticRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblUnitRate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorTypeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblDoorType = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.imgLogoNO = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.imgLogoEN = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.UnitRateValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ArchDoorTypeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.MaterialValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ConfigurationValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.QtyValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FireRatingValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.AcousticRatingValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Footer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.NotesValue = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TotalDoorsValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTotalSum = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TotalSumValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTotDoors = New GrapeCity.ActiveReports.SectionReportModel.Label()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RevisionValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProjectRef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectNameValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectRefValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProjectOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectOwnerValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblArchDoorType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblConfiguration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFireRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAcousticRating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblUnitRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorTypeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitRateValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArchDoorTypeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfigurationValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FireRatingValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcousticRatingValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotesValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalDoorsValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotalSum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSumValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotDoors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportName, Me.RevisionValue, Me.lblRev, Me.lblProjectRef, Me.ProjectNameValue, Me.ProjectRefValue, Me.lblProjectOwner, Me.ProjectOwnerValue, Me.lblProjectName, Me.lblDate, Me.DateValue, Me.lblPage, Me.CurrentPageNumber, Me.lblOf, Me.PageCount, Me.Line, Me.lblArchDoorType, Me.lblMaterial, Me.lblConfiguration, Me.lblQuantity, Me.lblFireRating, Me.lblAcousticRating, Me.lblUnitRate, Me.DoorTypeValue, Me.lblDoorType, Me.imgLogoNO, Me.imgLogoEN})
        Me.PageHeader.Height = 2.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblReportName
        '
        Me.lblReportName.Height = 0.2!
        Me.lblReportName.HyperLink = Nothing
        Me.lblReportName.Left = 0.0!
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Style = "font-size: 12pt; font-weight: bold; text-align: left; text-decoration: none; vert" & _
    "ical-align: middle; ddo-char-set: 1"
        Me.lblReportName.Text = "lblReportName"
        Me.lblReportName.Top = 0.0!
        Me.lblReportName.Width = 6.0!
        '
        'RevisionValue
        '
        Me.RevisionValue.DataField = "Revision"
        Me.RevisionValue.Height = 0.2!
        Me.RevisionValue.Left = 2.0!
        Me.RevisionValue.Name = "RevisionValue"
        Me.RevisionValue.Style = "font-size: 10pt; text-align: left; ddo-char-set: 1"
        Me.RevisionValue.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Max
        Me.RevisionValue.Text = "Revision"
        Me.RevisionValue.Top = 1.4!
        Me.RevisionValue.Width = 2.0!
        '
        'lblRev
        '
        Me.lblRev.Height = 0.2!
        Me.lblRev.HyperLink = Nothing
        Me.lblRev.Left = 0.0!
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Style = "text-align: left"
        Me.lblRev.Text = "lblRev"
        Me.lblRev.Top = 1.4!
        Me.lblRev.Width = 1.75!
        '
        'lblProjectRef
        '
        Me.lblProjectRef.Height = 0.2!
        Me.lblProjectRef.HyperLink = Nothing
        Me.lblProjectRef.Left = 0.0!
        Me.lblProjectRef.Name = "lblProjectRef"
        Me.lblProjectRef.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblProjectRef.Text = "lblProjectRef"
        Me.lblProjectRef.Top = 1.2!
        Me.lblProjectRef.Width = 1.75!
        '
        'ProjectNameValue
        '
        Me.ProjectNameValue.DataField = "ProjectName"
        Me.ProjectNameValue.Height = 0.2!
        Me.ProjectNameValue.Left = 2.0!
        Me.ProjectNameValue.Name = "ProjectNameValue"
        Me.ProjectNameValue.Style = "text-align: left; vertical-align: middle"
        Me.ProjectNameValue.Text = "ProjectName"
        Me.ProjectNameValue.Top = 1.0!
        Me.ProjectNameValue.Width = 2.0!
        '
        'ProjectRefValue
        '
        Me.ProjectRefValue.DataField = "ProjectReference"
        Me.ProjectRefValue.Height = 0.2!
        Me.ProjectRefValue.Left = 2.0!
        Me.ProjectRefValue.Name = "ProjectRefValue"
        Me.ProjectRefValue.Style = "text-align: left; vertical-align: middle"
        Me.ProjectRefValue.Text = "Project Ref"
        Me.ProjectRefValue.Top = 1.2!
        Me.ProjectRefValue.Width = 2.0!
        '
        'lblProjectOwner
        '
        Me.lblProjectOwner.Height = 0.2!
        Me.lblProjectOwner.HyperLink = Nothing
        Me.lblProjectOwner.Left = 4.25!
        Me.lblProjectOwner.Name = "lblProjectOwner"
        Me.lblProjectOwner.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblProjectOwner.Text = "lblProjectOwner"
        Me.lblProjectOwner.Top = 1.0!
        Me.lblProjectOwner.Width = 1.5!
        '
        'ProjectOwnerValue
        '
        Me.ProjectOwnerValue.DataField = "ProjectOwner"
        Me.ProjectOwnerValue.Height = 0.2!
        Me.ProjectOwnerValue.Left = 6.0!
        Me.ProjectOwnerValue.Name = "ProjectOwnerValue"
        Me.ProjectOwnerValue.Style = "text-align: left; vertical-align: middle"
        Me.ProjectOwnerValue.Text = "ProjectOwner"
        Me.ProjectOwnerValue.Top = 1.0!
        Me.ProjectOwnerValue.Width = 2.0!
        '
        'lblProjectName
        '
        Me.lblProjectName.Height = 0.2!
        Me.lblProjectName.HyperLink = Nothing
        Me.lblProjectName.Left = 0.0!
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblProjectName.Text = "lblProjectName"
        Me.lblProjectName.Top = 1.0!
        Me.lblProjectName.Width = 1.75!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 4.25!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblDate.Text = "lblDate"
        Me.lblDate.Top = 1.2!
        Me.lblDate.Width = 1.5!
        '
        'DateValue
        '
        Me.DateValue.DataField = "TodaysDate"
        Me.DateValue.Height = 0.2!
        Me.DateValue.Left = 6.0!
        Me.DateValue.Name = "DateValue"
        Me.DateValue.Style = "text-align: left; vertical-align: middle"
        Me.DateValue.Text = "TodaysDate"
        Me.DateValue.Top = 1.2!
        Me.DateValue.Width = 2.0!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 4.25!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve" & _
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblPage.Text = "lblPage"
        Me.lblPage.Top = 1.4!
        Me.lblPage.Width = 1.5!
        '
        'CurrentPageNumber
        '
        Me.CurrentPageNumber.FormatString = "{PageNumber}"
        Me.CurrentPageNumber.Height = 0.2!
        Me.CurrentPageNumber.Left = 6.0!
        Me.CurrentPageNumber.MultiLine = False
        Me.CurrentPageNumber.Name = "CurrentPageNumber"
        Me.CurrentPageNumber.Style = "font-size: 10pt; text-align: justify; ddo-char-set: 1"
        Me.CurrentPageNumber.Top = 1.4!
        Me.CurrentPageNumber.Width = 0.2!
        '
        'lblOf
        '
        Me.lblOf.Height = 0.2!
        Me.lblOf.Left = 6.2!
        Me.lblOf.MultiLine = False
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Style = "font-size: 10pt; text-align: center; ddo-char-set: 1"
        Me.lblOf.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Max
        Me.lblOf.Text = "of"
        Me.lblOf.Top = 1.4!
        Me.lblOf.Width = 0.25!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.2!
        Me.PageCount.Left = 6.45!
        Me.PageCount.MultiLine = False
        Me.PageCount.Name = "PageCount"
        Me.PageCount.OutputFormat = resources.GetString("PageCount.OutputFormat")
        Me.PageCount.Style = "font-size: 10pt; text-align: left; ddo-char-set: 1"
        Me.PageCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Min
        Me.PageCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.PageCount.Text = "PageTotal"
        Me.PageCount.Top = 1.4!
        Me.PageCount.Width = 0.4!
        '
        'Line
        '
        Me.Line.Height = 0.0!
        Me.Line.Left = 0.0!
        Me.Line.LineWeight = 2.0!
        Me.Line.Name = "Line"
        Me.Line.Top = 1.7!
        Me.Line.Width = 10.0!
        Me.Line.X1 = 10.0!
        Me.Line.X2 = 0.0!
        Me.Line.Y1 = 1.7!
        Me.Line.Y2 = 1.7!
        '
        'lblArchDoorType
        '
        Me.lblArchDoorType.Height = 0.2!
        Me.lblArchDoorType.Left = 0.0!
        Me.lblArchDoorType.Name = "lblArchDoorType"
        Me.lblArchDoorType.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical" & _
    "-align: middle; ddo-char-set: 1"
        Me.lblArchDoorType.Text = "lblArchDoorType"
        Me.lblArchDoorType.Top = 1.8!
        Me.lblArchDoorType.Width = 1.5!
        '
        'lblMaterial
        '
        Me.lblMaterial.Height = 0.2!
        Me.lblMaterial.Left = 1.5!
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical" & _
    "-align: middle; ddo-char-set: 1"
        Me.lblMaterial.Text = "lblMaterial"
        Me.lblMaterial.Top = 1.8!
        Me.lblMaterial.Width = 1.5!
        '
        'lblConfiguration
        '
        Me.lblConfiguration.Height = 0.2!
        Me.lblConfiguration.Left = 3.0!
        Me.lblConfiguration.Name = "lblConfiguration"
        Me.lblConfiguration.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical" & _
    "-align: middle; ddo-char-set: 1"
        Me.lblConfiguration.Text = "lblConfiguration"
        Me.lblConfiguration.Top = 1.8!
        Me.lblConfiguration.Width = 1.5!
        '
        'lblQuantity
        '
        Me.lblQuantity.Height = 0.2!
        Me.lblQuantity.Left = 4.5!
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: center; vertic" & _
    "al-align: middle; ddo-char-set: 1"
        Me.lblQuantity.Text = "lblQuantity"
        Me.lblQuantity.Top = 1.8!
        Me.lblQuantity.Width = 0.5!
        '
        'lblFireRating
        '
        Me.lblFireRating.Height = 0.2!
        Me.lblFireRating.Left = 5.0!
        Me.lblFireRating.Name = "lblFireRating"
        Me.lblFireRating.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: center; vertic" & _
    "al-align: middle; ddo-char-set: 1"
        Me.lblFireRating.Text = "lblFireRating"
        Me.lblFireRating.Top = 1.8!
        Me.lblFireRating.Width = 1.0!
        '
        'lblAcousticRating
        '
        Me.lblAcousticRating.Height = 0.2!
        Me.lblAcousticRating.Left = 6.0!
        Me.lblAcousticRating.Name = "lblAcousticRating"
        Me.lblAcousticRating.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: center; vertic" & _
    "al-align: middle; ddo-char-set: 1"
        Me.lblAcousticRating.Text = "lblAcousticRating"
        Me.lblAcousticRating.Top = 1.8!
        Me.lblAcousticRating.Width = 1.0!
        '
        'lblUnitRate
        '
        Me.lblUnitRate.Height = 0.2!
        Me.lblUnitRate.Left = 7.0!
        Me.lblUnitRate.Name = "lblUnitRate"
        Me.lblUnitRate.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: right; vertica" & _
    "l-align: middle; ddo-char-set: 1"
        Me.lblUnitRate.Text = "lblUnitRate"
        Me.lblUnitRate.Top = 1.8!
        Me.lblUnitRate.Width = 0.75!
        '
        'DoorTypeValue
        '
        Me.DoorTypeValue.DataField = "DoorElevation"
        Me.DoorTypeValue.Height = 0.2!
        Me.DoorTypeValue.Left = 6.0!
        Me.DoorTypeValue.Name = "DoorTypeValue"
        Me.DoorTypeValue.Style = "font-weight: bold; text-align: left; vertical-align: middle; ddo-char-set: 1"
        Me.DoorTypeValue.Text = "Door Type"
        Me.DoorTypeValue.Top = 0.8!
        Me.DoorTypeValue.Width = 2.0!
        '
        'lblDoorType
        '
        Me.lblDoorType.Height = 0.2!
        Me.lblDoorType.HyperLink = Nothing
        Me.lblDoorType.Left = 4.25!
        Me.lblDoorType.Name = "lblDoorType"
        Me.lblDoorType.Style = "font-size: 10pt; font-weight: bold; text-align: left; text-decoration: none; vert" & _
    "ical-align: middle; ddo-char-set: 1"
        Me.lblDoorType.Text = "lblDoorType"
        Me.lblDoorType.Top = 0.8!
        Me.lblDoorType.Width = 1.5!
        '
        'imgLogoNO
        '
        Me.imgLogoNO.Height = 0.56!
        Me.imgLogoNO.HyperLink = Nothing
        Me.imgLogoNO.ImageData = CType(resources.GetObject("imgLogoNO.ImageData"), System.IO.Stream)
        Me.imgLogoNO.Left = 6.6!
        Me.imgLogoNO.Name = "imgLogoNO"
        Me.imgLogoNO.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoNO.Top = 0.0!
        Me.imgLogoNO.Width = 1.35!
        '
        'imgLogoEN
        '
        Me.imgLogoEN.Height = 0.32!
        Me.imgLogoEN.HyperLink = Nothing
        Me.imgLogoEN.ImageData = CType(resources.GetObject("imgLogoEN.ImageData"), System.IO.Stream)
        Me.imgLogoEN.Left = 6.2!
        Me.imgLogoEN.Name = "imgLogoEN"
        Me.imgLogoEN.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoEN.Top = 0.0!
        Me.imgLogoEN.Width = 1.8!
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.UnitRateValue, Me.ArchDoorTypeValue, Me.MaterialValue, Me.ConfigurationValue, Me.QtyValue, Me.FireRatingValue, Me.AcousticRatingValue})
        Me.Detail.Height = 0.2!
        Me.Detail.Name = "Detail"
        '
        'UnitRateValue
        '
        Me.UnitRateValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.UnitRateValue.DataField = "UnitRate"
        Me.UnitRateValue.Height = 0.2!
        Me.UnitRateValue.Left = 7.0!
        Me.UnitRateValue.Name = "UnitRateValue"
        Me.UnitRateValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": right; vertical-align: middle; ddo-char-set: 1"
        Me.UnitRateValue.Text = "Unit Rate"
        Me.UnitRateValue.Top = 0.0!
        Me.UnitRateValue.Width = 0.75!
        '
        'ArchDoorTypeValue
        '
        Me.ArchDoorTypeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ArchDoorTypeValue.DataField = "ArchDoorType"
        Me.ArchDoorTypeValue.Height = 0.2!
        Me.ArchDoorTypeValue.Left = 0.0!
        Me.ArchDoorTypeValue.Name = "ArchDoorTypeValue"
        Me.ArchDoorTypeValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": left; vertical-align: middle; ddo-char-set: 1"
        Me.ArchDoorTypeValue.Text = "Arch Door Type"
        Me.ArchDoorTypeValue.Top = 0.0!
        Me.ArchDoorTypeValue.Width = 1.5!
        '
        'MaterialValue
        '
        Me.MaterialValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.MaterialValue.DataField = "DoorMaterial"
        Me.MaterialValue.Height = 0.2!
        Me.MaterialValue.Left = 1.5!
        Me.MaterialValue.Name = "MaterialValue"
        Me.MaterialValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": left; vertical-align: middle; ddo-char-set: 1"
        Me.MaterialValue.Text = "Material"
        Me.MaterialValue.Top = 0.0!
        Me.MaterialValue.Width = 1.5!
        '
        'ConfigurationValue
        '
        Me.ConfigurationValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ConfigurationValue.DataField = "Leaf"
        Me.ConfigurationValue.Height = 0.2!
        Me.ConfigurationValue.Left = 3.0!
        Me.ConfigurationValue.Name = "ConfigurationValue"
        Me.ConfigurationValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": left; vertical-align: middle; ddo-char-set: 1"
        Me.ConfigurationValue.Text = "Configuration"
        Me.ConfigurationValue.Top = 0.0!
        Me.ConfigurationValue.Width = 1.5!
        '
        'QtyValue
        '
        Me.QtyValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.QtyValue.DataField = "Qty"
        Me.QtyValue.Height = 0.2!
        Me.QtyValue.Left = 4.5!
        Me.QtyValue.Name = "QtyValue"
        Me.QtyValue.Style = "color: Black; font-size: 9pt; font-weight: normal; text-align: center; ddo-char-s" & _
    "et: 1"
        Me.QtyValue.Text = "Qty"
        Me.QtyValue.Top = 0.0!
        Me.QtyValue.Width = 0.5!
        '
        'FireRatingValue
        '
        Me.FireRatingValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FireRatingValue.DataField = "FireRating"
        Me.FireRatingValue.Height = 0.2!
        Me.FireRatingValue.Left = 5.0!
        Me.FireRatingValue.Name = "FireRatingValue"
        Me.FireRatingValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.FireRatingValue.Text = "Fire Rating"
        Me.FireRatingValue.Top = 0.0!
        Me.FireRatingValue.Width = 1.0!
        '
        'AcousticRatingValue
        '
        Me.AcousticRatingValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.AcousticRatingValue.DataField = "AcousticRating"
        Me.AcousticRatingValue.Height = 0.2!
        Me.AcousticRatingValue.Left = 6.0!
        Me.AcousticRatingValue.Name = "AcousticRatingValue"
        Me.AcousticRatingValue.Style = "color: Black; font-family: Arial; font-size: 9pt; font-weight: normal; text-align" & _
    ": center; vertical-align: middle; ddo-char-set: 1"
        Me.AcousticRatingValue.Text = "Acoustic Rating"
        Me.AcousticRatingValue.Top = 0.0!
        Me.AcousticRatingValue.Width = 1.0!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Footer})
        Me.PageFooter.Height = 0.62!
        Me.PageFooter.Name = "PageFooter"
        '
        'Footer
        '
        Me.Footer.DataField = "DocOwner"
        Me.Footer.Height = 0.62!
        Me.Footer.Left = 0.0!
        Me.Footer.Name = "Footer"
        Me.Footer.OutputFormat = resources.GetString("Footer.OutputFormat")
        Me.Footer.Style = "color: DimGray; font-size: 6.5pt; text-align: center; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.Footer.Text = "Footer Text"
        Me.Footer.Top = 0.0!
        Me.Footer.Width = 10.0!
        '
        'GroupHeader
        '
        Me.GroupHeader.ColumnGroupKeepTogether = True
        Me.GroupHeader.DataField = "DoorElevation"
        Me.GroupHeader.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader.Height = 0.0!
        Me.GroupHeader.KeepTogether = True
        Me.GroupHeader.Name = "GroupHeader"
        Me.GroupHeader.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
        '
        'GroupFooter
        '
        Me.GroupFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.NotesValue, Me.TotalDoorsValue, Me.lblTotalSum, Me.TotalSumValue, Me.lblTotDoors})
        Me.GroupFooter.Height = 1.4!
        Me.GroupFooter.KeepTogether = True
        Me.GroupFooter.Name = "GroupFooter"
        '
        'NotesValue
        '
        Me.NotesValue.Height = 1.0!
        Me.NotesValue.HyperLink = Nothing
        Me.NotesValue.Left = 0.0!
        Me.NotesValue.Name = "NotesValue"
        Me.NotesValue.Style = "font-style: italic; ddo-char-set: 1"
        Me.NotesValue.Text = "Optional free text field to allow for set specific remarks to be added as necessa" & _
    "ry/desired"
        Me.NotesValue.Top = 0.4!
        Me.NotesValue.Width = 8.0!
        '
        'TotalDoorsValue
        '
        Me.TotalDoorsValue.DataField = "Qty"
        Me.TotalDoorsValue.Height = 0.2!
        Me.TotalDoorsValue.Left = 4.5!
        Me.TotalDoorsValue.Name = "TotalDoorsValue"
        Me.TotalDoorsValue.OutputFormat = resources.GetString("TotalDoorsValue.OutputFormat")
        Me.TotalDoorsValue.Style = "color: Black; font-weight: bold; text-align: center; vertical-align: middle; ddo-" & _
    "char-set: 1"
        Me.TotalDoorsValue.SummaryGroup = "GroupHeader"
        Me.TotalDoorsValue.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TotalDoorsValue.Text = Nothing
        Me.TotalDoorsValue.Top = 0.0!
        Me.TotalDoorsValue.Width = 0.5!
        '
        'lblTotalSum
        '
        Me.lblTotalSum.Height = 0.2!
        Me.lblTotalSum.HyperLink = Nothing
        Me.lblTotalSum.Left = 5.75!
        Me.lblTotalSum.Name = "lblTotalSum"
        Me.lblTotalSum.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.lblTotalSum.Text = "lblTotalSum"
        Me.lblTotalSum.Top = 0.0!
        Me.lblTotalSum.Width = 1.25!
        '
        'TotalSumValue
        '
        Me.TotalSumValue.DataField = "UnitRate"
        Me.TotalSumValue.Height = 0.2!
        Me.TotalSumValue.Left = 7.0!
        Me.TotalSumValue.Name = "TotalSumValue"
        Me.TotalSumValue.OutputFormat = resources.GetString("TotalSumValue.OutputFormat")
        Me.TotalSumValue.Style = "color: Black; font-weight: bold; text-align: center; vertical-align: middle; ddo-" & _
    "char-set: 1"
        Me.TotalSumValue.SummaryGroup = "GroupHeader"
        Me.TotalSumValue.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TotalSumValue.Text = Nothing
        Me.TotalSumValue.Top = 0.0!
        Me.TotalSumValue.Width = 0.75!
        '
        'lblTotDoors
        '
        Me.lblTotDoors.Height = 0.2!
        Me.lblTotDoors.HyperLink = Nothing
        Me.lblTotDoors.Left = 2.5!
        Me.lblTotDoors.Name = "lblTotDoors"
        Me.lblTotDoors.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.lblTotDoors.Text = "lblTotDoors"
        Me.lblTotDoors.Top = 0.0!
        Me.lblTotDoors.Width = 2.0!
        '
        'rptEMEADoorScheduleSummaryByDoorType
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 8.0!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RevisionValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProjectRef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectNameValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectRefValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProjectOwner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectOwnerValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblArchDoorType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblConfiguration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFireRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAcousticRating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblUnitRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoorTypeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitRateValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArchDoorTypeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfigurationValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FireRatingValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcousticRatingValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotesValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalDoorsValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotalSum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSumValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotDoors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents lblReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents RevisionValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblRev As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblProjectRef As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ProjectNameValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ProjectRefValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblProjectOwner As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents ProjectOwnerValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblProjectName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents DateValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents CurrentPageNumber As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblOf As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblArchDoorType As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblMaterial As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblConfiguration As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFireRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblAcousticRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblUnitRate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents UnitRateValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ArchDoorTypeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents MaterialValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ConfigurationValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents QtyValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FireRatingValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents AcousticRatingValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Footer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents DoorTypeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblDoorType As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents NotesValue As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TotalDoorsValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTotalSum As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TotalSumValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTotDoors As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents imgLogoNO As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents imgLogoEN As GrapeCity.ActiveReports.SectionReportModel.Picture
End Class

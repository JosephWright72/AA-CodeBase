<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEMEADoorScheduleSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEMEADoorScheduleSummary))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.imgLogoEN = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.imgLogoNO = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.txtRev = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblRevNo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPrjRef = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProjectName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPrjRef = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPrjOwner = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProjectOwner = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPrjName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDate = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPage = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.CurrentPageNumber = New GrapeCity.ActiveReports.SectionReportModel.ReportInfo()
        Me.lblOf = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.lblFromRoom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblDoorRef = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblToRoom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblMaterial = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblConfiguration = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFireRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblAcousticRating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFrameWidth = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFrameHeight = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblFrameDepth = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblUnitRate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.UnitRateValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorRefValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ToRoomValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FromRoomValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.MaterialValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ConfigurationValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.QtyValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FireRatingValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.AcousticRatingValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameWidthValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameHeightValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepthValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblCurSymbol = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Footer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTotalSum = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TotalSumValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblCurSymbolTotal = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblTotDoors = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TotalDoorsValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.RemarksTopLine = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.RemarksRightLine = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.RemarksBottomLine = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.RemarksLeftLine = New GrapeCity.ActiveReports.SectionReportModel.Line()
        CType(Me.lblReportName,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgLogoEN,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgLogoNO,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtRev,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblRevNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPrjRef,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtProjectName,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtPrjRef,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPrjOwner,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtProjectOwner,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPrjName,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtDate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblPage,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CurrentPageNumber,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblOf,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PageCount,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFromRoom,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblDoorRef,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblToRoom,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblMaterial,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblConfiguration,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblQuantity,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFireRating,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblAcousticRating,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrameWidth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrameHeight,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblFrameDepth,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblUnitRate,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UnitRateValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DoorRefValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ToRoomValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FromRoomValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MaterialValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConfigurationValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QtyValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FireRatingValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.AcousticRatingValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FrameWidthValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FrameHeightValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FrameDepthValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCurSymbol,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Footer,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTotalSum,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TotalSumValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblCurSymbolTotal,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lblTotDoors,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TotalDoorsValue,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportName, Me.imgLogoEN, Me.imgLogoNO, Me.txtRev, Me.lblRevNo, Me.lblPrjRef, Me.txtProjectName, Me.txtPrjRef, Me.lblPrjOwner, Me.txtProjectOwner, Me.lblPrjName, Me.lblDate, Me.txtDate, Me.lblPage, Me.CurrentPageNumber, Me.lblOf, Me.PageCount, Me.Line1, Me.lblFromRoom, Me.lblDoorRef, Me.lblToRoom, Me.lblMaterial, Me.lblConfiguration, Me.lblQuantity, Me.lblFireRating, Me.lblAcousticRating, Me.lblFrameWidth, Me.lblFrameHeight, Me.lblFrameDepth, Me.lblUnitRate})
        Me.PageHeader.Height = 1.9!
        Me.PageHeader.Name = "PageHeader"
        '
        'lblReportName
        '
        Me.lblReportName.Height = 0.2!
        Me.lblReportName.HyperLink = Nothing
        Me.lblReportName.Left = 0!
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Style = "font-size: 12pt; font-weight: bold; text-align: left; text-decoration: none; vert"& _ 
    "ical-align: middle; ddo-char-set: 1"
        Me.lblReportName.Text = "ReportName"
        Me.lblReportName.Top = 0!
        Me.lblReportName.Width = 3!
        '
        'imgLogoEN
        '
        Me.imgLogoEN.Height = 0.32!
        Me.imgLogoEN.HyperLink = Nothing
        Me.imgLogoEN.ImageData = CType(resources.GetObject("imgLogoEN.ImageData"),System.IO.Stream)
        Me.imgLogoEN.Left = 6.35!
        Me.imgLogoEN.Name = "imgLogoEN"
        Me.imgLogoEN.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoEN.Top = 0!
        Me.imgLogoEN.Width = 1.8!
        '
        'imgLogoNO
        '
        Me.imgLogoNO.Height = 0.56!
        Me.imgLogoNO.HyperLink = Nothing
        Me.imgLogoNO.ImageData = CType(resources.GetObject("imgLogoNO.ImageData"),System.IO.Stream)
        Me.imgLogoNO.Left = 6.98!
        Me.imgLogoNO.Name = "imgLogoNO"
        Me.imgLogoNO.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoNO.Top = 0!
        Me.imgLogoNO.Width = 1.2!
        '
        'txtRev
        '
        Me.txtRev.Height = 0.2!
        Me.txtRev.Left = 1.2!
        Me.txtRev.Name = "txtRev"
        Me.txtRev.Style = "font-size: 10pt; text-align: left; ddo-char-set: 1"
        Me.txtRev.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Max
        Me.txtRev.Text = "Num"
        Me.txtRev.Top = 1.2!
        Me.txtRev.Width = 2.8!
        '
        'lblRevNo
        '
        Me.lblRevNo.Height = 0.2!
        Me.lblRevNo.HyperLink = Nothing
        Me.lblRevNo.Left = 0!
        Me.lblRevNo.Name = "lblRevNo"
        Me.lblRevNo.Style = "text-align: left"
        Me.lblRevNo.Text = "Revision No."
        Me.lblRevNo.Top = 1.2!
        Me.lblRevNo.Width = 1!
        '
        'lblPrjRef
        '
        Me.lblPrjRef.Height = 0.2!
        Me.lblPrjRef.HyperLink = Nothing
        Me.lblPrjRef.Left = 0!
        Me.lblPrjRef.Name = "lblPrjRef"
        Me.lblPrjRef.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve"& _ 
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblPrjRef.Text = "Project Ref."
        Me.lblPrjRef.Top = 1!
        Me.lblPrjRef.Width = 1!
        '
        'txtProjectName
        '
        Me.txtProjectName.DataField = "ProjectName"
        Me.txtProjectName.Height = 0.2!
        Me.txtProjectName.Left = 1.2!
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Style = "text-align: left; vertical-align: middle"
        Me.txtProjectName.Text = "ProjectName"
        Me.txtProjectName.Top = 0.8!
        Me.txtProjectName.Width = 2.8!
        '
        'txtPrjRef
        '
        Me.txtPrjRef.DataField = "NewProjID"
        Me.txtPrjRef.Height = 0.2!
        Me.txtPrjRef.Left = 1.2!
        Me.txtPrjRef.Name = "txtPrjRef"
        Me.txtPrjRef.Style = "text-align: left; vertical-align: middle"
        Me.txtPrjRef.Text = "ProjRef"
        Me.txtPrjRef.Top = 1!
        Me.txtPrjRef.Width = 2.8!
        '
        'lblPrjOwner
        '
        Me.lblPrjOwner.Height = 0.2!
        Me.lblPrjOwner.HyperLink = Nothing
        Me.lblPrjOwner.Left = 4.8!
        Me.lblPrjOwner.Name = "lblPrjOwner"
        Me.lblPrjOwner.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve"& _ 
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblPrjOwner.Text = "Project Owner"
        Me.lblPrjOwner.Top = 0.8!
        Me.lblPrjOwner.Width = 1!
        '
        'txtProjectOwner
        '
        Me.txtProjectOwner.DataField = "ProjectOwner"
        Me.txtProjectOwner.Height = 0.2!
        Me.txtProjectOwner.Left = 6!
        Me.txtProjectOwner.Name = "txtProjectOwner"
        Me.txtProjectOwner.Style = "text-align: left; vertical-align: middle"
        Me.txtProjectOwner.Text = "ProjectOwner"
        Me.txtProjectOwner.Top = 0.8!
        Me.txtProjectOwner.Width = 2!
        '
        'lblPrjName
        '
        Me.lblPrjName.Height = 0.2!
        Me.lblPrjName.HyperLink = Nothing
        Me.lblPrjName.Left = 0!
        Me.lblPrjName.Name = "lblPrjName"
        Me.lblPrjName.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve"& _ 
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblPrjName.Text = "Project Name"
        Me.lblPrjName.Top = 0.8!
        Me.lblPrjName.Width = 1!
        '
        'lblDate
        '
        Me.lblDate.Height = 0.2!
        Me.lblDate.HyperLink = Nothing
        Me.lblDate.Left = 4.8!
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve"& _ 
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblDate.Text = "Date"
        Me.lblDate.Top = 1!
        Me.lblDate.Width = 1!
        '
        'txtDate
        '
        Me.txtDate.DataField = "TodaysDate"
        Me.txtDate.Height = 0.2!
        Me.txtDate.Left = 6!
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Style = "text-align: left; vertical-align: middle"
        Me.txtDate.Text = "TodaysDate"
        Me.txtDate.Top = 1!
        Me.txtDate.Width = 2!
        '
        'lblPage
        '
        Me.lblPage.Height = 0.2!
        Me.lblPage.HyperLink = Nothing
        Me.lblPage.Left = 4.8!
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Style = "font-size: 10pt; font-weight: normal; text-align: left; text-decoration: none; ve"& _ 
    "rtical-align: middle; ddo-char-set: 1"
        Me.lblPage.Text = "Page"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPage.Top = 1.2!
        Me.lblPage.Width = 0.9999995!
        '
        'CurrentPageNumber
        '
        Me.CurrentPageNumber.FormatString = "{PageNumber}"
        Me.CurrentPageNumber.Height = 0.2!
        Me.CurrentPageNumber.Left = 6!
        Me.CurrentPageNumber.MultiLine = false
        Me.CurrentPageNumber.Name = "CurrentPageNumber"
        Me.CurrentPageNumber.Style = "font-size: 10pt; text-align: justify; ddo-char-set: 1"
        Me.CurrentPageNumber.Top = 1.2!
        Me.CurrentPageNumber.Width = 0.2!
        '
        'lblOf
        '
        Me.lblOf.Height = 0.2!
        Me.lblOf.Left = 6.17!
        Me.lblOf.MultiLine = false
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Style = "font-size: 10pt; text-align: center; ddo-char-set: 1"
        Me.lblOf.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Max
        Me.lblOf.Text = "of"
        Me.lblOf.Top = 1.2!
        Me.lblOf.Width = 0.2200002!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.2!
        Me.PageCount.Left = 6.4!
        Me.PageCount.MultiLine = false
        Me.PageCount.Name = "PageCount"
        Me.PageCount.OutputFormat = resources.GetString("PageCount.OutputFormat")
        Me.PageCount.Style = "font-size: 10pt; text-align: left; ddo-char-set: 1"
        Me.PageCount.SummaryFunc = GrapeCity.ActiveReports.SectionReportModel.SummaryFunc.Min
        Me.PageCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.PageCount.Text = "PageTotal"
        Me.PageCount.Top = 1.2!
        Me.PageCount.Width = 0.46!
        '
        'Line1
        '
        Me.Line1.Height = 0!
        Me.Line1.Left = 0!
        Me.Line1.LineWeight = 2!
        Me.Line1.Name = "Line"
        Me.Line1.Top = 1.6!
        Me.Line1.Width = 8.27!
        Me.Line1.X1 = 8.27!
        Me.Line1.X2 = 0!
        Me.Line1.Y1 = 1.6!
        Me.Line1.Y2 = 1.6!
        '
        'lblFromRoom
        '
        Me.lblFromRoom.Height = 0.2!
        Me.lblFromRoom.Left = 1.25!
        Me.lblFromRoom.Name = "lblFromRoom"
        Me.lblFromRoom.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblFromRoom.Text = "From Room"
        Me.lblFromRoom.Top = 1.7!
        Me.lblFromRoom.Width = 0.75!
        '
        'lblDoorRef
        '
        Me.lblDoorRef.Height = 0.2!
        Me.lblDoorRef.Left = 4.768372E-07!
        Me.lblDoorRef.Name = "lblDoorRef"
        Me.lblDoorRef.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblDoorRef.Text = "Door Ref"
        Me.lblDoorRef.Top = 1.7!
        Me.lblDoorRef.Width = 0.5!
        '
        'lblToRoom
        '
        Me.lblToRoom.Height = 0.2!
        Me.lblToRoom.Left = 0.5!
        Me.lblToRoom.Name = "lblToRoom"
        Me.lblToRoom.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblToRoom.Text = "To Room"
        Me.lblToRoom.Top = 1.7!
        Me.lblToRoom.Width = 0.75!
        '
        'lblMaterial
        '
        Me.lblMaterial.Height = 0.2!
        Me.lblMaterial.Left = 2!
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblMaterial.Text = "Material"
        Me.lblMaterial.Top = 1.7!
        Me.lblMaterial.Width = 0.75!
        '
        'lblConfiguration
        '
        Me.lblConfiguration.Height = 0.2!
        Me.lblConfiguration.Left = 2.75!
        Me.lblConfiguration.Name = "lblConfiguration"
        Me.lblConfiguration.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblConfiguration.Text = "Configuration"
        Me.lblConfiguration.Top = 1.7!
        Me.lblConfiguration.Width = 0.9!
        '
        'lblQuantity
        '
        Me.lblQuantity.Height = 0.2!
        Me.lblQuantity.Left = 3.65!
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblQuantity.Text = "Qty"
        Me.lblQuantity.Top = 1.7!
        Me.lblQuantity.Width = 0.25!
        '
        'lblFireRating
        '
        Me.lblFireRating.Height = 0.2!
        Me.lblFireRating.Left = 3.9!
        Me.lblFireRating.Name = "lblFireRating"
        Me.lblFireRating.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblFireRating.Text = "Fire Rating"
        Me.lblFireRating.Top = 1.7!
        Me.lblFireRating.Width = 0.75!
        '
        'lblAcousticRating
        '
        Me.lblAcousticRating.Height = 0.2!
        Me.lblAcousticRating.Left = 4.65!
        Me.lblAcousticRating.Name = "lblAcousticRating"
        Me.lblAcousticRating.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblAcousticRating.Text = "Acoustic Rating"
        Me.lblAcousticRating.Top = 1.7!
        Me.lblAcousticRating.Width = 0.75!
        '
        'lblFrameWidth
        '
        Me.lblFrameWidth.Height = 0.2!
        Me.lblFrameWidth.Left = 5.4!
        Me.lblFrameWidth.Name = "lblFrameWidth"
        Me.lblFrameWidth.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblFrameWidth.Text = "Frame Width"
        Me.lblFrameWidth.Top = 1.7!
        Me.lblFrameWidth.Width = 0.75!
        '
        'lblFrameHeight
        '
        Me.lblFrameHeight.Height = 0.2!
        Me.lblFrameHeight.Left = 6.15!
        Me.lblFrameHeight.Name = "lblFrameHeight"
        Me.lblFrameHeight.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblFrameHeight.Text = "Frame Height"
        Me.lblFrameHeight.Top = 1.7!
        Me.lblFrameHeight.Width = 0.75!
        '
        'lblFrameDepth
        '
        Me.lblFrameDepth.Height = 0.2!
        Me.lblFrameDepth.Left = 6.9!
        Me.lblFrameDepth.Name = "lblFrameDepth"
        Me.lblFrameDepth.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblFrameDepth.Text = "Frame Depth"
        Me.lblFrameDepth.Top = 1.7!
        Me.lblFrameDepth.Width = 0.75!
        '
        'lblUnitRate
        '
        Me.lblUnitRate.Height = 0.2!
        Me.lblUnitRate.Left = 7.65!
        Me.lblUnitRate.Name = "lblUnitRate"
        Me.lblUnitRate.Style = "font-family: Arial; font-size: 9pt; font-weight: bold; text-align: left; vertical"& _ 
    "-align: middle; ddo-char-set: 1"
        Me.lblUnitRate.Text = "Unit Rate"
        Me.lblUnitRate.Top = 1.7!
        Me.lblUnitRate.Width = 0.6!
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.UnitRateValue, Me.DoorRefValue, Me.ToRoomValue, Me.FromRoomValue, Me.MaterialValue, Me.ConfigurationValue, Me.QtyValue, Me.FireRatingValue, Me.AcousticRatingValue, Me.FrameWidthValue, Me.FrameHeightValue, Me.FrameDepthValue, Me.lblCurSymbol})
        Me.Detail.Height = 0.2!
        Me.Detail.Name = "Detail"
        '
        'UnitRateValue
        '
        Me.UnitRateValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.UnitRateValue.DataField = "UnitRate"
        Me.UnitRateValue.Height = 0.2!
        Me.UnitRateValue.Left = 7.75!
        Me.UnitRateValue.Name = "UnitRateValue"
        Me.UnitRateValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.UnitRateValue.Text = "Unit Rate"
        Me.UnitRateValue.Top = 0!
        Me.UnitRateValue.Width = 0.5!
        '
        'DoorRefValue
        '
        Me.DoorRefValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.DoorRefValue.DataField = "Mark"
        Me.DoorRefValue.Height = 0.2!
        Me.DoorRefValue.Left = 0.0!
        Me.DoorRefValue.Name = "DoorRefValue"
        Me.DoorRefValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.DoorRefValue.Text = "Mark"
        Me.DoorRefValue.Top = 0!
        Me.DoorRefValue.Width = 0.5!
        '
        'ToRoomValue
        '
        Me.ToRoomValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ToRoomValue.DataField = "ToRoom"
        Me.ToRoomValue.Height = 0.2!
        Me.ToRoomValue.Left = 0.5!
        Me.ToRoomValue.Name = "ToRoomValue"
        Me.ToRoomValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.ToRoomValue.Text = "To Room"
        Me.ToRoomValue.Top = 0!
        Me.ToRoomValue.Width = 0.75!
        '
        'FromRoomValue
        '
        Me.FromRoomValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FromRoomValue.DataField = "FromRoom"
        Me.FromRoomValue.Height = 0.2!
        Me.FromRoomValue.Left = 1.25!
        Me.FromRoomValue.Name = "FromRoomValue"
        Me.FromRoomValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.FromRoomValue.Text = "From Room"
        Me.FromRoomValue.Top = 0!
        Me.FromRoomValue.Width = 0.75!
        '
        'MaterialValue
        '
        Me.MaterialValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.MaterialValue.DataField = "DoorMaterial"
        Me.MaterialValue.Height = 0.2!
        Me.MaterialValue.Left = 2!
        Me.MaterialValue.Name = "MaterialValue"
        Me.MaterialValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.MaterialValue.Text = "Material"
        Me.MaterialValue.Top = 0!
        Me.MaterialValue.Width = 0.75!
        '
        'ConfigurationValue
        '
        Me.ConfigurationValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ConfigurationValue.DataField = "Leaf"
        Me.ConfigurationValue.Height = 0.2!
        Me.ConfigurationValue.Left = 2.75!
        Me.ConfigurationValue.Name = "ConfigurationValue"
        Me.ConfigurationValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.ConfigurationValue.Text = "Configuration"
        Me.ConfigurationValue.Top = 0!
        Me.ConfigurationValue.Width = 0.9!
        '
        'QtyValue
        '
        Me.QtyValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.QtyValue.DataField = "Qty"
        Me.QtyValue.Height = 0.2!
        Me.QtyValue.Left = 3.65!
        Me.QtyValue.Name = "QtyValue"
        Me.QtyValue.Style = "color: Blue; font-size: 9pt; font-weight: normal; text-align: left; ddo-char-set:"& _ 
    " 1"
        Me.QtyValue.Text = "Qty"
        Me.QtyValue.Top = 0!
        Me.QtyValue.Width = 0.25!
        '
        'FireRatingValue
        '
        Me.FireRatingValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FireRatingValue.DataField = "FireRating"
        Me.FireRatingValue.Height = 0.2!
        Me.FireRatingValue.Left = 3.9!
        Me.FireRatingValue.Name = "FireRatingValue"
        Me.FireRatingValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.FireRatingValue.Text = "Fire Rating"
        Me.FireRatingValue.Top = 0!
        Me.FireRatingValue.Width = 0.75!
        '
        'AcousticRatingValue
        '
        Me.AcousticRatingValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.AcousticRatingValue.DataField = "AcousticRating"
        Me.AcousticRatingValue.Height = 0.2!
        Me.AcousticRatingValue.Left = 4.65!
        Me.AcousticRatingValue.Name = "AcousticRatingValue"
        Me.AcousticRatingValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.AcousticRatingValue.Text = "Acoustic Rating"
        Me.AcousticRatingValue.Top = 0!
        Me.AcousticRatingValue.Width = 0.75!
        '
        'FrameWidthValue
        '
        Me.FrameWidthValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FrameWidthValue.DataField = "FrameWidth"
        Me.FrameWidthValue.Height = 0.2!
        Me.FrameWidthValue.Left = 5.4!
        Me.FrameWidthValue.Name = "FrameWidthValue"
        Me.FrameWidthValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.FrameWidthValue.Text = "Frame Width"
        Me.FrameWidthValue.Top = 0!
        Me.FrameWidthValue.Width = 0.75!
        '
        'FrameHeightValue
        '
        Me.FrameHeightValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FrameHeightValue.DataField = "FrameHeight"
        Me.FrameHeightValue.Height = 0.2!
        Me.FrameHeightValue.Left = 6.15!
        Me.FrameHeightValue.Name = "FrameHeightValue"
        Me.FrameHeightValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.FrameHeightValue.Text = "Frame Height"
        Me.FrameHeightValue.Top = 0!
        Me.FrameHeightValue.Width = 0.75!
        '
        'FrameDepthValue
        '
        Me.FrameDepthValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.FrameDepthValue.DataField = "FrameDepth"
        Me.FrameDepthValue.Height = 0.2!
        Me.FrameDepthValue.Left = 6.9!
        Me.FrameDepthValue.Name = "FrameDepthValue"
        Me.FrameDepthValue.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " left; vertical-align: middle; ddo-char-set: 1"
        Me.FrameDepthValue.Text = "Frame Depth"
        Me.FrameDepthValue.Top = 0!
        Me.FrameDepthValue.Width = 0.75!
        '
        'lblCurSymbol
        '
        Me.lblCurSymbol.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.lblCurSymbol.Height = 0.2!
        Me.lblCurSymbol.HyperLink = Nothing
        Me.lblCurSymbol.Left = 7.65!
        Me.lblCurSymbol.Name = "lblCurSymbol"
        Me.lblCurSymbol.Style = "color: Blue; font-family: Arial; font-size: 9pt; font-weight: normal; text-align:"& _ 
    " right; vertical-align: middle; ddo-char-set: 1"
        Me.lblCurSymbol.Text = " �"
        Me.lblCurSymbol.Top = 0!
        Me.lblCurSymbol.Width = 0.1!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Footer})
        Me.PageFooter.Height = 0.6!
        Me.PageFooter.Name = "PageFooter"
        '
        'Footer
        '
        Me.Footer.DataField = "DocOwner"
        Me.Footer.Height = 0.62!
        Me.Footer.Left = 0!
        Me.Footer.Name = "Footer"
        Me.Footer.OutputFormat = resources.GetString("Footer.OutputFormat")
        Me.Footer.Style = "color: DimGray; font-size: 6.5pt; text-align: center; vertical-align: middle; ddo"& _ 
    "-char-set: 1"
        Me.Footer.Text = "ASSA ABLOY UK Specification"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"School Street, Willenhall, West Midlands, UK, WV13 3"& _ 
    "PWT"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"T: +44 (0)845 223 2124 F: +44 (0)845 223 2125 "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"E: info@assaabloy.co.uk W: "& _ 
    "www.assaabloy.co.uk"
        Me.Footer.Top = 0!
        Me.Footer.Width = 8.27!
        '
        'lblTotalSum
        '
        Me.lblTotalSum.Height = 0.2!
        Me.lblTotalSum.HyperLink = Nothing
        Me.lblTotalSum.Left = 5.8!
        Me.lblTotalSum.Name = "lblTotalSum"
        Me.lblTotalSum.Style = "font-size: 10pt; font-weight: bold; text-align: left; vertical-align: middle; ddo"& _ 
    "-char-set: 1"
        Me.lblTotalSum.Text = "Total Sum"
        Me.lblTotalSum.Top = 0!
        Me.lblTotalSum.Width = 1.5!
        '
        'TotalSumValue
        '
        Me.TotalSumValue.DataField = "UnitRate"
        Me.TotalSumValue.Height = 0.2!
        Me.TotalSumValue.Left = 7.4!
        Me.TotalSumValue.Name = "TotalSumValue"
        Me.TotalSumValue.OutputFormat = resources.GetString("TotalSumValue.OutputFormat")
        Me.TotalSumValue.Style = "color: Blue; font-weight: bold; vertical-align: middle; ddo-char-set: 1"
        Me.TotalSumValue.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TotalSumValue.Text = Nothing
        Me.TotalSumValue.Top = 0!
        Me.TotalSumValue.Width = 0.85!
        '
        'lblCurSymbolTotal
        '
        Me.lblCurSymbolTotal.Height = 0.2!
        Me.lblCurSymbolTotal.HyperLink = Nothing
        Me.lblCurSymbolTotal.Left = 7.3!
        Me.lblCurSymbolTotal.Name = "lblCurSymbolTotal"
        Me.lblCurSymbolTotal.Style = "color: Blue; font-weight: bold; text-align: center; vertical-align: middle; ddo-c"& _ 
    "har-set: 1"
        Me.lblCurSymbolTotal.Text = " �"
        Me.lblCurSymbolTotal.Top = 0!
        Me.lblCurSymbolTotal.Width = 0.1!
        '
        'lblTotDoors
        '
        Me.lblTotDoors.Height = 0.2!
        Me.lblTotDoors.HyperLink = Nothing
        Me.lblTotDoors.Left = 0!
        Me.lblTotDoors.Name = "lblTotDoors"
        Me.lblTotDoors.Style = "font-size: 10pt; font-weight: bold; text-align: left; vertical-align: middle; ddo"& _ 
    "-char-set: 1"
        Me.lblTotDoors.Text = "Total Doors"
        Me.lblTotDoors.Top = 0!
        Me.lblTotDoors.Width = 3.65!
        '
        'TotalDoorsValue
        '
        Me.TotalDoorsValue.DataField = "Qty"
        Me.TotalDoorsValue.Height = 0.2!
        Me.TotalDoorsValue.Left = 3.65!
        Me.TotalDoorsValue.Name = "TotalDoorsValue"
        Me.TotalDoorsValue.OutputFormat = resources.GetString("TotalDoorsValue.OutputFormat")
        Me.TotalDoorsValue.Style = "color: Blue; font-weight: bold; vertical-align: middle; ddo-char-set: 1"
        Me.TotalDoorsValue.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TotalDoorsValue.Text = Nothing
        Me.TotalDoorsValue.Top = 0!
        Me.TotalDoorsValue.Width = 1!
        '
        'GroupHeader
        '
        Me.GroupHeader.Height = 0!
        Me.GroupHeader.Name = "GroupHeader"
        '
        'GroupFooter
        '
        Me.GroupFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblTotalSum, Me.TotalSumValue, Me.lblCurSymbolTotal, Me.lblTotDoors, Me.TotalDoorsValue, Me.RemarksTopLine, Me.RemarksRightLine, Me.RemarksBottomLine, Me.RemarksLeftLine})
        Me.GroupFooter.Height = 2.1!
        Me.GroupFooter.Name = "GroupFooter"
        '
        'RemarksTopLine
        '
        Me.RemarksTopLine.Height = 0!
        Me.RemarksTopLine.Left = 0!
        Me.RemarksTopLine.LineColor = System.Drawing.Color.Gray
        Me.RemarksTopLine.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.RemarksTopLine.LineWeight = 1!
        Me.RemarksTopLine.Name = "RemarksTopLine"
        Me.RemarksTopLine.Top = 0.4!
        Me.RemarksTopLine.Width = 7.3!
        Me.RemarksTopLine.X1 = 0!
        Me.RemarksTopLine.X2 = 7.3!
        Me.RemarksTopLine.Y1 = 0.4!
        Me.RemarksTopLine.Y2 = 0.4!
        '
        'RemarksRightLine
        '
        Me.RemarksRightLine.Height = 1.6!
        Me.RemarksRightLine.Left = 7.3!
        Me.RemarksRightLine.LineColor = System.Drawing.Color.Gray
        Me.RemarksRightLine.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.RemarksRightLine.LineWeight = 1!
        Me.RemarksRightLine.Name = "RemarksRightLine"
        Me.RemarksRightLine.Top = 0.4!
        Me.RemarksRightLine.Width = 0!
        Me.RemarksRightLine.X1 = 7.3!
        Me.RemarksRightLine.X2 = 7.3!
        Me.RemarksRightLine.Y1 = 0.4!
        Me.RemarksRightLine.Y2 = 2!
        '
        'RemarksBottomLine
        '
        Me.RemarksBottomLine.Height = 0!
        Me.RemarksBottomLine.Left = 0!
        Me.RemarksBottomLine.LineColor = System.Drawing.Color.Gray
        Me.RemarksBottomLine.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.RemarksBottomLine.LineWeight = 1!
        Me.RemarksBottomLine.Name = "RemarksBottomLine"
        Me.RemarksBottomLine.Top = 2!
        Me.RemarksBottomLine.Width = 7.3!
        Me.RemarksBottomLine.X1 = 0!
        Me.RemarksBottomLine.X2 = 7.3!
        Me.RemarksBottomLine.Y1 = 2!
        Me.RemarksBottomLine.Y2 = 2!
        '
        'RemarksLeftLine
        '
        Me.RemarksLeftLine.Height = 1.6!
        Me.RemarksLeftLine.Left = 0!
        Me.RemarksLeftLine.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.RemarksLeftLine.LineWeight = 1!
        Me.RemarksLeftLine.Name = "RemarksLeftLine"
        Me.RemarksLeftLine.Top = 0.4!
        Me.RemarksLeftLine.Width = 0!
        Me.RemarksLeftLine.X1 = 0!
        Me.RemarksLeftLine.X2 = 0!
        Me.RemarksLeftLine.Y1 = 0.4!
        Me.RemarksLeftLine.Y2 = 2!
        '
        'rptEMEADoorScheduleSummary
        '
        Me.MasterReport = false
        Me.PageSettings.PaperHeight = 11!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.27!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma"& _ 
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita"& _ 
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblReportName,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgLogoEN,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgLogoNO,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtRev,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblRevNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPrjRef,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtProjectName,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtPrjRef,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPrjOwner,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtProjectOwner,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPrjName,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtDate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblPage,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CurrentPageNumber,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblOf,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PageCount,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFromRoom,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblDoorRef,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblToRoom,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblMaterial,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblConfiguration,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblQuantity,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFireRating,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblAcousticRating,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrameWidth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrameHeight,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblFrameDepth,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblUnitRate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UnitRateValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DoorRefValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ToRoomValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FromRoomValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MaterialValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConfigurationValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QtyValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FireRatingValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AcousticRatingValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FrameWidthValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FrameHeightValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FrameDepthValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCurSymbol,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Footer,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTotalSum,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TotalSumValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblCurSymbolTotal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lblTotDoors,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TotalDoorsValue,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Private WithEvents lblReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents imgLogoEN As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents imgLogoNO As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents Footer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtRev As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblRevNo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPrjRef As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtProjectName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPrjRef As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPrjOwner As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtProjectOwner As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPrjName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDate As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPage As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents CurrentPageNumber As GrapeCity.ActiveReports.SectionReportModel.ReportInfo
    Private WithEvents lblOf As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents lblFromRoom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblDoorRef As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblToRoom As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblMaterial As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblConfiguration As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFireRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblAcousticRating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFrameWidth As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFrameHeight As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblFrameDepth As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblUnitRate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents UnitRateValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents DoorRefValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ToRoomValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FromRoomValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents MaterialValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ConfigurationValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents QtyValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FireRatingValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents AcousticRatingValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameWidthValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameHeightValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameDepthValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblCurSymbol As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTotalSum As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TotalSumValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblCurSymbolTotal As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblTotDoors As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TotalDoorsValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents RemarksTopLine As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents RemarksRightLine As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents RemarksBottomLine As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents RemarksLeftLine As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
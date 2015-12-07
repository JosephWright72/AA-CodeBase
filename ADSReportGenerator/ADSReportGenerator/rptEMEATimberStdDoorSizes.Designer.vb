<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEMEATimberStdDoorSizes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEMEATimberStdDoorSizes))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.imgLogoEN = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.imgLogoNO = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.TimberFrameSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.StructuralOpeningSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorLeafSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ModuleSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.KickPlateSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorTypesValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.EMEATimberStdDoorSizesSub = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Footer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepthListPrimedPainted = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStandardFrameDepths = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblDoorTypes = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblModuleSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblStructuralOpeningSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblTimberFrameSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblDoorLeafSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblKickplateSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.LeafValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.LeafGroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.txtAllSizesIn = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.LeafGroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.SubGroupHeader = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.lblDoorTypes2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSizeInfo = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblPrimedPainted = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblHardwood = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblVeneered = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepthListHardwood = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepthListVeneered = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.SubGroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.txtNBRatings = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimberFrameSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StructuralOpeningSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorLeafSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuleSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KickPlateSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorTypesValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameDepthListPrimedPainted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStandardFrameDepths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModuleSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStructuralOpeningSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTimberFrameSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorLeafSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKickplateSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeafValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllSizesIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorTypes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSizeInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrimedPainted, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHardwood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblVeneered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameDepthListHardwood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameDepthListVeneered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNBRatings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportName, Me.imgLogoEN, Me.imgLogoNO})
        Me.PageHeader.Height = 0.3!
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
        'imgLogoEN
        '
        Me.imgLogoEN.Height = 0.32!
        Me.imgLogoEN.HyperLink = Nothing
        Me.imgLogoEN.ImageData = CType(resources.GetObject("imgLogoEN.ImageData"), System.IO.Stream)
        Me.imgLogoEN.Left = 6.35!
        Me.imgLogoEN.Name = "imgLogoEN"
        Me.imgLogoEN.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoEN.Top = 0.0!
        Me.imgLogoEN.Width = 1.8!
        '
        'imgLogoNO
        '
        Me.imgLogoNO.Height = 0.56!
        Me.imgLogoNO.HyperLink = Nothing
        Me.imgLogoNO.ImageData = CType(resources.GetObject("imgLogoNO.ImageData"), System.IO.Stream)
        Me.imgLogoNO.Left = 6.98!
        Me.imgLogoNO.Name = "imgLogoNO"
        Me.imgLogoNO.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoNO.Top = 0.0!
        Me.imgLogoNO.Width = 1.2!
        '
        'Detail
        '
        Me.Detail.CanShrink = True
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TimberFrameSizeValue, Me.StructuralOpeningSizeValue, Me.DoorLeafSizeValue, Me.ModuleSizeValue, Me.KickPlateSizeValue, Me.DoorTypesValue})
        Me.Detail.Height = 0.2!
        Me.Detail.Name = "Detail"
        '
        'TimberFrameSizeValue
        '
        Me.TimberFrameSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TimberFrameSizeValue.CanShrink = True
        Me.TimberFrameSizeValue.DataField = "TimberFrameSize"
        Me.TimberFrameSizeValue.Height = 0.2!
        Me.TimberFrameSizeValue.Left = 2.0!
        Me.TimberFrameSizeValue.Name = "TimberFrameSizeValue"
        Me.TimberFrameSizeValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.TimberFrameSizeValue.Text = "TimberFrameSizeValue"
        Me.TimberFrameSizeValue.Top = 0.0!
        Me.TimberFrameSizeValue.Width = 1.25!
        '
        'StructuralOpeningSizeValue
        '
        Me.StructuralOpeningSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.StructuralOpeningSizeValue.CanShrink = True
        Me.StructuralOpeningSizeValue.DataField = "StructuralOpeningSize"
        Me.StructuralOpeningSizeValue.Height = 0.2!
        Me.StructuralOpeningSizeValue.Left = 0.75!
        Me.StructuralOpeningSizeValue.Name = "StructuralOpeningSizeValue"
        Me.StructuralOpeningSizeValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.StructuralOpeningSizeValue.Text = "StructuralOpeningSizeValue"
        Me.StructuralOpeningSizeValue.Top = 0.0!
        Me.StructuralOpeningSizeValue.Width = 1.25!
        '
        'DoorLeafSizeValue
        '
        Me.DoorLeafSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.DoorLeafSizeValue.CanShrink = True
        Me.DoorLeafSizeValue.DataField = "DoorLeafSize"
        Me.DoorLeafSizeValue.Height = 0.2!
        Me.DoorLeafSizeValue.Left = 3.25!
        Me.DoorLeafSizeValue.Name = "DoorLeafSizeValue"
        Me.DoorLeafSizeValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.DoorLeafSizeValue.Text = "DoorLeafSizeValue"
        Me.DoorLeafSizeValue.Top = 0.0!
        Me.DoorLeafSizeValue.Width = 1.25!
        '
        'ModuleSizeValue
        '
        Me.ModuleSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ModuleSizeValue.CanShrink = True
        Me.ModuleSizeValue.DataField = "ModuleSize"
        Me.ModuleSizeValue.Height = 0.2!
        Me.ModuleSizeValue.Left = 0.0!
        Me.ModuleSizeValue.Name = "ModuleSizeValue"
        Me.ModuleSizeValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.ModuleSizeValue.Text = "ModuleSizeValue"
        Me.ModuleSizeValue.Top = 0.0!
        Me.ModuleSizeValue.Width = 0.75!
        '
        'KickPlateSizeValue
        '
        Me.KickPlateSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.KickPlateSizeValue.CanShrink = True
        Me.KickPlateSizeValue.DataField = "KickPlateSize"
        Me.KickPlateSizeValue.Height = 0.2!
        Me.KickPlateSizeValue.Left = 4.5!
        Me.KickPlateSizeValue.Name = "KickPlateSizeValue"
        Me.KickPlateSizeValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.KickPlateSizeValue.Text = "KickPlateSizeValue"
        Me.KickPlateSizeValue.Top = 0.0!
        Me.KickPlateSizeValue.Width = 1.0!
        '
        'DoorTypesValue
        '
        Me.DoorTypesValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.DoorTypesValue.CanShrink = True
        Me.DoorTypesValue.DataField = "DoorTypes"
        Me.DoorTypesValue.Height = 0.2!
        Me.DoorTypesValue.Left = 5.5!
        Me.DoorTypesValue.Name = "DoorTypesValue"
        Me.DoorTypesValue.Style = "font-size: 8pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.DoorTypesValue.Text = "DoorTypesValue"
        Me.DoorTypesValue.Top = 0.0!
        Me.DoorTypesValue.Width = 2.5!
        '
        'EMEATimberStdDoorSizesSub
        '
        Me.EMEATimberStdDoorSizesSub.CanShrink = False
        Me.EMEATimberStdDoorSizesSub.CloseBorder = False
        Me.EMEATimberStdDoorSizesSub.Height = 0.15!
        Me.EMEATimberStdDoorSizesSub.Left = 3.25!
        Me.EMEATimberStdDoorSizesSub.Name = "EMEATimberStdDoorSizesSub"
        Me.EMEATimberStdDoorSizesSub.Report = Nothing
        Me.EMEATimberStdDoorSizesSub.ReportName = "EMEATimberStdDoorSizesSub"
        Me.EMEATimberStdDoorSizesSub.Top = 0.0!
        Me.EMEATimberStdDoorSizesSub.Width = 4.75!
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
        Me.Footer.Text = "Footer text"
        Me.Footer.Top = 0.0!
        Me.Footer.Width = 8.27!
        '
        'FrameDepthListPrimedPainted
        '
        Me.FrameDepthListPrimedPainted.DataField = "FrameDepthListPrimedPainted"
        Me.FrameDepthListPrimedPainted.Height = 0.15!
        Me.FrameDepthListPrimedPainted.Left = 3.25!
        Me.FrameDepthListPrimedPainted.Name = "FrameDepthListPrimedPainted"
        Me.FrameDepthListPrimedPainted.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.FrameDepthListPrimedPainted.Text = "Frame DepthListPrimedPainted"
        Me.FrameDepthListPrimedPainted.Top = 0.85!
        Me.FrameDepthListPrimedPainted.Width = 4.75!
        '
        'txtStandardFrameDepths
        '
        Me.txtStandardFrameDepths.Height = 0.15!
        Me.txtStandardFrameDepths.Left = 0.0!
        Me.txtStandardFrameDepths.Name = "txtStandardFrameDepths"
        Me.txtStandardFrameDepths.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.txtStandardFrameDepths.Text = "txtStandardFrameDepths"
        Me.txtStandardFrameDepths.Top = 0.85!
        Me.txtStandardFrameDepths.Width = 2.0!
        '
        'lblDoorTypes
        '
        Me.lblDoorTypes.CanShrink = True
        Me.lblDoorTypes.DataField = "Header6"
        Me.lblDoorTypes.Height = 0.2!
        Me.lblDoorTypes.Left = 5.5!
        Me.lblDoorTypes.Name = "lblDoorTypes"
        Me.lblDoorTypes.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblDoorTypes.Text = "Header6"
        Me.lblDoorTypes.Top = 0.25!
        Me.lblDoorTypes.Width = 2.5!
        '
        'lblModuleSize
        '
        Me.lblModuleSize.CanShrink = True
        Me.lblModuleSize.DataField = "Header1"
        Me.lblModuleSize.Height = 0.2!
        Me.lblModuleSize.Left = 0.0!
        Me.lblModuleSize.Name = "lblModuleSize"
        Me.lblModuleSize.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblModuleSize.Text = "Header1"
        Me.lblModuleSize.Top = 0.25!
        Me.lblModuleSize.Width = 0.75!
        '
        'lblStructuralOpeningSize
        '
        Me.lblStructuralOpeningSize.CanShrink = True
        Me.lblStructuralOpeningSize.DataField = "Header2"
        Me.lblStructuralOpeningSize.Height = 0.2!
        Me.lblStructuralOpeningSize.Left = 0.75!
        Me.lblStructuralOpeningSize.Name = "lblStructuralOpeningSize"
        Me.lblStructuralOpeningSize.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblStructuralOpeningSize.Text = "Header2"
        Me.lblStructuralOpeningSize.Top = 0.25!
        Me.lblStructuralOpeningSize.Width = 1.25!
        '
        'lblTimberFrameSize
        '
        Me.lblTimberFrameSize.CanShrink = True
        Me.lblTimberFrameSize.DataField = "Header3"
        Me.lblTimberFrameSize.Height = 0.2!
        Me.lblTimberFrameSize.Left = 2.0!
        Me.lblTimberFrameSize.Name = "lblTimberFrameSize"
        Me.lblTimberFrameSize.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblTimberFrameSize.Text = "Header3"
        Me.lblTimberFrameSize.Top = 0.25!
        Me.lblTimberFrameSize.Width = 1.25!
        '
        'lblDoorLeafSize
        '
        Me.lblDoorLeafSize.CanShrink = True
        Me.lblDoorLeafSize.DataField = "Header4"
        Me.lblDoorLeafSize.Height = 0.2!
        Me.lblDoorLeafSize.Left = 3.25!
        Me.lblDoorLeafSize.Name = "lblDoorLeafSize"
        Me.lblDoorLeafSize.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblDoorLeafSize.Text = "Header4"
        Me.lblDoorLeafSize.Top = 0.25!
        Me.lblDoorLeafSize.Width = 1.25!
        '
        'lblKickplateSize
        '
        Me.lblKickplateSize.CanShrink = True
        Me.lblKickplateSize.DataField = "Header5"
        Me.lblKickplateSize.Height = 0.2!
        Me.lblKickplateSize.Left = 4.5!
        Me.lblKickplateSize.Name = "lblKickplateSize"
        Me.lblKickplateSize.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblKickplateSize.Text = "Header5"
        Me.lblKickplateSize.Top = 0.25!
        Me.lblKickplateSize.Width = 1.0!
        '
        'LeafValue
        '
        Me.LeafValue.CanShrink = True
        Me.LeafValue.DataField = "Leaf"
        Me.LeafValue.Height = 0.2!
        Me.LeafValue.Left = 0.0!
        Me.LeafValue.Name = "LeafValue"
        Me.LeafValue.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.LeafValue.Text = "Leaf"
        Me.LeafValue.Top = 0.05!
        Me.LeafValue.Width = 2.0!
        '
        'LeafGroupHeader
        '
        Me.LeafGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.LeafValue, Me.lblModuleSize, Me.lblDoorTypes, Me.lblKickplateSize, Me.lblDoorLeafSize, Me.lblTimberFrameSize, Me.lblStructuralOpeningSize, Me.txtAllSizesIn})
        Me.LeafGroupHeader.DataField = "Leaf"
        Me.LeafGroupHeader.Height = 0.45!
        Me.LeafGroupHeader.Name = "LeafGroupHeader"
        Me.LeafGroupHeader.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'txtAllSizesIn
        '
        Me.txtAllSizesIn.CanShrink = True
        Me.txtAllSizesIn.Height = 0.2!
        Me.txtAllSizesIn.Left = 6.0!
        Me.txtAllSizesIn.Name = "txtAllSizesIn"
        Me.txtAllSizesIn.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.txtAllSizesIn.Text = "txtAllSizesIn"
        Me.txtAllSizesIn.Top = 0.05!
        Me.txtAllSizesIn.Width = 2.0!
        '
        'LeafGroupFooter
        '
        Me.LeafGroupFooter.Height = 0.0!
        Me.LeafGroupFooter.Name = "LeafGroupFooter"
        '
        'SubGroupHeader
        '
        Me.SubGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.EMEATimberStdDoorSizesSub, Me.FrameDepthListPrimedPainted, Me.txtStandardFrameDepths, Me.lblDoorTypes2, Me.txtSizeInfo, Me.lblPrimedPainted, Me.lblHardwood, Me.lblVeneered, Me.FrameDepthListHardwood, Me.FrameDepthListVeneered})
        Me.SubGroupHeader.Height = 1.3!
        Me.SubGroupHeader.Name = "SubGroupHeader"
        '
        'lblDoorTypes2
        '
        Me.lblDoorTypes2.CanShrink = True
        Me.lblDoorTypes2.Height = 0.15!
        Me.lblDoorTypes2.Left = 2.0!
        Me.lblDoorTypes2.Name = "lblDoorTypes2"
        Me.lblDoorTypes2.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblDoorTypes2.Text = "lblDoorTypes2"
        Me.lblDoorTypes2.Top = 0.0!
        Me.lblDoorTypes2.Width = 1.25!
        '
        'txtSizeInfo
        '
        Me.txtSizeInfo.Height = 0.8!
        Me.txtSizeInfo.HyperLink = Nothing
        Me.txtSizeInfo.Left = 0.0!
        Me.txtSizeInfo.Name = "txtSizeInfo"
        Me.txtSizeInfo.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 1"
        Me.txtSizeInfo.Text = "txtSizeInfo"
        Me.txtSizeInfo.Top = 0.0!
        Me.txtSizeInfo.Width = 2.0!
        '
        'lblPrimedPainted
        '
        Me.lblPrimedPainted.Height = 0.15!
        Me.lblPrimedPainted.Left = 2.0!
        Me.lblPrimedPainted.Name = "lblPrimedPainted"
        Me.lblPrimedPainted.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.lblPrimedPainted.Text = "lblPrimedPainted"
        Me.lblPrimedPainted.Top = 0.85!
        Me.lblPrimedPainted.Width = 1.25!
        '
        'lblHardwood
        '
        Me.lblHardwood.Height = 0.15!
        Me.lblHardwood.Left = 2.0!
        Me.lblHardwood.Name = "lblHardwood"
        Me.lblHardwood.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.lblHardwood.Text = "lblHardwood"
        Me.lblHardwood.Top = 1.0!
        Me.lblHardwood.Width = 1.25!
        '
        'lblVeneered
        '
        Me.lblVeneered.Height = 0.15!
        Me.lblVeneered.Left = 2.0!
        Me.lblVeneered.Name = "lblVeneered"
        Me.lblVeneered.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.lblVeneered.Text = "lblVeneered"
        Me.lblVeneered.Top = 1.15!
        Me.lblVeneered.Width = 1.25!
        '
        'FrameDepthListHardwood
        '
        Me.FrameDepthListHardwood.DataField = "FrameDepthListHardwood"
        Me.FrameDepthListHardwood.Height = 0.15!
        Me.FrameDepthListHardwood.Left = 3.25!
        Me.FrameDepthListHardwood.Name = "FrameDepthListHardwood"
        Me.FrameDepthListHardwood.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.FrameDepthListHardwood.Text = "FrameDepthListHardwood"
        Me.FrameDepthListHardwood.Top = 1.0!
        Me.FrameDepthListHardwood.Width = 4.75!
        '
        'FrameDepthListVeneered
        '
        Me.FrameDepthListVeneered.DataField = "FrameDepthListVeneered"
        Me.FrameDepthListVeneered.Height = 0.15!
        Me.FrameDepthListVeneered.Left = 3.25!
        Me.FrameDepthListVeneered.Name = "FrameDepthListVeneered"
        Me.FrameDepthListVeneered.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.FrameDepthListVeneered.Text = "FrameDepthListVeneered"
        Me.FrameDepthListVeneered.Top = 1.15!
        Me.FrameDepthListVeneered.Width = 4.75!
        '
        'SubGroupFooter
        '
        Me.SubGroupFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtNBRatings})
        Me.SubGroupFooter.Height = 0.2!
        Me.SubGroupFooter.Name = "SubGroupFooter"
        '
        'txtNBRatings
        '
        Me.txtNBRatings.CanShrink = True
        Me.txtNBRatings.Height = 0.2!
        Me.txtNBRatings.Left = 0.0!
        Me.txtNBRatings.Name = "txtNBRatings"
        Me.txtNBRatings.Style = "font-size: 8pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.txtNBRatings.Text = "txtNBRatings"
        Me.txtNBRatings.Top = 0.0!
        Me.txtNBRatings.Width = 8.0!
        '
        'rptEMEATimberStdDoorSizes
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 8.2!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.SubGroupHeader)
        Me.Sections.Add(Me.LeafGroupHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.LeafGroupFooter)
        Me.Sections.Add(Me.SubGroupFooter)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimberFrameSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StructuralOpeningSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoorLeafSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModuleSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KickPlateSizeValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoorTypesValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Footer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameDepthListPrimedPainted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStandardFrameDepths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModuleSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStructuralOpeningSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTimberFrameSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorLeafSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKickplateSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeafValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllSizesIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorTypes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSizeInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrimedPainted, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHardwood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblVeneered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameDepthListHardwood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameDepthListVeneered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNBRatings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private WithEvents Footer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents imgLogoEN As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents imgLogoNO As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents EMEATimberStdDoorSizesSub As GrapeCity.ActiveReports.SectionReportModel.SubReport
    Private WithEvents TimberFrameSizeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents StructuralOpeningSizeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents DoorLeafSizeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ModuleSizeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents KickPlateSizeValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents DoorTypesValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblDoorTypes As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblModuleSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblStructuralOpeningSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblTimberFrameSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblDoorLeafSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblKickplateSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents LeafValue As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents LeafGroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents LeafGroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents FrameDepthListPrimedPainted As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStandardFrameDepths As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents SubGroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents SubGroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents txtAllSizesIn As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblDoorTypes2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSizeInfo As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPrimedPainted As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblHardwood As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblVeneered As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameDepthListHardwood As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameDepthListVeneered As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNBRatings As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

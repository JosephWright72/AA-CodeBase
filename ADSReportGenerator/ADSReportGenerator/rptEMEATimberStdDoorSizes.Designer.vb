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
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEMEATimberStdDoorSizes))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.imgLogoEN = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.imgLogoNO = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.TimberFrameSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.StructuralOpeningSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorLeafSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ModuleSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.KickPlateSizeValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.DoorTypesValue = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.EMEATimberStdDoorSizesSub = New GrapeCity.ActiveReports.SectionReportModel.SubReport()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtFooter = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSizeInfo = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepthList = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
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
        Me.SubGroupFooter = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        CType(Me.lblReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimberFrameSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StructuralOpeningSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorLeafSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModuleSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KickPlateSizeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoorTypesValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSizeInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameDepthList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStandardFrameDepths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblModuleSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblStructuralOpeningSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTimberFrameSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDoorLeafSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKickplateSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeafValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllSizesIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportName, Me.imgLogoEN, Me.imgLogoNO})
        Me.PageHeader.Height = 0.6!
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
        Me.lblReportName.Text = "ReportName"
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
        'Detail1
        '
        Me.Detail1.CanShrink = True
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TimberFrameSizeValue, Me.StructuralOpeningSizeValue, Me.DoorLeafSizeValue, Me.ModuleSizeValue, Me.KickPlateSizeValue, Me.DoorTypesValue})
        Me.Detail1.Height = 0.2!
        Me.Detail1.Name = "Detail1"
        '
        'TimberFrameSizeValue
        '
        Me.TimberFrameSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TimberFrameSizeValue.DataField = "TimberFrameSize"
        Me.TimberFrameSizeValue.Height = 0.2!
        Me.TimberFrameSizeValue.Left = 2.0!
        Me.TimberFrameSizeValue.Name = "TimberFrameSizeValue"
        Me.TimberFrameSizeValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.TimberFrameSizeValue.Text = "TimberFrameSizeValue"
        Me.TimberFrameSizeValue.Top = 0.0!
        Me.TimberFrameSizeValue.Width = 1.25!
        '
        'StructuralOpeningSizeValue
        '
        Me.StructuralOpeningSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.StructuralOpeningSizeValue.DataField = "StructuralOpeningSize"
        Me.StructuralOpeningSizeValue.Height = 0.2!
        Me.StructuralOpeningSizeValue.Left = 0.75!
        Me.StructuralOpeningSizeValue.Name = "StructuralOpeningSizeValue"
        Me.StructuralOpeningSizeValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.StructuralOpeningSizeValue.Text = "StructuralOpeningSizeValue"
        Me.StructuralOpeningSizeValue.Top = 0.0!
        Me.StructuralOpeningSizeValue.Width = 1.25!
        '
        'DoorLeafSizeValue
        '
        Me.DoorLeafSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.DoorLeafSizeValue.DataField = "DoorLeafSize"
        Me.DoorLeafSizeValue.Height = 0.2!
        Me.DoorLeafSizeValue.Left = 3.25!
        Me.DoorLeafSizeValue.Name = "DoorLeafSizeValue"
        Me.DoorLeafSizeValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.DoorLeafSizeValue.Text = "DoorLeafSizeValue"
        Me.DoorLeafSizeValue.Top = 0.0!
        Me.DoorLeafSizeValue.Width = 1.25!
        '
        'ModuleSizeValue
        '
        Me.ModuleSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.ModuleSizeValue.DataField = "ModuleSize"
        Me.ModuleSizeValue.Height = 0.2!
        Me.ModuleSizeValue.Left = 0.0!
        Me.ModuleSizeValue.Name = "ModuleSizeValue"
        Me.ModuleSizeValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.ModuleSizeValue.Text = "ModuleSizeValue"
        Me.ModuleSizeValue.Top = 0.0!
        Me.ModuleSizeValue.Width = 0.75!
        '
        'KickPlateSizeValue
        '
        Me.KickPlateSizeValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.KickPlateSizeValue.DataField = "KickPlateSize"
        Me.KickPlateSizeValue.Height = 0.2!
        Me.KickPlateSizeValue.Left = 4.5!
        Me.KickPlateSizeValue.Name = "KickPlateSizeValue"
        Me.KickPlateSizeValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.KickPlateSizeValue.Text = "KickPlateSizeValue"
        Me.KickPlateSizeValue.Top = 0.0!
        Me.KickPlateSizeValue.Width = 1.0!
        '
        'DoorTypesValue
        '
        Me.DoorTypesValue.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.DoorTypesValue.DataField = "DoorTypes"
        Me.DoorTypesValue.Height = 0.2!
        Me.DoorTypesValue.Left = 5.5!
        Me.DoorTypesValue.Name = "DoorTypesValue"
        Me.DoorTypesValue.Style = "font-size: 9pt; font-weight: normal; text-align: center; ddo-char-set: 1"
        Me.DoorTypesValue.Text = "DoorTypesValue"
        Me.DoorTypesValue.Top = 0.0!
        Me.DoorTypesValue.Width = 2.5!
        '
        'EMEATimberStdDoorSizesSub
        '
        Me.EMEATimberStdDoorSizesSub.CanShrink = False
        Me.EMEATimberStdDoorSizesSub.CloseBorder = False
        Me.EMEATimberStdDoorSizesSub.Height = 0.2!
        Me.EMEATimberStdDoorSizesSub.Left = 3.0!
        Me.EMEATimberStdDoorSizesSub.Name = "EMEATimberStdDoorSizesSub"
        Me.EMEATimberStdDoorSizesSub.Report = Nothing
        Me.EMEATimberStdDoorSizesSub.ReportName = "EMEATimberStdDoorSizesSub"
        Me.EMEATimberStdDoorSizesSub.Top = 0.0!
        Me.EMEATimberStdDoorSizesSub.Width = 5.0!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtFooter})
        Me.PageFooter.Height = 0.62!
        Me.PageFooter.Name = "PageFooter"
        '
        'txtFooter
        '
        Me.txtFooter.DataField = "DocOwner"
        Me.txtFooter.Height = 0.62!
        Me.txtFooter.Left = 0.0!
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.OutputFormat = resources.GetString("txtFooter.OutputFormat")
        Me.txtFooter.Style = "color: DimGray; font-size: 6.5pt; text-align: center; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txtFooter.Text = "ASSA ABLOY UK Specification" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "School Street, Willenhall, West Midlands, UK, WV13 3" & _
    "PWT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T: +44 (0)845 223 2124 F: +44 (0)845 223 2125 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E: info@assaabloy.co.uk W: " & _
    "www.assaabloy.co.uk"
        Me.txtFooter.Top = 0.0!
        Me.txtFooter.Width = 8.27!
        '
        'txtSizeInfo
        '
        Me.txtSizeInfo.DataField = "SetName"
        Me.txtSizeInfo.Height = 0.2!
        Me.txtSizeInfo.Left = 0.0!
        Me.txtSizeInfo.Name = "txtSizeInfo"
        Me.txtSizeInfo.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.txtSizeInfo.Text = "Size Info"
        Me.txtSizeInfo.Top = 0.0!
        Me.txtSizeInfo.Width = 3.0!
        '
        'FrameDepthList
        '
        Me.FrameDepthList.DataField = "FrameDepthList"
        Me.FrameDepthList.Height = 0.2!
        Me.FrameDepthList.Left = 2.0!
        Me.FrameDepthList.Name = "FrameDepthList"
        Me.FrameDepthList.Style = "font-size: 9pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.FrameDepthList.Text = "Frame DepthList"
        Me.FrameDepthList.Top = 0.2!
        Me.FrameDepthList.Width = 4.0!
        '
        'txtStandardFrameDepths
        '
        Me.txtStandardFrameDepths.Height = 0.2!
        Me.txtStandardFrameDepths.Left = 0.0!
        Me.txtStandardFrameDepths.Name = "txtStandardFrameDepths"
        Me.txtStandardFrameDepths.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.txtStandardFrameDepths.Text = "Standard frame depths"
        Me.txtStandardFrameDepths.Top = 0.2!
        Me.txtStandardFrameDepths.Width = 2.0!
        '
        'lblDoorTypes
        '
        Me.lblDoorTypes.Height = 0.2!
        Me.lblDoorTypes.Left = 5.5!
        Me.lblDoorTypes.Name = "lblDoorTypes"
        Me.lblDoorTypes.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblDoorTypes.Text = "Door Types"
        Me.lblDoorTypes.Top = 0.4!
        Me.lblDoorTypes.Width = 2.5!
        '
        'lblModuleSize
        '
        Me.lblModuleSize.Height = 0.2!
        Me.lblModuleSize.Left = 0.0!
        Me.lblModuleSize.Name = "lblModuleSize"
        Me.lblModuleSize.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblModuleSize.Text = "Module Size"
        Me.lblModuleSize.Top = 0.4!
        Me.lblModuleSize.Width = 0.75!
        '
        'lblStructuralOpeningSize
        '
        Me.lblStructuralOpeningSize.Height = 0.2!
        Me.lblStructuralOpeningSize.Left = 0.75!
        Me.lblStructuralOpeningSize.Name = "lblStructuralOpeningSize"
        Me.lblStructuralOpeningSize.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblStructuralOpeningSize.Text = "Structural Opening Size"
        Me.lblStructuralOpeningSize.Top = 0.4!
        Me.lblStructuralOpeningSize.Width = 1.25!
        '
        'lblTimberFrameSize
        '
        Me.lblTimberFrameSize.Height = 0.2!
        Me.lblTimberFrameSize.Left = 2.0!
        Me.lblTimberFrameSize.Name = "lblTimberFrameSize"
        Me.lblTimberFrameSize.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblTimberFrameSize.Text = "Timber Frame Size"
        Me.lblTimberFrameSize.Top = 0.4!
        Me.lblTimberFrameSize.Width = 1.25!
        '
        'lblDoorLeafSize
        '
        Me.lblDoorLeafSize.Height = 0.2!
        Me.lblDoorLeafSize.Left = 3.25!
        Me.lblDoorLeafSize.Name = "lblDoorLeafSize"
        Me.lblDoorLeafSize.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblDoorLeafSize.Text = "Door Leaf Size"
        Me.lblDoorLeafSize.Top = 0.4!
        Me.lblDoorLeafSize.Width = 1.25!
        '
        'lblKickplateSize
        '
        Me.lblKickplateSize.Height = 0.2!
        Me.lblKickplateSize.Left = 4.5!
        Me.lblKickplateSize.Name = "lblKickplateSize"
        Me.lblKickplateSize.Style = "font-size: 9pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.lblKickplateSize.Text = "Kickplate Size"
        Me.lblKickplateSize.Top = 0.4!
        Me.lblKickplateSize.Width = 1.0!
        '
        'LeafValue
        '
        Me.LeafValue.DataField = "Leaf"
        Me.LeafValue.Height = 0.2!
        Me.LeafValue.Left = 0.0!
        Me.LeafValue.Name = "LeafValue"
        Me.LeafValue.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.LeafValue.Text = "Leaf"
        Me.LeafValue.Top = 0.2!
        Me.LeafValue.Width = 2.0!
        '
        'LeafGroupHeader
        '
        Me.LeafGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.LeafValue, Me.lblModuleSize, Me.lblDoorTypes, Me.lblKickplateSize, Me.lblDoorLeafSize, Me.lblTimberFrameSize, Me.lblStructuralOpeningSize, Me.txtAllSizesIn})
        Me.LeafGroupHeader.DataField = "Leaf"
        Me.LeafGroupHeader.Height = 0.6!
        Me.LeafGroupHeader.Name = "LeafGroupHeader"
        Me.LeafGroupHeader.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'txtAllSizesIn
        '
        Me.txtAllSizesIn.Height = 0.2!
        Me.txtAllSizesIn.Left = 6.0!
        Me.txtAllSizesIn.Name = "txtAllSizesIn"
        Me.txtAllSizesIn.Style = "font-size: 9pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.txtAllSizesIn.Text = "All Sizes In"
        Me.txtAllSizesIn.Top = 0.2!
        Me.txtAllSizesIn.Width = 2.0!
        '
        'LeafGroupFooter
        '
        Me.LeafGroupFooter.Height = 0.0!
        Me.LeafGroupFooter.Name = "LeafGroupFooter"
        '
        'SubGroupHeader
        '
        Me.SubGroupHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.EMEATimberStdDoorSizesSub, Me.txtSizeInfo, Me.FrameDepthList, Me.txtStandardFrameDepths})
        Me.SubGroupHeader.Height = 0.4!
        Me.SubGroupHeader.Name = "SubGroupHeader"
        '
        'SubGroupFooter
        '
        Me.SubGroupFooter.Height = 0.0!
        Me.SubGroupFooter.Name = "SubGroupFooter"
        '
        'rptEMEATimberStdDoorSizes
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2!
        Me.PageSettings.Margins.Left = 0.2!
        Me.PageSettings.Margins.Right = 0.2!
        Me.PageSettings.Margins.Top = 0.2!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 8.194918!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.SubGroupHeader)
        Me.Sections.Add(Me.LeafGroupHeader)
        Me.Sections.Add(Me.Detail1)
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
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSizeInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameDepthList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStandardFrameDepths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblModuleSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblStructuralOpeningSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTimberFrameSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDoorLeafSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKickplateSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeafValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllSizesIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private WithEvents txtFooter As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Private WithEvents txtSizeInfo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameDepthList As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtStandardFrameDepths As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents SubGroupHeader As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents SubGroupFooter As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents txtAllSizesIn As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

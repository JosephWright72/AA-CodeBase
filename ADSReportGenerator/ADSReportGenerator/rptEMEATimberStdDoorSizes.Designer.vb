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
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptEMEATimberStdDoorSizes))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.ReportName = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.imgLogoEN = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.imgLogoNO = New GrapeCity.ActiveReports.SectionReportModel.Picture()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtFooter = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.HWSet = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Thickness = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FrameDepths = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.ReportName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HWSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrameDepths, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.ReportName, Me.imgLogoEN, Me.imgLogoNO})
        Me.PageHeader1.Height = 1.000416!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'ReportName
        '
        Me.ReportName.Height = 0.2!
        Me.ReportName.HyperLink = Nothing
        Me.ReportName.Left = 0.0!
        Me.ReportName.Name = "ReportName"
        Me.ReportName.Style = "font-size: 10pt; font-weight: bold; text-align: left; text-decoration: none; vert" & _
    "ical-align: middle; ddo-char-set: 1"
        Me.ReportName.Text = "ReportName"
        Me.ReportName.Top = 0.0!
        Me.ReportName.Width = 3.01!
        '
        'imgLogoEN
        '
        Me.imgLogoEN.Height = 0.316!
        Me.imgLogoEN.HyperLink = Nothing
        Me.imgLogoEN.ImageData = CType(resources.GetObject("imgLogoEN.ImageData"), System.IO.Stream)
        Me.imgLogoEN.Left = 6.369!
        Me.imgLogoEN.Name = "imgLogoEN"
        Me.imgLogoEN.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoEN.Top = 0.0!
        Me.imgLogoEN.Width = 1.824!
        '
        'imgLogoNO
        '
        Me.imgLogoNO.Height = 0.567!
        Me.imgLogoNO.HyperLink = Nothing
        Me.imgLogoNO.ImageData = CType(resources.GetObject("imgLogoNO.ImageData"), System.IO.Stream)
        Me.imgLogoNO.Left = 6.976!
        Me.imgLogoNO.Name = "imgLogoNO"
        Me.imgLogoNO.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        Me.imgLogoNO.Top = 0.0!
        Me.imgLogoNO.Width = 1.218999!
        '
        'Detail1
        '
        Me.Detail1.CanShrink = True
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.HWSet, Me.Thickness, Me.TextBox2, Me.FrameDepths})
        Me.Detail1.Height = 0.8604164!
        Me.Detail1.Name = "Detail1"
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtFooter})
        Me.PageFooter1.Height = 0.6819167!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.txtFooter.Width = 8.193001!
        '
        'HWSet
        '
        Me.HWSet.DataField = "SetName"
        Me.HWSet.Height = 0.17!
        Me.HWSet.Left = 5.004!
        Me.HWSet.Name = "HWSet"
        Me.HWSet.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.HWSet.Text = "HW Set"
        Me.HWSet.Top = 0.0!
        Me.HWSet.Width = 1.0!
        '
        'Thickness
        '
        Me.Thickness.DataField = "Thickness"
        Me.Thickness.Height = 0.17!
        Me.Thickness.Left = 6.004!
        Me.Thickness.Name = "Thickness"
        Me.Thickness.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Thickness.Text = "HW Set"
        Me.Thickness.Top = 0.0!
        Me.Thickness.Width = 1.0!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "Rating"
        Me.TextBox2.Height = 0.17!
        Me.TextBox2.Left = 7.004!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.TextBox2.Text = "HW Set"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.0!
        '
        'FrameDepths
        '
        Me.FrameDepths.Height = 0.17!
        Me.FrameDepths.Left = 4.004!
        Me.FrameDepths.Name = "FrameDepths"
        Me.FrameDepths.Style = "font-size: 9pt; font-weight: normal; text-align: left; ddo-char-set: 1"
        Me.FrameDepths.Text = "Frame Depths"
        Me.FrameDepths.Top = 0.6900001!
        Me.FrameDepths.Width = 4.0!
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
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.ReportName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogoNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HWSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrameDepths, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private WithEvents txtFooter As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ReportName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents imgLogoEN As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents imgLogoNO As GrapeCity.ActiveReports.SectionReportModel.Picture
    Private WithEvents HWSet As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Thickness As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FrameDepths As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

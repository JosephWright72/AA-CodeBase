<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptEMEATimberStdDoorSizesSub
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
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptEMEATimberStdDoorSizesSub))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.HWSet = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Thickness = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Rating = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        CType(Me.HWSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.HWSet, Me.Thickness, Me.Rating})
        Me.Detail.Height = 0.2!
        Me.Detail.Name = "Detail"
        '
        'HWSet
        '
        Me.HWSet.DataField = "SetName"
        Me.HWSet.Height = 0.2!
        Me.HWSet.Left = 1.0!
        Me.HWSet.Name = "HWSet"
        Me.HWSet.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.HWSet.Text = "HW Set"
        Me.HWSet.Top = 0.0!
        Me.HWSet.Width = 1.0!
        '
        'Thickness
        '
        Me.Thickness.DataField = "Thickness"
        Me.Thickness.Height = 0.2!
        Me.Thickness.Left = 2.0!
        Me.Thickness.Name = "Thickness"
        Me.Thickness.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Thickness.Text = "Thickness"
        Me.Thickness.Top = 0.0!
        Me.Thickness.Width = 1.0!
        '
        'Rating
        '
        Me.Rating.DataField = "Rating"
        Me.Rating.Height = 0.2!
        Me.Rating.Left = 3.0!
        Me.Rating.Name = "Rating"
        Me.Rating.Style = "font-size: 9pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Rating.Text = "Rating"
        Me.Rating.Top = 0.0!
        Me.Rating.Width = 1.0!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptEMEATimberStdDoorSizesSub
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 3.989584!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.HWSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thickness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rating, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents HWSet As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Thickness As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Rating As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
End Class

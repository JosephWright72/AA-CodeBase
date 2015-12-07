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
        CType(Me.HWSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thickness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rating, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.HWSet, Me.Thickness, Me.Rating})
        Me.Detail.Height = 0.15!
        Me.Detail.Name = "Detail"
        '
        'HWSet
        '
        Me.HWSet.DataField = "SetName"
        Me.HWSet.Height = 0.15!
        Me.HWSet.Left = 0.0!
        Me.HWSet.Name = "HWSet"
        Me.HWSet.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.HWSet.Text = "HW Set"
        Me.HWSet.Top = 0.0!
        Me.HWSet.Width = 1.25!
        '
        'Thickness
        '
        Me.Thickness.CanShrink = True
        Me.Thickness.DataField = "Thickness"
        Me.Thickness.Height = 0.15!
        Me.Thickness.Left = 1.25!
        Me.Thickness.Name = "Thickness"
        Me.Thickness.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Thickness.Text = "Thickness"
        Me.Thickness.Top = 0.0!
        Me.Thickness.Width = 1.0!
        '
        'Rating
        '
        Me.Rating.CanShrink = True
        Me.Rating.DataField = "Rating"
        Me.Rating.Height = 0.15!
        Me.Rating.Left = 2.25!
        Me.Rating.Name = "Rating"
        Me.Rating.Style = "font-size: 8pt; font-weight: bold; text-align: left; ddo-char-set: 1"
        Me.Rating.Text = "Rating"
        Me.Rating.Top = 0.0!
        Me.Rating.Width = 2.5!
        '
        'rptEMEATimberStdDoorSizesSub
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.27!
        Me.PrintWidth = 4.74!
        Me.Sections.Add(Me.Detail)
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
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptUnmatchHW
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
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptUnmatchHW))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ghMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.lblManufacturer = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.txtHardwareSets = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.gfMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHardwareSets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox2, Me.TextBox3, Me.TextBox1, Me.TextBox4})
        Me.Detail1.Height = 0.19!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "TypeDescription"
        Me.TextBox2.Height = 0.19!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox2.Text = "TextBox1"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 2.399!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "Description"
        Me.TextBox3.Height = 0.19!
        Me.TextBox3.Left = 2.4!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 2.399!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "Manufacturer"
        Me.TextBox1.Height = 0.19!
        Me.TextBox1.Left = 4.809!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.7340002!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "Change"
        Me.TextBox4.Height = 0.19!
        Me.TextBox4.Left = 5.674!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox4.Text = "TextBox1"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.226!
        '
        'ghMarkNumbers
        '
        Me.ghMarkNumbers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblManufacturer, Me.Label1, Me.Label3, Me.Label4, Me.txtHardwareSets, Me.Label5, Me.Line1})
        Me.ghMarkNumbers.DataField = "MarkNumber"
        Me.ghMarkNumbers.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.ghMarkNumbers.Height = 0.4500001!
        Me.ghMarkNumbers.KeepTogether = True
        Me.ghMarkNumbers.Name = "ghMarkNumbers"
        Me.ghMarkNumbers.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Height = 0.2291667!
        Me.lblManufacturer.HyperLink = Nothing
        Me.lblManufacturer.Left = 4.809!
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; text-ali" & _
            "gn: left; vertical-align: middle; ddo-char-set: 1"
        Me.lblManufacturer.Text = "Manufacturer"
        Me.lblManufacturer.Top = 0.208!
        Me.lblManufacturer.Width = 0.7340002!
        '
        'Label1
        '
        Me.Label1.Height = 0.2291667!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; text-ali" & _
            "gn: left; vertical-align: middle; ddo-char-set: 1"
        Me.Label1.Text = "Type Description"
        Me.Label1.Top = 0.208!
        Me.Label1.Width = 2.4!
        '
        'Label3
        '
        Me.Label3.Height = 0.2291667!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.399!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; text-ali" & _
            "gn: left; vertical-align: middle; ddo-char-set: 1"
        Me.Label3.Text = "Description"
        Me.Label3.Top = 0.208!
        Me.Label3.Width = 2.4!
        '
        'Label4
        '
        Me.Label4.Height = 0.2083333!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label4.Text = "Hardware Set(s):"
        Me.Label4.Top = 0.0!
        Me.Label4.Width = 1.198167!
        '
        'txtHardwareSets
        '
        Me.txtHardwareSets.DataField = "MarkNumber"
        Me.txtHardwareSets.Height = 0.2083333!
        Me.txtHardwareSets.Left = 1.198!
        Me.txtHardwareSets.Name = "txtHardwareSets"
        Me.txtHardwareSets.Text = "TextBox4"
        Me.txtHardwareSets.Top = 0.0!
        Me.txtHardwareSets.Width = 5.702!
        '
        'Label5
        '
        Me.Label5.Height = 0.2291667!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.674!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; text-ali" & _
            "gn: left; vertical-align: middle; ddo-char-set: 1"
        Me.Label5.Text = "Change"
        Me.Label5.Top = 0.208!
        Me.Label5.Width = 1.226!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.4370001!
        Me.Line1.Width = 6.95!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 6.95!
        Me.Line1.Y1 = 0.4370001!
        Me.Line1.Y2 = 0.4370001!
        '
        'gfMarkNumbers
        '
        Me.gfMarkNumbers.Height = 0.1875!
        Me.gfMarkNumbers.Name = "gfMarkNumbers"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label2})
        Me.GroupHeader1.Height = 0.25!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label2
        '
        Me.Label2.Height = 0.243!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 14pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label2.Text = "Added / Removed Hardware Items"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 6.9!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptUnmatchHW
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.3!
        Me.PageSettings.Margins.Top = 0.3!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.9585!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.ghMarkNumbers)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.gfMarkNumbers)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHardwareSets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents ghMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents gfMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblManufacturer As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtHardwareSets As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
End Class

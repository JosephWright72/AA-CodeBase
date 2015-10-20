<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptAddRemoveDoors
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptAddRemoveDoors))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ghMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.ProjectName1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ProjectName2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.gfMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox2, Me.TextBox3, Me.TextBox1})
        Me.Detail1.Height = 0.19!
        Me.Detail1.KeepTogether = True
        Me.Detail1.Name = "Detail1"
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "Mark1"
        Me.TextBox2.Height = 0.19!
        Me.TextBox2.Left = 0.021!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox2.Text = "TextBox1"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 2.681!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "Mark2"
        Me.TextBox3.Height = 0.19!
        Me.TextBox3.Left = 2.85!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 2.681!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "Change"
        Me.TextBox1.Height = 0.19!
        Me.TextBox1.Left = 5.667!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.27!
        '
        'ghMarkNumbers
        '
        Me.ghMarkNumbers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.ProjectName1, Me.ProjectName2, Me.Label2})
        Me.ghMarkNumbers.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
        Me.ghMarkNumbers.Height = 0.57!
        Me.ghMarkNumbers.KeepTogether = True
        Me.ghMarkNumbers.Name = "ghMarkNumbers"
        Me.ghMarkNumbers.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
        Me.ghMarkNumbers.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label1
        '
        Me.Label1.Height = 0.2225!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.76!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; text-ali" & _
            "gn: left; vertical-align: middle; ddo-char-set: 1"
        Me.Label1.Text = "Change"
        Me.Label1.Top = 0.34!
        Me.Label1.Width = 1.1775!
        '
        'ProjectName1
        '
        Me.ProjectName1.Height = 0.21875!
        Me.ProjectName1.Left = 0.086!
        Me.ProjectName1.Name = "ProjectName1"
        Me.ProjectName1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; vertical" & _
            "-align: middle; ddo-char-set: 0"
        Me.ProjectName1.Text = "TextBox1"
        Me.ProjectName1.Top = 0.34!
        Me.ProjectName1.Width = 2.616!
        '
        'ProjectName2
        '
        Me.ProjectName2.Height = 0.21875!
        Me.ProjectName2.Left = 2.915!
        Me.ProjectName2.Name = "ProjectName2"
        Me.ProjectName2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; vertical" & _
            "-align: middle; ddo-char-set: 0"
        Me.ProjectName2.Text = "TextBox1"
        Me.ProjectName2.Top = 0.34!
        Me.ProjectName2.Width = 2.616!
        '
        'Label2
        '
        Me.Label2.Height = 0.3229167!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 18pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label2.Text = "Mark Number Changes"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 6.9375!
        '
        'gfMarkNumbers
        '
        Me.gfMarkNumbers.Height = 0.15625!
        Me.gfMarkNumbers.Name = "gfMarkNumbers"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line1})
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
        Me.GroupHeader1.Height = 0.01041667!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 6.95!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 6.95!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptAddRemoveDoors
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.3!
        Me.PageSettings.Margins.Top = 0.3!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.9585!
        Me.Sections.Add(Me.ghMarkNumbers)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.gfMarkNumbers)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents ghMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents gfMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ProjectName1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ProjectName2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
End Class

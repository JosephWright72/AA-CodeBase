<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCompareHWSets
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptCompareHWSets))
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ghMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.txtHardwareSets = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.gfMarkNumbers = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.lblFieldName = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.ProjectName1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ProjectName2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.ghTypeDescriptions = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.gfTypeDescriptions = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.GroupHeader2 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHardwareSets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFieldName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectName1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectName2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3})
        Me.Detail1.Height = 0.19!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "FieldName"
        Me.TextBox1.Height = 0.19!
        Me.TextBox1.Left = 0.021!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.365!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "Project1"
        Me.TextBox2.Height = 0.19!
        Me.TextBox2.Left = 2.386!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox2.Text = "TextBox1"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 2.223!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "Project2"
        Me.TextBox3.Height = 0.19!
        Me.TextBox3.Left = 4.609!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; ddo-char-set: 0"
        Me.TextBox3.Text = "TextBox1"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 2.35!
        '
        'ghMarkNumbers
        '
        Me.ghMarkNumbers.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.txtHardwareSets, Me.Line1})
        Me.ghMarkNumbers.DataField = "MarkNumbers"
        Me.ghMarkNumbers.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.ghMarkNumbers.Height = 0.2083333!
        Me.ghMarkNumbers.Name = "ghMarkNumbers"
        Me.ghMarkNumbers.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label1
        '
        Me.Label1.Height = 0.2083333!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.021!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label1.Text = "Hardware Set(s):"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 1.198167!
        '
        'txtHardwareSets
        '
        Me.txtHardwareSets.DataField = "MarkNumbers"
        Me.txtHardwareSets.Height = 0.2083333!
        Me.txtHardwareSets.Left = 1.37!
        Me.txtHardwareSets.Name = "txtHardwareSets"
        Me.txtHardwareSets.Text = "TextBox4"
        Me.txtHardwareSets.Top = 0.0!
        Me.txtHardwareSets.Width = 5.518!
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
        'gfMarkNumbers
        '
        Me.gfMarkNumbers.Height = 0.1979167!
        Me.gfMarkNumbers.Name = "gfMarkNumbers"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label2, Me.lblFieldName, Me.ProjectName1, Me.ProjectName2})
        Me.GroupHeader1.Height = 0.6094167!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label2
        '
        Me.Label2.Height = 0.3229167!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 18pt; font-weight: bold; text-align: center; ddo-char-set: 1"
        Me.Label2.Text = "Hardware Set Comparison Report"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 6.9375!
        '
        'lblFieldName
        '
        Me.lblFieldName.Height = 0.23!
        Me.lblFieldName.HyperLink = Nothing
        Me.lblFieldName.Left = 0.0!
        Me.lblFieldName.Name = "lblFieldName"
        Me.lblFieldName.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; text-align: left; vertical-" & _
            "align: middle; ddo-char-set: 0"
        Me.lblFieldName.Text = "Field Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblFieldName.Top = 0.373!
        Me.lblFieldName.Visible = False
        Me.lblFieldName.Width = 1.219!
        '
        'ProjectName1
        '
        Me.ProjectName1.Height = 0.2195833!
        Me.ProjectName1.Left = 2.386!
        Me.ProjectName1.Name = "ProjectName1"
        Me.ProjectName1.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; vertical" & _
            "-align: middle; ddo-char-set: 0"
        Me.ProjectName1.Text = "TextBox1"
        Me.ProjectName1.Top = 0.383!
        Me.ProjectName1.Width = 2.1!
        '
        'ProjectName2
        '
        Me.ProjectName2.Height = 0.2195833!
        Me.ProjectName2.Left = 4.609!
        Me.ProjectName2.Name = "ProjectName2"
        Me.ProjectName2.Style = "font-family: Microsoft Sans Serif; font-size: 8.25pt; font-weight: bold; vertical" & _
            "-align: middle; ddo-char-set: 0"
        Me.ProjectName2.Text = "TextBox1"
        Me.ProjectName2.Top = 0.383!
        Me.ProjectName2.Width = 2.279!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'ghTypeDescriptions
        '
        Me.ghTypeDescriptions.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label3, Me.TextBox5})
        Me.ghTypeDescriptions.DataField = "TypeDescription"
        Me.ghTypeDescriptions.Height = 0.2156944!
        Me.ghTypeDescriptions.Name = "ghTypeDescriptions"
        '
        'Label3
        '
        Me.Label3.Height = 0.2083333!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-weight: bold; ddo-char-set: 1"
        Me.Label3.Text = "Type Description(s):"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 1.379!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "TypeDescription"
        Me.TextBox5.Height = 0.2083333!
        Me.TextBox5.Left = 1.37!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Text = "TextBox4"
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 5.518!
        '
        'gfTypeDescriptions
        '
        Me.gfTypeDescriptions.Height = 0.0!
        Me.gfTypeDescriptions.Name = "gfTypeDescriptions"
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line2})
        Me.GroupHeader2.Height = 0.01041667!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.0!
        Me.Line2.Width = 6.95!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 6.95!
        Me.Line2.Y1 = 0.0!
        Me.Line2.Y2 = 0.0!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0.0!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'rptCompareHWSets
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.3!
        Me.PageSettings.Margins.Top = 0.3!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.9585!
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.ghMarkNumbers)
        Me.Sections.Add(Me.ghTypeDescriptions)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.gfTypeDescriptions)
        Me.Sections.Add(Me.gfMarkNumbers)
        Me.Sections.Add(Me.GroupFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHardwareSets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFieldName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectName1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectName2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents ghMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents gfMarkNumbers As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtHardwareSets As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents ghTypeDescriptions As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents gfTypeDescriptions As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents lblFieldName As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents GroupHeader2 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents ProjectName1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ProjectName2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptHWSchedule 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptHWSchedule))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1})
        Me.PageHeader.Height = 0.4062501!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10})
        Me.Detail.Height = 0.4062501!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Name = "PageFooter"
        '
        'TextBox1
        '
        Me.TextBox1.DataField = ""
        Me.TextBox1.DistinctField = ""
        Me.TextBox1.Height = 0.293!
        Me.TextBox1.Left = 2.636!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "color: Black; font-size: 18pt; text-align: center"
        Me.TextBox1.SummaryGroup = ""
        Me.TextBox1.Text = "Hardware Schedule"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.261!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox12, Me.TextBox13})
        Me.GroupHeader1.DataField = "SetName"
        Me.GroupHeader1.Height = 0.5416667!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox11, Me.TextBox14})
        Me.GroupFooter1.Height = 0.625!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "=""Groupe - "" + SetName"
        Me.TextBox2.DistinctField = ""
        Me.TextBox2.Height = 0.252!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "color: Black; font-family: Microsoft Sans Serif; font-size: 12pt; font-weight: bo" & _
    "ld; text-decoration: underline; ddo-char-set: 0"
        Me.TextBox2.SummaryGroup = ""
        Me.TextBox2.Text = "Groupe - 01"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.533!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "=""Porte # - "" + Doors"
        Me.TextBox3.Height = 0.252!
        Me.TextBox3.Left = 1.533!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: Microsoft Sans Serif; font-size: 12pt; font-weight: bold; ddo-char-s" & _
    "et: 0"
        Me.TextBox3.Text = "Porte # - 101"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 5.967!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.DataField = "Qty"
        Me.TextBox6.Height = 0.4!
        Me.TextBox6.Left = 0.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "vertical-align: middle"
        Me.TextBox6.Text = "TextBox6"
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.521!
        '
        'TextBox7
        '
        Me.TextBox7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.DataField = "TypeDescription"
        Me.TextBox7.Height = 0.2!
        Me.TextBox7.Left = 0.521!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Text = "TextBox7"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 4.979001!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.DataField = "Description"
        Me.TextBox8.Height = 0.2!
        Me.TextBox8.Left = 0.521!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Text = "TextBox8"
        Me.TextBox8.Top = 0.2!
        Me.TextBox8.Width = 4.979001!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.DataField = "Finish"
        Me.TextBox9.Height = 0.4!
        Me.TextBox9.Left = 5.5!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "vertical-align: middle"
        Me.TextBox9.Text = "TextBox9"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.573!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.DataField = "Manufacturer"
        Me.TextBox10.Height = 0.398!
        Me.TextBox10.Left = 6.073!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "vertical-align: middle"
        Me.TextBox10.Text = "TextBox10"
        Me.TextBox10.Top = 0.002000004!
        Me.TextBox10.Width = 1.427!
        '
        'TextBox11
        '
        Me.TextBox11.Height = 0.1979167!
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-size: 9.75pt; font-weight: bold; text-decoration: underline"
        Me.TextBox11.Text = "Notes: "
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 7.5!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2!
        Me.TextBox4.Left = 0.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-size: 9.75pt; font-weight: bold; text-align: center"
        Me.TextBox4.Text = "QTÉ"
        Me.TextBox4.Top = 0.344!
        Me.TextBox4.Width = 0.521!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2!
        Me.TextBox5.Left = 0.521!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-size: 9.75pt; font-weight: bold; text-align: center"
        Me.TextBox5.Text = "DESCRIPTION"
        Me.TextBox5.Top = 0.344!
        Me.TextBox5.Width = 4.979001!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2!
        Me.TextBox12.Left = 5.5!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-size: 9.75pt; font-weight: bold; text-align: center"
        Me.TextBox12.Text = "FINI"
        Me.TextBox12.Top = 0.344!
        Me.TextBox12.Width = 0.573!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2!
        Me.TextBox13.Left = 6.073!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-size: 9.75pt; font-weight: bold; text-align: center"
        Me.TextBox13.Text = "MANUFACTURIER"
        Me.TextBox13.Top = 0.344!
        Me.TextBox13.Width = 1.427!
        '
        'TextBox14
        '
        Me.TextBox14.DataField = "SetNotes"
        Me.TextBox14.Height = 0.1979167!
        Me.TextBox14.Left = 0.0000002384186!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Text = "Notes: "
        Me.TextBox14.Top = 0.2135417!
        Me.TextBox14.Width = 7.5!
        '
        'rptHWSchedule
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.5!
        Me.ScriptLanguage = "VB.NET"
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class 

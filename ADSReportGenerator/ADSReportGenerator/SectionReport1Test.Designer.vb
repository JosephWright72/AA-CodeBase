<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SectionReport1Test 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SectionReport1Test))
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.25F
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.Height = 2.0F
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.25F
        Me.PageFooter.Name = "PageFooter"
        '
        'SectionReport1Test
        '
        Me.MasterReport = False
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
		   "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
		   "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
End Class 

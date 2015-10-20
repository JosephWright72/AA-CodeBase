<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDoorEstimateReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDoorEstimateReport))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.lblReportTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblSeries = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProjectName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJobName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblHeadFace = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblElevType = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblJambFace = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtDescComment = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSize = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtElevType = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtHeadFace = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtJambFace = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtSeries = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGa = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtST = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtListPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdj4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExtension = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNetPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdj3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdj2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdj1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdj = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.chkNC = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.txtNC = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.txtPageCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.lblPageNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPageNumber = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDateTime = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ghCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.txtCategory = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtCategorySort = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.gfCategory = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTotalExtension = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtTotalQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGrandTotal = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.lblReportTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJobName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHeadFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblElevType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJambFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescComment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtElevType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHeadFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJambFace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtListPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdj4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdj3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdj2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdj1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategorySort, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalExtension, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrandTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblReportTitle, Me.Label1, Me.Label2, Me.lblSeries, Me.Label4, Me.Label7, Me.Label9, Me.txtProjectName, Me.txtJobName, Me.Label11, Me.Label12, Me.Label13, Me.lblHeadFace, Me.lblElevType, Me.lblJambFace, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Line1})
        Me.PageHeader1.Height = 1.150833!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'lblReportTitle
        '
        Me.lblReportTitle.Height = 0.302!
        Me.lblReportTitle.HyperLink = Nothing
        Me.lblReportTitle.Left = 0.0!
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Style = "font-size: 18pt; text-align: center; ddo-char-set: 1"
        Me.lblReportTitle.Text = "Hollow Metal Door Estimate"
        Me.lblReportTitle.Top = 0.0!
        Me.lblReportTitle.Width = 10.0!
        '
        'Label1
        '
        Me.Label1.Height = 0.334!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 9.75pt; font-weight: bold; text-align: left; text-decoration: none; ve" & _
            "rtical-align: top; ddo-char-set: 1"
        Me.Label1.Text = "Description Comment"
        Me.Label1.Top = 0.7820001!
        Me.Label1.Width = 0.8710001!
        '
        'Label2
        '
        Me.Label2.Height = 0.334!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.8710001!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 9.75pt; font-weight: bold; text-align: left; text-decoration: none; ve" & _
            "rtical-align: top; ddo-char-set: 1"
        Me.Label2.Text = "Size"
        Me.Label2.Top = 0.7820001!
        Me.Label2.Width = 1.391!
        '
        'lblSeries
        '
        Me.lblSeries.Height = 0.334!
        Me.lblSeries.HyperLink = Nothing
        Me.lblSeries.Left = 3.758!
        Me.lblSeries.Name = "lblSeries"
        Me.lblSeries.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.lblSeries.Text = "Series"
        Me.lblSeries.Top = 0.7820001!
        Me.lblSeries.Width = 0.4960001!
        '
        'Label4
        '
        Me.Label4.Height = 0.334!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.254001!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label4.Text = "Ga"
        Me.Label4.Top = 0.7820001!
        Me.Label4.Width = 0.5!
        '
        'Label7
        '
        Me.Label7.Height = 0.2395833!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 2.21!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: none; v" & _
            "ertical-align: middle; ddo-char-set: 1"
        Me.Label7.Text = "Project ID:"
        Me.Label7.Top = 0.5420001!
        Me.Label7.Width = 1.048!
        '
        'Label9
        '
        Me.Label9.Height = 0.2395833!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.21!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: none; v" & _
            "ertical-align: middle; ddo-char-set: 1"
        Me.Label9.Text = "Project Name:"
        Me.Label9.Top = 0.3019998!
        Me.Label9.Width = 1.048!
        '
        'txtProjectName
        '
        Me.txtProjectName.DataField = "ProjectName"
        Me.txtProjectName.Height = 0.2399167!
        Me.txtProjectName.Left = 3.258004!
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Style = "vertical-align: middle"
        Me.txtProjectName.Text = "TextBox1"
        Me.txtProjectName.Top = 0.302!
        Me.txtProjectName.Width = 4.52!
        '
        'txtJobName
        '
        Me.txtJobName.DataField = "ProjectID"
        Me.txtJobName.Height = 0.2399167!
        Me.txtJobName.Left = 3.258004!
        Me.txtJobName.Name = "txtJobName"
        Me.txtJobName.Style = "vertical-align: middle"
        Me.txtJobName.Text = "TextBox1"
        Me.txtJobName.Top = 0.5420001!
        Me.txtJobName.Width = 4.52!
        '
        'Label11
        '
        Me.Label11.Height = 0.334!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 4.754001!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label11.Text = "S.T."
        Me.Label11.Top = 0.7820001!
        Me.Label11.Width = 0.5!
        '
        'Label12
        '
        Me.Label12.Height = 0.334!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 5.41!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label12.Text = "List Price"
        Me.Label12.Top = 0.7960001!
        Me.Label12.Width = 0.5060005!
        '
        'Label13
        '
        Me.Label13.Height = 0.334!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.243!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: none; v" & _
            "ertical-align: top; ddo-char-set: 1"
        Me.Label13.Text = "Extension"
        Me.Label13.Top = 0.7820001!
        Me.Label13.Width = 0.757!
        '
        'lblHeadFace
        '
        Me.lblHeadFace.Height = 0.334!
        Me.lblHeadFace.HyperLink = Nothing
        Me.lblHeadFace.Left = 2.758!
        Me.lblHeadFace.Name = "lblHeadFace"
        Me.lblHeadFace.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.lblHeadFace.Text = "Head Face"
        Me.lblHeadFace.Top = 0.7820001!
        Me.lblHeadFace.Width = 0.5!
        '
        'lblElevType
        '
        Me.lblElevType.Height = 0.334!
        Me.lblElevType.HyperLink = Nothing
        Me.lblElevType.Left = 2.262!
        Me.lblElevType.Name = "lblElevType"
        Me.lblElevType.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.lblElevType.Text = "Elev. Type"
        Me.lblElevType.Top = 0.7820001!
        Me.lblElevType.Width = 0.4960001!
        '
        'lblJambFace
        '
        Me.lblJambFace.Height = 0.334!
        Me.lblJambFace.HyperLink = Nothing
        Me.lblJambFace.Left = 3.258!
        Me.lblJambFace.Name = "lblJambFace"
        Me.lblJambFace.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.lblJambFace.Text = "Jamb Face"
        Me.lblJambFace.Top = 0.7820001!
        Me.lblJambFace.Width = 0.5!
        '
        'Label15
        '
        Me.Label15.Height = 0.334!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 8.743!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label15.Text = "Qty"
        Me.Label15.Top = 0.7820001!
        Me.Label15.Width = 0.5!
        '
        'Label16
        '
        Me.Label16.Height = 0.3340001!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 8.243!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label16.Text = "Net Price"
        Me.Label16.Top = 0.7820001!
        Me.Label16.Width = 0.5!
        '
        'Label17
        '
        Me.Label17.Height = 0.3340001!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.339!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label17.Text = "Adjustments"
        Me.Label17.Top = 0.7820001!
        Me.Label17.Width = 1.702!
        '
        'Label18
        '
        Me.Label18.Height = 0.334!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 5.916!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: none; " & _
            "vertical-align: top; ddo-char-set: 1"
        Me.Label18.Text = "NC"
        Me.Label18.Top = 0.7820001!
        Me.Label18.Width = 0.4170003!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.13!
        Me.Line1.Width = 10.0!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 10.0!
        Me.Line1.Y1 = 1.13!
        Me.Line1.Y2 = 1.13!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtDescComment, Me.txtSize, Me.txtElevType, Me.txtHeadFace, Me.txtJambFace, Me.txtSeries, Me.txtGa, Me.txtST, Me.txtListPrice, Me.txtAdj4, Me.txtExtension, Me.txtNetPrice, Me.txtQty, Me.txtAdj3, Me.txtAdj2, Me.txtAdj1, Me.txtAdj, Me.chkNC, Me.txtNC})
        Me.Detail1.Height = 0.17!
        Me.Detail1.Name = "Detail1"
        '
        'txtDescComment
        '
        Me.txtDescComment.DataField = "Name"
        Me.txtDescComment.Height = 0.17!
        Me.txtDescComment.Left = 0.0!
        Me.txtDescComment.Name = "txtDescComment"
        Me.txtDescComment.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.txtDescComment.Text = "TextBox1"
        Me.txtDescComment.Top = 0.0!
        Me.txtDescComment.Width = 0.8710001!
        '
        'txtSize
        '
        Me.txtSize.DataField = "SizeDesc"
        Me.txtSize.Height = 0.17!
        Me.txtSize.Left = 0.8710001!
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.txtSize.Text = "TextBox1"
        Me.txtSize.Top = 0.0!
        Me.txtSize.Width = 1.391!
        '
        'txtElevType
        '
        Me.txtElevType.DataField = "FrameDesign"
        Me.txtElevType.Height = 0.17!
        Me.txtElevType.Left = 2.262!
        Me.txtElevType.Name = "txtElevType"
        Me.txtElevType.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtElevType.Text = "TextBox1"
        Me.txtElevType.Top = 0.0!
        Me.txtElevType.Width = 0.4960001!
        '
        'txtHeadFace
        '
        Me.txtHeadFace.DataField = "FrameHead"
        Me.txtHeadFace.Height = 0.17!
        Me.txtHeadFace.Left = 2.758!
        Me.txtHeadFace.Name = "txtHeadFace"
        Me.txtHeadFace.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtHeadFace.Text = "TextBox1"
        Me.txtHeadFace.Top = 0.0!
        Me.txtHeadFace.Width = 0.5!
        '
        'txtJambFace
        '
        Me.txtJambFace.DataField = "FrameFace"
        Me.txtJambFace.Height = 0.17!
        Me.txtJambFace.Left = 3.258!
        Me.txtJambFace.Name = "txtJambFace"
        Me.txtJambFace.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtJambFace.Text = "0"
        Me.txtJambFace.Top = 0.0!
        Me.txtJambFace.Width = 0.5!
        '
        'txtSeries
        '
        Me.txtSeries.DataField = "Series"
        Me.txtSeries.Height = 0.17!
        Me.txtSeries.Left = 3.758!
        Me.txtSeries.Name = "txtSeries"
        Me.txtSeries.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtSeries.Text = "TextBox1"
        Me.txtSeries.Top = 0.0!
        Me.txtSeries.Width = 0.496!
        '
        'txtGa
        '
        Me.txtGa.DataField = "Gauge"
        Me.txtGa.Height = 0.17!
        Me.txtGa.Left = 4.254!
        Me.txtGa.Name = "txtGa"
        Me.txtGa.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtGa.Text = "TextBox1"
        Me.txtGa.Top = 0.0!
        Me.txtGa.Width = 0.5000002!
        '
        'txtST
        '
        Me.txtST.DataField = "SteelType"
        Me.txtST.Height = 0.17!
        Me.txtST.Left = 4.758!
        Me.txtST.Name = "txtST"
        Me.txtST.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.txtST.Text = "TextBox1"
        Me.txtST.Top = 0.0!
        Me.txtST.Width = 0.4960001!
        '
        'txtListPrice
        '
        Me.txtListPrice.DataField = "List"
        Me.txtListPrice.Height = 0.17!
        Me.txtListPrice.Left = 5.254!
        Me.txtListPrice.Name = "txtListPrice"
        Me.txtListPrice.OutputFormat = resources.GetString("txtListPrice.OutputFormat")
        Me.txtListPrice.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtListPrice.Text = "TextBox1"
        Me.txtListPrice.Top = 0.0!
        Me.txtListPrice.Width = 0.6619997!
        '
        'txtAdj4
        '
        Me.txtAdj4.DataField = "Adj4"
        Me.txtAdj4.Height = 0.17!
        Me.txtAdj4.Left = 7.622!
        Me.txtAdj4.Name = "txtAdj4"
        Me.txtAdj4.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdj4.Text = "0"
        Me.txtAdj4.Top = 0.0!
        Me.txtAdj4.Width = 0.34!
        '
        'txtExtension
        '
        Me.txtExtension.DataField = "TotalExtended"
        Me.txtExtension.Height = 0.17!
        Me.txtExtension.Left = 9.243!
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.OutputFormat = resources.GetString("txtExtension.OutputFormat")
        Me.txtExtension.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtExtension.Text = "TextBox1"
        Me.txtExtension.Top = 0.0!
        Me.txtExtension.Width = 0.757!
        '
        'txtNetPrice
        '
        Me.txtNetPrice.DataField = "TotalNet"
        Me.txtNetPrice.Height = 0.17!
        Me.txtNetPrice.Left = 7.962!
        Me.txtNetPrice.Name = "txtNetPrice"
        Me.txtNetPrice.OutputFormat = resources.GetString("txtNetPrice.OutputFormat")
        Me.txtNetPrice.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtNetPrice.Text = "TextBox1"
        Me.txtNetPrice.Top = 0.0!
        Me.txtNetPrice.Width = 0.71!
        '
        'txtQty
        '
        Me.txtQty.DataField = "TotalQty"
        Me.txtQty.Height = 0.17!
        Me.txtQty.Left = 8.743!
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtQty.Text = "TextBox1"
        Me.txtQty.Top = 0.0!
        Me.txtQty.Width = 0.427!
        '
        'txtAdj3
        '
        Me.txtAdj3.DataField = "Adj3"
        Me.txtAdj3.Height = 0.17!
        Me.txtAdj3.Left = 7.282001!
        Me.txtAdj3.Name = "txtAdj3"
        Me.txtAdj3.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdj3.Text = "0"
        Me.txtAdj3.Top = 0.0!
        Me.txtAdj3.Width = 0.34!
        '
        'txtAdj2
        '
        Me.txtAdj2.DataField = "Adj2"
        Me.txtAdj2.Height = 0.17!
        Me.txtAdj2.Left = 6.942001!
        Me.txtAdj2.Name = "txtAdj2"
        Me.txtAdj2.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdj2.Text = "0"
        Me.txtAdj2.Top = 0.0!
        Me.txtAdj2.Width = 0.34!
        '
        'txtAdj1
        '
        Me.txtAdj1.DataField = "Adj1"
        Me.txtAdj1.Height = 0.17!
        Me.txtAdj1.Left = 6.602!
        Me.txtAdj1.Name = "txtAdj1"
        Me.txtAdj1.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdj1.Text = "0"
        Me.txtAdj1.Top = 0.0!
        Me.txtAdj1.Width = 0.34!
        '
        'txtAdj
        '
        Me.txtAdj.DataField = "Adj"
        Me.txtAdj.Height = 0.17!
        Me.txtAdj.Left = 6.26!
        Me.txtAdj.Name = "txtAdj"
        Me.txtAdj.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdj.Text = "0"
        Me.txtAdj.Top = 0.0!
        Me.txtAdj.Width = 0.34!
        '
        'chkNC
        '
        Me.chkNC.CheckAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkNC.Height = 0.1458333!
        Me.chkNC.Left = 5.978!
        Me.chkNC.Name = "chkNC"
        Me.chkNC.Style = ""
        Me.chkNC.Text = ""
        Me.chkNC.Top = 0.02083333!
        Me.chkNC.Width = 0.2820001!
        '
        'txtNC
        '
        Me.txtNC.DataField = "NC"
        Me.txtNC.Height = 0.1770833!
        Me.txtNC.Left = 4.625!
        Me.txtNC.Name = "txtNC"
        Me.txtNC.Text = "TextBox2"
        Me.txtNC.Top = 0.28125!
        Me.txtNC.Visible = False
        Me.txtNC.Width = 0.4895833!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtPageCount, Me.lblPageNumber, Me.txtPageNumber, Me.Label10, Me.lblDateTime})
        Me.PageFooter1.Height = 0.17!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'txtPageCount
        '
        Me.txtPageCount.Height = 0.1875!
        Me.txtPageCount.Left = 2.139998!
        Me.txtPageCount.Name = "txtPageCount"
        Me.txtPageCount.Style = "font-size: 8pt; font-style: italic; font-weight: bold; ddo-char-set: 1"
        Me.txtPageCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.txtPageCount.Text = "NO"
        Me.txtPageCount.Top = 0.0!
        Me.txtPageCount.Visible = False
        Me.txtPageCount.Width = 0.5!
        '
        'lblPageNumber
        '
        Me.lblPageNumber.Height = 0.17!
        Me.lblPageNumber.HyperLink = Nothing
        Me.lblPageNumber.Left = 0.0!
        Me.lblPageNumber.Name = "lblPageNumber"
        Me.lblPageNumber.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.lblPageNumber.Text = "PageNumber"
        Me.lblPageNumber.Top = 0.0!
        Me.lblPageNumber.Width = 10.0!
        '
        'txtPageNumber
        '
        Me.txtPageNumber.Height = 0.1875!
        Me.txtPageNumber.Left = 1.39!
        Me.txtPageNumber.Name = "txtPageNumber"
        Me.txtPageNumber.Style = "font-size: 8pt; font-style: italic; font-weight: bold; text-align: right; ddo-cha" & _
            "r-set: 1"
        Me.txtPageNumber.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.txtPageNumber.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.txtPageNumber.Text = "Page"
        Me.txtPageNumber.Top = 0.0!
        Me.txtPageNumber.Visible = False
        Me.txtPageNumber.Width = 0.5!
        '
        'Label10
        '
        Me.Label10.Height = 0.17!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.Label10.Text = "ASSA ABLOY Openings Studio"
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 2.042!
        '
        'lblDateTime
        '
        Me.lblDateTime.Height = 0.17!
        Me.lblDateTime.HyperLink = Nothing
        Me.lblDateTime.Left = 8.041!
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.Top = 0.0!
        Me.lblDateTime.Width = 1.959!
        '
        'ghCategory
        '
        Me.ghCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtCategory, Me.txtCategorySort})
        Me.ghCategory.DataField = "Category"
        Me.ghCategory.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.ghCategory.Height = 0.219!
        Me.ghCategory.KeepTogether = True
        Me.ghCategory.Name = "ghCategory"
        Me.ghCategory.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtCategory
        '
        Me.txtCategory.DataField = "Category"
        Me.txtCategory.Height = 0.1979167!
        Me.txtCategory.Left = 0.0!
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Style = "font-size: 11pt; font-weight: bold; text-decoration: underline; ddo-char-set: 1"
        Me.txtCategory.Text = "TextBox1"
        Me.txtCategory.Top = 0.0!
        Me.txtCategory.Width = 10.0!
        '
        'txtCategorySort
        '
        Me.txtCategorySort.DataField = "CategorySort"
        Me.txtCategorySort.Height = 0.1875!
        Me.txtCategorySort.Left = 0.34375!
        Me.txtCategorySort.Name = "txtCategorySort"
        Me.txtCategorySort.Text = "TextBox2"
        Me.txtCategorySort.Top = 0.3020833!
        Me.txtCategorySort.Visible = False
        Me.txtCategorySort.Width = 0.8229167!
        '
        'gfCategory
        '
        Me.gfCategory.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.Label20, Me.txtTotalExtension, Me.Line2, Me.txtTotalQty})
        Me.gfCategory.Height = 0.3333333!
        Me.gfCategory.Name = "gfCategory"
        '
        'TextBox1
        '
        Me.TextBox1.CanGrow = False
        Me.TextBox1.DataField = "Category"
        Me.TextBox1.Height = 0.1979167!
        Me.TextBox1.Left = 0.1539998!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 11pt; font-weight: bold; text-align: right; text-decoration: underline" & _
            "; ddo-char-set: 1"
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 7.887001!
        '
        'Label20
        '
        Me.Label20.Height = 0.17!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 8.041!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-size: 9pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label20.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label20.Top = 0.0!
        Me.Label20.Width = 0.6250002!
        '
        'txtTotalExtension
        '
        Me.txtTotalExtension.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalExtension.Height = 0.17!
        Me.txtTotalExtension.Left = 9.17!
        Me.txtTotalExtension.Name = "txtTotalExtension"
        Me.txtTotalExtension.OutputFormat = resources.GetString("txtTotalExtension.OutputFormat")
        Me.txtTotalExtension.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalExtension.Text = "TextBox1"
        Me.txtTotalExtension.Top = 0.0!
        Me.txtTotalExtension.Width = 0.8299999!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.24!
        Me.Line2.Width = 10.0!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 10.0!
        Me.Line2.Y1 = 0.24!
        Me.Line2.Y2 = 0.24!
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalQty.DataField = "Qty"
        Me.txtTotalQty.Height = 0.17!
        Me.txtTotalQty.Left = 8.67!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalQty.Text = "TextBox1"
        Me.txtTotalQty.Top = 0.0!
        Me.txtTotalQty.Width = 0.5!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label3, Me.txtGrandTotal})
        Me.GroupFooter1.Height = 0.25!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label3
        '
        Me.Label3.Height = 0.17!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 7.571001!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 9pt; font-weight: bold; text-align: right; ddo-char-set: 1"
        Me.Label3.Text = "Total For Estimate:"
        Me.Label3.Top = 0.08000001!
        Me.Label3.Width = 1.307!
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Height = 0.17!
        Me.txtGrandTotal.Left = 9.17!
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.OutputFormat = resources.GetString("txtGrandTotal.OutputFormat")
        Me.txtGrandTotal.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtGrandTotal.Text = "TextBox1"
        Me.txtGrandTotal.Top = 0.08000001!
        Me.txtGrandTotal.Width = 0.83!
        '
        'rptDoorEstimateReport
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.3!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.0!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.ghCategory)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.gfCategory)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.lblReportTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJobName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHeadFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblElevType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJambFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescComment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtElevType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHeadFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJambFace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtListPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdj4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdj3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdj2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdj1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategorySort, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalExtension, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrandTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents txtPageCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents lblPageNumber As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtPageNumber As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDateTime As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReportTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblSeries As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtProjectName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtJobName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblHeadFace As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblElevType As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblJambFace As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents ghCategory As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents txtCategory As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents gfCategory As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents txtDescComment As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSize As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtElevType As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtHeadFace As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtJambFace As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtSeries As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGa As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtST As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtListPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAdj4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExtension As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNetPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtTotalExtension As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents txtTotalQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAdj3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAdj2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAdj1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtAdj As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents chkNC As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private WithEvents txtNC As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtCategorySort As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtGrandTotal As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class

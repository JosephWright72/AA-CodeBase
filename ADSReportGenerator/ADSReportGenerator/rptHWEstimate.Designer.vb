<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptHWEstimate
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptHWEstimate))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblReportTitle = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtProjectName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPrjDesc = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblNetCost = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.txtHwdID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtDescription = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtQuantity = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtListPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtAdjustment1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtNetCost = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.lblPageNumber = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtPageNumber = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtPageCount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.lblDateTime = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ghManufacturer = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.txtManufacturer = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.gfManufacturer = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalListPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtTotalExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.txtGrandTotalListPrice = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtGrandTotalExtended = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblReportTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrjDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNetCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHwdID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtListPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAdjustment1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtended, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManufacturer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalListPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalExtended, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrandTotalListPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrandTotalExtended, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label6, Me.lblReportTitle, Me.Label9, Me.txtProjectName, Me.txtPrjDesc, Me.Label11, Me.lblNetCost, Me.Label13})
        Me.PageHeader1.Height = 1.02!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label1
        '
        Me.Label1.Height = 0.2395833!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 9.75pt; font-weight: bold; text-align: left; text-decoration: underlin" & _
    "e; vertical-align: middle; ddo-char-set: 0"
        Me.Label1.Text = "Hdw ID"
        Me.Label1.Top = 0.7820001!
        Me.Label1.Width = 0.9960001!
        '
        'Label2
        '
        Me.Label2.Height = 0.2395833!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.9960001!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 9.75pt; font-weight: bold; text-align: left; text-decoration: underlin" & _
    "e; vertical-align: middle; ddo-char-set: 0"
        Me.Label2.Text = "Description"
        Me.Label2.Top = 0.7820001!
        Me.Label2.Width = 3.162!
        '
        'Label3
        '
        Me.Label3.Height = 0.2395833!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.158!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: underli" & _
    "ne; vertical-align: middle; ddo-char-set: 0"
        Me.Label3.Text = "Quantity"
        Me.Label3.Top = 0.7820001!
        Me.Label3.Width = 0.652!
        '
        'Label4
        '
        Me.Label4.Height = 0.2395833!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.81!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: underli" & _
    "ne; vertical-align: middle; ddo-char-set: 0"
        Me.Label4.Text = "List Price"
        Me.Label4.Top = 0.7820001!
        Me.Label4.Width = 1.069!
        '
        'Label6
        '
        Me.Label6.Height = 0.2395833!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.132!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: none; v" & _
    "ertical-align: middle; ddo-char-set: 1"
        Me.Label6.Text = "Project ID:"
        Me.Label6.Top = 0.5420001!
        Me.Label6.Width = 1.048!
        '
        'lblReportTitle
        '
        Me.lblReportTitle.Height = 0.302!
        Me.lblReportTitle.HyperLink = Nothing
        Me.lblReportTitle.Left = 0.0!
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Style = "font-size: 18pt; text-align: center; ddo-char-set: 1"
        Me.lblReportTitle.Text = "Hardware Estimate Report"
        Me.lblReportTitle.Top = 0.0!
        Me.lblReportTitle.Width = 10.0!
        '
        'Label9
        '
        Me.Label9.Height = 0.2395833!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.132!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: none; v" & _
    "ertical-align: middle; ddo-char-set: 1"
        Me.Label9.Text = "Project Name:"
        Me.Label9.Top = 0.3019997!
        Me.Label9.Width = 1.048!
        '
        'txtProjectName
        '
        Me.txtProjectName.DataField = "ProjectName"
        Me.txtProjectName.Height = 0.2399167!
        Me.txtProjectName.Left = 4.180004!
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Style = "vertical-align: middle"
        Me.txtProjectName.Text = "TextBox1"
        Me.txtProjectName.Top = 0.3019998!
        Me.txtProjectName.Width = 4.52!
        '
        'txtPrjDesc
        '
        Me.txtPrjDesc.DataField = "ProjectID"
        Me.txtPrjDesc.Height = 0.2399167!
        Me.txtPrjDesc.Left = 4.180004!
        Me.txtPrjDesc.Name = "txtPrjDesc"
        Me.txtPrjDesc.Style = "vertical-align: middle"
        Me.txtPrjDesc.Text = "TextBox1"
        Me.txtPrjDesc.Top = 0.5420001!
        Me.txtPrjDesc.Width = 4.52!
        '
        'Label11
        '
        Me.Label11.Height = 0.2395833!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.879!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 9.75pt; font-weight: bold; text-align: center; text-decoration: underl" & _
    "ine; vertical-align: middle; ddo-char-set: 0"
        Me.Label11.Text = "Adjustments"
        Me.Label11.Top = 0.7820001!
        Me.Label11.Visible = False
        Me.Label11.Width = 1.993!
        '
        'lblNetCost
        '
        Me.lblNetCost.Height = 0.2395833!
        Me.lblNetCost.HyperLink = Nothing
        Me.lblNetCost.Left = 7.872!
        Me.lblNetCost.Name = "lblNetCost"
        Me.lblNetCost.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: underli" & _
    "ne; vertical-align: middle; ddo-char-set: 0"
        Me.lblNetCost.Text = "Net Cost"
        Me.lblNetCost.Top = 0.7820001!
        Me.lblNetCost.Visible = False
        Me.lblNetCost.Width = 0.9960008!
        '
        'Label13
        '
        Me.Label13.Height = 0.2395833!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 8.931001!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; text-decoration: underli" & _
    "ne; vertical-align: middle; ddo-char-set: 0"
        Me.Label13.Text = "Extended"
        Me.Label13.Top = 0.7820001!
        Me.Label13.Width = 1.069!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtHwdID, Me.txtDescription, Me.txtQuantity, Me.txtListPrice, Me.txtAdjustment1, Me.txtNetCost, Me.txtExtended})
        Me.Detail1.Height = 0.17!
        Me.Detail1.Name = "Detail1"
        '
        'txtHwdID
        '
        Me.txtHwdID.DataField = "Product"
        Me.txtHwdID.Height = 0.17!
        Me.txtHwdID.Left = 0.0!
        Me.txtHwdID.Name = "txtHwdID"
        Me.txtHwdID.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.txtHwdID.Text = "TextBox1"
        Me.txtHwdID.Top = 0.0!
        Me.txtHwdID.Width = 0.996!
        '
        'txtDescription
        '
        Me.txtDescription.DataField = "Description"
        Me.txtDescription.Height = 0.17!
        Me.txtDescription.Left = 0.9960001!
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.txtDescription.Text = "TextBox1"
        Me.txtDescription.Top = 0.0!
        Me.txtDescription.Width = 3.162!
        '
        'txtQuantity
        '
        Me.txtQuantity.DataField = "Qty"
        Me.txtQuantity.Height = 0.17!
        Me.txtQuantity.Left = 4.158!
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtQuantity.Text = "TextBox1"
        Me.txtQuantity.Top = 0.0!
        Me.txtQuantity.Width = 0.652!
        '
        'txtListPrice
        '
        Me.txtListPrice.DataField = "Price"
        Me.txtListPrice.Height = 0.17!
        Me.txtListPrice.Left = 4.81!
        Me.txtListPrice.Name = "txtListPrice"
        Me.txtListPrice.OutputFormat = resources.GetString("txtListPrice.OutputFormat")
        Me.txtListPrice.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtListPrice.Text = "TextBox1"
        Me.txtListPrice.Top = 0.0!
        Me.txtListPrice.Width = 1.069!
        '
        'txtAdjustment1
        '
        Me.txtAdjustment1.Height = 0.17!
        Me.txtAdjustment1.Left = 5.879!
        Me.txtAdjustment1.Name = "txtAdjustment1"
        Me.txtAdjustment1.OutputFormat = resources.GetString("txtAdjustment1.OutputFormat")
        Me.txtAdjustment1.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtAdjustment1.Text = "0"
        Me.txtAdjustment1.Top = 0.0!
        Me.txtAdjustment1.Visible = False
        Me.txtAdjustment1.Width = 1.181!
        '
        'txtNetCost
        '
        Me.txtNetCost.Height = 0.17!
        Me.txtNetCost.Left = 7.872!
        Me.txtNetCost.Name = "txtNetCost"
        Me.txtNetCost.OutputFormat = resources.GetString("txtNetCost.OutputFormat")
        Me.txtNetCost.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtNetCost.Text = "TextBox1"
        Me.txtNetCost.Top = 0.0!
        Me.txtNetCost.Visible = False
        Me.txtNetCost.Width = 0.9960003!
        '
        'txtExtended
        '
        Me.txtExtended.Height = 0.17!
        Me.txtExtended.Left = 8.931001!
        Me.txtExtended.Name = "txtExtended"
        Me.txtExtended.OutputFormat = resources.GetString("txtExtended.OutputFormat")
        Me.txtExtended.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtExtended.Text = "TextBox1"
        Me.txtExtended.Top = 0.0!
        Me.txtExtended.Width = 1.069!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblPageNumber, Me.txtPageNumber, Me.txtPageCount, Me.Label10, Me.lblDateTime})
        Me.PageFooter1.Height = 0.3366667!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'lblPageNumber
        '
        Me.lblPageNumber.Height = 0.17!
        Me.lblPageNumber.HyperLink = Nothing
        Me.lblPageNumber.Left = 0.000001192093!
        Me.lblPageNumber.Name = "lblPageNumber"
        Me.lblPageNumber.Style = "font-size: 9pt; text-align: center; ddo-char-set: 1"
        Me.lblPageNumber.Text = "PageNumber"
        Me.lblPageNumber.Top = 0.149!
        Me.lblPageNumber.Width = 10.0!
        '
        'txtPageNumber
        '
        Me.txtPageNumber.Height = 0.1875!
        Me.txtPageNumber.Left = 1.390001!
        Me.txtPageNumber.Name = "txtPageNumber"
        Me.txtPageNumber.Style = "font-size: 8pt; font-style: italic; font-weight: bold; text-align: right; ddo-cha" & _
    "r-set: 1"
        Me.txtPageNumber.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.txtPageNumber.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.txtPageNumber.Text = "Page"
        Me.txtPageNumber.Top = 0.149!
        Me.txtPageNumber.Visible = False
        Me.txtPageNumber.Width = 0.5!
        '
        'txtPageCount
        '
        Me.txtPageCount.Height = 0.1875!
        Me.txtPageCount.Left = 2.14!
        Me.txtPageCount.Name = "txtPageCount"
        Me.txtPageCount.Style = "font-size: 8pt; font-style: italic; font-weight: bold; ddo-char-set: 1"
        Me.txtPageCount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.txtPageCount.Text = "NO"
        Me.txtPageCount.Top = 0.149!
        Me.txtPageCount.Visible = False
        Me.txtPageCount.Width = 0.5!
        '
        'Label10
        '
        Me.Label10.Height = 0.17!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.000001192093!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.Label10.Text = "ASSA ABLOY Openings Studio"
        Me.Label10.Top = 0.149!
        Me.Label10.Width = 2.139999!
        '
        'lblDateTime
        '
        Me.lblDateTime.Height = 0.17!
        Me.lblDateTime.HyperLink = Nothing
        Me.lblDateTime.Left = 8.041001!
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.lblDateTime.Text = "DateTime"
        Me.lblDateTime.Top = 0.149!
        Me.lblDateTime.Width = 1.959!
        '
        'ghManufacturer
        '
        Me.ghManufacturer.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.txtManufacturer, Me.Line1})
        Me.ghManufacturer.DataField = "Name"
        Me.ghManufacturer.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.FirstDetail
        Me.ghManufacturer.Height = 0.2083333!
        Me.ghManufacturer.KeepTogether = True
        Me.ghManufacturer.Name = "ghManufacturer"
        Me.ghManufacturer.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtManufacturer
        '
        Me.txtManufacturer.DataField = "Name"
        Me.txtManufacturer.Height = 0.1979167!
        Me.txtManufacturer.Left = 0.0!
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Style = "font-size: 11pt; font-weight: bold; text-decoration: underline; ddo-char-set: 1"
        Me.txtManufacturer.Text = "TextBox1"
        Me.txtManufacturer.Top = 0.0!
        Me.txtManufacturer.Width = 10.0!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 10.0!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 10.0!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'gfManufacturer
        '
        Me.gfManufacturer.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.txtTotalQty, Me.txtTotalListPrice, Me.Label5, Me.Label14, Me.txtTotalExtended})
        Me.gfManufacturer.Height = 0.1875833!
        Me.gfManufacturer.KeepTogether = True
        Me.gfManufacturer.Name = "gfManufacturer"
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "Name"
        Me.TextBox1.Height = 0.1979167!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 11pt; font-weight: bold; text-align: right; text-decoration: underline" & _
    "; ddo-char-set: 1"
        Me.TextBox1.Text = "TextBox1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Visible = False
        Me.TextBox1.Width = 2.662!
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalQty.Height = 0.17!
        Me.txtTotalQty.Left = 4.158!
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalQty.Text = "TextBox1"
        Me.txtTotalQty.Top = 0.0!
        Me.txtTotalQty.Visible = False
        Me.txtTotalQty.Width = 0.652!
        '
        'txtTotalListPrice
        '
        Me.txtTotalListPrice.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalListPrice.Height = 0.17!
        Me.txtTotalListPrice.Left = 4.81!
        Me.txtTotalListPrice.Name = "txtTotalListPrice"
        Me.txtTotalListPrice.OutputFormat = resources.GetString("txtTotalListPrice.OutputFormat")
        Me.txtTotalListPrice.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalListPrice.Text = "TextBox1"
        Me.txtTotalListPrice.Top = 0.0!
        Me.txtTotalListPrice.Visible = False
        Me.txtTotalListPrice.Width = 1.069!
        '
        'Label5
        '
        Me.Label5.Height = 0.17!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.138!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 9pt; ddo-char-set: 1"
        Me.Label5.Text = "Extended Cost"
        Me.Label5.Top = 0.0!
        Me.Label5.Visible = False
        Me.Label5.Width = 1.02!
        '
        'Label14
        '
        Me.Label14.Height = 0.17!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 7.911!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.Label14.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label14.Top = 0.0!
        Me.Label14.Width = 0.957!
        '
        'txtTotalExtended
        '
        Me.txtTotalExtended.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.txtTotalExtended.Height = 0.17!
        Me.txtTotalExtended.Left = 8.931001!
        Me.txtTotalExtended.Name = "txtTotalExtended"
        Me.txtTotalExtended.OutputFormat = resources.GetString("txtTotalExtended.OutputFormat")
        Me.txtTotalExtended.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtTotalExtended.Text = "TextBox1"
        Me.txtTotalExtended.Top = 0.0!
        Me.txtTotalExtended.Width = 1.069!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label7, Me.txtGrandTotalListPrice, Me.txtGrandTotalExtended})
        Me.ReportFooter1.Height = 0.3543333!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'Label7
        '
        Me.Label7.Height = 0.2291667!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.690001!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-size: 11pt; font-weight: bold; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.Label7.Text = "Total For Estimate:"
        Me.Label7.Top = 0.08000001!
        Me.Label7.Width = 2.010417!
        '
        'txtGrandTotalListPrice
        '
        Me.txtGrandTotalListPrice.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.txtGrandTotalListPrice.Height = 0.17!
        Me.txtGrandTotalListPrice.Left = 4.81!
        Me.txtGrandTotalListPrice.Name = "txtGrandTotalListPrice"
        Me.txtGrandTotalListPrice.OutputFormat = resources.GetString("txtGrandTotalListPrice.OutputFormat")
        Me.txtGrandTotalListPrice.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtGrandTotalListPrice.Text = "TextBox1"
        Me.txtGrandTotalListPrice.Top = 0.08000001!
        Me.txtGrandTotalListPrice.Visible = False
        Me.txtGrandTotalListPrice.Width = 1.069!
        '
        'txtGrandTotalExtended
        '
        Me.txtGrandTotalExtended.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.txtGrandTotalExtended.Height = 0.17!
        Me.txtGrandTotalExtended.Left = 8.828!
        Me.txtGrandTotalExtended.Name = "txtGrandTotalExtended"
        Me.txtGrandTotalExtended.OutputFormat = resources.GetString("txtGrandTotalExtended.OutputFormat")
        Me.txtGrandTotalExtended.Style = "font-size: 9pt; text-align: right; ddo-char-set: 1"
        Me.txtGrandTotalExtended.Text = "TextBox1"
        Me.txtGrandTotalExtended.Top = 0.08000001!
        Me.txtGrandTotalExtended.Width = 1.172!
        '
        'rptHWEstimate
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.5!
        Me.PageSettings.Margins.Left = 0.5!
        Me.PageSettings.Margins.Right = 0.5!
        Me.PageSettings.Margins.Top = 0.5!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.0!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.ghManufacturer)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.gfManufacturer)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
            "lic", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblReportTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrjDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNetCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHwdID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtListPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAdjustment1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtended, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManufacturer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalListPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalExtended, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrandTotalListPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrandTotalExtended, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents txtHwdID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblReportTitle As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtDescription As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtQuantity As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtListPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ghManufacturer As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents gfManufacturer As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents txtManufacturer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtProjectName As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPrjDesc As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtTotalListPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtPageNumber As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtPageCount As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblDateTime As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblPageNumber As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents lblNetCost As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtAdjustment1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtNetCost As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtExtended As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtTotalExtended As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Private WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Private WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtGrandTotalListPrice As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents txtGrandTotalExtended As GrapeCity.ActiveReports.SectionReportModel.TextBox

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class

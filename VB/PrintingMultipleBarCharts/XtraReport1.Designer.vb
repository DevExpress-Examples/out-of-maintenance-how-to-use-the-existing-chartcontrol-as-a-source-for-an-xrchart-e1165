Imports Microsoft.VisualBasic
Imports System
Namespace PrintingMultipleBarCharts
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim sideBySideBarSeriesLabel4 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.xrChart4 = New DevExpress.XtraReports.UI.XRChart()
			Me.xrChart3 = New DevExpress.XtraReports.UI.XRChart()
			Me.xrChart2 = New DevExpress.XtraReports.UI.XRChart()
			Me.xrChart1 = New DevExpress.XtraReports.UI.XRChart()
			CType(Me.xrChart4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrChart3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrChart2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChart1, Me.xrChart2, Me.xrChart3, Me.xrChart4})
			Me.Detail.Height = 645
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrChart4
			' 
			Me.xrChart4.BorderColor = System.Drawing.SystemColors.ControlText
			Me.xrChart4.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart4.Location = New System.Drawing.Point(333, 358)
			Me.xrChart4.Name = "xrChart4"
			Me.xrChart4.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel4.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.xrChart4.SeriesTemplate.Label = sideBySideBarSeriesLabel4
			Me.xrChart4.Size = New System.Drawing.Size(308, 275)
			' 
			' xrChart3
			' 
			Me.xrChart3.BorderColor = System.Drawing.SystemColors.ControlText
			Me.xrChart3.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart3.Location = New System.Drawing.Point(8, 358)
			Me.xrChart3.Name = "xrChart3"
			Me.xrChart3.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.xrChart3.SeriesTemplate.Label = sideBySideBarSeriesLabel3
			Me.xrChart3.Size = New System.Drawing.Size(317, 275)
			' 
			' xrChart2
			' 
			Me.xrChart2.BorderColor = System.Drawing.SystemColors.ControlText
			Me.xrChart2.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart2.Location = New System.Drawing.Point(333, 8)
			Me.xrChart2.Name = "xrChart2"
			Me.xrChart2.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.xrChart2.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.xrChart2.Size = New System.Drawing.Size(308, 283)
			' 
			' xrChart1
			' 
			Me.xrChart1.BorderColor = System.Drawing.SystemColors.ControlText
			Me.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChart1.Location = New System.Drawing.Point(17, 8)
			Me.xrChart1.Name = "xrChart1"
			Me.xrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
			Me.xrChart1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.xrChart1.Size = New System.Drawing.Size(308, 283)
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.Version = "8.2"
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChart1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Public Detail As DevExpress.XtraReports.UI.DetailBand
		Public xrChart1 As DevExpress.XtraReports.UI.XRChart
		Public xrChart2 As DevExpress.XtraReports.UI.XRChart
		Public xrChart3 As DevExpress.XtraReports.UI.XRChart
		Public xrChart4 As DevExpress.XtraReports.UI.XRChart
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace PrintingMultipleBarCharts
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel1 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(129))}, 0)
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(256))}, 1)
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(12562))}, 2)
			Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieSeriesLabel2 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView2 As New DevExpress.XtraCharts.PieSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pieSeriesLabel3 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (CObj(477))}, 0)
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (CObj(52))}, 1)
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (CObj(123))}, 2)
			Dim pieSeriesView3 As New DevExpress.XtraCharts.PieSeriesView()
			Dim pieSeriesLabel4 As New DevExpress.XtraCharts.PieSeriesLabel()
			Dim pieSeriesView4 As New DevExpress.XtraCharts.PieSeriesView()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(171))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(135))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(57))})
			Dim sideBySideBarSeriesLabel2 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim xyDiagram2 As New DevExpress.XtraCharts.XYDiagram()
			Dim series4 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel3 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(96))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(148))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(300))})
			Dim series5 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel4 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(86))})
			Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(123))})
			Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(150))})
			Dim series6 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel5 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint("1", New Object() { (CObj(30))})
			Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint("2", New Object() { (CObj(111))})
			Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint("3", New Object() { (CObj(120))})
			Dim sideBySideBarSeriesLabel6 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.chartControl2 = New DevExpress.XtraCharts.ChartControl()
			Me.chartControl3 = New DevExpress.XtraCharts.ChartControl()
			Me.chartControl4 = New DevExpress.XtraCharts.ChartControl()
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pieSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chartControl4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Location = New System.Drawing.Point(42, 6)
			Me.chartControl1.Name = "chartControl1"
			pieSeriesLabel1.LineVisible = True
			series1.Label = pieSeriesLabel1
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3})
			pieSeriesView1.RuntimeExploding = False
			series1.View = pieSeriesView1
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			pieSeriesLabel2.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = pieSeriesLabel2
			pieSeriesView2.RuntimeExploding = False
			Me.chartControl1.SeriesTemplate.View = pieSeriesView2
			Me.chartControl1.Size = New System.Drawing.Size(284, 243)
			Me.chartControl1.TabIndex = 0
			' 
			' chartControl2
			' 
			Me.chartControl2.Location = New System.Drawing.Point(394, 6)
			Me.chartControl2.Name = "chartControl2"
			pieSeriesLabel3.LineVisible = True
			series2.Label = pieSeriesLabel3
			series2.Name = "Series 1"
			series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint4, seriesPoint5, seriesPoint6})
			pieSeriesView3.RuntimeExploding = False
			series2.View = pieSeriesView3
			Me.chartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			pieSeriesLabel4.LineVisible = True
			Me.chartControl2.SeriesTemplate.Label = pieSeriesLabel4
			pieSeriesView4.RuntimeExploding = False
			Me.chartControl2.SeriesTemplate.View = pieSeriesView4
			Me.chartControl2.Size = New System.Drawing.Size(285, 239)
			Me.chartControl2.TabIndex = 1
			' 
			' chartControl3
			' 
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl3.Diagram = xyDiagram1
			Me.chartControl3.Location = New System.Drawing.Point(42, 294)
			Me.chartControl3.Name = "chartControl3"
			sideBySideBarSeriesLabel1.LineVisible = True
			series3.Label = sideBySideBarSeriesLabel1
			series3.Name = "Series 1"
			series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint7, seriesPoint8, seriesPoint9})
			Me.chartControl3.SeriesSerializable = New DevExpress.XtraCharts.Series() { series3}
			sideBySideBarSeriesLabel2.LineVisible = True
			Me.chartControl3.SeriesTemplate.Label = sideBySideBarSeriesLabel2
			Me.chartControl3.Size = New System.Drawing.Size(284, 200)
			Me.chartControl3.TabIndex = 2
			' 
			' chartControl4
			' 
			xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisX.Range.SideMarginsEnabled = True
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram2.AxisY.Range.SideMarginsEnabled = True
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl4.Diagram = xyDiagram2
			Me.chartControl4.Location = New System.Drawing.Point(394, 294)
			Me.chartControl4.Name = "chartControl4"
			sideBySideBarSeriesLabel3.LineVisible = True
			series4.Label = sideBySideBarSeriesLabel3
			series4.Name = "Series 1"
			series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint10, seriesPoint11, seriesPoint12})
			sideBySideBarSeriesLabel4.LineVisible = True
			series5.Label = sideBySideBarSeriesLabel4
			series5.Name = "Series 2"
			series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint13, seriesPoint14, seriesPoint15})
			sideBySideBarSeriesLabel5.LineVisible = True
			series6.Label = sideBySideBarSeriesLabel5
			series6.Name = "Series 3"
			series6.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint16, seriesPoint17, seriesPoint18})
			Me.chartControl4.SeriesSerializable = New DevExpress.XtraCharts.Series() { series4, series5, series6}
			sideBySideBarSeriesLabel6.LineVisible = True
			Me.chartControl4.SeriesTemplate.Label = sideBySideBarSeriesLabel6
			Me.chartControl4.Size = New System.Drawing.Size(285, 200)
			Me.chartControl4.TabIndex = 3
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(301, 500)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(122, 43)
			Me.button1.TabIndex = 4
			Me.button1.Text = "PrintPreview"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(758, 577)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.chartControl4)
			Me.Controls.Add(Me.chartControl3)
			Me.Controls.Add(Me.chartControl2)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(pieSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pieSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private chartControl2 As DevExpress.XtraCharts.ChartControl
		Private chartControl3 As DevExpress.XtraCharts.ChartControl
		Private chartControl4 As DevExpress.XtraCharts.ChartControl
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace


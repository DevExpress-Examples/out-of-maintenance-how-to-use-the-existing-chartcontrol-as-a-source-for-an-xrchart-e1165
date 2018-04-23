Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts.Native
' ...

Namespace PrintingMultipleBarCharts
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()

			CType(report.xrChart1, IChartContainer).Chart.Assign((CType(chartControl1, IChartContainer)).Chart)
			CType(report.xrChart2, IChartContainer).Chart.Assign((CType(chartControl2, IChartContainer)).Chart)
			CType(report.xrChart3, IChartContainer).Chart.Assign((CType(chartControl3, IChartContainer)).Chart)
			CType(report.xrChart4, IChartContainer).Chart.Assign((CType(chartControl4, IChartContainer)).Chart)

			report.ShowPreview()
		End Sub

	End Class
End Namespace
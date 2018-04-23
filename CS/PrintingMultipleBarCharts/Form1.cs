using System;
using System.Windows.Forms;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;
// ...

namespace PrintingMultipleBarCharts {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ((IChartContainer)report.xrChart1).Chart.Assign(((IChartContainer)chartControl1).Chart);
            ((IChartContainer)report.xrChart2).Chart.Assign(((IChartContainer)chartControl2).Chart);
            ((IChartContainer)report.xrChart3).Chart.Assign(((IChartContainer)chartControl3).Chart);
            ((IChartContainer)report.xrChart4).Chart.Assign(((IChartContainer)chartControl4).Chart);
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreview();
        }
    }
}
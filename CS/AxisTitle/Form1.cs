using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraCharts;

namespace AxisTitle {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl chartControl1 = new ChartControl();

            // Create a bar series and add points to it.
            Series series1 = new Series("Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 17 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("E", new double[] { 17 }));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Hide the legend (if necessary).
            chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;

            // Customize the appearance of the X-axis title.
            diagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisX.Title.Alignment = StringAlignment.Center;
            diagram.AxisX.Title.Text = "<i>X-axis</i> <color=violet>Title</color>";
            diagram.AxisX.Title.TextColor = Color.Red;
            diagram.AxisX.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisX.Title.DXFont = new DXFont("Tahoma", 14, DXFontStyle.Bold);

            // Customize the appearance of the Y-axis title.
            diagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.Alignment = StringAlignment.Center;
            diagram.AxisY.Title.Text = "Y-axis Title";
            diagram.AxisY.Title.TextColor = Color.Blue;
            diagram.AxisY.Title.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            diagram.AxisY.Title.DXFont = new DXFont("Tahoma", 14, DXFontStyle.Bold);

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }
    }
}

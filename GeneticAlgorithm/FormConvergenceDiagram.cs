using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeneticAlgorithm
{
    public partial class FormConvergenceDiagram : Form
    {
        public GeneticAlgorithm.ExecutionResult GAResults { set; get; }

        public FormConvergenceDiagram()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConvergenceDiagram_Load(object sender, EventArgs e)
        {
            DrawChart();
            numZoom_ValueChanged(sender, e);
        }

        private void DrawChart()
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = chartConvDiagram.Series[0];
            System.Windows.Forms.DataVisualization.Charting.DataPoint p;

            // Set MarkerStyle of DataPoints
            s.MarkerStyle =
                (chkMarkers.Checked) ? System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                : System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;

            for (int i = 0; i < GAResults.NumberOfGenerations; i++)
            {
                p = new System.Windows.Forms.DataVisualization.Charting.DataPoint(i + 1, (double)Math.Abs(GAResults.BestChromosomes[i].FitnessValue));
                p.ToolTip = p.YValues[0].ToString();
                s.Points.Add(p);
            }

        }

        private void chkShowFitnessValue_CheckedChanged(object sender, EventArgs e)
        {
            chartConvDiagram.Series[0].IsValueShownAsLabel = ((CheckBox)sender).Checked;
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            chartConvDiagram.ChartAreas[0].AxisX.MajorGrid.Enabled = ((CheckBox)sender).Checked;
            chartConvDiagram.ChartAreas[0].AxisY.MajorGrid.Enabled = ((CheckBox)sender).Checked;
        }

        private void numZoom_ValueChanged(object sender, EventArgs e)
        {
            double delta;
            delta = (double)(1 - numZoom.Value);
            chartConvDiagram.ChartAreas[0].AxisY.Minimum =
                Math.Abs(GAResults.BestChromosomes[GAResults.NumberOfGenerations - 1].FitnessValue) - delta;
            chartConvDiagram.ChartAreas[0].AxisY.Maximum =
                Math.Abs(GAResults.BestChromosomes[0].FitnessValue) + delta;

        }

        private void chkMarkers_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = chartConvDiagram.Series[0];
            s.MarkerStyle =
                (chkMarkers.Checked) ? System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                : System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
        }
    }
}

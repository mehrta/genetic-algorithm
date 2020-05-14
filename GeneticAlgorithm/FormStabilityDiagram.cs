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
    public partial class FormStabilityDiagram : Form
    {
        public FormMain MainForm { set; get; }
        private double _minFitness, _maxFitness;

        public FormStabilityDiagram()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DrawChart()
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = chartStabilityDiagram.Series[0];
            System.Windows.Forms.DataVisualization.Charting.DataPoint p;
            
            // Create GeneticAlgorithm Object and set it
            GeneticAlgorithm ga = new GeneticAlgorithm();
            GeneticAlgorithm.ExecutionResult res;
            ga.PopulationSize = (int)MainForm.numPopSize.Value;
            ga.ProbabilityOfCrossover = (float)MainForm.numCrossover.Value;
            ga.ProbabilityOfMutation = (float)MainForm.numMutation.Value;
            ga.Termination.MaxNumberOfGenerations = (int)MainForm.numMaxGenerations.Value;
            ga.Termination.MaxUselessIterations = (int)MainForm.numMaxUselessIterations.Value;
            ga.Termination.UselessIterationFactor = (float)MainForm.numUselessIterationFactor.Value;
            GeneticAlgorithm.SpaceQuantizationDecimalPlaces = MainForm.cmbSpaceQuantizationFactor.SelectedIndex + 1;

            // Draw Chart
            s.Points.Clear();
            s.MarkerStyle =
                (chkMarkers.Checked) ? System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                : System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;

            _minFitness = Double.PositiveInfinity;
            _maxFitness = Double.NegativeInfinity;

            for (int i = 0; i < (int)numExecutions.Value; i++)
            {
                res = ga.Run();

                p = new System.Windows.Forms.DataVisualization.Charting.DataPoint
                    (i + 1, (double)Math.Abs(res.BestChromosomes[res.NumberOfGenerations-1].FitnessValue));
                p.ToolTip = p.YValues[0].ToString();
                s.Points.Add(p);

                // Find minimum and maximum of fitnesses
                if (p.YValues[0] < _minFitness)
                    _minFitness = p.YValues[0];
                if (p.YValues[0] > _maxFitness)
                    _maxFitness = p.YValues[0];
            }

        }

        private void chkShowFitnessValue_CheckedChanged(object sender, EventArgs e)
        {
            chartStabilityDiagram.Series[0].IsValueShownAsLabel = ((CheckBox)sender).Checked;
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            chartStabilityDiagram.ChartAreas[0].AxisX.MajorGrid.Enabled = ((CheckBox)sender).Checked;
            chartStabilityDiagram.ChartAreas[0].AxisY.MajorGrid.Enabled = ((CheckBox)sender).Checked;
        }

        private void numZoom_ValueChanged(object sender, EventArgs e)
        {
                double delta;
                delta = (double)(1 - numZoom.Value);
                chartStabilityDiagram.ChartAreas[0].AxisY.Minimum = _minFitness - delta;
                chartStabilityDiagram.ChartAreas[0].AxisY.Maximum = _maxFitness + delta;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            DrawChart();
            numZoom_ValueChanged(sender, e);
        }

        private void chkMarkers_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Series s = chartStabilityDiagram.Series[0];
            s.MarkerStyle =
                (chkMarkers.Checked) ? System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
                : System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
        }
    }
}

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
    public partial class FormMain : Form
    {
        private GeneticAlgorithm.ExecutionResult _gaResults;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtInputFilePath.Text = openFileDialog1.FileName;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Check User Input
            
            if (txtInputFilePath.Text.Trim() == "" || (!System.IO.File.Exists(txtInputFilePath.Text)))
            {
                MessageBox.Show("Please choose an input file that contains problem parameters.", "Invalid input");
                return;
            } 

            // Load Problem Parameters
            bool err;
            err = ProblemParameters.Load(txtInputFilePath.Text);
            if(err)
            {
                MessageBox.Show("Invalid input file, please verify content of input file.", "Invalid input file");
                return;
            }

            // Create GeneticAlgorithm Object and set it
            GeneticAlgorithm ga = new GeneticAlgorithm();
            ga.PopulationSize = (int)numPopSize.Value;
            ga.ProbabilityOfCrossover = (float)numCrossover.Value;
            ga.ProbabilityOfMutation = (float)numMutation.Value;
            ga.Termination.MaxNumberOfGenerations = (int)numMaxGenerations.Value;
            ga.Termination.MaxUselessIterations = (int)numMaxUselessIterations.Value;
            ga.Termination.UselessIterationFactor = (float)numUselessIterationFactor.Value;
            GeneticAlgorithm.SpaceQuantizationDecimalPlaces = cmbSpaceQuantizationFactor.SelectedIndex + 1;
            
            // Run
            _gaResults = ga.Run();

            // Show Results
            Chromosome best;
            StringBuilder bestChromosomeGenomes = new StringBuilder(ProblemParameters.Dimension * 12);
            
            lblGenerations.Text = _gaResults.NumberOfGenerations.ToString();
            best = _gaResults.BestChromosomes[_gaResults.NumberOfGenerations - 1];
            lblBestChromosomeFitness.Text = best.FitnessValue.ToString();
            foreach (double genom in best.Genomes)
                bestChromosomeGenomes.Append(genom.ToString("F" + (GeneticAlgorithm.SpaceQuantizationDecimalPlaces).ToString()) + " ; ");
            txtBestChromosomeGenomes.Text = bestChromosomeGenomes.ToString();

            // Change GUI
            btnShowConvergenceDiagram.Enabled = true;
        }

        private void btnShowConvergenceDiagram_Click(object sender, EventArgs e)
        {
            FormConvergenceDiagram frmCD = new FormConvergenceDiagram();
            frmCD.GAResults = _gaResults;
            frmCD.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cmbSpaceQuantizationFactor.SelectedIndex = 2;
        }

        private void btnShowStabilityDiagram_Click(object sender, EventArgs e)
        {
            // Check User Input
            if (txtInputFilePath.Text.Trim() == "" || (!System.IO.File.Exists(txtInputFilePath.Text)))
            {
                MessageBox.Show("Please choose an input file that contains problem parameters.", "Invalid input");
                return;
            }

            // Load Problem Parameters
            bool err;
            err = ProblemParameters.Load(txtInputFilePath.Text);
            if (err)
            {
                MessageBox.Show("Invalid input file, please verify content of input file.", "Invalid input file");
                return;
            }

            // Show FormStabilityDiagram
            FormStabilityDiagram frmSD = new FormStabilityDiagram();

            frmSD.MainForm = this;
            frmSD.ShowDialog();
        }

        private void resetParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numPopSize.Value = 100;
            numCrossover.Value = (decimal)0.7;
            numMutation.Value = (decimal)0.01;
            numMaxGenerations.Value = 100;
            numMaxUselessIterations.Value = 3;
            numUselessIterationFactor.Value = (decimal)0.01;
            cmbSpaceQuantizationFactor.SelectedIndex = 2;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.MainForm = this;
            frmAbout.Show();
        }
    }
}

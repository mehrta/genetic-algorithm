namespace GeneticAlgorithm
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputFilePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenerations = new System.Windows.Forms.Label();
            this.txtBestChromosomeGenomes = new System.Windows.Forms.TextBox();
            this.lblBestChromosomeFitness = new System.Windows.Forms.Label();
            this.btnShowConvergenceDiagram = new System.Windows.Forms.Button();
            this.btnShowStabilityDiagram = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbSpaceQuantizationFactor = new System.Windows.Forms.ComboBox();
            this.numMutation = new System.Windows.Forms.NumericUpDown();
            this.numCrossover = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numUselessIterationFactor = new System.Windows.Forms.NumericUpDown();
            this.numMaxUselessIterations = new System.Windows.Forms.NumericUpDown();
            this.numMaxGenerations = new System.Windows.Forms.NumericUpDown();
            this.numPopSize = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showConvergenceDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showStabilityDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUselessIterationFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUselessIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputFilePath
            // 
            this.txtInputFilePath.Location = new System.Drawing.Point(65, 29);
            this.txtInputFilePath.Name = "txtInputFilePath";
            this.txtInputFilePath.Size = new System.Drawing.Size(362, 20);
            this.txtInputFilePath.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInputFilePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Problem Parameters";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(433, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(71, 24);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input File:";
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRun.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Location = new System.Drawing.Point(12, 362);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(166, 31);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lblGenerations);
            this.groupBox3.Controls.Add(this.txtBestChromosomeGenomes);
            this.groupBox3.Controls.Add(this.lblBestChromosomeFitness);
            this.groupBox3.Location = new System.Drawing.Point(12, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Best Chromosome Genomes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Generations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Best Chromosome Fitness:";
            // 
            // lblGenerations
            // 
            this.lblGenerations.AutoSize = true;
            this.lblGenerations.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblGenerations.Location = new System.Drawing.Point(153, 21);
            this.lblGenerations.Name = "lblGenerations";
            this.lblGenerations.Size = new System.Drawing.Size(14, 14);
            this.lblGenerations.TabIndex = 1;
            this.lblGenerations.Text = "0";
            // 
            // txtBestChromosomeGenomes
            // 
            this.txtBestChromosomeGenomes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBestChromosomeGenomes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBestChromosomeGenomes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtBestChromosomeGenomes.Location = new System.Drawing.Point(156, 60);
            this.txtBestChromosomeGenomes.Name = "txtBestChromosomeGenomes";
            this.txtBestChromosomeGenomes.Size = new System.Drawing.Size(348, 15);
            this.txtBestChromosomeGenomes.TabIndex = 0;
            // 
            // lblBestChromosomeFitness
            // 
            this.lblBestChromosomeFitness.AutoSize = true;
            this.lblBestChromosomeFitness.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBestChromosomeFitness.Location = new System.Drawing.Point(153, 41);
            this.lblBestChromosomeFitness.Name = "lblBestChromosomeFitness";
            this.lblBestChromosomeFitness.Size = new System.Drawing.Size(14, 14);
            this.lblBestChromosomeFitness.TabIndex = 1;
            this.lblBestChromosomeFitness.Text = "0";
            // 
            // btnShowConvergenceDiagram
            // 
            this.btnShowConvergenceDiagram.Enabled = false;
            this.btnShowConvergenceDiagram.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowConvergenceDiagram.Location = new System.Drawing.Point(184, 362);
            this.btnShowConvergenceDiagram.Name = "btnShowConvergenceDiagram";
            this.btnShowConvergenceDiagram.Size = new System.Drawing.Size(166, 31);
            this.btnShowConvergenceDiagram.TabIndex = 1;
            this.btnShowConvergenceDiagram.Text = "Show Convergence Diagram";
            this.btnShowConvergenceDiagram.UseVisualStyleBackColor = true;
            this.btnShowConvergenceDiagram.Click += new System.EventHandler(this.btnShowConvergenceDiagram_Click);
            // 
            // btnShowStabilityDiagram
            // 
            this.btnShowStabilityDiagram.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowStabilityDiagram.Location = new System.Drawing.Point(356, 362);
            this.btnShowStabilityDiagram.Name = "btnShowStabilityDiagram";
            this.btnShowStabilityDiagram.Size = new System.Drawing.Size(166, 31);
            this.btnShowStabilityDiagram.TabIndex = 2;
            this.btnShowStabilityDiagram.Text = "Show Stability Diagram";
            this.btnShowStabilityDiagram.UseVisualStyleBackColor = true;
            this.btnShowStabilityDiagram.Click += new System.EventHandler(this.btnShowStabilityDiagram_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbSpaceQuantizationFactor);
            this.groupBox4.Controls.Add(this.numMutation);
            this.groupBox4.Controls.Add(this.numCrossover);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numUselessIterationFactor);
            this.groupBox4.Controls.Add(this.numMaxUselessIterations);
            this.groupBox4.Controls.Add(this.numMaxGenerations);
            this.groupBox4.Controls.Add(this.numPopSize);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(12, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 132);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Genetic Algorithm Parameters";
            // 
            // cmbSpaceQuantizationFactor
            // 
            this.cmbSpaceQuantizationFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpaceQuantizationFactor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSpaceQuantizationFactor.FormattingEnabled = true;
            this.cmbSpaceQuantizationFactor.Items.AddRange(new object[] {
            "0.1",
            "0.01",
            "0.001",
            "0.0001",
            "0.00001",
            "1 * 10E-6",
            "1 * 10E-7",
            "1 * 10E-8",
            "1 * 10E-9"});
            this.cmbSpaceQuantizationFactor.Location = new System.Drawing.Point(148, 102);
            this.cmbSpaceQuantizationFactor.Name = "cmbSpaceQuantizationFactor";
            this.cmbSpaceQuantizationFactor.Size = new System.Drawing.Size(86, 22);
            this.cmbSpaceQuantizationFactor.TabIndex = 6;
            // 
            // numMutation
            // 
            this.numMutation.DecimalPlaces = 2;
            this.numMutation.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numMutation.Location = new System.Drawing.Point(148, 77);
            this.numMutation.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMutation.Name = "numMutation";
            this.numMutation.Size = new System.Drawing.Size(86, 20);
            this.numMutation.TabIndex = 2;
            this.numMutation.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numCrossover
            // 
            this.numCrossover.DecimalPlaces = 2;
            this.numCrossover.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numCrossover.Location = new System.Drawing.Point(148, 51);
            this.numCrossover.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrossover.Name = "numCrossover";
            this.numCrossover.Size = new System.Drawing.Size(86, 20);
            this.numCrossover.TabIndex = 1;
            this.numCrossover.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Space Quantization Factor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Probability of Mutation:";
            // 
            // numUselessIterationFactor
            // 
            this.numUselessIterationFactor.DecimalPlaces = 9;
            this.numUselessIterationFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUselessIterationFactor.Location = new System.Drawing.Point(418, 77);
            this.numUselessIterationFactor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numUselessIterationFactor.Name = "numUselessIterationFactor";
            this.numUselessIterationFactor.Size = new System.Drawing.Size(86, 20);
            this.numUselessIterationFactor.TabIndex = 5;
            this.numUselessIterationFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numMaxUselessIterations
            // 
            this.numMaxUselessIterations.Location = new System.Drawing.Point(418, 51);
            this.numMaxUselessIterations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaxUselessIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxUselessIterations.Name = "numMaxUselessIterations";
            this.numMaxUselessIterations.Size = new System.Drawing.Size(86, 20);
            this.numMaxUselessIterations.TabIndex = 4;
            this.numMaxUselessIterations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numMaxGenerations
            // 
            this.numMaxGenerations.Location = new System.Drawing.Point(418, 25);
            this.numMaxGenerations.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numMaxGenerations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxGenerations.Name = "numMaxGenerations";
            this.numMaxGenerations.Size = new System.Drawing.Size(86, 20);
            this.numMaxGenerations.TabIndex = 3;
            this.numMaxGenerations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numPopSize
            // 
            this.numPopSize.Location = new System.Drawing.Point(148, 25);
            this.numPopSize.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPopSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPopSize.Name = "numPopSize";
            this.numPopSize.Size = new System.Drawing.Size(86, 20);
            this.numPopSize.TabIndex = 0;
            this.numPopSize.ThousandsSeparator = true;
            this.numPopSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Probability of Crossover:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Useless Iteration Factor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Max Useless Iterations:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(270, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Max Number of Generations:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Population Size:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*";
            this.openFileDialog1.Title = "Problem Parameters File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.toolStripSeparator3,
            this.showConvergenceDiagramToolStripMenuItem,
            this.showStabilityDiagramToolStripMenuItem,
            this.toolStripSeparator2,
            this.resetParametersToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // showConvergenceDiagramToolStripMenuItem
            // 
            this.showConvergenceDiagramToolStripMenuItem.Name = "showConvergenceDiagramToolStripMenuItem";
            this.showConvergenceDiagramToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showConvergenceDiagramToolStripMenuItem.Text = "Show Convergence Diagram";
            this.showConvergenceDiagramToolStripMenuItem.Click += new System.EventHandler(this.btnShowConvergenceDiagram_Click);
            // 
            // showStabilityDiagramToolStripMenuItem
            // 
            this.showStabilityDiagramToolStripMenuItem.Name = "showStabilityDiagramToolStripMenuItem";
            this.showStabilityDiagramToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showStabilityDiagramToolStripMenuItem.Text = "Show Stability Diagram";
            this.showStabilityDiagramToolStripMenuItem.Click += new System.EventHandler(this.btnShowStabilityDiagram_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // resetParametersToolStripMenuItem
            // 
            this.resetParametersToolStripMenuItem.Name = "resetParametersToolStripMenuItem";
            this.resetParametersToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.resetParametersToolStripMenuItem.Text = "Reset Parameters";
            this.resetParametersToolStripMenuItem.Click += new System.EventHandler(this.resetParametersToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(539, 402);
            this.Controls.Add(this.btnShowStabilityDiagram);
            this.Controls.Add(this.btnShowConvergenceDiagram);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Genetic Algorithm (Solving Minimum Distance Problem)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUselessIterationFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxUselessIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowConvergenceDiagram;
        private System.Windows.Forms.Button btnShowStabilityDiagram;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBestChromosomeGenomes;
        private System.Windows.Forms.Label lblBestChromosomeFitness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGenerations;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showConvergenceDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showStabilityDiagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numMutation;
        public System.Windows.Forms.NumericUpDown numCrossover;
        public System.Windows.Forms.NumericUpDown numUselessIterationFactor;
        public System.Windows.Forms.NumericUpDown numMaxUselessIterations;
        public System.Windows.Forms.NumericUpDown numMaxGenerations;
        public System.Windows.Forms.NumericUpDown numPopSize;
        public System.Windows.Forms.ComboBox cmbSpaceQuantizationFactor;
    }
}
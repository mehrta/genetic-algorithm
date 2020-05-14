namespace GeneticAlgorithm
{
    partial class FormConvergenceDiagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConvergenceDiagram));
            this.btnClose = new System.Windows.Forms.Button();
            this.chartConvDiagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMarkers = new System.Windows.Forms.CheckBox();
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            this.chkShowFitnessValue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartConvDiagram)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose.Location = new System.Drawing.Point(516, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chartConvDiagram
            // 
            this.chartConvDiagram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.Title = "Generations";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.RoyalBlue;
            chartArea1.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX2.LineWidth = 2;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Blue;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Title = "abs( Fitness Value )";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.RoyalBlue;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisY2.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chartConvDiagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConvDiagram.Legends.Add(legend1);
            this.chartConvDiagram.Location = new System.Drawing.Point(1, 3);
            this.chartConvDiagram.Name = "chartConvDiagram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartConvDiagram.Series.Add(series1);
            this.chartConvDiagram.Size = new System.Drawing.Size(614, 362);
            this.chartConvDiagram.TabIndex = 2;
            this.chartConvDiagram.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.numZoom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(184, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 89);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axes";
            // 
            // numZoom
            // 
            this.numZoom.DecimalPlaces = 3;
            this.numZoom.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.numZoom.Location = new System.Drawing.Point(49, 21);
            this.numZoom.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(68, 20);
            this.numZoom.TabIndex = 1;
            this.numZoom.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numZoom.ValueChanged += new System.EventHandler(this.numZoom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.chkMarkers);
            this.groupBox2.Controls.Add(this.chkShowGrid);
            this.groupBox2.Controls.Add(this.chkShowFitnessValue);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appearance";
            // 
            // chkMarkers
            // 
            this.chkMarkers.AutoSize = true;
            this.chkMarkers.Checked = true;
            this.chkMarkers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMarkers.Location = new System.Drawing.Point(10, 62);
            this.chkMarkers.Name = "chkMarkers";
            this.chkMarkers.Size = new System.Drawing.Size(64, 17);
            this.chkMarkers.TabIndex = 1;
            this.chkMarkers.Text = "Markers";
            this.chkMarkers.UseVisualStyleBackColor = true;
            this.chkMarkers.CheckedChanged += new System.EventHandler(this.chkMarkers_CheckedChanged);
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Checked = true;
            this.chkShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowGrid.Location = new System.Drawing.Point(10, 42);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(75, 17);
            this.chkShowGrid.TabIndex = 0;
            this.chkShowGrid.Text = "Show Grid";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            this.chkShowGrid.CheckedChanged += new System.EventHandler(this.chkShowGrid_CheckedChanged);
            // 
            // chkShowFitnessValue
            // 
            this.chkShowFitnessValue.AutoSize = true;
            this.chkShowFitnessValue.Location = new System.Drawing.Point(10, 22);
            this.chkShowFitnessValue.Name = "chkShowFitnessValue";
            this.chkShowFitnessValue.Size = new System.Drawing.Size(124, 17);
            this.chkShowFitnessValue.TabIndex = 0;
            this.chkShowFitnessValue.Text = "Show Fitness Values";
            this.chkShowFitnessValue.UseVisualStyleBackColor = true;
            this.chkShowFitnessValue.CheckedChanged += new System.EventHandler(this.chkShowFitnessValue_CheckedChanged);
            // 
            // FormConvergenceDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartConvDiagram);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 510);
            this.Name = "FormConvergenceDiagram";
            this.Text = "Convergence Diagram";
            this.Load += new System.EventHandler(this.FormConvergenceDiagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConvDiagram)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartConvDiagram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkShowFitnessValue;
        private System.Windows.Forms.CheckBox chkShowGrid;
        private System.Windows.Forms.CheckBox chkMarkers;
    }
}
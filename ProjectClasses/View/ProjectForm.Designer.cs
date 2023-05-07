namespace MainProject
{
    partial class ProjectForm
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(200D, 101D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalcInflation_Button = new System.Windows.Forms.Button();
            this.CalcInflation_Possible_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcInflation_Current_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.predictedInflation_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InflationTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.InflationYear_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPI_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.InflationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationChart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InflationChart);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.predictedInflation_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InflationTable_DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 435);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inflation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalcInflation_Button);
            this.groupBox2.Controls.Add(this.CalcInflation_Possible_TextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CalcInflation_Current_TextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(186, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 136);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate cost of a product after 3 years";
            // 
            // CalcInflation_Button
            // 
            this.CalcInflation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcInflation_Button.Location = new System.Drawing.Point(233, 95);
            this.CalcInflation_Button.Name = "CalcInflation_Button";
            this.CalcInflation_Button.Size = new System.Drawing.Size(99, 32);
            this.CalcInflation_Button.TabIndex = 2;
            this.CalcInflation_Button.Text = "Calculate";
            this.CalcInflation_Button.UseVisualStyleBackColor = true;
            this.CalcInflation_Button.Click += new System.EventHandler(this.CalcInflation_Button_Click);
            // 
            // CalcInflation_Possible_TextBox
            // 
            this.CalcInflation_Possible_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalcInflation_Possible_TextBox.Location = new System.Drawing.Point(187, 56);
            this.CalcInflation_Possible_TextBox.Name = "CalcInflation_Possible_TextBox";
            this.CalcInflation_Possible_TextBox.ReadOnly = true;
            this.CalcInflation_Possible_TextBox.Size = new System.Drawing.Size(145, 23);
            this.CalcInflation_Possible_TextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(184, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Possible cost (RUB):";
            // 
            // CalcInflation_Current_TextBox
            // 
            this.CalcInflation_Current_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalcInflation_Current_TextBox.Location = new System.Drawing.Point(12, 56);
            this.CalcInflation_Current_TextBox.Name = "CalcInflation_Current_TextBox";
            this.CalcInflation_Current_TextBox.Size = new System.Drawing.Size(145, 23);
            this.CalcInflation_Current_TextBox.TabIndex = 12;
            this.CalcInflation_Current_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcInflation_Current_TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current cost (RUB):";
            // 
            // predictedInflation_TextBox
            // 
            this.predictedInflation_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.predictedInflation_TextBox.Location = new System.Drawing.Point(373, 391);
            this.predictedInflation_TextBox.Name = "predictedInflation_TextBox";
            this.predictedInflation_TextBox.ReadOnly = true;
            this.predictedInflation_TextBox.Size = new System.Drawing.Size(67, 23);
            this.predictedInflation_TextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(183, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPI predict for 3 next years:";
            // 
            // InflationTable_DataGridView
            // 
            this.InflationTable_DataGridView.AllowUserToAddRows = false;
            this.InflationTable_DataGridView.AllowUserToDeleteRows = false;
            this.InflationTable_DataGridView.AllowUserToResizeColumns = false;
            this.InflationTable_DataGridView.AllowUserToResizeRows = false;
            this.InflationTable_DataGridView.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.InflationTable_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InflationTable_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InflationYear_Column,
            this.CPI_Column});
            this.InflationTable_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.InflationTable_DataGridView.Location = new System.Drawing.Point(6, 22);
            this.InflationTable_DataGridView.Name = "InflationTable_DataGridView";
            this.InflationTable_DataGridView.ReadOnly = true;
            this.InflationTable_DataGridView.RowHeadersVisible = false;
            this.InflationTable_DataGridView.RowTemplate.ReadOnly = true;
            this.InflationTable_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InflationTable_DataGridView.Size = new System.Drawing.Size(103, 386);
            this.InflationTable_DataGridView.TabIndex = 9;
            // 
            // InflationYear_Column
            // 
            this.InflationYear_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InflationYear_Column.HeaderText = "Year";
            this.InflationYear_Column.MinimumWidth = 45;
            this.InflationYear_Column.Name = "InflationYear_Column";
            this.InflationYear_Column.ReadOnly = true;
            this.InflationYear_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InflationYear_Column.Width = 45;
            // 
            // CPI_Column
            // 
            this.CPI_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CPI_Column.HeaderText = "CPI";
            this.CPI_Column.MinimumWidth = 50;
            this.CPI_Column.Name = "CPI_Column";
            this.CPI_Column.ReadOnly = true;
            this.CPI_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CPI_Column.Width = 50;
            // 
            // LoadData_Button
            // 
            this.LoadData_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadData_Button.Location = new System.Drawing.Point(403, 454);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(197, 32);
            this.LoadData_Button.TabIndex = 1;
            this.LoadData_Button.Text = "Load data from file";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // InflationChart
            // 
            this.InflationChart.BorderlineColor = System.Drawing.Color.Black;
            this.InflationChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.InflationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InflationChart.Legends.Add(legend1);
            this.InflationChart.Location = new System.Drawing.Point(131, 22);
            this.InflationChart.Name = "InflationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPI";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.InflationChart.Series.Add(series1);
            this.InflationChart.Size = new System.Drawing.Size(456, 216);
            this.InflationChart.TabIndex = 2;
            this.InflationChart.Text = "chart1";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(772, 697);
            this.Controls.Add(this.LoadData_Button);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.Text = "Statistics for Russia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InflationChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView InflationTable_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InflationYear_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPI_Column;
        private System.Windows.Forms.Button LoadData_Button;
        private System.Windows.Forms.TextBox predictedInflation_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CalcInflation_Possible_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CalcInflation_Current_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcInflation_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart InflationChart;
    }
}
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(200D, 101D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(200D, 101D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.District_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DistrictPopulationDecline_TextBox = new System.Windows.Forms.TextBox();
            this.DistrictPopulationDecline_Label = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Population_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Inflation_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.predictedInflation_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalcInflation_Button = new System.Windows.Forms.Button();
            this.CalcInflation_Possible_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcInflation_Current_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.InflationTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.InflationYear_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPI_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Population_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopulationChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.District_Chart)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Population_Chart)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inflation_Chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.LoadData_Button);
            this.groupBox1.Controls.Add(this.InflationTable_DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1879, 1016);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inflation";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(917, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(938, 922);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Population";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.District_Chart);
            this.groupBox6.Controls.Add(this.DistrictPopulationDecline_TextBox);
            this.groupBox6.Controls.Add(this.DistrictPopulationDecline_Label);
            this.groupBox6.Location = new System.Drawing.Point(18, 347);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(906, 556);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "District population (million)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 516);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Biggest population decline:";
            // 
            // District_Chart
            // 
            this.District_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.District_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.District_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.District_Chart.Legends.Add(legend1);
            this.District_Chart.Location = new System.Drawing.Point(11, 22);
            this.District_Chart.Name = "District_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPI";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.District_Chart.Series.Add(series1);
            this.District_Chart.Size = new System.Drawing.Size(881, 432);
            this.District_Chart.TabIndex = 17;
            this.District_Chart.Text = "chart1";
            // 
            // DistrictPopulationDecline_TextBox
            // 
            this.DistrictPopulationDecline_TextBox.Location = new System.Drawing.Point(191, 516);
            this.DistrictPopulationDecline_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DistrictPopulationDecline_TextBox.Name = "DistrictPopulationDecline_TextBox";
            this.DistrictPopulationDecline_TextBox.ReadOnly = true;
            this.DistrictPopulationDecline_TextBox.Size = new System.Drawing.Size(81, 23);
            this.DistrictPopulationDecline_TextBox.TabIndex = 18;
            // 
            // DistrictPopulationDecline_Label
            // 
            this.DistrictPopulationDecline_Label.AutoSize = true;
            this.DistrictPopulationDecline_Label.Location = new System.Drawing.Point(9, 481);
            this.DistrictPopulationDecline_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DistrictPopulationDecline_Label.Name = "DistrictPopulationDecline_Label";
            this.DistrictPopulationDecline_Label.Size = new System.Drawing.Size(276, 17);
            this.DistrictPopulationDecline_Label.TabIndex = 19;
            this.DistrictPopulationDecline_Label.Text = "District with the biggest population decline:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Population_Chart);
            this.groupBox5.Location = new System.Drawing.Point(18, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(906, 319);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total population (million)";
            // 
            // Population_Chart
            // 
            this.Population_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Population_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.Population_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Population_Chart.Legends.Add(legend2);
            this.Population_Chart.Location = new System.Drawing.Point(12, 32);
            this.Population_Chart.Name = "Population_Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "CPI";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.Population_Chart.Series.Add(series2);
            this.Population_Chart.Size = new System.Drawing.Size(880, 271);
            this.Population_Chart.TabIndex = 3;
            this.Population_Chart.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Inflation_Chart);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.predictedInflation_TextBox);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 454);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inflation";
            // 
            // Inflation_Chart
            // 
            this.Inflation_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Inflation_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.Inflation_Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Inflation_Chart.Legends.Add(legend3);
            this.Inflation_Chart.Location = new System.Drawing.Point(26, 22);
            this.Inflation_Chart.Name = "Inflation_Chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "CPI";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            this.Inflation_Chart.Series.Add(series3);
            this.Inflation_Chart.Size = new System.Drawing.Size(827, 224);
            this.Inflation_Chart.TabIndex = 2;
            this.Inflation_Chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(584, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "CPI predict for 3 next years:";
            // 
            // predictedInflation_TextBox
            // 
            this.predictedInflation_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.predictedInflation_TextBox.Location = new System.Drawing.Point(772, 313);
            this.predictedInflation_TextBox.Name = "predictedInflation_TextBox";
            this.predictedInflation_TextBox.ReadOnly = true;
            this.predictedInflation_TextBox.Size = new System.Drawing.Size(67, 23);
            this.predictedInflation_TextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalcInflation_Button);
            this.groupBox2.Controls.Add(this.CalcInflation_Possible_TextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CalcInflation_Current_TextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(26, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 168);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate cost of a product after 3 years";
            // 
            // CalcInflation_Button
            // 
            this.CalcInflation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcInflation_Button.Location = new System.Drawing.Point(367, 108);
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
            this.CalcInflation_Possible_TextBox.Location = new System.Drawing.Point(274, 68);
            this.CalcInflation_Possible_TextBox.Name = "CalcInflation_Possible_TextBox";
            this.CalcInflation_Possible_TextBox.ReadOnly = true;
            this.CalcInflation_Possible_TextBox.Size = new System.Drawing.Size(192, 23);
            this.CalcInflation_Possible_TextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(271, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Possible cost (RUB):";
            // 
            // CalcInflation_Current_TextBox
            // 
            this.CalcInflation_Current_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalcInflation_Current_TextBox.Location = new System.Drawing.Point(20, 68);
            this.CalcInflation_Current_TextBox.Name = "CalcInflation_Current_TextBox";
            this.CalcInflation_Current_TextBox.Size = new System.Drawing.Size(192, 23);
            this.CalcInflation_Current_TextBox.TabIndex = 12;
            this.CalcInflation_Current_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcInflation_Current_TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(17, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current cost (RUB):";
            // 
            // LoadData_Button
            // 
            this.LoadData_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadData_Button.Location = new System.Drawing.Point(1658, 967);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(197, 32);
            this.LoadData_Button.TabIndex = 1;
            this.LoadData_Button.Text = "Load data from file";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // InflationTable_DataGridView
            // 
            this.InflationTable_DataGridView.AllowUserToAddRows = false;
            this.InflationTable_DataGridView.AllowUserToDeleteRows = false;
            this.InflationTable_DataGridView.AllowUserToResizeColumns = false;
            this.InflationTable_DataGridView.AllowUserToResizeRows = false;
            this.InflationTable_DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.InflationTable_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InflationTable_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InflationYear_Column,
            this.CPI_Column,
            this.Population_column,
            this.PopulationChange});
            this.InflationTable_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.InflationTable_DataGridView.Location = new System.Drawing.Point(6, 21);
            this.InflationTable_DataGridView.Name = "InflationTable_DataGridView";
            this.InflationTable_DataGridView.ReadOnly = true;
            this.InflationTable_DataGridView.RowHeadersVisible = false;
            this.InflationTable_DataGridView.RowHeadersWidth = 51;
            this.InflationTable_DataGridView.RowTemplate.ReadOnly = true;
            this.InflationTable_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InflationTable_DataGridView.Size = new System.Drawing.Size(893, 454);
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
            // Population_column
            // 
            this.Population_column.HeaderText = "PoP";
            this.Population_column.MinimumWidth = 6;
            this.Population_column.Name = "Population_column";
            this.Population_column.ReadOnly = true;
            this.Population_column.Width = 50;
            // 
            // PopulationChange
            // 
            this.PopulationChange.HeaderText = "PopChange";
            this.PopulationChange.MinimumWidth = 6;
            this.PopulationChange.Name = "PopulationChange";
            this.PopulationChange.ReadOnly = true;
            this.PopulationChange.Width = 125;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.Text = "Statistics for Russia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.District_Chart)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Population_Chart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inflation_Chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView InflationTable_DataGridView;
        private System.Windows.Forms.Button LoadData_Button;
        private System.Windows.Forms.TextBox predictedInflation_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CalcInflation_Possible_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CalcInflation_Current_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalcInflation_Button;
        private System.Windows.Forms.DataVisualization.Charting.Chart Inflation_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart District_Chart;
        private System.Windows.Forms.TextBox DistrictPopulationDecline_TextBox;
        private System.Windows.Forms.Label DistrictPopulationDecline_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn InflationYear_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPI_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationChange_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationChange;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Population_Chart;
        private System.Windows.Forms.Label label3;
    }
}
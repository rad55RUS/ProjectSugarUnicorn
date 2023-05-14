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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(200D, 101D);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Inflation_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CalcInflation_Button = new System.Windows.Forms.Button();
            this.CalcInflation_Possible_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CalcInflation_Current_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.predictedInflation_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InflationTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.Population_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.InflationYear_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPI_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.District_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DistrictPopulationDecline_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DistrictPopulationDecline_Label = new System.Windows.Forms.Label();
            this.Population_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopulationChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inflation_Chart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.District_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Population_Chart);
            this.groupBox1.Controls.Add(this.Inflation_Chart);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.predictedInflation_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InflationTable_DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1576, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inflation";
            // 
            // InflationChart
            // 
            this.Inflation_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Inflation_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.Inflation_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Inflation_Chart.Legends.Add(legend1);
            this.Inflation_Chart.Location = new System.Drawing.Point(175, 27);
            this.Inflation_Chart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Inflation_Chart.Name = "InflationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPI";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.Inflation_Chart.Series.Add(series1);
            this.Inflation_Chart.Size = new System.Drawing.Size(608, 266);
            this.Inflation_Chart.TabIndex = 2;
            this.Inflation_Chart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalcInflation_Button);
            this.groupBox2.Controls.Add(this.CalcInflation_Possible_TextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CalcInflation_Current_TextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(302, 290);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(465, 167);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculate cost of a product after 3 years";
            // 
            // CalcInflation_Button
            // 
            this.CalcInflation_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcInflation_Button.Location = new System.Drawing.Point(311, 117);
            this.CalcInflation_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalcInflation_Button.Name = "CalcInflation_Button";
            this.CalcInflation_Button.Size = new System.Drawing.Size(132, 39);
            this.CalcInflation_Button.TabIndex = 2;
            this.CalcInflation_Button.Text = "Calculate";
            this.CalcInflation_Button.UseVisualStyleBackColor = true;
            this.CalcInflation_Button.Click += new System.EventHandler(this.CalcInflation_Button_Click);
            // 
            // CalcInflation_Possible_TextBox
            // 
            this.CalcInflation_Possible_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalcInflation_Possible_TextBox.Location = new System.Drawing.Point(249, 69);
            this.CalcInflation_Possible_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalcInflation_Possible_TextBox.Name = "CalcInflation_Possible_TextBox";
            this.CalcInflation_Possible_TextBox.ReadOnly = true;
            this.CalcInflation_Possible_TextBox.Size = new System.Drawing.Size(192, 26);
            this.CalcInflation_Possible_TextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(245, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Possible cost (RUB):";
            // 
            // CalcInflation_Current_TextBox
            // 
            this.CalcInflation_Current_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CalcInflation_Current_TextBox.Location = new System.Drawing.Point(16, 69);
            this.CalcInflation_Current_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalcInflation_Current_TextBox.Name = "CalcInflation_Current_TextBox";
            this.CalcInflation_Current_TextBox.Size = new System.Drawing.Size(192, 26);
            this.CalcInflation_Current_TextBox.TabIndex = 12;
            this.CalcInflation_Current_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcInflation_Current_TextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Current cost (RUB):";
            // 
            // predictedInflation_TextBox
            // 
            this.predictedInflation_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.predictedInflation_TextBox.Location = new System.Drawing.Point(551, 470);
            this.predictedInflation_TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.predictedInflation_TextBox.Name = "predictedInflation_TextBox";
            this.predictedInflation_TextBox.ReadOnly = true;
            this.predictedInflation_TextBox.Size = new System.Drawing.Size(88, 26);
            this.predictedInflation_TextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(298, 470);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
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
            this.CPI_Column,
            this.Population_Column,
            this.PopulationChange_Column});
            this.InflationTable_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.InflationTable_DataGridView.Location = new System.Drawing.Point(8, 26);
            this.InflationTable_DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InflationTable_DataGridView.Name = "InflationTable_DataGridView";
            this.InflationTable_DataGridView.ReadOnly = true;
            this.InflationTable_DataGridView.RowHeadersVisible = false;
            this.InflationTable_DataGridView.RowHeadersWidth = 51;
            this.InflationTable_DataGridView.RowTemplate.ReadOnly = true;
            this.InflationTable_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InflationTable_DataGridView.Size = new System.Drawing.Size(276, 475);
            this.InflationTable_DataGridView.TabIndex = 9;
            this.InflationTable_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InflationTable_DataGridView_CellContentClick);
            // 
            // LoadData_Button
            // 
            this.LoadData_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadData_Button.Location = new System.Drawing.Point(537, 559);
            this.LoadData_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(263, 39);
            this.LoadData_Button.TabIndex = 1;
            this.LoadData_Button.Text = "Load data from file";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // population_chart
            // 
            this.Population_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Population_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            this.Population_Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Population_Chart.Legends.Add(legend1);
            this.Population_Chart.Location = new System.Drawing.Point(960, 26);
            this.Population_Chart.Margin = new System.Windows.Forms.Padding(4);
            this.Population_Chart.Name = "population_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPI";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.Population_Chart.Series.Add(series1);
            this.Population_Chart.Size = new System.Drawing.Size(608, 266);
            this.Population_Chart.TabIndex = 17;
            this.Population_Chart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(956, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Population Change";
            // 
            // InflationYear_Column
            // 
            this.InflationYear_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InflationYear_Column.HeaderText = "Year";
            this.InflationYear_Column.MinimumWidth = 45;
            this.InflationYear_Column.Name = "InflationYear_Column";
            this.InflationYear_Column.ReadOnly = true;
            this.InflationYear_Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InflationYear_Column.Width = 49;
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
            this.LoadData_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadData_Button.Location = new System.Drawing.Point(537, 559);
            this.LoadData_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(263, 39);
            this.LoadData_Button.TabIndex = 1;
            this.LoadData_Button.Text = "Load data from file";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // DistrictPopChart
            // 
            this.District_Chart.BorderlineColor = System.Drawing.Color.Black;
            this.District_Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.District_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.District_Chart.Legends.Add(legend2);
            this.District_Chart.Location = new System.Drawing.Point(836, 68);
            this.District_Chart.Margin = new System.Windows.Forms.Padding(4);
            this.District_Chart.Name = "DistrictPopChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "CPI";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.District_Chart.Series.Add(series2);
            this.District_Chart.Size = new System.Drawing.Size(381, 187);
            this.District_Chart.TabIndex = 17;
            this.District_Chart.Text = "chart1";
            // 
            // textBox1
            // 
            this.DistrictPopulationDecline_TextBox.Location = new System.Drawing.Point(836, 287);
            this.DistrictPopulationDecline_TextBox.Name = "textBox1";
            this.DistrictPopulationDecline_TextBox.Size = new System.Drawing.Size(367, 22);
            this.DistrictPopulationDecline_TextBox.TabIndex = 18;
            // 
            // districtName
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 259);
            this.label5.Name = "districtName";
            this.label5.Size = new System.Drawing.Size(211, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Округ с самой большой убылью";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // DistrictText
            // 
            this.DistrictPopulationDecline_Label.AutoSize = true;
            this.DistrictPopulationDecline_Label.Location = new System.Drawing.Point(833, 43);
            this.DistrictPopulationDecline_Label.Name = "DistrictText";
            this.DistrictPopulationDecline_Label.Size = new System.Drawing.Size(106, 16);
            this.DistrictPopulationDecline_Label.TabIndex = 20;
            this.DistrictPopulationDecline_Label.Text = "График Округа";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.DistrictPopulationDecline_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DistrictPopulationDecline_TextBox);
            this.Controls.Add(this.District_Chart);
            this.BackColor = System.Drawing.Color.Plum;
            this.Controls.Add(this.LoadData_Button);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.Text = "Statistics for Russia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Inflation_Chart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.District_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.population_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Population_Chart;
        private System.Windows.Forms.DataGridViewTextBoxColumn InflationYear_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPI_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Population_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopulationChange_Column;
    }
}
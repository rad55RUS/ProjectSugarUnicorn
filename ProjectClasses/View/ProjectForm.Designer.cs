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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InflationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.DistrictPopChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.districtName = new System.Windows.Forms.Label();
            this.DistrictText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictPopChart)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(791, 535);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inflation";
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
            this.InflationChart.Location = new System.Drawing.Point(175, 27);
            this.InflationChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InflationChart.Name = "InflationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "CPI";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.InflationChart.Series.Add(series1);
            this.InflationChart.Size = new System.Drawing.Size(608, 266);
            this.InflationChart.TabIndex = 2;
            this.InflationChart.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CalcInflation_Button);
            this.groupBox2.Controls.Add(this.CalcInflation_Possible_TextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CalcInflation_Current_TextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(248, 300);
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
            this.predictedInflation_TextBox.Location = new System.Drawing.Point(497, 481);
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
            this.label1.Location = new System.Drawing.Point(244, 481);
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
            this.CPI_Column});
            this.InflationTable_DataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.InflationTable_DataGridView.Location = new System.Drawing.Point(8, 27);
            this.InflationTable_DataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InflationTable_DataGridView.Name = "InflationTable_DataGridView";
            this.InflationTable_DataGridView.ReadOnly = true;
            this.InflationTable_DataGridView.RowHeadersVisible = false;
            this.InflationTable_DataGridView.RowHeadersWidth = 51;
            this.InflationTable_DataGridView.RowTemplate.ReadOnly = true;
            this.InflationTable_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InflationTable_DataGridView.Size = new System.Drawing.Size(137, 475);
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
            // DistrictPopChart
            // 
            this.DistrictPopChart.BorderlineColor = System.Drawing.Color.Black;
            this.DistrictPopChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.Name = "ChartArea1";
            this.DistrictPopChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.DistrictPopChart.Legends.Add(legend2);
            this.DistrictPopChart.Location = new System.Drawing.Point(836, 68);
            this.DistrictPopChart.Margin = new System.Windows.Forms.Padding(4);
            this.DistrictPopChart.Name = "DistrictPopChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "CPI";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            this.DistrictPopChart.Series.Add(series2);
            this.DistrictPopChart.Size = new System.Drawing.Size(381, 187);
            this.DistrictPopChart.TabIndex = 17;
            this.DistrictPopChart.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(836, 287);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 22);
            this.textBox1.TabIndex = 18;
            // 
            // districtName
            // 
            this.districtName.AutoSize = true;
            this.districtName.Location = new System.Drawing.Point(833, 259);
            this.districtName.Name = "districtName";
            this.districtName.Size = new System.Drawing.Size(211, 16);
            this.districtName.TabIndex = 19;
            this.districtName.Text = "Округ с самой большой убылью";
            this.districtName.Click += new System.EventHandler(this.label3_Click);
            // 
            // DistrictText
            // 
            this.DistrictText.AutoSize = true;
            this.DistrictText.Location = new System.Drawing.Point(833, 43);
            this.DistrictText.Name = "DistrictText";
            this.DistrictText.Size = new System.Drawing.Size(106, 16);
            this.DistrictText.TabIndex = 20;
            this.DistrictText.Text = "График Округа";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1298, 858);
            this.Controls.Add(this.DistrictText);
            this.Controls.Add(this.districtName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DistrictPopChart);
            this.Controls.Add(this.LoadData_Button);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ProjectForm";
            this.Text = "Statistics for Russia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DistrictPopChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataVisualization.Charting.Chart DistrictPopChart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label districtName;
        private System.Windows.Forms.Label DistrictText;
    }
}
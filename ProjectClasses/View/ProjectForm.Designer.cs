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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InflationTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.InflationYear_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPI_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoadData_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.predictedInflation_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.predictedInflation_TextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InflationTable_DataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inflation";
            // 
            // InflationTable_DataGridView
            // 
            this.InflationTable_DataGridView.AllowUserToAddRows = false;
            this.InflationTable_DataGridView.AllowUserToDeleteRows = false;
            this.InflationTable_DataGridView.AllowUserToResizeColumns = false;
            this.InflationTable_DataGridView.AllowUserToResizeRows = false;
            this.InflationTable_DataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.InflationTable_DataGridView.Size = new System.Drawing.Size(99, 360);
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
            this.LoadData_Button.Location = new System.Drawing.Point(491, 414);
            this.LoadData_Button.Name = "LoadData_Button";
            this.LoadData_Button.Size = new System.Drawing.Size(197, 32);
            this.LoadData_Button.TabIndex = 1;
            this.LoadData_Button.Text = "Load data from file";
            this.LoadData_Button.UseVisualStyleBackColor = true;
            this.LoadData_Button.Click += new System.EventHandler(this.LoadData_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(111, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inflation predict for 3 next years:";
            // 
            // predictedInflation_TextBox
            // 
            this.predictedInflation_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.predictedInflation_TextBox.Location = new System.Drawing.Point(327, 359);
            this.predictedInflation_TextBox.Name = "predictedInflation_TextBox";
            this.predictedInflation_TextBox.ReadOnly = true;
            this.predictedInflation_TextBox.Size = new System.Drawing.Size(67, 23);
            this.predictedInflation_TextBox.TabIndex = 11;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(703, 571);
            this.Controls.Add(this.LoadData_Button);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 610);
            this.Name = "ProjectForm";
            this.Text = "Statistics for Russia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InflationTable_DataGridView)).EndInit();
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
    }
}
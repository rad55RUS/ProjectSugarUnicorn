using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MainProject
{
    public partial class ProjectForm : Form, IProjectForm
    {
        // Private fields
        private readonly Presenter presenter;
        //

        // Constructors
        public ProjectForm()
        {
            // Initalizing form
            InitializeComponent();
            this.MaximumSize = this.Size;
            //

            // Presenter declaration
            presenter = new Presenter(this);
            InflationChart = presenter.ClearChart(InflationChart);
            //

            // Event assignment
            //
        }
        //

        // Public methods
        /// <summary>
        /// Add CPI to inflation DataGridView call
        /// </summary>
        public void UpdateInflationData_Call()
        {
            InflationTable_DataGridView = presenter.UpdateDataGridView(InflationTable_DataGridView);
        }

        /// <summary>
        /// Add predicted inflation to textbox call
        /// </summary>
        public void UpdatePredictedInflation_Call(double predictedInflation)
        {
            predictedInflation_TextBox.Text = presenter.UpdateTextBox(predictedInflation);
        }

        /// <summary>
        /// Recreate inflation chart call
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void UpdateInflationChart_Call()
        {
            InflationChart = presenter.ClearChart(InflationChart);
            InflationChart = presenter.UpdateChart_Accumulated(InflationChart);
            InflationChart = presenter.UpdateChart_Common(InflationChart);
            population_chart = presenter.ClearChart(population_chart);
            population_chart = presenter.UpdatePopulationChart_Common(population_chart);
        }
        
        /// <summary>
        /// Show error with specific message
        /// </summary>
        /// <param name="message"></param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
        
        // Click events
        private void LoadData_Button_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void CalcInflation_Button_Click(object sender, EventArgs e)
        {
            CalcInflation_Possible_TextBox.Text = presenter.CalcInflation(CalcInflation_Current_TextBox.Text);
        }

        private void CalcInflation_Current_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = presenter.CheckNumEnter(e, CalcInflation_Current_TextBox.Text);
            if (e.KeyChar == ((char)Keys.Enter)) 
            {
                CalcInflation_Possible_TextBox.Text = presenter.CalcInflation(CalcInflation_Current_TextBox.Text);
            }
        }

        private void InflationTable_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
    }
}
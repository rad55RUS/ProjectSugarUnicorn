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

            Inflation_Chart = presenter.ClearChart(Inflation_Chart);
            District_Chart = presenter.ClearChart(District_Chart);
            Population_Chart = presenter.ClearChart(Population_Chart);
            //

            // Event assignment
            //
        }
        //

        // Public methods
        /// <summary>
        /// Add CPI to inflation DataGridView call
        /// </summary>
        public void UpdateData_Call()
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
        /// Add max population decine between districts and districts to textbox and label respectively
        /// </summary>
        /// <param name="populationDecline"></param>
        /// <param name="DistrictName"></param>
        public void UpdatePopulationDecline_Call(double populationDecline, string DistrictName)
        {
            DistrictPopulationDecline_TextBox.Text = presenter.UpdateTextBox(populationDecline);
            DistrictPopulationDecline_Label.Text = "District with the biggest population decline is " + DistrictName + " federal district";
        }

        /// <summary>
        /// Recreate inflation chart call
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void UpdateChart_Call()
        {
            Inflation_Chart = presenter.ClearChart(Inflation_Chart);
            Inflation_Chart = presenter.UpdateChart_InflationAccumulated(Inflation_Chart);
            Inflation_Chart = presenter.UpdateChart_InflationCommon(Inflation_Chart);

            District_Chart = presenter.ClearChart(District_Chart);
            District_Chart = presenter.UpdateChart_District(District_Chart);

            Population_Chart = presenter.ClearChart(Population_Chart);
            Population_Chart = presenter.UpdateChart_Population(Population_Chart);
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
        //
    }
}
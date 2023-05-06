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
            //

            // Event assignment
            //
        }
        //

        // Public methods
        /// <summary>
        /// Add CPI to inflation DataGridView
        /// </summary>
        public void UpdateInflationData_Call(int year, double cpi)
        {
            InflationTable_DataGridView = presenter.UpdateData_InflationDataGridView(year, cpi, InflationTable_DataGridView);
        }

        /// <summary>
        /// Add predicted inflation to textbox
        /// </summary>
        public void UpdatePredictedInflation_Call(double predictedInflation)
        {
            predictedInflation_TextBox.Text = presenter.UpdateTextBox(predictedInflation);
        }

        /// <summary>
        /// (TEMPLATE) Add dot to specific graph
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void AddDot(int x, int y)
        {

        }

        /// <summary>
        /// (TEMPLATE) Add dot with signature to specific graph
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="xText"></param>
        public void AddDot(int x, int y, string xText)
        {
            
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
        }
        //
    }
}
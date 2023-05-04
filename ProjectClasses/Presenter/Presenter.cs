using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;

using MainProject.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace MainProject
{
    public class Presenter: IPresenter
    {
        // Public fields
        public IProjectForm view;
        public Interactor interactor;
        //

        // Constructors
        public Presenter(IProjectForm view)
        {
            this.view = view;
            interactor = new Interactor(this);
        }
        //

        // Methods
        //// Public void methods
        /// <summary>
        /// Load data via interactor
        /// </summary>
        public void LoadData()
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml",
                FilterIndex = 2
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = openFileDialog.OpenFile()) != null)
                {
                    stream.Dispose();
                    stream.Close();

                    try
                    {
                        interactor.LoadData(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        view.ShowError("Error while reading xml file!");
                    }
                }
            }
        }
        
        /// <summary>
        /// Add year to view
        /// </summary>
        public void UpdateInflationData_Call(int year, double cpi)
        {
            view.UpdateInflationData_Call(year, cpi);
        }
        
        /// <summary>
        /// Add predicted inflation to View
        /// </summary>
        public void UpdatePredictedInflation_Call(double predictedInflation)
        {
            view.UpdatePredictedInflation_Call((double)predictedInflation);
        }
        ////

        //// Internal void methods
        /// <summary>
        /// Add data to inflation DataGridView
        /// </summary>
        internal DataGridView UpdateData_InflationDataGridView(int year, double cpi, DataGridView InflationTable)
        {
            InflationTable.Rows.Add(year, cpi);

            return InflationTable;
        }

        /// <summary>
        /// Update textbox string
        /// </summary>
        internal string UpdateTextBox(double _double)
        {
            _double = Math.Round(_double, 2);
            return Convert.ToString(_double);
        }
        ////
        //
    }
}
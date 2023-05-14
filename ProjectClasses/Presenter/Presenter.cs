using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;
using MainProject.Properties;
using static System.Net.Mime.MediaTypeNames;
using DataClasses;

namespace MainProject
{
    public class Presenter : IPresenter
    {
        // Public fields
        public IProjectForm view;
        public Interactor interactor;
        //

        public List<Data> dataList; 

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
        /// Add year to view call
        /// </summary>
        public void UpdateInflationData_Call(List<Data> dataList)
        {
            this.dataList = dataList;
            view.UpdateInflationData_Call();
        }

        /// <summary>
        /// Recreate inflation chart in view call
        /// </summary>
        public void UpdateInflationChart_Call(List<Data> dataList)
        {
            this.dataList = dataList;
            view.UpdateInflationChart_Call();
        }

        /// <summary>
        /// Add predicted inflation to View call
        /// </summary>
        public void UpdatePredictedInflation_Call(double predictedInflation)
        {
            view.UpdatePredictedInflation_Call((double)predictedInflation);
        }

        /// <summary>
        /// Add population growth/decline value to View call
        /// </summary>
        /// <param name="populationChange"></param>
        public void UpdatePopulationChange_Call(double populationChange)
        {
            view.UpdatePredictedInflation_Call((double)populationChange);
        }

        public void UpdatePopulationDecline_Call(double populationDecline)
        {
            view.UpdatePopulationDecline_Call((double)populationDecline);
        }
        ////

        //// Internal void methods
        /// <summary>
        /// Add data to inflation DataGridView
        /// </summary>
        internal DataGridView UpdateDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            for (int i = 0; i < dots.Count; i++)
            {
                dataGridView.Rows.Add(dots[i][0], dots[i][1]);
            }

            return dataGridView;
        }

        /// <summary>
        /// Update textbox string
        /// </summary>
        internal string UpdateTextBox(double _double)
        {
            _double = Math.Round(_double, 2);
            return Convert.ToString(_double);
        }

        /// <summary>
        /// Update textbox string
        /// </summary>
        internal string CalcInflation(string currentCost_String)
        {
            if (currentCost_String.Last() == ',')
            {
                currentCost_String = currentCost_String.Replace(",", "");
            }
            double currentCost_Double = interactor.CalcInflation(Convert.ToDouble(currentCost_String));

            currentCost_Double = Math.Round(currentCost_Double, 2);
            currentCost_String = Convert.ToString(currentCost_Double);

            return currentCost_String;
        }

        /// <summary>
        /// Check num entering
        /// </summary>
        /// <param name="e"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        internal bool CheckNumEnter(KeyPressEventArgs e, string text)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 44 || e.KeyChar == 8)
            {
                if (e.KeyChar == 44 && (text.Contains(",") || text.Length == 0))
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clear chart from any data
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        internal Chart ClearChart(Chart chart)
        {
            chart.Series.Clear();
            return chart;
        }

        /// <summary>
        /// Fill chart with accumulated dots
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        internal Chart UpdateChart_Accumulated(Chart chart)
        {

            if (dots.Count > 0)
            {
                Series series1 = new Series();
                series1.Name = "Accumulated CPI";
                series1.ChartType = SeriesChartType.Area;
                series1.Color = Color.OrangeRed;
                double accumulatedCPI = dots[0][1];
                series1.Points.AddXY(dots[0][0], accumulatedCPI);

                for (int i = 1; i < dots.Count; i++)
                {
                    accumulatedCPI /= 100;
                    accumulatedCPI *= (dots[i][1]);
                    series1.Points.AddXY(dots[i][0], accumulatedCPI);
                }
                chart.Series.Add(series1);
            }

            return chart;
        }

        /// <summary>
        /// Fill chart with dots
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        internal Chart UpdateChart_Common(Chart chart)
        {

            if (dots.Count > 0)
            {
                Series series = new Series();
                series.Name = "CPI";
                series.ChartType = SeriesChartType.Area;
                for (int i = 0; i < dots.Count; i++)
                {
                    series.Points.AddXY(dots[i][0], dots[i][1]);
                }
                chart.Series.Add(series);
            }

            return chart;
        }
    }
}
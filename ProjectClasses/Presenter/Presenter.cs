using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Schema;
using MainProject.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace MainProject
{
    public class Presenter : IPresenter
    {
        // Public fields
        public IProjectForm view;
        public Interactor interactor;
        //

        // Internal fields
        internal float graph_PictureBox_Height;
        internal float graph_PictureBox_Width;
        internal List<List<double>> dots;
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
        /// Add year to view call
        /// </summary>
        public void UpdateInflationData_Call(int year, double cpi)
        {
            view.UpdateInflationData_Call(year, cpi);
        }

        /// <summary>
        /// Recreate inflation graph in view call
        /// </summary>
        public void UpdateInflationGraph_Call(List<List<double>> dots)
        {
            this.dots = dots;
            view.UpdateInflationGraph_Call();
        }

        /// <summary>
        /// Add predicted inflation to View call
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

        internal void GraphSizeInitialize(PictureBox graph_PictureBox)
        {
            graph_PictureBox_Height = graph_PictureBox.Height;
            graph_PictureBox_Width = graph_PictureBox.Width;
        }

        internal void DrawGraph(object sender, PaintEventArgs e)
        {
            Font drawFont = new Font("Arial", 8, FontStyle.Bold);
            StringFormat drawFormat = new StringFormat();

            double Ystep;
            double Ymax = double.MinValue;
            double Ymin = double.MaxValue;

            for(int i = 0; i < dots.Count; i++)
            {
                if (dots[i][1] > Ymax)
                {
                    Ymax = dots[i][1];
                }
                if (dots[i][1] < Ymin)
                {
                    Ymin = dots[i][1];
                }
            }

            Ystep = (Ymax - Ymin) / dots.Count;

            float heightStep = (graph_PictureBox_Height / dots.Count);
            float widthStep = (graph_PictureBox_Width / dots.Count);

            for (int i = 0; i < 15; i++)
            {
                float yLine = graph_PictureBox_Height - i * heightStep;
                float xLine = graph_PictureBox_Width - i * widthStep;
                var leftPoint = new PointF(0, yLine);
                var rightPoint = new PointF(graph_PictureBox_Width, yLine);
                var upPoint = new PointF(xLine, 0);
                var downPoint = new PointF(xLine, graph_PictureBox_Height - i);

                e.Graphics.DrawLine(Pens.LightGray, leftPoint, rightPoint);
                e.Graphics.DrawLine(Pens.LightGray, upPoint, downPoint);

            }

            double y = Math.Round(Ymin, 0);
            if (y > Ymin)
            {
                y--;
            }

            var prev = new PointF(graph_PictureBox_Width, graph_PictureBox_Height - ((float)dots[dots.Count - 1][1] * heightStep - heightStep * (float)Ymin + heightStep * (float)Ystep));
            for (int i = 0; i < dots.Count; i++)
            {
                var xDot = graph_PictureBox_Width - i * widthStep;
                var yDot = graph_PictureBox_Height - ((float)dots[dots.Count - 1 - i][1] * heightStep - heightStep * (float)Ymin + heightStep * (float)Ystep);
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), xDot, yDot, 6, 6);

                var curr = new PointF(xDot, yDot);
                e.Graphics.DrawLine(Pens.Black, prev, curr);
                prev = curr;
            }

            for (int i = 0; i < dots.Count; i++)
            {
                double x = dots[dots.Count - 1 - i][0];

                if (i > 0)
                {
                    e.Graphics.DrawString(y.ToString(), drawFont, new SolidBrush(Color.DarkOrchid), 0, graph_PictureBox_Height - 9 - i * heightStep, drawFormat);
                    e.Graphics.DrawString(x.ToString(), drawFont, new SolidBrush(Color.DarkSlateBlue), graph_PictureBox_Width - 9 - i * widthStep, graph_PictureBox_Height - drawFont.Size * 2, drawFormat);
                }

                y += Math.Round(Ystep);
            }

            drawFont.Dispose();
        }
        ////
        //
    }
}
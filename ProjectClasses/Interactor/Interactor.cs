using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

using DataClasses;

using MainProject.Properties;

namespace MainProject
{
    public class Interactor
    {
        // Public fields
        public IPresenter presenter;
        public Model model;
        //
        
        // Constructors
        public Interactor(IPresenter presenter)
        {
            this.presenter = presenter;

            model = new Model();
        }
        
        // Public methods
        /// <summary>
        /// Load data from model database
        /// </summary>
        /// <param name="path"></param>
        public void LoadData(string path)
        {
            // Extra data changes
            model.LoadData(path);
            model.DataList = PopulationChange(model.DataList);
            model.predictedCPI = PredictInflation(model.DataList);
            model.populationDecline = PopulationDecline(model.DataList, ref model.districtMaxDecline);
            //

            // Presenter calls
            presenter.UpdateData_Call(model.DataList);
            presenter.UpdateChart_Call(model.DataList);
            presenter.UpdatePredictedInflation_Call(model.predictedCPI);
            presenter.UpdatePopulationDecline_Call(model.populationDecline, model.districtMaxDecline);
            //
        }

        /// <summary>
        /// Calculate inflation for 3 next years
        /// </summary>
        /// <param name="dataList"></param>
        /// <returns></returns>
        public double PredictInflation(List<Data> dataList)
        {
            double predictedCPI = 0;

            foreach (Data data in dataList)
            {
                predictedCPI += data.CPI;
            }

            predictedCPI /= (double)dataList.Count;
            predictedCPI /= 100;
            predictedCPI *= Math.Pow(predictedCPI, 2) * 100;

            return predictedCPI;
        }

        /// <summary>
        /// Calculate year population change in percentage
        /// </summary>
        /// <param name="dataList"></param>
        /// <returns></returns>
        public List<Data> PopulationChange( List<Data> dataList)
        {
            for (int i = 0; i < dataList.Count; i++)
            {
                Data data = dataList[i];
               

                if ( i==0)
                {
                    data.PopulationChange = 0; 

                }
                else
                {
                   data.PopulationChange = -((dataList[i-1].Population * 100 / dataList[i].Population) - 100);
                }
                dataList[i] = data;
            }
            
            return dataList;
        }
        
        /// <summary>
        /// Calculate most population decline among districts
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="DistricName"></param>
        /// <returns></returns>
        public double PopulationDecline(List<Data> dataList, ref string DistricName)
        {
            List<double> populationdecline = new List<double>();

            double MaxDecline = double.MinValue;

            for (int i = 0; i < dataList[0].districts.Count; i++)
            {
                populationdecline.Add(dataList[0].districts[i].Population - dataList[dataList.Count - 1].districts[i].Population);

                if (populationdecline[i] > MaxDecline)
                {
                    MaxDecline = populationdecline[i];
                    DistricName = dataList[0].districts[i].Name;
                }
            }

            return MaxDecline;
        }

        /// <summary>
        /// Calculate inflation for a product for 3 next years
        /// </summary>
        /// <param name="currentCost"></param>
        /// <returns></returns>
        public double CalcInflation(double currentCost)
        {
            return currentCost *= (model.predictedCPI / 100);
        }
        //
    }
}

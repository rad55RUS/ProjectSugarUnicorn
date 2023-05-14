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
            model.LoadData(path);
            List<Data> dataList = model.DataList;

            model.predictedCPI = PredictInflation(model.DataList);
            model.populationChange = PopulationChange(model.DataList);
            model.populationDecline = PopulationDecline(model.DataList,ref model.DistrictName);

            presenter.UpdateInflationData_Call(model.DataList);
            presenter.UpdateInflationChart_Call(model.DataList);
            presenter.UpdatePredictedInflation_Call(model.predictedCPI);
            presenter.UpdatePopulationChange_Call(model.populationChange);
            presenter.UpdatePopulationDecline_Call(model.populationDecline, model.DistrictName);
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
        /// Calculate average population growth/decline
        /// </summary>
        /// <param name="dataList"></param>
        /// <returns></returns>
        public double PopulationChange(List<Data> dataList)
        {
            double populatitionChange = 0;

            foreach (Data data in dataList)
            {
                populatitionChange += data.Population;
            }

            populatitionChange /= (double)dataList.Count;
            populatitionChange = 100 * (Math.Pow(1 + populatitionChange / 100, 3) - 1);

            return populatitionChange;

        }
        
        public double PopulationDecline(List<Data> dataList, ref string DistricName)
        {
            List<double> populationdecline = new List<double>();

            double Max=double.MinValue;

            for (int i = 0; i < dataList[0].districts.Count; i++)
                {
                    populationdecline.Add(dataList[0].districts[i].Population-dataList[dataList.Count-1].districts[i].Population);

                    if (populationdecline[i] > Max)
                    {
                        Max = populationdecline[i];
                        DistricName = dataList[0].districts[i].Name;
                    }
                }

            return Max;
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

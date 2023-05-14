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
            List<List<double>> dots = new List<List<double>>();
            dataList = PopulationChange(dataList);
           
            foreach(Data data in dataList)
            {
                List<double> coordinate = new List<double>();
                coordinate.Add(data.Year);
                coordinate.Add(data.CPI);
                coordinate.Add(data.Population);
                coordinate.Add(data.PopulationChange);
                dots.Add(coordinate);

            }

            model.predictedCPI = PredictInflation(dataList);
           

            presenter.UpdateInflationData_Call(dots);
            presenter.UpdateInflationChart_Call(dots);
            presenter.UpdatePredictedInflation_Call(model.predictedCPI);
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
                   //data.PopulationChange = 100 * (Math.Pow(1+ dataList[i-1].Population / (double)100, 3) - 1);
                }
                dataList[i] = data;
            }
            
         
            return dataList;

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

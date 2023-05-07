﻿using System;
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

            foreach(Data data in dataList)
            {
                List<double> coordinate = new List<double>();
                coordinate.Add(data.Year);
                coordinate.Add(data.CPI);
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

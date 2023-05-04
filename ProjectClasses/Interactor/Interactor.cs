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

        public void LoadData(string path)
        {
            model.LoadData(path);
            List<Data> dataList = model.DataList;

            foreach(Data data in dataList)
            {
                presenter.UpdateInflationData_Call(data.Year, data.CPI);
            }

            presenter.UpdatePredictedInflation_Call(PredictInflation(dataList));
        }

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
    }
}

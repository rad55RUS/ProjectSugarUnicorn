﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataClasses;

namespace MainProject
{
    public interface IPresenter
    {
        void LoadData();
        // Call methods
        void UpdateInflationChart_Call(List<Data> dataList);
        void UpdateInflationData_Call(List<Data> dataList);
        void UpdatePredictedInflation_Call(double predictedInflation);
        void UpdatePopulationChange_Call(double populationChange);
        void UpdatePopulationDecline_Call(double populationDecline, string DistrictName);
        //
    }
}

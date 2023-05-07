using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public interface IProjectForm
    {
        void UpdateInflationChart_Call();
        void UpdateInflationData_Call();
        void UpdatePredictedInflation_Call(double predictedInflation);
        void ShowError(string message);
    }
}
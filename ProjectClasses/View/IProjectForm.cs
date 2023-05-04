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
        void UpdateInflationData_Call(int year, double CPI);
        void UpdatePredictedInflation_Call(double predictedInflation);
        void AddDot(int x, int y);
        void AddDot(int x, int y, string xText);
        void ShowError(string message);
    }
}
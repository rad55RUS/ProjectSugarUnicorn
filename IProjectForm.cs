using DataClasses_Library;
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
        void LoadTextboxData(string text);
        void AddDot(int x, int y);
        void AddDot(int x, int y, string xText);
        void ShowError(string message);
    }
}

using System;
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

        internal void LoadData(string path)
        {
            model.LoadData(path);
        }
    }
}

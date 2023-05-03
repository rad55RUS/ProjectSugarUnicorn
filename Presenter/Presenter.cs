using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

using DataClasses;

using MainProject.Properties;

namespace MainProject
{
    public class Presenter: IPresenter
    {
        // Public fields
        public IProjectForm view;
        public Interactor interactor;
        //

        // Constructors
        public Presenter(IProjectForm view)
        {
            this.view = view;
            interactor = new Interactor(this);
        }
        //

        // Methods
        //// Void methods
        /// <summary>
        /// Load data via interactor
        /// </summary>
        public void LoadData(string path)
        {
            interactor.LoadData(path);
            /* Some code */

        }
        ////
        //
    }
}
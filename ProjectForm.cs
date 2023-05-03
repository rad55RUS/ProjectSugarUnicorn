using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataClasses_Library;

namespace MainProject
{
    public partial class ProjectForm : Form, IProjectForm
    {
        // Private fields
        private readonly Presenter presenter;
        //

        // Constructors
        public ProjectForm()
        {
            // Initalizing form
            InitializeComponent();
            //

            // Presenter declaration
            presenter = new Presenter(this);
            //

            // Event assignment
            //
        }
        //

        // Public methods
        /// <summary>
        /// (TEMPLATE) Load data to specific textbox
        /// </summary>
        /// <param name="text"></param>
        public void LoadTextboxData(string text)
        {
            
        }

        /// <summary>
        /// (TEMPLATE) Add dot to specific graph
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void AddDot(int x, int y)
        {

        }

        /// <summary>
        /// (TEMPLATE) Add dot with signature to specific graph
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="xText"></param>
        public void AddDot(int x, int y, string xText)
        {

        }

        /// <summary>
        /// Show error with specific message
        /// </summary>
        /// <param name="message"></param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //
    }
}

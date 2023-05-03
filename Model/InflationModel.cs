using System.Xml;
using System.Collections.Generic;

using MainProject.Properties;

using DataClasses;

namespace MainProject
{
    public class InflationModel : IModel
    {
        // Public fields
        public List<InflationDataClass> InflationData = new List<InflationDataClass>();
        //

        // Constructors
        public InflationModel() { }
        //

        // Public methods
        /// <summary>
        /// Load data from specific xml file
        /// </summary>
        /// <param name="path"></param>
        public void LoadData(string path)
        {
            XmlDocument xDoc = new XmlDocument();
        }
        //
    }
}

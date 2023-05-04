using System.Xml;
using System.Collections.Generic;

using DataClasses;

using MainProject.Properties;
using System;

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
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    InflationDataClass inflationObject = new InflationDataClass();

                    XmlNode attr = xnode.Attributes.GetNamedItem("Year");
                    inflationObject.Year = Convert.ToInt32(attr.Value);
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "CPI")
                        {
                            inflationObject.CPI = Convert.ToDouble(childnode.Value);
                        }
                    }

                    InflationData.Add(inflationObject);
                }
            }
        }
        //
    }
}

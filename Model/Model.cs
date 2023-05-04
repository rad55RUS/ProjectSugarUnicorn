using System.Xml;
using System.Collections.Generic;

using DataClasses;

using MainProject.Properties;
using System;

namespace MainProject
{
    public class Model
    {
        // Public fields
        public List<Data> DataList = new List<Data>();
        //

        // Constructors
        public Model() { }
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
                    Data inflationObject = new Data();

                    XmlNode attr = xnode.Attributes.GetNamedItem("Year");
                    inflationObject.Year = Convert.ToInt32(attr.Value);
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "CPI")
                        {
                            inflationObject.CPI = Convert.ToDouble(childnode.Value);
                        }
                    }

                    DataList.Add(inflationObject);
                }
            }
        }
        //
    }
}

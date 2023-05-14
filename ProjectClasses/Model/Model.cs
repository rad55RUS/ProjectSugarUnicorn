using System.Xml;
using System.Collections.Generic;

using DataClasses;

using MainProject.Properties;
using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace MainProject
{
    public class Model
    {
        // Public fields
        public List<Data> DataList = new List<Data>();
        public double predictedCPI;
        public double populationChange;
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
            DataList.Clear();
            predictedCPI = 0;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    Data dataObject = new Data();

                    XmlNode attr = xnode.Attributes.GetNamedItem("Value");
                    try
                    {
                        if (attr == null)
                        {
                            throw new Exception();
                        }
                        dataObject.Year = Convert.ToInt32(attr.Value);
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "CPI")
                            {
                                string tempString = "";
                                for (int i = 0; i < childnode.InnerText.Length; i++)
                                {
                                    if (childnode.InnerText[i] == '.')
                                    {
                                        tempString += ",";
                                    }
                                    else
                                    {
                                        tempString += childnode.InnerText[i];
                                    }
                                }
                                dataObject.CPI = Convert.ToDouble(tempString);
                            }
                            if (childnode.Name == "population")
                            {
                                string tempString = "";
                                for (int i = 0; i < childnode.InnerText.Length; i++)
                                {
                                    if (childnode.InnerText[i] == '.')
                                    {
                                        tempString += ",";
                                    }
                                    else
                                    {
                                        tempString += childnode.InnerText[i];
                                    }
                                }
                                dataObject.Population = Convert.ToDouble(tempString);
                            }
                        }

                        DataList.Add(dataObject);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception();
                    }
                }
            }
        }
        //
    }
}

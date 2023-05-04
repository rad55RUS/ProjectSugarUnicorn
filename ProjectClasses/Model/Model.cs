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

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlElement xnode in xRoot)
                {
                    Data inflationObject = new Data();

                    XmlNode attr = xnode.Attributes.GetNamedItem("Value");
                    try
                    {
                        if (attr == null)
                        {
                            throw new Exception();
                        }
                        inflationObject.Year = Convert.ToInt32(attr.Value);
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
                                inflationObject.CPI = Convert.ToDouble(tempString);
                            }
                        }

                        DataList.Add(inflationObject);
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

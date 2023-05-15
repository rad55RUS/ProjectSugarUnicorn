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
        public double populationDecline;
        public string districtMaxDecline = "";
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

            XmlDocument data_XML = new XmlDocument();
            data_XML.Load(path);
            XmlElement data_Root = data_XML.DocumentElement;
            if (data_Root != null)
            {
                foreach (XmlElement data_Node in data_Root)
                {
                    Data dataObject = new Data();

                    XmlNode year_Attribute = data_Node.Attributes.GetNamedItem("Value");
                    try
                    {
                        if (year_Attribute == null)
                        {
                            throw new Exception();
                        }
                        dataObject.Year = Convert.ToInt32(year_Attribute.Value);
                        foreach (XmlNode year_Node in data_Node.ChildNodes)
                        {
                            if (year_Node.Name == "CPI")
                            {
                                string tempString = "";
                                for (int i = 0; i < year_Node.InnerText.Length; i++)
                                {
                                    if (year_Node.InnerText[i] == '.')
                                    {
                                        tempString += ",";
                                    }
                                    else
                                    {
                                        tempString += year_Node.InnerText[i];
                                    }
                                }
                                dataObject.CPI = Convert.ToDouble(tempString);
                            }
                            if (year_Node.Name == "Population")
                            {
                                string tempString = "";
                                for (int i = 0; i < year_Node.InnerText.Length; i++)
                                {
                                    if (year_Node.InnerText[i] == '.')
                                    {
                                        tempString += ",";
                                    }
                                    else
                                    {
                                        tempString += year_Node.InnerText[i];
                                    }
                                }
                                dataObject.Population = Convert.ToDouble(tempString);
                            }

                            if (year_Node.Name=="District")  
                            {
                                foreach (XmlNode district_Node in year_Node.ChildNodes)
                                {
                                    XmlNode district_Attribute = year_Node.Attributes.GetNamedItem("Value");
                                    if (district_Node.Name == "Population")
                                    {
                                        string tempString = "";
                                        for (int i = 0; i < year_Node.InnerText.Length; i++)
                                        {
                                            if (year_Node.InnerText[i] == '.')
                                            {
                                                tempString += ",";
                                            }
                                            else
                                            {
                                                tempString += year_Node.InnerText[i];
                                            }
                                        }
                                        dataObject.AddDistrict(district_Attribute.Value, Convert.ToDouble(tempString));
                                    }
                                }
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

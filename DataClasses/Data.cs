using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataClasses
{
    public class Data
    {
        // Private fields
        private int year;
        private double cpi;
        private double population;
        public List<District> districts = new List<District>();
        //

        // Public properties
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public double CPI
        {
            get
            {
                return cpi;
            }
            set
            {
                cpi = value;
            }
        }
        public double Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
        //

        // Structures
        public struct District
        {
            private string name;
            private double population;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public double Population 
            {
                get
                {
                    return population;
                }
                set
                {
                    population = value;
                }
            }
            public District(string _Name, double _population) 
            {
                name =_Name;
                population = _population;
            }
        }
        //

        // Constructors
        public Data() { }

        public Data(int year, double cpi, double population)
        {

            this.year = year;
            this.cpi = cpi;
            this.population = population;
        }
        //

        // Methods
        public void AddDistrict(string name, double population)
        {
            District district = new District(name,population);
            districts.Add(district);
        }
        //
    }
}

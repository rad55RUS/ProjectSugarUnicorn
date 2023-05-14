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
        private District district = new District();
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
            district.name = name;
            district.population = population;
        }
        //
    }
}

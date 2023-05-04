using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataClasses
{
    public class InflationDataClass : IDataClass
    {
        // Private fields
        private int year;
        private double cpi;
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
        //

        // Constructors
        public InflationDataClass() { }

        public InflationDataClass(int year, double cpi)
        {
            this.Year = year;
            this.CPI = cpi;
        }
        //
    }
}

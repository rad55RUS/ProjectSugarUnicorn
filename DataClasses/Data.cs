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
        Sub sub = new Sub();
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

        public struct Sub
            {
                public string Name;
                public double pop;
            }



        // Constructors
        public Data() { }

        public Data(int year, double cpi, string Name, double pop)
        {

            this.Year = year;
            this.CPI = cpi;
            sub.Name = Name;
            sub.pop = pop;
        }
        //
    }
}

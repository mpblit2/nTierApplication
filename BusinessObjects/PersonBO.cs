using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class PersonBO
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private double tax;

        public double Tax
        {
            get { return tax; }
            set { tax = value; }
        }
    }
}

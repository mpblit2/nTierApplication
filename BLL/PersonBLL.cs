using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using DAL;

namespace BLL
{
    public class PersonBLL
    {
        public List<PersonBO> Read()
        {
            IReadable dal = new PersonDAL();
            return dal.Read();
        }
        public void save(PersonBO bo)
        {
            bo.Tax = CalculateTax(bo.Salary);
            PersonDAL pdl = new PersonDAL();
            pdl.Save(bo);
        }

        public double CalculateTax(double Salary)
        {
            return Salary * 0.20;
        }


    }

    
}

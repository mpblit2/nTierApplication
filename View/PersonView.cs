using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using BLL;

namespace View
{
    public class PersonView
    {
        public void Input()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            
            Console.Write("Enter Salry: ");
            double salary = double.Parse(Console.ReadLine());

            PersonBO PBO = new PersonBO();
            PBO.Name = name;
            PBO.Salary = salary;

            PersonBLL pbll = new PersonBLL();
            pbll.save(PBO);
        }
        public void Display()
        {
            PersonBLL b1 = new PersonBLL();

            List<PersonBO> list = b1.Read();

            foreach (var x in list)
            {
                Console.WriteLine("\t\tName     : " + x.Name);
                Console.WriteLine("\t\tSalary   : " + x.Salary);
                Console.WriteLine("\t\tTax      : " + x.Tax); 
            }

            Console.ReadKey();
        }
    }


}

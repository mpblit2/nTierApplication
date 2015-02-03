using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using System.IO;

namespace DAL
{
    public class PersonDAL : IReadable
    {
        public List<PersonBO> Read()
        {
            //FileStream fin = new FileStream("File1.txt", FileMode.Open);
            StreamReader sr = new StreamReader("File1.txt");
            List<PersonBO> lpbo = new List<PersonBO>();
            while (!sr.EndOfStream)
            {
                string data = sr.ReadLine();
                PersonBO pbo = new PersonBO();
                string bufor = "";

                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != ';')
                    {
                        pbo.Name += data[i];
                    }
                    else
                    {
                        data = data.Remove(0, i+1);
                        break;
                    }
                }
                
                for (int i = 0; i < data.Length; i++)
                {
                   
                    if (data[i] != ';')
                    {
                        bufor += data[i];
                    }
                    else
                    {
                        data = data.Remove(0, i+1);
                        pbo.Salary = double.Parse(bufor);
                        break;
                    }
                }
                 

                pbo.Tax = double.Parse(data);

                lpbo.Add(pbo);
            }
            
            sr.Close();
            //fin.Close();
            
            return lpbo;
            

        }
        public void Save(PersonBO bo)
        {
            FileStream fout;
            if(File.Exists("File1.txt"))
            {
                fout = new FileStream("File1.txt", FileMode.Open);
            }
            else
            {
                fout = new FileStream("File1.txt", FileMode.Create);
            }
            
            StreamWriter sw = new StreamWriter(fout);

            string data = bo.Name + ";" + bo.Salary + ";" + bo.Tax;
            sw.WriteLine(data);

            sw.Close();
            fout.Close();
        }
    }
}

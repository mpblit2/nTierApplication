using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessObjects;
using BLL;

namespace View
{
    public partial class PersonViewWF : Form
    {
        public PersonViewWF()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            this.Input();
            this.Display();
        }

        public void Input()
        {
            PersonBO PBO = new PersonBO();
            PBO.Name = this.textBoxImie.Text;
            PBO.Salary = double.Parse(this.textBoxSalary.Text);

            PersonBLL pbll = new PersonBLL();
            pbll.save(PBO);
        }
        public void Display()
        {
            PersonBLL b1 = new PersonBLL();

            List<PersonBO> list = b1.Read();

            foreach (var x in list)
            {
                textBoxDisplay.Text = x.Name + "\r\n" + x.Salary + "\r\n" + x.Tax;
               
            }

        }

        private void PersonViewWF_Load(object sender, EventArgs e)
        {

        }
    }
}

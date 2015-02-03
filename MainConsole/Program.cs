using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using View;
using NUnit.Framework;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonView pv = new PersonView();
            pv.Input();
            pv.Display();
        }
    }
}

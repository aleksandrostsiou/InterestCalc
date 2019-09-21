using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passing List<Data> to ctor of Calculator
            Calculator calc = new Calculator(DataManager.GetData());

            //Input Amount , START date , END date 
            calc.CalcInterest(100,"01/01/2000", DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}

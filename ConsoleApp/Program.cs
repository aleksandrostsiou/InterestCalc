using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            DateTime startDate = DateTime.Now;
            DateTime endDate = startDate;

            //Console UI
            Console.WriteLine("Give the amount ,starting date ,and the ending date \n **in this order**");
            if (float.TryParse(Console.ReadLine(), out float amount))
            {
                Console.WriteLine(" Correct. \n Now give a starting date\n **dd/MM/yyyy**");
                if (DateTime.TryParse(Console.ReadLine(),out startDate))
                {
                    Console.WriteLine(" Congrats!\n At last give me an ending date\n **dd/MM/yyyy**");
                    if (DateTime.TryParse(Console.ReadLine(), out endDate))
                    {
                        Console.WriteLine("Perfect give me just a second");
                        Thread.Sleep(2000);
                        Console.WriteLine("Your results : \n");

                        //Input Amount , START date , END date 
                        calc.CalcInterest(amount, startDate.ToString("dd/MM/yyyy"), endDate.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        Console.WriteLine("Wrong format.Please try again");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong format.Please try again");
                }
            }
            else
            {
                Console.WriteLine("I told u with this order");
            }
            
        }
    }
}

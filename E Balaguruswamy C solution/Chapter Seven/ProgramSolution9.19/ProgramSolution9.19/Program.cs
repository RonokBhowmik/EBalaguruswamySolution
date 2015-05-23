using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution9._19
{
    class Program
    {
        private string findLeapYear()
        {
            Program program = new Program();

            if (program.year % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("Not Leap year");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year it's Leapyear or not");
            Console.WriteLine("-----------------------------");
            Console.Write("Enter a year:");
            int year=Convert.ToInt32(Console.ReadLine());
   
            Console.ReadKey();
        }
       
    }
}

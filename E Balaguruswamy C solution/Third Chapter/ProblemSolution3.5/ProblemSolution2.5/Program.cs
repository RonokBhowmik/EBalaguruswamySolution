using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number as input:");
            int myNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            int secondNumber =myNumber%1000;
            int thridNumber = myNumber % 100;
            int lastNumber = myNumber%10;
            Console.WriteLine(myNumber+
                Environment.NewLine+secondNumber+
                Environment.NewLine+thridNumber+
                Environment.NewLine+lastNumber);
            Console.ReadKey();

        }
    }
}

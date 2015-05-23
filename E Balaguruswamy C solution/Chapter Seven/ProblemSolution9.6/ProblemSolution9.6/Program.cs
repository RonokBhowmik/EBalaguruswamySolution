using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double a=Convert.ToDouble(Console.ReadLine());
            double output=Math.Round(a, 2);
            Console.WriteLine("The rounded result is:"+output);
            Console.ReadKey();
        }
    }
}

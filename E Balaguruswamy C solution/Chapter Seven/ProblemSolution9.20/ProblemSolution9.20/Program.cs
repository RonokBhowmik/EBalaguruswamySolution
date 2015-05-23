using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x:");
            double x=Convert.ToDouble(Console.ReadLine());
            double roundedValue=Math.Round(x,2);
            Console.WriteLine("Rounded Value is:"+roundedValue);
            Console.ReadKey();
        }
    }
}

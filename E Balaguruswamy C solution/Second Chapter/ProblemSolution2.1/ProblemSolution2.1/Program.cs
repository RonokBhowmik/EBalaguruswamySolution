using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n:");
            int n=Convert.ToInt32(Console.ReadLine());
            double result = (n * (n + 1)) / 2;
            Console.WriteLine("Result of the series is:"+result);
            Console.ReadKey();
        }
    }
}

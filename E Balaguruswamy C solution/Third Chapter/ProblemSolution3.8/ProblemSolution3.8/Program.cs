using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of initial velocity:");
            double u=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of accelaration:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of intervals of time:");
            double t = Convert.ToDouble(Console.ReadLine());
            double D = u*t + (a*t*t)/2;
            Console.WriteLine("Distance is,D:"+D.ToString());
            Console.ReadKey();
        }
    }
}

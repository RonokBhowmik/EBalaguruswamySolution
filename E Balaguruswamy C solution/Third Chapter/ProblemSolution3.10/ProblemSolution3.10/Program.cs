using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of inductance,l:");
            double l =Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of registence,r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------------");
            double f = 0;
            double c = 0.01;
            for (; c <= 0.1; c=c+0.01)
            {
               f = Math.Sqrt((1 / l * c) - (r * r / 4 * c * c));
               Console.WriteLine("Frequency is:"+f);
            }
           
            Console.ReadKey();
        }
    }
}

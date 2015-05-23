using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a floating point number:");
            double aNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            int dotPosition=aNumber.ToString().IndexOf('.');
            int positionBeforeDot =(dotPosition - 1);
            Console.WriteLine("The right most digit of the integral part is:"+aNumber.ToString().ElementAt(index: positionBeforeDot));
            Console.ReadKey();
        }
    }
}

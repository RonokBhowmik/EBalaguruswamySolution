using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read two floating point numbers from users");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Enter the First Number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            double secondNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Divide firstNumber by the second Number");
            Console.WriteLine("-------------------------------------------");
            double result = firstNumber/secondNumber;
            Console.WriteLine("The two numbers are:"+firstNumber+" and "+secondNumber +"and the result is:"+result);
            Console.ReadKey();
        }
    }
}

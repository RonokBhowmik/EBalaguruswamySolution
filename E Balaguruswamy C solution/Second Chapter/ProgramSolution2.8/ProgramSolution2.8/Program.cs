using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two floating point numbers:");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter the First Number:");
            double firstNumber=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("----------------------------------");
            int Sum = (int) (firstNumber + secondNumber);
            Console.WriteLine("First Number is:"+firstNumber+Environment.NewLine+"Second Number is:"+secondNumber+Environment.NewLine+"Sum is:"+Sum);
            Console.ReadKey();
        }
    }
}

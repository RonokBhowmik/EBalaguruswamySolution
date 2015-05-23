using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Length:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value os width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            double area = length*width;
            Console.WriteLine("Area of the rectangle is:"+area);
            double perimeter = 2*(width+length);
            Console.WriteLine("Perimeter of the rectangle is:"+perimeter);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int s=(a+b+c)/2;
            Console.WriteLine("Sides of the triangle is, S:"+s);
            double A = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine("Result is:"+A.ToString());
            Console.ReadKey();
        }
    }
}

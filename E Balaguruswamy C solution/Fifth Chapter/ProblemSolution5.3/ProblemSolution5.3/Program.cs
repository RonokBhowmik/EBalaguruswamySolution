using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of d:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());

            if (((a*d - c*d) == 0))
            {
                Console.WriteLine("Zero");
            }
            else
            {
                var x1 = ((m * d - b * n) / (a * d - c * d));
                var x2 = (n * a - m * c) / (a * d - c * d);
                Console.WriteLine("value of x1 is:"+x1);
                Console.WriteLine("value of x2 is:"+x2);
            }
            
            Console.ReadKey();
        }
    }
}

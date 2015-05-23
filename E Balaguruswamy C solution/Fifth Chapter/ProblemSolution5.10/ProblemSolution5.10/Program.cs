using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._10
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of a:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c:");
            int c = Convert.ToInt32(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;

            if ((a == 0) && (b == 0))
            {
                Console.WriteLine("No solution");
            }
            if (a==0)
            {
                x1 = -b + ((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a));
                x2 = -b - ((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a));
            }
            else
            {
                if((Math.Sqrt(Math.Pow(b,2) -4*a*c)<0))
                {
                    Console.WriteLine("There are no real roots");
                }
                else
                {
                    x1 = -b +((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a));
                    x2 = -b -((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a));
                }
                Console.WriteLine("X1 is:" + x1);
                Console.WriteLine("X2 is:" + x2); 
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._15
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the value of Angle of radians,x:");
            double x=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Type of Trigonometric function:");
            char T=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("**********Using if-else statement**********");
            Console.WriteLine("---------------------------------------");
            if (T == 'S')
            {
                Console.WriteLine(Math.Sin(x));
            }
            if (T == 'C')
            {
                Console.WriteLine(Math.Cos(x));
            }
            if (T == 'T')
            {
                Console.WriteLine(Math.Tan(x));
            }

            Console.WriteLine("\n");
            Console.WriteLine("**********Using switch statement**********");
            Console.WriteLine("---------------------------------------");
            switch (T)
            {
                case 'S':
                    Console.WriteLine(Math.Sin(x));
                    break;
                case 'C':
                    Console.WriteLine(Math.Cos(x));
                    break;
                case 'T':
                    Console.WriteLine(Math.Tan(x));
                    break;
                default:
                    Console.WriteLine("I donot know");
                    break;
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Without using else option");
            Console.WriteLine("---------------------------");
            if (a%2 == 0)
            {
                Console.WriteLine("NUMBER IS EVEN");
            }
            Console.WriteLine("NUMBER IS ODD");
            Console.WriteLine("---------------------------");
            Console.WriteLine("With else option");
            Console.WriteLine("---------------------------");
            if (a % 2 == 0)
            {
                Console.WriteLine("NUMBER IS EVEN");
            }
            Console.WriteLine("NUMBER IS ODD");
            Console.ReadKey();
        }
    }
}

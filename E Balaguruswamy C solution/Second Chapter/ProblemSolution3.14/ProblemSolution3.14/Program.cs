using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of m:");
            int m=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m == (n * n))
            {
                Console.WriteLine("m is multiple of n");
            }
            else
            {
                Console.WriteLine("m is not multiple of n");
            }
            Console.ReadKey();
        }
    }
}

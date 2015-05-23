using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check whether it is even or odd");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            if (a%2 == 0)
            {
                Console.WriteLine(a+" is Even");
            }
            else
            {
                Console.WriteLine(a+" is odd");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbelmSolution5._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find out a number is prime or not");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter a Number:");
            int a=Convert.ToInt32(Console.ReadLine());
            if ((a%1 == 0) && (a%a == 0))
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
            Console.WriteLine("Find out the prime numbers between 0 to 100");
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i <100; i++)
            {
                if ((a % 1 == 0) && (a % a == 0))
                {
                    Console.WriteLine(a+" is Prime");
                }
                else
                {
                    Console.WriteLine(a + "is not Prime");
                }   
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSOlution5._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Numbers divisible by 7 between 100 to 200");
            Console.WriteLine("-----------------------------------------");
            int sum = 0;
            for (int i = 101; i <200; i++)
            {
                if (i%7 == 0)
                {
                    Console.Write(i+"\t");
                    sum = sum + i;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sum is:"+sum);
            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compute and Display all integers which are divisible by 6 but not divisible by 4");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int count=0;
            int sum = 0;
            for (int i = 0; i <100; i++)
            {
                if ((i % 6 == 0) && (i % 4 != 0))
                {
                    count++;
                    sum = sum + i;
                    Console.Write(i+"\t");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Sum is:"+sum+ " and no of numbers are:"+count);
            Console.ReadKey();
        }
    }
}

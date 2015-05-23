using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prints the even numbers from 1 to 100");
            Console.WriteLine("---------------------------------------");
            int count = 0;
            for (int i = 1; i <=100; i++)
            {
                if (i%2==0)
                {
                    Console.Write(i+"\t");
                    count++;
                }
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Number of even numbers are:"+count);
            Console.ReadKey();
        }
    }
}

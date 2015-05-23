using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some digits from user");
            Console.WriteLine("----------------------------");
            List<int>numbers=new List<int>();
            int Range = 10;
            int countNumbers = 0;
            for (int i = 0; i<100; i++)
            {
                if (countNumbers!=Range)
                {
                    
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                    countNumbers++;
                }
                else
                {
                    Console.WriteLine("Limit crossed");
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Read how many positive and negative numbers in the list");
            int negCounter = 0;
            int posCounter = 0;
            foreach (var anumber in numbers)
            {
                if (anumber == 0)
                {
                   
                }
                else if (anumber < 0)
                {
                    negCounter++;
                }
                else
                {
                    posCounter++;
                }
            }
            Console.WriteLine("Number of positive numbers are:"+posCounter);
            Console.WriteLine("Number of negative numbers are:" +negCounter);
            Console.ReadKey();

        }
    }
}

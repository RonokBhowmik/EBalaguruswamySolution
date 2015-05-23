using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbelmSolution6._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prints all the numbers which are not divisible by either 2 or 3 between 1 to 100");
            Console.WriteLine("-------------------------------------------------------------------------");
            int count=0;
            for (int i = 0; i <=100; i++)
            {
                if ((i%2 != 0) && (i%3!=0))
                {
                    count++;
                    Console.Write(i+"\t");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("No of Numbers not divisible by either 2 or 3 are:"+count);
            Console.ReadKey();
        }
    }
}

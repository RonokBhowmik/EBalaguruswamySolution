using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbelmSolution6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse the given Number:");
            int aNumber = 12345;
            int lastDigit = aNumber%10;
            
            int s=0;
            for (int i = 0; i <lastDigit-1; i++)
            {
               s=aNumber/10;
            }
            
            Console.WriteLine(s);
            
            Console.ReadKey();
        }
    }
}

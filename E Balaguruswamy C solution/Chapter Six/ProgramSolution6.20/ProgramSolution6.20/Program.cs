using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution6._20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of 10 positive and negative numbers are given");
            int[] numbersList = {12,-65,25,98,-36,87,56,-98,-10,-6};
            int sum = 0;
            int countPositiveValues = 0;
            foreach (var aNumber in numbersList)
            {
                if (aNumber>0)
                {
                    if (sum > 999)
                    {
                        Console.WriteLine("program is termininating");
                    }
                    else
                    {
                        sum = sum + aNumber;
                        countPositiveValues++;   
                    }
                    
                }
                
            }
            Console.WriteLine("Sum is:"+sum);
            Console.WriteLine("No of positive values are:"+countPositiveValues);
            Console.ReadKey();
        }
    }
}

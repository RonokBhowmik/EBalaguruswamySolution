using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of purchase price:");
            double purchasePrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Years of Service:");
            double yearsOfService=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Depreciation:");
            double depreciation = Convert.ToDouble(Console.ReadLine());
            double salvageValue = purchasePrice - (depreciation * yearsOfService);
            Console.WriteLine("Salvage Value is:"+salvageValue);
            Console.ReadKey();
        }
    }
}

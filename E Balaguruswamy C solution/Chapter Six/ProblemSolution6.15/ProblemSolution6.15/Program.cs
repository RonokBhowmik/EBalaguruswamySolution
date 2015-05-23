using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution6._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Depreciation Rate,d:");
            double d=Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter original Cost,c:");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter scrap value,P:");
            double P= Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter original cost,o:");
            double o = Convert.ToDouble(Console.ReadLine());

            double n=P/(c*(1 - d));
            
            Console.WriteLine("Number of Years:"+n);

            Console.ReadKey();
        }

    }
}

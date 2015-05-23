using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of the Products:");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Enter the price of Rice:");
            double priceOfrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price of Sugar:");
            double priceOfsugar= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            Console.WriteLine("***LIST OF ITEMS***");
            Console.WriteLine("Item"+"\t"+"Price");
            Console.WriteLine("Rice"+"\t"+priceOfrice);
            Console.WriteLine("Sugar" + "\t" + priceOfsugar);
            Console.ReadKey();
        }
    }
}

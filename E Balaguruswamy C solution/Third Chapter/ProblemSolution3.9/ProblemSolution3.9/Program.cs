using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Economic Order Quantity*****");
            Console.WriteLine("------------------------------------------------");
            Console.Write("Enter demand rate:");
            double demandRate=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter setup  costs:");
            double setUpCosts = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter holding  costs:");
            double holdingCost = Convert.ToDouble(Console.ReadLine());
            double EOQ = Math.Sqrt((2 * demandRate * setUpCosts) / holdingCost);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Economic Order Quantity is="+EOQ);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("*****Optimal Time between Orders*****");
            Console.WriteLine("------------------------------------------------");
            double TBO = Math.Sqrt((2*setUpCosts)/(demandRate*holdingCost));
            Console.WriteLine("Optimal Time between Orders is :" + TBO);
            Console.ReadKey();
        }
    }
}

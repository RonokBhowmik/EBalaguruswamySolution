using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer Codes:");
            string customerCode=Console.ReadLine();
            Console.Write("Enter Calls made:");
            int callsMade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------");
            double cost = 0.00;
            if (callsMade > 100)
            {
                cost = 250.00 + (callsMade - 100) * 1.25;
            }
            if (callsMade<=100)
            {
                cost = 250.00;
            }
            Console.WriteLine("*******************Bill For Each Customer*******************");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Customer Code"+"\t"+"No of calls made:"+"\t"+"Cost");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(customerCode+"\t"+"\t"+callsMade+"\t"+"\t"+"\t"+cost);
            Console.ReadKey();
        }
    }
}

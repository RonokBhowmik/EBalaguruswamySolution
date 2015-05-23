using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Purchase Amount"+"\t"+"\t"+"Discount");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\t"+"Mill Cloth"+"\t"+"Handloom Items");
            Console.WriteLine("0-100"+"\t"+"\t"+"-"+"\t"+"\t"+"5%");
            Console.WriteLine("101-200" +"\t" +"\t" + "5%" + "\t" + "\t" + "7.5%");
            Console.WriteLine("201-300" +"\t" +"\t" + "7.5%" + "\t" + "\t" + "10%");
            Console.WriteLine("Above300" + "\t" + "10.0%" + "\t" + "\t" + "15%");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Enter Purchase Amount:");
            int purchaseAmount=Convert.ToInt16(Console.ReadLine());
         
            double totalAmountPaid = 0;
            switch (purchaseAmount)
            {
                case 100:
                    totalAmountPaid = purchaseAmount * (5 / 100) * (5 / 100);
                    break;
                case 200:
                    totalAmountPaid = purchaseAmount * (5 / 100) * (7.5 / 100);
                    break;
                case 300:
                    totalAmountPaid = purchaseAmount * (7.5 / 100) * (10 / 100);
                    break;
                default:
                    totalAmountPaid = purchaseAmount * (10 / 100) * (15 / 100);
                    break;

            }
            Console.WriteLine(totalAmountPaid);
            Console.ReadKey();
        }
    }
}

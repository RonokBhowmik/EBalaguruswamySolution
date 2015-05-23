using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("\t" + "\t" + "*****Electricity Bill Calculation*****");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Write("Enter User's Name:");
            string userName = Console.ReadLine();
            Console.Write("Enter no of Unit's Consumed:");
            double noOfUnitsConsumed = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------------------------");
            const double meterCharge = 100.00;
            double totalBill = 0.00;
            double bill = 0.00;
            if (noOfUnitsConsumed < 1)
            {
                totalBill = meterCharge;

            }
            if (noOfUnitsConsumed > 0 && noOfUnitsConsumed < 201)
            {
                bill = 0.80 * noOfUnitsConsumed + meterCharge;
                if (bill > 400)
                {
                    totalBill = bill + (bill * 15) / 100;
                }

                else
                {
                    totalBill = bill;
                }
            }
            if (noOfUnitsConsumed >= 201 && noOfUnitsConsumed <= 300)
            {
                bill = 0.90 * noOfUnitsConsumed + meterCharge;
                if (bill > 400)
                {
                    totalBill = bill + (bill * 15) / 100;
                }
                else
                {
                    totalBill = bill;
                }
            }
            if (noOfUnitsConsumed >= 301)
            {
                bill = 1.0 * noOfUnitsConsumed + meterCharge;
                if (bill > 400)
                {
                    totalBill = bill + (bill * 15) / 100;
                }
                else
                {
                    totalBill = bill;
                }
            }

            Console.WriteLine("User Name" + "\t" + "No of unit's Consumed" + "\t" + "Total Bill");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine(userName + "\t" + "\t" + noOfUnitsConsumed + "\t" + "\t" + "\t" + totalBill);
            Console.ReadKey();
        }
    }
}

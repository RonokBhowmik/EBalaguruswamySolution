using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution4._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four floating point values between 0.0 to 20.0");
            Console.WriteLine("----------------------------------------------------");
            const int noOfInputs = 4;
            int counter = 1;
            double input = 0;
            for (int i = 1; i <= noOfInputs; i++)
            {
                if (((input >= 0.0) && (input <= 20.00)))
                {
                    Console.Write(@"Enter input No--" + counter + "is:");
                    input = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("----------------------------------------------------");
                    for (int j = 0; j < Math.Round(input); j++)
                    {
                        for (int k = 0; k < Math.Round(input); k++)
                        {
                            Console.Write("*" + "\t");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("\t" + "\t" + "\t" + "\t" + "\t" + input);
                    Console.WriteLine("\n");
                    Console.WriteLine("-------------------------------------");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Out of Range");
                }
            }
            Console.ReadKey();
        }
    }
}

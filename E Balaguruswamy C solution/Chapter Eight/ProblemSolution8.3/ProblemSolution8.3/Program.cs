using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string myString=Console.ReadLine();
            string desiredString=string.Empty;
            if (myString != null)
            {
                try
                {
                    desiredString = myString.Substring(2,5);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                
            }
            Console.WriteLine("The output is:"+desiredString);
            Console.ReadKey();
        }
    }
}

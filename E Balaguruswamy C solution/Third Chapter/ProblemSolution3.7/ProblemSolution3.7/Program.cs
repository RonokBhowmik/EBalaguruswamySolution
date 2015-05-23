using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a real number:");
            int number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Smallest integer"+"\t"+"The given Number"+"\t"+"Largest integer");
            Console.WriteLine("Not less than the number" + "\t" +"\t"+ "Not greater than the number");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._3
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x:");
            double x=Convert.ToDouble(Console.ReadLine());
            int dotPosition=x.ToString().IndexOf('.');
            int positionBeforeDot = dotPosition-1;
            int twoPositionBeforeDot = dotPosition - 2;
            Console.Write(x.ToString().ElementAt(twoPositionBeforeDot));
            Console.Write(x.ToString().ElementAt(positionBeforeDot));
            
            Console.ReadKey();
        }
    }
}

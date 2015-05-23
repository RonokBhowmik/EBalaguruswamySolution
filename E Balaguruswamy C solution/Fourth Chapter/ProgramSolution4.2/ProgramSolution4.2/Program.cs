using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x:");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Result of 1st Equation (x+y)/(x-y) is:" + (x + y) / (x - y));
            Console.WriteLine("Result of the 2nd equation (x+y)/2 is:" + (x + y) / 2);
            Console.WriteLine("Result of the 3rd equation  (x+y*(x-y) is:" + (x + y * (x - y)));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution6._17
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            double y=0;
            Console.WriteLine("\t"+"Y---------------------------------------->"+"\n");
            Console.WriteLine("0---------------------------------------------");
            for (int i = 0; i <180; i=i+15)
            {
                y=Math.Sin(i);
                Console.WriteLine("X |");
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}

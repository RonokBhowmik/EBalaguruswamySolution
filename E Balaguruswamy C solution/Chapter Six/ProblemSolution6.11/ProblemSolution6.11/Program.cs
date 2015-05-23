using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution6._11
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value,X:");
            int X=Convert.ToInt32(Console.ReadLine());
            int result;

            if (X!=0)
            {
                result=((X % 2));
                Console.WriteLine(result);
            
            }
           else
           {
               Console.WriteLine("Not possible");
           }
                
            
            
            Console.ReadKey();
        }
    }
}

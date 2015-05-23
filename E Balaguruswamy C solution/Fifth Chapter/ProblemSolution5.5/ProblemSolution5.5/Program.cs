using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 65;
            int p = 89;
            int c = 43;
            Console.WriteLine("Marks in Mathematics:"+m);
           

            Console.WriteLine("Marks in Physics:"+p);
           

            Console.WriteLine("Marks in Chemistry:"+c);
           
            Console.WriteLine("-------------------------------------");

            if (m >= 60 || p >= 50 || c >= 40 || (m + p + c) >= 200 || (m + p) >= 150)
            {
                Console.WriteLine("You are an Eligible Candidate");
            }
            else
            {
                Console.WriteLine("Not eligible");   
            }
            
            Console.ReadKey();

        }
    }
}
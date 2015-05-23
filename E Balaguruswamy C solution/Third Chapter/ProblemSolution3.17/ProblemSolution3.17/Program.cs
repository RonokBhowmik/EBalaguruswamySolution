using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("x(degrees)" + "\t"+"sin(x)"+"\t"+"cos(x)");
            Console.WriteLine("0" +"\t"+Math.Sin(0)+"\t"+Math.Cos(0));
            
            Console.WriteLine("30" + "\t" + Math.Sin(30) + "\t" + Math.Cos(30));
            Console.WriteLine("45" + "\t" + Math.Sin(45) + "\t" + Math.Cos(45));
           
            Console.WriteLine("90" + "\t" + Math.Sin(90) + "\t" + Math.Cos(90));
            
            Console.WriteLine("120" + "\t" + Math.Sin(120) + "\t" + Math.Cos(120));
            
            Console.WriteLine("180" + "\t" + Math.Sin(180) + "\t" + Math.Cos(180));
            Console.WriteLine("-------------------------------------------------");
            Console.ReadKey();
        }
    }
}

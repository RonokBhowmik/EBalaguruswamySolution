using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Number"+"\t"+"Square-root"+"\t"+"square");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("0"+"\t"+Math.Sqrt(0)+"\t"+Math.Pow(0,2));
            Console.WriteLine("10" + "\t" + Math.Sqrt(10) + "\t" + Math.Pow(10, 2));
            Console.WriteLine("20" + "\t" + Math.Sqrt(20) + "\t" + Math.Pow(20, 2));
            Console.WriteLine("30" + "\t" + Math.Sqrt(30) + "\t" + Math.Pow(30, 2));
            Console.WriteLine("40" + "\t" + Math.Sqrt(40) + "\t" + Math.Pow(40, 2));
            Console.WriteLine("50" + "\t" + Math.Sqrt(50) + "\t" + Math.Pow(50, 2));
            Console.WriteLine("60" + "\t" + Math.Sqrt(60) + "\t" + Math.Pow(60, 2));
            Console.WriteLine("70" + "\t" + Math.Sqrt(70) + "\t" + Math.Pow(70, 2));
            Console.WriteLine("80" + "\t" + Math.Sqrt(80) + "\t" + Math.Pow(80, 2));
            Console.WriteLine("90" + "\t" + Math.Sqrt(90) + "\t" + Math.Pow(90, 2));
            Console.WriteLine("100" + "\t" + Math.Sqrt(100) + "\t" + Math.Pow(100, 2));
            Console.WriteLine("----------------------------------------");
            Console.ReadKey();
        }
    }
}

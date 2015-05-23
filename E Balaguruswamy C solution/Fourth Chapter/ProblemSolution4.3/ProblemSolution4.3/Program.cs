using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 35.7;
            double b = 50.21;
            double c = -23.73;
            double d = -46.45;
            Console.WriteLine("Actual Value"+"\t"+"After Changing");
            Console.WriteLine("-----------------------------------");
            
            int k=(int) a; 
            int l = (int)b;
            int m = (int) c;
            int n=(int)d;
            Console.WriteLine(a+"\t"+k+
                Environment.NewLine+b+"\t"+l+
                Environment.NewLine+c+"\t"+m+
                Environment.NewLine+d+"\t"+n);    
            Console.ReadKey();
        }
    }
}

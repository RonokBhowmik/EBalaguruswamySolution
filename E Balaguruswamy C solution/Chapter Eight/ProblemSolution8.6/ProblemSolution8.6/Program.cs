using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution8._6
{
    class Program
    {
        static void Main(string[] args)
        {

            string s1 = "it is good to program in PASCAL";
            Console.WriteLine("Given String:"+Environment.NewLine+s1);
            Console.WriteLine("------------------------------------------------");
            string s2 = string.Empty;
            if (s1.Contains("PASCAL"))
            {
                s2=s1.Replace("PASCAL", "C");
            }
            Console.WriteLine("Replaced String is:"+Environment.NewLine+s2);
            Console.ReadKey();
        }
    }
}

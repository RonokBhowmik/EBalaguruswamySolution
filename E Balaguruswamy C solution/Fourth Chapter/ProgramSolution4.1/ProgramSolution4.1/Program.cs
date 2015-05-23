using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "WORD PROCESSING";
            string s2 = s1.Substring(0,5);
         
            string s4 =s1.Trim('R');
            Console.WriteLine(s1 +Environment.NewLine+s4+Environment.NewLine);
            Console.ReadKey();
        }
    }
}

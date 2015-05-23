using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String:");
            string s = Console.ReadLine();
            string s1 = s.Substring(0, 4);
            string s2 = s.Substring(5, 6);
            string s3 = s.Substring(11, 15);
            string myString = s1 + s2 + "." + s3;

            Console.WriteLine(myString);
            Console.ReadKey();
        }
    }
}

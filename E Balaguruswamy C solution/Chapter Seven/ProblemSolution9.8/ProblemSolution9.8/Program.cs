using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a lower case String:");
            string s1=Console.ReadLine();
            Console.WriteLine("----------------------");
            MyClass myClass=new MyClass();
            Console.WriteLine("The output in uppercase is:"+myClass.lowerToUpper(s1));
            Console.ReadKey();
        }
    }
}

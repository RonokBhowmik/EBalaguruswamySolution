using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will find the size of various data types in c#");
            Console.WriteLine("\t"+"DATA TYPES");
            Console.WriteLine("------------------------");
            Console.WriteLine("Data Type" +"\t"+"Size");
            Console.WriteLine("------------------------");
            Console.WriteLine("byte" + "\t" + byte.MinValue + " to " + Byte.MaxValue);
            Console.WriteLine("short" + "\t" + short.MinValue + " to " + short.MaxValue);
            Console.WriteLine("------------------------");
            Console.WriteLine("int"+"\t"+Int16.MinValue+" to "+Int16.MaxValue);
            Console.WriteLine("long" + "\t" + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine("------------------------");
            Console.WriteLine("float" + "\t" + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("double" + "\t" + double.MinValue + " to " + double.MaxValue);
            Console.WriteLine("------------------------");
            Console.WriteLine("char" + "\t" + char.MinValue + " to " + char.MaxValue);
            Console.ReadKey();
        }
    }
}

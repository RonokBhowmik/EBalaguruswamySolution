using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problemno1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0, x=0;
            Console.WriteLine("Enter the value of a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c:");
            c = Convert.ToInt32(Console.ReadLine());
            x=a/(b-c);
            Console.WriteLine("Result is:"+x);
            Console.ReadKey();
        }
    }
}

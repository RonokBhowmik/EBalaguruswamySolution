using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;
            x = y;
            y = z;
            z = y-x;
            Console.WriteLine("---------------");
            Console.WriteLine("The value of x is:"+x);
            Console.WriteLine("The value of y is:" + y);
            Console.WriteLine("The value of z is:" + z);
            Console.ReadKey();

        }
    }
}

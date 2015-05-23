using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            short z;
            x = 111111;
            y = 222222;
            z = (short) (x + y);
            Console.WriteLine("Value of x is:"+x);
            Console.WriteLine("Value of y is:" + y);
            Console.WriteLine("Value of z is:"+z);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            int x1 = 2, x2 = 2;
            int y1 = 5, y2 = 6;
            double diameter = Math.Sqrt((x2 - x1) * (x2 - x1) + ((y2 - y1) * (y2 - y1)));
            double r = diameter/2;
            double area = PI * r * r;
            Console.WriteLine(@"Area of the Circle is:" + area.ToString());
            Console.ReadKey();
        }
    }
}

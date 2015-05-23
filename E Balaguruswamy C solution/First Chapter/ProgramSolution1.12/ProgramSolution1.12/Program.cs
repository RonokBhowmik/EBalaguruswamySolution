using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSolution1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI=3.1416;
            int x1=0,x2 =0;
            int y1 =4,y2=5;
            double r = Math.Sqrt((x2-x1)*(x2-x1)+((y2-y1)*(y2-y1)));
            Console.WriteLine(@"Distance between two points:"+r.ToString());
            double perimeter=2*PI*r;
            double area=PI*r*r;
            Console.WriteLine(@"Perimeter of the Circle is:" +perimeter.ToString());
            Console.WriteLine(@"Area of the Circle is:"+area.ToString());
            Console.ReadKey();
        }
    }
}

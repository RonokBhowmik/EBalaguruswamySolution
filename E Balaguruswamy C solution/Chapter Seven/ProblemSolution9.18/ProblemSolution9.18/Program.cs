using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter month as input:");
            int month=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------");
            Month aMonth=new Month();
            Console.WriteLine("The month is:"+aMonth.findMonth(month));
            Console.ReadKey();
        }
    }
}

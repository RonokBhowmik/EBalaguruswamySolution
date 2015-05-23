using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._1
{
   public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Interchange the value");
            Console.WriteLine("Before Interchange");
            Console.WriteLine("------------------");
            Interchange aInterchange=new Interchange();
            Console.WriteLine("x is:"+aInterchange.x +"\n"+"y is:"+aInterchange.y+"\n");
            Console.WriteLine("After Interchange");
            Console.WriteLine("------------------");
            aInterchange.exchange();
            Console.ReadKey();
        }
    }
}

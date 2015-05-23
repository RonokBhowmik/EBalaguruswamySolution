using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._15
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine();
            Function aFunction=new Function();
            
            aFunction.copy();
            Console.WriteLine(aFunction.compare());
            Console.WriteLine(aFunction.concate());
            Console.ReadKey();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbelmSolution5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of marks ranging from 0 to 100");
            Console.WriteLine("------------------------------------");
            int[] numberList = {0,1,40,80,98,60,65,40,41,45,39,35,25};
            foreach (var aNumber in numberList)
            {
                if (aNumber > 80 && (aNumber > 81 || aNumber<100))
                {
                    Console.WriteLine( aNumber+",Obtained more than 80 marks");
                }
                if (aNumber > 60 && (aNumber > 61 || aNumber < 80))
                {
                    Console.WriteLine(aNumber+",Obtained more than 60 marks");
                }
                if (aNumber > 40 && (aNumber > 81 || aNumber < 100))
                {
                    Console.WriteLine(aNumber+",Obtained more than 40 marks");
                }
                if ((aNumber <= 40) && (aNumber > 0 || aNumber < 40))
                {
                    Console.WriteLine(aNumber+",Obtained 40 or less marks");
                }
            }
            Console.ReadKey();
        }
    }
}

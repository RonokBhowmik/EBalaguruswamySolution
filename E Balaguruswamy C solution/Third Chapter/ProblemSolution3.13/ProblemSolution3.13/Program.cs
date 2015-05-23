using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read three values from the user");
            Console.WriteLine("--------------------------------");
            Console.Write("First Number:");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Thrid Line:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            
            List<int>numberList=new List<int>();
            numberList.Add(firstNumber);
            numberList.Add(secondNumber);
            numberList.Add(thirdNumber);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The maximum number of the three numbers is:"+numberList.Max());

            Console.ReadKey();
        }
    }
}

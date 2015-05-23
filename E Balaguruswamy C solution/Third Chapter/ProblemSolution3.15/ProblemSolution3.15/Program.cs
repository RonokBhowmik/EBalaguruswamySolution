using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three values from the user:");
            Console.WriteLine("---------------------------------");
            Console.Write("Number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            int sum = number1 + number2 + number3;
            Console.WriteLine("Sum of the three numbers is:"+sum);
            Console.WriteLine("---------------------------------");
            List<int>numbersList=new List<int>();
            numbersList.Add(number1);
            numbersList.Add(number2);
            numbersList.Add(number3);
            Console.WriteLine("Maximum value of the three numbers is:"+numbersList.Max());
            Console.WriteLine("Minimum value of the three numbers is:"+numbersList.Min());
            Console.ReadKey();
        }
    }
}

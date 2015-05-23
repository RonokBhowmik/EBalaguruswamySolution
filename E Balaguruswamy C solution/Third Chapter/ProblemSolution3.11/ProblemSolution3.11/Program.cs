using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number");
            int a = Convert.ToInt32(Console.ReadLine());
            
            int firstDigit = a/1000;
            int secondDigit = (a /100)%10;
            int thirdDigit = ((a / 10)%10);
            int lastDigit = a % 10;

            int sum = firstDigit + secondDigit + thirdDigit + lastDigit;
            Console.WriteLine("1st Digit" + "\t" + "2nd Digit" + "\t" + "3rd Digit" + "\t" + "4th Digit");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(firstDigit + "\t"+ secondDigit + "\t" + thirdDigit + "\t" + lastDigit);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Their sum is:"+sum);
            Console.ReadKey();
        }
    }
}

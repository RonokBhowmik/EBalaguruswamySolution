using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._9
{
    public class Calculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }

        public void calculatging()
        {
            read();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("The sum of two numbers is:" + sum(number1,number2));
            Console.WriteLine("The difference between two numbers is:" + difference(number1, number2));
            Console.WriteLine("The product of two numbers is:" + product(number1, number2));
            Console.WriteLine("The division of two numbers is:" + division(number1, number2));

        }

        public void read()
        {
            Console.Write("Enter the value of number 1:");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of number 2:");
            number2 = Convert.ToDouble(Console.ReadLine());
        }

        public double sum(double num1,double num2)
        {
            return (number1 + number2);
        }

        public double difference(double num1, double num2)
        {
            return (number1 - number2);
        }
        public double product(double num1, double num2)
        {
            return (number1 * number2);
        }
        public double division(double num1, double num2)
        {
            double result = 0.0;
            if (number2 != 0)
            {
                result = (number1 / number2);
            }
            return result;
        }
    }
}

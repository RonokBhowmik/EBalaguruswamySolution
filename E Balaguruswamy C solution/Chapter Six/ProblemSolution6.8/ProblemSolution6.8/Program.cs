using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution6._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age of 100 persons:");
            Console.WriteLine("------------------------------");
            int count = 0;
            const int personLimit = 100;
            int personNoCounter = 1;
            int age = 0;
            List<int> ageList = new List<int>();
            for (int i = personNoCounter; i <= personLimit; i++)
            {
                if (i <= 5)
                {
                    Console.WriteLine("Enter age of person No:" + personNoCounter);
                    personNoCounter++;
                    Console.Write("Enter age:");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("------------------------------");
                    ageList.Add(age);
                    if ((age >= 50) ||(age<=60))
                    {
                        count++;
                    }

                }

            }
            foreach (var anAge in ageList)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Person no:" + (personNoCounter) + "\t" + "Age" + anAge);
            }
            Console.WriteLine("count is:" + count);
            Console.ReadKey();
        }
    }
}

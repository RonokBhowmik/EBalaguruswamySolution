using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution8._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st string:");
            string s1=Console.ReadLine();
            Console.Write("Enter 2nd string:");
            string s2 = Console.ReadLine();
            Console.WriteLine("-------------");
            if (s1 != null && s2 != null)
            {
                if ((s1.Equals(s2)))
                {
                    Console.WriteLine("Message 1:Both string are equal");
                }

                else
                {
                    Console.WriteLine("Message 1:Both string are not equal");
                }

            }
            if (s1 != null && s2 != null)
            {
                if ((s1.Length==s2.Length))
                {
                    Console.WriteLine("Message 2:Length are equal");
                }

                else
                {
                    Console.WriteLine("Message 2:Length is not equal");
                }

            }
            if (s1 != null && s2 != null)
            {
                if ((s1.Length>s2.Length))
                {
                    Console.WriteLine("Message 3:Greater than the second string");
                }

                else
                {
                    Console.WriteLine("Message 3:Greater than the first string");
                }

            }
            Console.ReadKey();
        }
    }
}

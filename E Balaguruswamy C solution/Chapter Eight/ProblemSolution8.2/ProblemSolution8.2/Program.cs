using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Dennis Ritchie";
            Console.Write("Who is the inventor of C:");
            string s2=Console.ReadLine();
            if (s1.Equals(s2))
            {
                Console.WriteLine("Good");
                Console.WriteLine("*****End of Program*****");
                
            }
            else
            {
                Console.WriteLine("try again");
                Console.Write("Who is the inventor of C:");
                string s3 = Console.ReadLine();
                if (s1.Equals(s3))
                {
                    Console.WriteLine("Good");
                    Console.WriteLine("*****End of Program*****");
                }
                else
                {
                    Console.WriteLine("try again");
                    Console.Write("Who is the inventor of C:");
                    string s4 = Console.ReadLine();
                    if (s1.Equals(s4))
                    {
                        Console.WriteLine("Good");
                        Console.WriteLine("*****End of Program*****");

                    }
                    else
                    {
                        Console.WriteLine("-----------------------------------------------");
                        Console.WriteLine("The inventor of C is:"+s1);
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

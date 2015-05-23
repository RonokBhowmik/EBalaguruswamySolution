using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a charater:");
            char aCharacter=Convert.ToChar(Console.ReadLine());

            CharacterFinder aFinder=new CharacterFinder();
            Console.WriteLine(aFinder.find(aCharacter));
            Console.ReadKey();
        }
    }
}

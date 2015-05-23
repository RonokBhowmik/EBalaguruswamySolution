using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._16
{
    public class CharacterFinder
    {
        public char aCharacter { get; set; }

        public string find(char myCharacter)
        {
            List<char> charList = new List<char>();
            charList.Add(aCharacter);
            if (charList.Count == 1)
            {
                return "1";
            }
            return "0";

        }
    }
}

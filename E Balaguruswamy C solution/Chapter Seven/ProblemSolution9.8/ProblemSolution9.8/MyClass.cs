using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._8
{
   public class MyClass
    {
       public string input { get; set; }

       public string lowerToUpper(string input)
       {
           string upperString = input.ToUpper();
           return upperString;
       }
    }
}

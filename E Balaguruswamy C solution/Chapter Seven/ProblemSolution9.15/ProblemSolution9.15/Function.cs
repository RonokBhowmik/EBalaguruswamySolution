using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._15
{
   public class Function
    {
        string s1 = "Bangladesh";
        string s2 = "India";

        public string copy()
        {
            string s4 = s2;
            string s5 = s1;
            return s4;

        }

        public int compare()
        {
            int compareTo = s1.CompareTo(s2);
            return compareTo;
        }

        public string concate()
        {
            string s3 = s1 + s2;
            return s3;
        }
    }
}

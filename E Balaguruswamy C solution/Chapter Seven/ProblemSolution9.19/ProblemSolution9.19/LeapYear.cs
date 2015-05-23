using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemSolution9._19
{
    class LeapYear
    {
        public int Year { get; set;}

        public string leap()
        {
            if (Year % 4== 0)
            {
                return "Leap year";
            }
            return "not leap year";
        }
    }
}

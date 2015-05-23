using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution9._1
{
   public class Interchange
   {
       public int x = 10;
       public int y = 30;

       public void exchange()
       {
           int z = x;
           x = y;
           y = z;
           Console.WriteLine("x is:"+x);
           Console.WriteLine("y is:" + y);

       }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution7._5
{
   public class Student
    {
       public string rollNo { get; set; }

       public double subjectOneMarks { get; set; }

       public double subjectTwoMarks { get; set; }

       public double subjectThreeMarks { get; set; }

       public double sum { get; set; }

       public Student(string rollNo, double subjectOneMarks, double subjectTwoMarks, double subjectThreeMarks):this()
       {
           this.rollNo = rollNo;
           this.subjectOneMarks = subjectOneMarks;
           this.subjectTwoMarks = subjectTwoMarks;
           this.subjectThreeMarks = subjectThreeMarks;
       }

       public Student()
       {
       }
    }
}

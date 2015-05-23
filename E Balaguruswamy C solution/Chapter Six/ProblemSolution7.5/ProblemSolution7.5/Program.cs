using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution7._5
{
    class Program
    {
        private static Student aStudent;

        static void Main(string[] args)
        {
            List<Student> studentInfoList = new List<Student>();
            
            int counter=1;
            for (int i = 1; i <=2; i++)
            {
                Console.WriteLine("Student Number:"+counter);
                Console.WriteLine("-------------------------------------");
                aStudent = new Student();
                Console.Write("Enter the Roll Number,Roll Number:");
                aStudent.rollNo = Console.ReadLine();
                Console.WriteLine("-------------------------------------");
                Console.Write("Enter Subject1 Marks,Subject 1:");
                aStudent.subjectOneMarks = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Subject2 Marks,Subject 2:");
                aStudent.subjectTwoMarks = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Subject3 Marks,Subject 3:");
                aStudent.subjectThreeMarks = Convert.ToDouble(Console.ReadLine());
                aStudent.sum = aStudent.subjectOneMarks + aStudent.subjectTwoMarks + aStudent.subjectThreeMarks;
                counter++;
                studentInfoList.Add(aStudent);
            }
            Console.WriteLine("\n");
            Console.WriteLine("*******************************Result*******************************");
            Console.WriteLine("Roll No" + "\t" + "Subject 1" + "\t" + "Subject 3" + "\t" + "Subject 4"+"\t"+"Total Marks");
            Console.WriteLine("--------------------------------------------------------------------");
            foreach (var aStudent1 in studentInfoList)
            {
                Console.WriteLine(aStudent1.rollNo+"\t"+"\t"+aStudent1.subjectOneMarks+"\t"+"\t"+aStudent1.subjectTwoMarks+"\t"+"\t"+aStudent1.subjectThreeMarks+"\t"+aStudent1.sum);
            }
            Console.WriteLine("Roll Number"+"\t"+"Highest in Subject 1" + "\t" + "Highest  in Subject 2" + "\t" + "Highest  in Subject 3" );
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Roll Number"+"\t"+"Highest Total Marks:");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution8._10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> rollNumbersList = new List<string>();
            for (int i = 0; i <2; i++)
            {
                Console.Write("Enter RollNo:");
                string rollNo = string.Empty;
                rollNo = Console.ReadLine();
                rollNumbersList.Add(rollNo);
                rollNumbersList.Sort();
            }
            
            List<string>nameList=new List<string>();
            for (int i = 0; i <2; i++)
            {
                Console.Write("Enter Name:");
                string name=Console.ReadLine();
                nameList.Add(name);
            }



           
            List<double>marksList=new List<double>();
            for (int i = 0; i <2; i++)
            {
                Console.Write("Enter Marks:");
                double marks = Convert.ToDouble(Console.ReadLine());
                marksList.Add(marks);
            }
            Console.WriteLine("Roll No." + "\t" + "Name" + "\t" + "Marks obtained");
            Console.WriteLine("--------------------------------------------------");
            foreach (var aRollNumber in rollNumbersList)
            {
                Console.WriteLine(aRollNumber);    
            }
            foreach (var aName in nameList)
            {
                Console.WriteLine("\t"+aName);
            }
            
            Console.ReadKey();
        }
    }
}

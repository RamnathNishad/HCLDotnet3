using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProceduralProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //store the details of a student like rollno,name and total marks and display the 
            //student's result as Pass or Fail based on total marks assuming above 60 is pass else
            //failed. Display all the details of the student.

            int rollno;
            string sname;
            int totalMarks;
            string result;

            Console.WriteLine("Enter rollno:");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter total marks:");
            totalMarks = int.Parse(Console.ReadLine());

            result = GetResult(totalMarks);

            DisplayDetails(rollno, sname, totalMarks, result);
            
        }
        static void DisplayDetails(int rollno,string sname,int totalMarks,string result)
        {
            Console.WriteLine("Roll number:" + rollno);
            Console.WriteLine("Name       :" + sname);
            Console.WriteLine("Marks      :" + totalMarks);
            Console.WriteLine("Result     :" + result);

        }
        static string GetResult(int totalMarks)
        {
            string result;

            if (totalMarks > 60)
            {
                result = "Pass";
            }
            else
            {
                result = "Failed";
            }

            return result;
        }
    }
}

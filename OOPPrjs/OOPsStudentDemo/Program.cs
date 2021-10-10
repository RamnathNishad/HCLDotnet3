using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsStudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {         

            int rollno;
            string sname;
            int totalMarks;

            Console.WriteLine("Enter rollno:");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter total marks:");
            totalMarks = int.Parse(Console.ReadLine());

            Student s = new Student();
            s.StoreDetails(rollno, sname, totalMarks);
            s.DisplayDetails();


            s.Name = "Alex";
            s.TotalMarks = 180;
            
            Console.WriteLine("Updated name:" + s.Name);
            Console.WriteLine("Updated marks:" + s.TotalMarks);

        }
    }

    //define the class
    class Student
    {
        int _rollNo;
        string _sname;
        int _totalMarks;
        string _result;

        public string Name
        {
            get { return this._sname; }
            set { this._sname = value; }
        }
        public int TotalMarks
        {
            get { return this._totalMarks; }
            set 
            {
                if (value > 100)
                {
                    Console.WriteLine("invalid marks, must not exceed 100");
                }
                else
                {
                    this._totalMarks = value;
                }
            }
        }

        public void StoreDetails(int _rollNo,string sname,int totalMarks)
        {
            this._rollNo = _rollNo;
            this._sname = sname;
            this._totalMarks = totalMarks;
        }
        void CalculateResult()
        {
            if(_totalMarks>60)
            {
                this._result = "Pass";
            }
            else
            {
                this._result = "Failed";
            }
        }
        public void DisplayDetails()
        {
            CalculateResult();

            Console.WriteLine("Roll number:" + _rollNo);
            Console.WriteLine("Name       :" + _sname);
            Console.WriteLine("Marks      :" + _totalMarks);
            Console.WriteLine("Result     :" + _result);
        }
    }
}

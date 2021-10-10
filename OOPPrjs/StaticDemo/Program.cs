using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {     
            Console.WriteLine("Power:" + Math.Pow(2,3));
            Console.WriteLine("Sqrt:" + Math.Sqrt(16));

            //Employee.companyName = "HCL Bangalore"; //if member is public

            Employee e1 = new Employee();
            e1.Store(101, "Ravi", 1111);
            e1.Display();

            Employee e2 = new Employee();
            e2.Store(102, "Raghu", 2222);
            e2.Display();



            Test.Method1();
            Test.Method2();
            Test.Method3();

            //Test t = new Test(); static class instance not allowed
            
        }
    }

    class Employee
    {
        int ecode;
        string ename;
        int salary;
        static string companyName;

        public void Store(int ec,string en, int sal)
        {
            this.ecode = ec;
            this.ename = en;
            this.salary = sal;
            companyName = "HCL Bangalore";
        }
        public void Display()
        {
            Console.WriteLine(this.ecode+"\t" +this.ename+"\t"+this.salary+"\t" + companyName);
        }
    }


    static class Test
    {
        public static void Method1()
        {
            //TODO
        }
        public static void Method2()
        {
            //TODO
        }
        public static void Method3()
        {
            //TODO
        }
    }
}

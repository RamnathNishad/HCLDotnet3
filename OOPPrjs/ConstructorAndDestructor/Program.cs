using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer c = new Customer();
            Console.WriteLine("Enter customer id:");
            c.CustomerId = int.Parse(Console.ReadLine());

            Console.WriteLine("Customer Id:" + c.CustomerId);

            // Test t=new Test();

            // t.DoTask();
            // t.DoTask();


            // Test t2 = new Test();


            Employee emp = new Employee(101, "Ramnath", 1111, 201);
            emp.Display();

            Employee emp2 = new Employee(102, "Ravi", 2222, 202);
            emp2.Display();
            }
    }
    class Test
    {
        public  Test()
        {
            Console.WriteLine("constructor called");
        }
        public void DoTask()
        {
            Console.WriteLine("Some task");
        }
        ~Test() //Tilde
        {
            Console.WriteLine("destructor called");
        }
    }


    class Employee
    {
        int ecode;
        string ename;
        int salary;
        int deptid;

        public Employee(int ecode, string ename,int salary, int deptid)
        {
            this.ecode = ecode;
            this.ename = ename;
            this.salary = salary;
            this.deptid = deptid;
        }
        public void Display()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}",ecode,ename,salary,deptid);
        }
    }
}



class Customer
{
    int custId;
    public int CustomerId
    {
        get { return this.custId; }
        set { this.custId = value; }
    }



    string cname;
    string city;



}
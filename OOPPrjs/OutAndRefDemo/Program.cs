using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutAndRefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("Before Swap:a={0} b={1}", a, b);

            Test obj = new Test();
            obj.Swap(ref a, ref b);

            Console.WriteLine("After Swap:a={0} b={1}", a, b);





            int salary = 7000;
            double bonus = 0;

            Employee emp = new Employee();
            emp.CalculateBonus(salary, out bonus);
            Console.WriteLine("Salary:{0}   Bonus:{1}",salary,bonus);
        }
    }
    class Test
    {
        public void Swap(ref int n1,ref int n2)
        {
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("Inside Swap:n1={0} n2={1}", n1, n2);
        }
    }

    class Employee
    {
        public void CalculateBonus(int salary, out double bonus)
        {
            //if(salary>5000)
            bonus = salary * 0.1;
        }
    }
}

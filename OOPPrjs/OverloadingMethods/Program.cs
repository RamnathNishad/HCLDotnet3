using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            Console.WriteLine("Sum:" + obj.Add(100,200));
            Console.WriteLine("Sum:" + obj.Add(100, 200,300));

            double d1 = 10.5, d2 = 11.3;
            Console.WriteLine("Sum:" + obj.Add(d1,d2));

            Console.WriteLine("Sum:" + obj.Add(5,10.2));
            Console.WriteLine("Sum:" + obj.Add(10.2,5));
        }
    }

    class Calculator
    {
        public int Add(int n1, int n2)
        {
            int result = n1 + n2;
            return result;
        }
        public int Add(int n1, int n2, int n3) //overloading based on number of parameters
        {
            int result = n1 + n2 + n3;
            return result;
        }
        public double Add(double n1, double n2) //overloading based on data-types
        {
            double result = n1 + n2;
            return result;
        }
        public double Add(int n, double d)
        {
            double result = n + d;
            return result;
        }
        public double Add(double d,int n)//overloading based on order of parameters
        {
            double result = n + d;
            return result;
        } 

        //public double Add(int n1, int n2) //can't be overloaded based on return type of the method
        //{
        //    double result = n1 + n2;
        //    return result;
        //}
    }
}

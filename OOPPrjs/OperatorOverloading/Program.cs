using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {      
            Calculator c1 = new Calculator();
            c1.N1 = 10;
            c1.N2 = 20;

            Calculator c2 = new Calculator();
            c2.N1 = 5;
            c2.N2 = 3;

            Calculator c =  c1 + c2;

            Console.WriteLine("C.N1="+ c.N1);
            Console.WriteLine("C.N2=" + c.N2);

            c = c1 - c2;
            Console.WriteLine("C.N1=" + c.N1);
            Console.WriteLine("C.N2=" + c.N2);

            c = c1 * c2;
            Console.WriteLine("C.N1=" + c.N1);
            Console.WriteLine("C.N2=" + c.N2);
        }
    }

    class Calculator
    {
        int n1;
        int n2;
        public int N1
        {
            get { return this.n1; }
            set { this.n1 = value; }
        }
        public int N2
        {
            get { return this.n2; }
            set { this.n2 = value; }
        }

       
        public static Calculator operator+(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.N1 = c1.N1 + c2.N1;
            c.N2 = c1.N2 + c2.N2;

            return c;
        }
        public static Calculator operator -(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.N1 = c1.N1 - c2.N1;
            c.N2 = c1.N2 - c2.N2;

            return c;
        }
        public static Calculator operator *(Calculator c1, Calculator c2)
        {
            Calculator c = new Calculator();
            c.N1 = c1.N1 * c2.N1;
            c.N2 = c1.N2 * c2.N2;

            return c;
        }
    }
}

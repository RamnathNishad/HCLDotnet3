using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversions
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("int max value:" + int.MaxValue);
            //Console.WriteLine("long max value:" + long.MaxValue);

            //1. value-type to value-type
            int i = 100;

            long l =  i; //implicit conevrsion

            int a = (int)l; //explicit, data-loss may happen

           Console.WriteLine("Long L="+ l);
            Console.WriteLine("Integer A=" + a);


            //2. Value-type to reference-type

            int x = 100; //value-type
            object o = x; //Boxing, implicit

            //3. Reference type to value-type
            int y = (int)o; //UnBoxing, explicit 
            Console.WriteLine("Y="+ y);

            //4. Reference to reference 
            //One reference to another reference can be converted only when there is an inheritance
            //relation among them or both shud be of same class type
            //


            double d = 10.5;
            int e = Convert.ToInt32(d);
            Console.WriteLine(e);

            d = float.Parse("10.5");
            Console.WriteLine(d);
        }
    }  
}

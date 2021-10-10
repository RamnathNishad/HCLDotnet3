using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //object o = null;


            Nullable<int> i = null;
            i = 100;
            if(i.HasValue)
            {
                Console.WriteLine(i.Value);
            }



            double? d = 10.5;
            d = null;



            //int x = null; //invalid as null cannot be stored in a value-type variable

            int? x = null; //nullable value-type i.e. can store null also remaining as a value-type

            x = 10;

            //Console.WriteLine(x.GetType());

            if(x.HasValue)
            {
                int y = x.Value;
                Console.WriteLine("Y=" + y);
            }
            else
            {
                Console.WriteLine("no value");
            }
           
        }
    }
}

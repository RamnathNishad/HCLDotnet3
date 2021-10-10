using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsrAndReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Test
    {
        const double PI = 3.14156;
        readonly int r;

        public Test()
        {
            //PI = 3.14; not allowed for constant
            r = 200; //allowed for readonly
        }
        public void ChangeThem()
        {
            //PI = 3.14; not allowed 
            //r = 200; not allowed
        }
    }
}

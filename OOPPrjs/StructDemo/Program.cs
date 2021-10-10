using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
   
    class Program
    {        
        static void Main(string[] args)
        {

            //int inum = Console.ReadLine();

            //declare a structure variable
            Address adr1 = new Address();
            adr1.StoreData("95/26", "Bangalore", "Karnataka", "560132");
            adr1.Display();          

            
        }
    }

    //address------> hno,city,state,pin

    //define
    struct Address
    {
        string hno;
        string city;
        string state;
        string pin;

        public void StoreData(string _houseNo,string _city,string _state,string _pin)
        {
            hno = _houseNo;
            city = _city;
            state = _state;
            pin = _pin;
        }
        public void Display()
        {
            Console.WriteLine("\nHounse No.:" + hno);
            Console.WriteLine("City      :" + city);
            Console.WriteLine("State     :" + state);
            Console.WriteLine("Pin number:" + pin);
        }
    }

    class Test
    {
        public void Display()
        {
            Console.WriteLine("Hello");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    enum MenuChoice
    {
        Add=10,
        Multiply=20,
        Subtract=30,
        Divide=40,
        Exit=5
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, result, choice;
            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("10.Add");
                Console.WriteLine("20.Multiply");
                Console.WriteLine("30.Subtract");
                Console.WriteLine("40.Divide");
                Console.WriteLine("5.Exit");
                Console.Write("Enter choice:");
                choice = int.Parse(Console.ReadLine());

                Console.Write("Enter N1:");
                n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter N2:");
                n2 = int.Parse(Console.ReadLine());

                switch (choice)
                {                  
                    case (int)MenuChoice.Add:
                        result = n1 + n2;
                        Console.WriteLine("Sum:" + result);
                        break;
                    case (int)MenuChoice.Subtract:
                        result = n1 - n2;
                        Console.WriteLine("Subtract:" + result);
                        break;
                    case (int)MenuChoice.Multiply:
                        result = n1 * n2;
                        Console.WriteLine("Multiply:" + result);
                        break;
                    case (int)MenuChoice.Divide:
                        result = n1 / n2;
                        Console.WriteLine("Divide:" + result);
                        break;
                    case (int)MenuChoice.Exit:
                        Console.WriteLine("Exited...");
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            } while (choice != 5);
        }
    }
}

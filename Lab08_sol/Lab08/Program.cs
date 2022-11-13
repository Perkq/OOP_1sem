using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss b1 = new Boss(1);
            Boss b2 = new Boss(5);

            Events Ev = new Events();

            b1.upgrade += Newlevel => Console.WriteLine(Newlevel);
            b1.turnOn += Ev.CheckVoltage;

            b1.GetLevel();
            b1.GiveVoltage(250);

            b2.turnOn += Ev.CheckVoltage;
            b2.GiveVoltage(100);


            // Методы строк
            Console.WriteLine("\n Методы строк \n");

            string DoOperation(string str, Func<string, string> operation) => operation(str);

            string example = "He?llo world";
            Console.WriteLine(DoOperation(example, Str.RemoveS));
            Console.WriteLine(DoOperation(example, Str.AddToString));
            Console.WriteLine(DoOperation(example, Str.RemoveSpase));
            Console.WriteLine(DoOperation(example, Str.Upper));
            Console.WriteLine(DoOperation(example, Str.Lower));
        }
    }
}

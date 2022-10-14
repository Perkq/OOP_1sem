using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad test = new Ad(288, "2 month");

            Printer print = new Printer();
            Object secr = new News("порно", "10 years");

            Console.WriteLine(print.IAmPrinting(secr));
        }
    }
}

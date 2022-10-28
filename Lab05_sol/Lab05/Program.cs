﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Ad test = new Ad(288, 2);

            Printer print = new Printer();
            Object secr = new News(new NewsTopic("Crime"), 10);

            Film testFilm = new Film("Топчик", "Мужик");

            object testPolimorph = testFilm as Producer;
            if(testPolimorph != null)
            {
                Console.WriteLine(print.IAmPrinting(testPolimorph));
            }
            else
            {
                Console.WriteLine("Операция невозможна");
            }

            Ad testAd = new Ad(552, 15);

            object testPolimAd = testAd as TVProgram;
            if (testPolimAd is TVProgram)
            {
                Console.WriteLine(print.IAmPrinting(testPolimAd));
            }
            else
            {
                Console.WriteLine("Операция невозможна");
            }

            Console.WriteLine(print.IAmPrinting(secr));

        }
    }
}

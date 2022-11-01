using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();

            try
            {
                Film test = new Film("20.22", "Male");

                Ad testAd1 = new Ad(288, 2);

                Printer print = new Printer();
                Object secr = new News(new NewsTopic("Crime"), 10);

                Film testFilm = new Film("20.02.202222", "Gey");

                Num check = new Num(10);
                check.Omnomnom();
                object testPolimorph = testFilm as Producer;
                if (testPolimorph != null)
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
            catch (MyException ex)
            {
                fileLogger.WriteLog(ex);
            }
            finally
            {
                Console.WriteLine("Все ок");
            }



            try
            {
                int x = 5, y = 0;
                int c = x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }

            try
            {

                int[] arr = new int[8];
                arr[10] = 10;
            }
            catch (Exception e) when (e.Source.Length < 6)
            {
                Console.WriteLine(e.Source);
            }
            catch
            {
                Console.WriteLine("Что-то пошло не так\n");

            }

            Debugger.Break();

            int debugTest = 10;

            Debug.Assert(debugTest == 11, "Переменная не равна 10");

        }
    }
}

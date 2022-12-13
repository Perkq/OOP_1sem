using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            { 
                Console.Write("Введите номер проверки: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Matrix<int> test = new Matrix<int>(4, 4);
                        Matrix<int> test2 = new Matrix<int>(4, 4);

                        for (int i = 0; i < test.RowsNum; i++)
                        {
                            for (int q = 0; q < test.ColNum; q++)
                            {
                                test[i, q] = i;
                                Console.Write(test[i, q] + " ");
                            }
                            Console.WriteLine();

                        }

                        Console.WriteLine();

                        for (int i = 0; i < test.RowsNum; i++)
                        {
                            for (int q = 0; q < test.ColNum; q++)
                            {
                                test2[i, q] = q;
                                Console.Write(test2[i, q] + " ");
                            }
                            Console.WriteLine();
                        }

                        Matrix<int> minus = test2 - test;

                        Console.WriteLine();

                        for (int i = 0; i < minus.RowsNum; i++)
                        {
                            for (int q = 0; q < minus.ColNum; q++)
                            {
                                Console.Write(minus[i, q] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Matrix<int> testInkr = new Matrix<int>(4, 4);

                        for (int i = 0; i < testInkr.RowsNum; i++)
                        {
                            for (int q = 0; q < testInkr.ColNum; q++)
                            {
                                testInkr[i, q] = i;
                                Console.Write(testInkr[i, q] + " ");
                            }
                            Console.WriteLine();

                        }

                        Console.WriteLine();

                        for (int i = 0; i < testInkr.RowsNum; i++)
                        {
                            for (int q = 0; q < testInkr.ColNum; q++)
                            {
                                testInkr[i, q]++;
                                Console.Write(testInkr[i, q] + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Matrix<int> testEq = new Matrix<int>(4, 4);
                        Matrix<int> testEqSec = new Matrix<int>(4, 4);


                        for (int i = 0; i < testEq.RowsNum; i++)
                        {
                            for (int q = 0; q < testEq.ColNum; q++)
                            {
                                testEq[i, q] = i;
                                testEqSec[i, q] = q;
                            }
                        }
                        Console.WriteLine(testEq != testEqSec);
                        Console.WriteLine(testEq == testEqSec);

                        Matrix<Ad> objExample = new Matrix<Ad>(4, 4);

                        Ad frst = new Ad(10, "hour");
                        Ad sec = new Ad(30, "day");
                        Ad thrd = new Ad(15, "week");

                        objExample.Add(frst);
                        objExample.Add(sec);
                        objExample.Add(thrd);

                        for (int i = 0; i < objExample.RowsNum; i++)
                        {
                            for (int q = 0; q < objExample.ColNum; q++)
                            {
                                objExample[i, q] = i;
                                objExample[i, q] = q;
                            }
                        }
                        objExample.InFile();
                        break;
                    case 4:
                        Matrix<int> testInt = new Matrix<int>(4, 4);

                        for (int i = 0; i < testInt.RowsNum; i++)
                        {
                            for (int q = 0; q < testInt.ColNum; q++)
                            {
                                testInt[i, q] = q;
                                Console.Write(testInt[i, q] + " ");
                            }
                            Console.WriteLine();

                        }
                        Console.WriteLine((int)testInt);
                        break;
                    case 5:
                        Matrix<int>.Developer testDev = new Matrix<int>.Developer();
                        testDev.GetDev();
                        Matrix<int>.org.GetDev();
                        break;
                }
                Matrix<int> intExample = new Matrix<int>(4,4);
                intExample.Add(10);
                intExample.Add(115);


                Matrix<double> floatExample= new Matrix<double>(4, 4);
                floatExample.Add(12.4123);
                floatExample.Add(124.4123);

           

            }
            catch
            {
                Console.WriteLine("ОШИБКА!!!!");
            }
            finally
            {
                Console.WriteLine("Все прошло по кайфу");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Введите номер проверки: ");
            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Matrix test = new Matrix(4, 4);
                    Matrix test2 = new Matrix(4, 4);

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

                    Matrix minus = test2 - test;

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
                    Matrix testInkr = new Matrix(4, 4);

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
                    Matrix testEq = new Matrix(4, 4);
                    Matrix testEqSec = new Matrix(4, 4);


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
                    break;
                case 4:
                    Matrix testInt = new Matrix(4, 4);

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
                    Matrix.Developer testDev = new Matrix.Developer();
                    testDev.getDev();
                    Matrix.org.getDev();
                    break;
            }
        }
    }
}

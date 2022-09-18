using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1

            Console.WriteLine("Введите значения типа: int, string, char, double, bool, byte, sbyte, decimal, float, short, ushort, uint, ulong");
            int i = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();
            char c = Convert.ToChar(Console.ReadLine());
            double f = Convert.ToDouble(Console.ReadLine());
            bool lol = Convert.ToBoolean(Console.ReadLine());
            byte b = Convert.ToByte(Console.ReadLine());
            sbyte sb = Convert.ToSByte(Console.ReadLine());
            decimal dc = Convert.ToDecimal(Console.ReadLine());
            float fl = Convert.ToSingle(Console.ReadLine());
            short sh = Convert.ToInt16(Console.ReadLine());
            ushort ush = Convert.ToUInt16(Console.ReadLine());
            uint ui = Convert.ToUInt32(Console.ReadLine());
            ulong ul = Convert.ToUInt64(Console.ReadLine());
            //nint ni = Convert.ToInt32(Console.ReadLine());
            //nuint nui = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine(i + " " + str + " " + c + " "+ f + " " + lol + " " + b + " " + sb + " " + dc + " " + fl + " " + sh + " " + ush + " " + ui + " " + ul);

            // Неявные преобразования
            long bigNum = i;
            int bigNumInt = sh;
            ulong bigUNum = ul;
            uint bigUInt = ui;
            double bigNumDouble = fl;

            // Явные преобразования 
            sbyte sByteNum = (sbyte)b;
            uint uIntNum = (uint)i;
            decimal decNum = (decimal)i;
            float flNum = (float)f;
            ushort uShNum = (ushort)sh;
            float flNum2 = (float)f;

            Console.WriteLine("double до преобразования во float: " + f + " после: " + flNum2);

            // Упаковка и распаковка значимых типов
            Object Example = i;
            Example = 123;
            i = (int)Example;

            // NullAble
            int? qweqw = null;

            // Неявно типизированные переменные
            var implExample = "Lol kek";
            // implExample = 23;
            Console.WriteLine(implExample);

            // Задание 2

            string strLit = "Valera";
            string strLit2 = "Petya";
            Console.WriteLine("Сравнение строковых литералов: " + (strLit == strLit2));

            Console.WriteLine("Копируем строку: " + String.Copy(strLit));
            Console.WriteLine("Складываем строки: " + String.Concat(strLit, strLit2));
            Console.WriteLine("Берём подстроку:" + strLit.Substring(3));
            Console.WriteLine("Деление строки на слова: ");
            string strDiv = "Hello dear world";
            string[] arrStr;
            arrStr = strDiv.Split();
            for (int count = 0; count < arrStr.Length; count++)
            {
                Console.WriteLine(arrStr[count]);
            }
            Console.WriteLine("Вставим подстроку в строку в заданную позицию: " + strLit.Insert(4, strLit2));
            Console.WriteLine($"Удаление заданной подстроки: {strLit.Remove(3)}");

            string empty = "";
            string strNull = null;
            Console.WriteLine($"Сравнение пустой и null-строки: {(empty == strNull)}");
            Console.WriteLine($"Использование метода .IsNullOrEmpty для пустого: {String.IsNullOrEmpty(empty)} для null-строки: {String.IsNullOrEmpty(strNull)}");

            StringBuilder stringBuilder = new StringBuilder("dear world", 20);
            stringBuilder.Append(new char[] { '!', '!', '!' });
            stringBuilder.Insert(0, "Hello ");
            stringBuilder.Remove(6, 4);
            Console.WriteLine(stringBuilder);

            // Задание 3

            int[,] arr = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            for (int rrr = 0; rrr < rows; rrr++)
            {
                for (int ccc = 0; ccc < columns; ccc++)
                {
                    Console.Write($"{arr[rrr, ccc]} \t");
                }
                Console.WriteLine();
            }

            string[] strArray = { "Привет", " как ", "дела?" };

            for (int count = 0; count < strArray.Length; count++)
            {
                Console.Write(strArray[count]);
            }
            Console.WriteLine(" Длинна массива: " + strArray.Length);

            Console.Write("Введите позицию и значение: ");
            int index = Convert.ToInt32(Console.ReadLine());
            string strChange = Console.ReadLine();

            strArray[index] = strChange;
            for (int q = 0; q < strArray.Length; q++)
            {
                Console.WriteLine(strArray[q]);
            }

            float[][] flArray = new float[3][];
            flArray[0] = new float[2];
            flArray[1] = new float[3];
            flArray[2] = new float[4];

            Console.Write("Введите значения первой строки: ");
            for (int count = 0; count < 2; count++)
            {
                flArray[0][count] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Введите значения второй строки: ");
            for (int count = 0; count < 3; count++)
            {
                flArray[1][count] = Convert.ToSingle(Console.ReadLine());
            }

            Console.Write("Введите значения третьей строки: ");
            for (int count = 0; count < 4; count++)
            {
                flArray[2][count] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Вывод ступенчатого массива: ");
            for (int count = 0; count < 2; count++)
            {
                Console.Write(flArray[0][count] + " ");
            }

            Console.WriteLine();
            for (int count = 0; count < 3; count++)
            {
                Console.Write(flArray[1][count] + " ");
            }

            Console.WriteLine();
            for (int count = 0; count < 4; count++)
            {
                Console.Write(flArray[2][count] + " ");
            }

            Console.WriteLine();

            var implArr = new[] { 1, 2, 3 };
            var implStr = "String";

            // Кортежи

            (int intNum, string strTup, char charTup, string strSecTup, ulong ulongNum) tuple = (34, "first string", 'q', "second string", 53464362);
            Console.WriteLine("Вывод всех элементов кортежа: " + tuple.intNum + " " + tuple.strTup + " " + tuple.charTup + " " + tuple.strSecTup + " " + tuple.ulongNum);
            Console.WriteLine("Вывод 1, 3, 4 элементов кортежа: " + tuple.intNum + " " + tuple.charTup + " " + tuple.strSecTup);

            var (unboxInt, unboxStr, unboxChar, unboxSecStr, unboxUlong) = (tuple.intNum, tuple.strTup, tuple.charTup, tuple.strSecTup, tuple.ulongNum);
            unboxInt = tuple.intNum;

            (int Num, bool Bool) firstTup = (10, true);
            (int Num, bool Bool) secTup = (10, true);
            Console.WriteLine($"Сравнение кортежей на равенство: {firstTup == secTup}");
            Console.WriteLine($"Сравнение кортежей на неравенство: {firstTup != secTup}");

            int[] locArr = { 6, 5, 7, 10 };
            string locStr = "Привет Андрей";
            Console.WriteLine(localFunc(locArr, locStr));

            dynamic localFunc(int[] array, string strLoc)
            {
                int max = array[0];
                int min = array[0];
                int sum = 0;
                char firstLetter = strLoc[0];
                foreach (int arrEl in array)
                {
                    if (arrEl > max)
                    {
                        max = arrEl;
                    }
                    else if (arrEl < min)
                    {
                        min = arrEl;
                    }
                    sum += arrEl;
                }

                (int maxNum, int minNum, int sumNum, char firstLet) retTup = (max, min, sum, firstLetter);

                return retTup;
            }

            Console.WriteLine(funCheck());
            string funCheck()
            {
                int maxInt = int.MaxValue;

                try
                {
                    checked
                    {
                        Console.WriteLine(maxInt + 1);
                    }
                }
                catch (OverflowException exception)
                {
                    return exception.Message;
                }
                return "Нет ошибок";
            }

            Console.WriteLine(funUncheck());
            int funUncheck()
            {
                int maxInt = int.MaxValue;

                unchecked
                {
                    return (maxInt + 1);
                }
            }
        }
    }
}

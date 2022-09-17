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
        }
    }
}

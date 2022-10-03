using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperString[] strings = new SuperString[3];
            strings[0] = new SuperString("Hello", 5);
            strings[1] = new SuperString("dear", 4);
            strings[2] = new SuperString("world", 5);

            SuperString.GetNumOfStrings();
            Console.Write("Задайте кол-во символов в строке: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список строк с данным кол-вом символов в строке: ");
            foreach (SuperString str in strings)
            {
                if (str.GetNumOfSymbols() == number)
                {
                    Console.WriteLine(str.StringValue);
                }
            }

            Console.Write("Задайте слово: ");
            string userWord = Console.ReadLine();
            Console.WriteLine("Строки, в которых есть такое слово: ");
            foreach (SuperString str in strings)
            {
                if (str.FindWord(ref userWord))
                {
                    Console.WriteLine(str.StringValue);
                }
            }

            Console.Write("Введите номеров объектов в массиве, которые хотите сравнить: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(strings[firstNum - 1].Equals(strings[secondNum - 1]));

            Console.WriteLine("Введите номер строки, которую хотите вывести: ");
            int numOfStrings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вывод информации о строке: ");
            strings[numOfStrings - 1].ToString();

            Console.WriteLine(strings[0].StringValue);
            strings[0].ChangeSymbol(3, 'X');
            Console.WriteLine(strings[0].GetNumOfSymbols());
            Console.WriteLine(strings[0].CheckSym('D'));

        }
    }
}

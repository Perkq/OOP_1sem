using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    partial class SuperString
    {

        private readonly int id;
        private string stringValue;
        private int symbolsNumber;
        static int numberOfStrings = 0;
        public const string strExample = "Example string";
        public string StringValue
        {
            get
            {
                return stringValue;
            }

            set
            {
                if(!String.IsNullOrEmpty(stringValue))
                { 
                stringValue = value;
                }
                else
                {
                    Console.WriteLine("Неверно введена строка");
                }
            }
        }
        
        // Конструктор по умолчанию
        public SuperString()
        {
            stringValue = "Default string";
            symbolsNumber = 0;
            id = GetHashCode();
            numberOfStrings++;
        }

        // Неполный конструктор
        public SuperString(string thisStringValue)
        {
            stringValue = thisStringValue;
            id = GetHashCode();
            numberOfStrings++;
        }

        // Полный конструктор
        public SuperString(string thisStringValue, int thisStrSymbolsNumber)
        {
            stringValue = thisStringValue;
            symbolsNumber = thisStrSymbolsNumber;
            id = GetHashCode();
            numberOfStrings++;
        }

        // Закрытый конструктор
        /*private SuperString()
        {

        }*/

        //Статический метод
        static void getNumOfStrings()
        {
            Console.WriteLine("Кол-во записанных строк: " + numberOfStrings);
        }

        public int getNumOfSymbols()
        {
            if(symbolsNumber != 0)
            {
                return symbolsNumber;
            }
            else 
            {
                return stringValue.Length;
            }
        }

        public int checkSym(char usersSym)
        {
            for(int i = 0; i < stringValue.Length; i++)
            {
                if (stringValue[i] == usersSym)
                {
                    Console.WriteLine("Введенный символ есть в строке");
                    return 0;
                }
            }

            Console.WriteLine("Введенного символа нет в строке");
            return 0;
        }

        public int changeSymbol(int position, char symbol)
        {
            char[] temp = stringValue.ToCharArray();
            temp[position] = symbol;
            stringValue = new string(temp);
            return 0;
        }

        public bool findWord(string userWord)
        {
            string[] arr;
            arr = StringValue.Split();
            foreach(string temp in arr)
            {
                if(temp == userWord)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperString[] strings = new SuperString[3];
            strings[0] = new SuperString("Hello", 5);
            strings[1] = new SuperString("dear", 4);
            strings[2] = new SuperString("world", 5);

            
            Console.Write("Задайте кол-во символов в строке: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список строк с данным кол-вом символов в строке: ");
            foreach(SuperString str in strings)
            {
                if(str.getNumOfSymbols() == number)
                {
                    Console.WriteLine(str.StringValue);
                }
            }

            Console.Write("Задайте слово: ");
            string userWord = Console.ReadLine();
            Console.WriteLine("Строки, в которых есть такое слово: ");
            foreach(SuperString str in strings)
            {
                if(str.findWord(userWord))
                {
                    Console.WriteLine(str.StringValue);
                }
            }

            /*Console.WriteLine(Example.StringValue);
            Example.changeSymbol(3, 'X');
            Console.WriteLine(Example.getNumOfSymbols());
            Console.WriteLine(Example.checkSym('D'));*/

        }
    }
}

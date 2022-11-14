using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    partial class SuperString
    {
        private readonly int id;
        private string stringValue;
        private int symbolsNumber;
        static int numberOfStrings;
        public const string strExample = "Example string";

        public int NumberOfStrings
        {
            get
            {
                return numberOfStrings;
            }
        }
        public string StringValue
        {
            get
            {
                return stringValue;
            }

            set
            {
                if (!String.IsNullOrEmpty(stringValue))
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

        // Полный конструктор
        public SuperString(string thisStringValue)
        {
            stringValue = thisStringValue;
            symbolsNumber = thisStringValue.Length;
            id = GetHashCode();
            numberOfStrings++;
        }

        // статический конструктор
        static SuperString()
        {
            numberOfStrings = 0;
        }

        // Закрытый конструктор
        SuperString(int symbolsNumber) : this()
        {
            this.symbolsNumber = symbolsNumber;
        }

        //Статический метод
        public static void GetNumOfStrings()
        {
            Console.WriteLine("Кол-во записанных строк: " + numberOfStrings);
        }


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            SuperString str = obj as SuperString;
            if (str == null)
                return false;
            return this.stringValue == str.stringValue && this.symbolsNumber == str.symbolsNumber;
               
        }

        public override int GetHashCode()
        {
            var hash = 0;
            foreach (char temp in stringValue)
            {
                hash += Convert.ToInt32(temp);
            }
            return Convert.ToInt32(hash);
        }

        public int GetNumOfSymbols()
        {
            if (symbolsNumber != 0)
            {
                return symbolsNumber;
            }
            else
            {
                return stringValue.Length;
            }
        }

        public int CheckSym(char usersSym)
        {
            for (int i = 0; i < stringValue.Length; i++)
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

        public int ChangeSymbol(int position, char symbol)
        {
            char[] temp = stringValue.ToCharArray();
            temp[position] = symbol;
            stringValue = new string(temp);
            return 0;
        }

        public override string ToString()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Строка: {stringValue}");
            Console.WriteLine($"Кол-во символов: {symbolsNumber}");
            return "";
        }

        public bool FindWord(ref string userWord)
        {
            string[] arr;
            arr = StringValue.Split();
            foreach (string temp in arr)
            {
                if (temp == userWord)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

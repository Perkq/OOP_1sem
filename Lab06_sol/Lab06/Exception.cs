using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.IO;
using System.Data;

namespace Lab05
{
    public class MyException : System.Exception
    {
        public string ErrorClass { get; set; }
        public MyException(string message, string errorClass)
            : base(message)  // наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }

    public class GenderException : MyException
    {

        public string Gender { get; set; }
        public GenderException(string message, string errorGender)
            : base(message, "Error code 1: Incorrect gender.\n")  // наследуем message и errorClass от MyException
        {

            this.Gender = errorGender;
        }
    }

    public class DateException : MyException
    {
        public string Date { get; set; }
        public DateException(string message, string errorDate)
            : base(message, "Error code 2: Incorrect date.\n")
        {
            this.Date = errorDate;
        }
    }

    public class GenreException : MyException
    {
        public string Genre { get; set; }
        public GenreException(string message, string errorGenre)
            : base(message, "Error code 3: Incorrect genre.\n")
        {
            this.Genre = errorGenre;
        }
    }

    public class AgeAccessException : MyException
    {
        public int Age { get; set; }
        public AgeAccessException(string message, int errorAge)
            : base(message, "Error code 4: Incorrect age.\n")
        {
            this.Age = errorAge;
        }
    }
    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(MyException exception)
        {
            GenderException GenderEx = exception as GenderException;
            DateException DateEx = exception as DateException;
            GenreException GenreEx = exception as GenreException;
            AgeAccessException AgeEx = exception as AgeAccessException;

            Console.WriteLine("\n" + DateTime.Now);
            if (GenderEx != null)
            {
                Console.WriteLine("{0}{1} {2}", GenderEx.ErrorClass, GenderEx.Message, GenderEx.Gender);
            }
            if (DateEx != null)
            {
                Console.WriteLine("{0}{1} {2}", DateEx.ErrorClass, DateEx.Message, DateEx.Date);
            }
            if (GenreEx != null)
            {
                Console.WriteLine("{0}{1} {2}", GenreEx.ErrorClass, GenreEx.Message, GenreEx.Genre);
            }
            if (AgeEx != null)
            {
                Console.WriteLine("{0}{1} {2}", AgeEx.ErrorClass, AgeEx.Message, AgeEx.Age);
            }
        }
    }

    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(MyException exception)
        {
            GenderException GenderEx = exception as GenderException;
            DateException DateEx = exception as DateException;
            GenreException GenreEx = exception as GenreException;
            AgeAccessException AgeEx = exception as AgeAccessException;

            string filePath = @"D:\Прога\2 курс\ООП\OOP_1sem\Lab06_sol\Lab06\log.txt";
            using StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default);
            streamWriter.WriteLine(DateTime.Now);
            if (GenderEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", GenderEx.ErrorClass, GenderEx.Message, GenderEx.Gender); ;
            }
            if (DateEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", DateEx.ErrorClass, DateEx.Message, DateEx.Date);
            }
            if (GenreEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", GenreEx.ErrorClass, GenreEx.Message, GenreEx.Genre);
            }
            if (AgeEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", AgeEx.ErrorClass, AgeEx.Message, AgeEx.Age);
            }
        }
    }

    public class Num
    {
        public int num { get; set; }
        public Num(int num)
        {
            this.num = num;
        }
        public Num Namnamnam()
        {
            try
            {
                if (!(this.num is int))
                {
                    throw new MyException("Incorrect type", "Error code 5: Uncorrect type.\n");
                }

                return this;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Omnomnom()
        {
            try
            {
                if (Convert.ToInt32(this.Namnamnam()) is int)
                {
                    return Convert.ToInt32(this.Namnamnam());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "impossible convert to int\n");
                return 0;
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class NAOLog
    {
        public static void WriteInLog()
        {
            string path = Path.GetFullPath(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt");
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now.ToString()}");
                writer.WriteLine($"Имя файла лога:      {Path.GetFileName(path)}   ");
                writer.WriteLine($"Путь лога:           {path}");
                writer.WriteLine($"Время записи лога:   {DateTime.Now}");
                writer.WriteLine("\n------------------------------");
            }
        }

       public static void WriteInTxt(string path,string message)
        {
            
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now.ToString()}\n{message}\n------------------------------");
            }
        }
    }
}

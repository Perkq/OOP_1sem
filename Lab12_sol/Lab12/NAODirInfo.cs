using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class NAODirInfo
    {
        public static void GetDirInfo()
        {
            string path = @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt";
            string dirName = @"F:\Прога\2 курс\ООП\OOP_1sem";
            string dirInfoLog = "";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            if (dirInfo.Exists)
                dirInfoLog = 
                             "\nИмя директория:           " + dirInfo.Name +
                             "\nКоличество файлов:        " + dirInfo.GetFiles().Length +
                             "\nВремя создания:           " + dirInfo.LastWriteTime +
                             "\nКол-во поддиректориев:    " + dirInfo.GetDirectories().Length +
                             "\nРодительские директории:  " + dirInfo.Parent.Name;

            NAOLog.WriteInTxt(path, dirInfoLog);
        }
    }
}
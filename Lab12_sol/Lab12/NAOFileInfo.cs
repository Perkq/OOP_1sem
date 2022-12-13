using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public static class NAOFileInfo
    {
        public static void GetFileInfo()
        {

            string path = @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt";
            string fileInfoLog = "";

            FileInfo fileInf = new FileInfo(path);

            if (fileInf.Exists)
            {
                fileInfoLog = 
                    "\nПолный путь:       " + path +
                    "\nРазмер:            " + fileInf.Length +
                    "\nРасширение:        " + fileInf.Extension +
                    "\nИмя файла:         " + fileInf.Name +
                    "\nВремя изменения:    " + fileInf.CreationTime;
            }
            NAOLog.WriteInTxt(path, fileInfoLog);
        }

    }
}

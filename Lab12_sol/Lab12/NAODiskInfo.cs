using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab12
{
    public static class NAODiskInfo
    {
        public static void GetDiskInfo()
        {
           
            string diskInfo = "";
            string path = @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt";

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach(DriveInfo drive in drives)
            {
                diskInfo =
                    "\nНазвание: " + drive.Name +
                    "\nОбъем: " + drive.TotalSize +
                    "\nДоступный объем: " + drive.TotalFreeSpace +
                    "\nМетка тома: " + drive.VolumeLabel +
                    "\nФайловая система: " + drive.DriveFormat;

            NAOLog.WriteInTxt(path, diskInfo);
            }
        }
    }
}

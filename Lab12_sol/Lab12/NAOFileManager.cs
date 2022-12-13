using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Laba12
{
    public class NAOFileManager
    { 
        public static void InspectDrive(string driveName)
        {
            Directory.CreateDirectory(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir");

            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driveName);

            File.Create(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOdirinfo.txt").Close();

            using (var streamWriter = new StreamWriter(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOdirinfo.txt"))
            {
                streamWriter.WriteLine("|Directories| [");
                foreach (var directoryInfo in currentDrive.RootDirectory.GetDirectories()) streamWriter.WriteLine(directoryInfo.Name);
                streamWriter.WriteLine("]");

                streamWriter.WriteLine("|Files| [");
                foreach (var fileInfo in currentDrive.RootDirectory.GetFiles()) streamWriter.WriteLine(fileInfo.Name);
                streamWriter.WriteLine("]");
            }

            File.Copy(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOdirinfo.txt",
                @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOdirinfoCopy.txt", true);
            File.Delete(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOdirinfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {

            var directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOFiles");

            foreach (var file in directory.GetFiles())
                if (file.Extension == extension)
                    file.CopyTo($@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOFiles\{file.Name}", true);
            Directory.Delete(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOFiles\", true);
            Directory.Move(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOFiles\",
                @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOFiles\");
        }

        public static void Archive(string pathFrom, string pathTo)
        {
            if (!File.Exists($@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\Archieve.zip"))
            {
                ZipFile.CreateFromDirectory(pathFrom, $@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\Archieve.zip");
            }

            if (!File.Exists($@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\Unarchieve\Пример1.docx"))
            {
                ZipFile.ExtractToDirectory($@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\Archieve.zip", pathTo);
            }
        }
    }
}

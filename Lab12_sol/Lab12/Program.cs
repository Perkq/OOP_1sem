using Laba12;
using System;
using System.Text;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            NAODiskInfo.GetDiskInfo();

            NAOFileInfo.GetFileInfo();

            NAODirInfo.GetDirInfo();
            NAOLog.WriteInLog();

            NAOFileManager.InspectDrive(@"F:\");
            NAOFileManager.CopyFiles(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\", ".docx");
            NAOFileManager.Archive(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\NAOInspDir\NAOFIles\",
                    @"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\Unarchieve");
                FindInfo();
            }

            public static void FindInfo()
            {
                var output = new StringBuilder();

                using (var stream = new StreamReader(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt"))
                {
                    var textline = "";
                    var isActual = false;
                    while (stream.EndOfStream == false)
                    {
                        isActual = false;
                        textline = stream.ReadLine();
                        if (textline != "" && DateTime.Parse(textline).Day == DateTime.Now.Day)
                        {
                            isActual = true;
                            textline += "\n";
                            output.AppendFormat(textline);
                        }

                        textline = stream.ReadLine();
                        while (textline != "------------------------------")
                        {
                            if (isActual)
                            {
                                textline += "\n";
                                output.AppendFormat(textline);
                            }

                            textline = stream.ReadLine();
                        }

                        if (isActual) output.AppendFormat("------------------------------\n");
                    }
                }

                using (var stream = new StreamWriter(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab12_sol\Lab12\log.txt"))
                {
                    stream.WriteLine(output.ToString());
                }
            }




        
    }
}
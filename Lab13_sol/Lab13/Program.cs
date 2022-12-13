using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters;
using System.Xml;
using System.Xml.Linq;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            News forBin = new News("Sport", "hour");
            CustomSerializer.SerializeToBinary(forBin);
            CustomSerializer.DeserializeFromBinary(ref forBin);
            Console.WriteLine($"From .bin : {forBin.ToString()}");
          

              News forSoap = new News("Worlwide", "month");
              CustomSerializer.SerializeToSoap(forSoap);
              CustomSerializer.DeserializeFromSoap(ref forSoap);

              News forJson = new News("Food", "day");
              CustomSerializer.SerializeToJson(forJson);
              CustomSerializer.DeserializeFromJson(ref forJson);
              Console.WriteLine($"From .json : {forBin.ToString()}");
  
            TVProgram forXml = new TVProgram();
            CustomSerializer.SerializeToXml(forXml);
            CustomSerializer.DeserializefromXml(ref forXml);
            Console.WriteLine($"From .xml : {forXml.ToString()}");


            // задание 3
            List<TVProgram> forXML = new List<TVProgram>();
            List<TVProgram> programs = new List<TVProgram>();

            TVProgram first = new TVProgram();
            TVProgram sec = new TVProgram();
            TVProgram third = new TVProgram();

            programs.Add(first);
            programs.Add(sec);
            programs.Add(third);


            CustomSerializer.SerializeToXml(programs);
            CustomSerializer.DeserializefromXml(ref forXML);
            foreach (var temp in forXML)
            {
                Console.WriteLine(temp.ToString());
            }

            //задание 4
            //используя XPath напишите два селектора для вашего XML-документа

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\XML.xml");
            var xRoot = xmlDoc.DocumentElement;

            var selectNodes = xRoot.SelectNodes("*");
            foreach (object xnode in selectNodes) Console.WriteLine((xnode as XmlNode).InnerText);

            Console.WriteLine();
            var nameNodes = xRoot.SelectNodes("Name");
            foreach (object nameNode in nameNodes) Console.WriteLine((nameNode as XmlNode).Name);

            //задание 5
            XDocument Students = new XDocument();
            XElement root = new XElement("Студенты");

            XElement stud;
            XElement name;
            XAttribute year;

            stud = new XElement("animal");
            name = new XElement("type");
            name.Value = "Жираф";
            year = new XAttribute("age", "5");
            stud.Add(name);
            stud.Add(year);
            root.Add(stud);

            stud = new XElement("animal");
            name = new XElement("type");
            name.Value = "Кот";
            year = new XAttribute("age", "9");
            stud.Add(name);
            stud.Add(year);
            root.Add(stud);

            Students.Add(root);
            Students.Save(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\NewXML.xml");

            Console.WriteLine("Inter the year for searching: ");
            string yearXML = Console.ReadLine();
            var allAlbums = root.Elements("stud");

            foreach (var item in allAlbums)
            {
                if (item.Attribute("age").Value == yearXML)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}

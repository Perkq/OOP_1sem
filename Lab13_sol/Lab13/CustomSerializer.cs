﻿using System;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Soap;
using Newtonsoft.Json;


namespace Lab13
{
    public class CustomSerializer
    {
        public static void SerializeToBinary<T>(T obj) where T : class
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\Binary.bin", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, obj);
            }
        }
        public static void DeserializeFromBinary<T>(ref T container) where T : class
        {
            var binaryFormatter = new BinaryFormatter();
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\Binary.bin", FileMode.OpenOrCreate))
            {
                container = binaryFormatter.Deserialize(fileStream) as T;
            }
        }

        public static void SerializeToSoap<T>(T obj) where T : class
        {
            var soapFormatter = new SoapFormatter();
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\SOAP.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fileStream, obj);
            }
        }
        public static void DeserializeFromSoap<T>(ref T container) where T : class
        {
            var soapFormatter = new SoapFormatter();
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\SOAP.soap", FileMode.OpenOrCreate))
            {
                container = soapFormatter.Deserialize(fileStream) as T;
            }
        }

        public static void SerializeToXml<T>(T obj) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\XML.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, obj);
            }
        }
        public static void DeserializefromXml<T>(ref T container) where T : class
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            using (var fileStream = new FileStream(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\XML.xml", FileMode.OpenOrCreate))
            {
                container = xmlSerializer.Deserialize(fileStream) as T;
            }
        }

        public static void SerializeToJson<T>(T obj) where T : class
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

            string serialized = JsonConvert.SerializeObject(obj, settings);
            using (var fileStream = new StreamWriter(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\JSON.json"))
            {
                fileStream.Write(serialized);
            }

        }
        public static void DeserializeFromJson<T>(ref T container) where T : class
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            using (var fileStream = new StreamReader(@"F:\Прога\2 курс\ООП\OOP_1sem\Lab13_sol\Lab13\JSON.json"))
            {
                string json = fileStream.ReadToEnd();
                container = JsonConvert.DeserializeObject<T>(json, settings);
            }
        }
    }
}

﻿using System.Reflection;

namespace Lab_11
{
    static class A
    {
        //public void Anum() { }
        public static void Byes(int i) { }

        //public A() { }

        static private int asdasda = 0;
        static public int yespublic = 0;

        static public string DFSDFS { get; set; }
        static private string Ddaasd { get; set; }

    }
    class SuperStringInvoke
    {
        //public void Anum() { }
        public void WriteCar(List<string> list)
        {
            foreach (var news in list)
            {
                Console.WriteLine(news);
            }
        }

    }
    class Program
    {
        static void Main()
        {
            /*   
            Assembly assembly = Assembly.LoadFrom(@"C:\Users\Илья\Desktop\Пацей\ООП\Labs\Lab_04\Lab_04\Lab_04\bin\Debug\net6.0\Lab_04.dll");
            Console.WriteLine(assembly.FullName);
            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine(module.FullyQualifiedName);
                foreach (Type type in module.GetTypes())
                {
                    Console.WriteLine(type.FullName);
                }
            }
            */

            Reflector.ExploreClass("Lab_11.SuperString");
            Reflector.ExploreClass("Lab_11.TVProgram");

            Console.WriteLine("\nТест метода Invoke:\n");
            Reflector.Invoke("Lab_11.SuperStringInvoke", "WriteString");

            Console.WriteLine("\nТест метода Create:\n");

            object obj = Reflector.Create("Lab_11.SuperString");
            Console.WriteLine(obj);
        }
    }
}
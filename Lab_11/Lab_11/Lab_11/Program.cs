using System.Reflection;

namespace Lab_11
{
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
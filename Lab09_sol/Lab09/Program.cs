using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(22);
            arr.Add("lol");
            arr.Add(23.5);
            arr.Add('q');
            arr.Add(true);

            Console.WriteLine("Элементы ArrayList");
            foreach (var tmp in arr) Console.WriteLine(tmp);
            

            Stack st = new Stack(arr);
            Console.WriteLine("Элементы Stack");

            foreach (var tmp in st) Console.WriteLine(tmp);


            arr.AddRange(st);
            Console.WriteLine("Элементы ArrayListX2");
            foreach (var tmp in arr) Console.WriteLine(tmp);


            int number = 22;
            Console.WriteLine("Содержит ли стэк заданное значение: " + st.Contains(number));

            Console.ForegroundColor = ConsoleColor.Magenta;
            var myCollection = new ObservableCollection<Furniture>();
            myCollection.CollectionChanged += SayChange;


            myCollection.Add(new Furniture("Шкаф", 200));
            myCollection.Add(new Furniture("Дверь", 500));
            myCollection.Add(new Furniture("Стол", 1000));

            myCollection.RemoveAt(2);
        }

        private static void SayChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
                Console.WriteLine("|Add complete|");
            else if (e.Action == NotifyCollectionChangedAction.Remove) Console.WriteLine("|Remove complete|");
        }
    }
}
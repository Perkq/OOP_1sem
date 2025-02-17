﻿using Lab10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks.Dataflow;

namespace Laba10
{

    class DataKeeper
    {
        public int number;
        public string name;

        public DataKeeper(int num, string nm)
        {
            number = num;
            name = nm;
        }
    }


    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания:");

            switch (Convert.ToInt32(Console.ReadLine())) {
                case 1:
                    string[] months =
                        { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                    /*запрос выбирающий последовательность месяцев с длиной строки равной n*/
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    var n = 5;
                    Console.WriteLine("Months length n symbol: ");
                    foreach (string item in from m in months where m.Length == n select m) Console.WriteLine(item);

                    /*запрос возвращающий только летние и зимние месяцы, */
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Summer and winter months:");
                    foreach (string item in from m in months
                                            where Array.IndexOf(months, m) < 2 ||
                                                  Array.IndexOf(months, m) > 4 && Array.IndexOf(months, m) < 8 ||
                                                  Array.IndexOf(months, m) == 11
                                            select m
                    ) Console.WriteLine(item);

                    /*запрос вывода месяцев в алфавитном порядке,*/
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Months sorted alphabetly:");
                    foreach (string item in from m in months orderby m select m) Console.WriteLine(item);

                    /*запрос считающий месяцы содержащие букву «u» и длиной имени не менее 4-х*/
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Months contains letter 'u' and length not less than 4:");
                    foreach (string item in from m in months where m.Contains('u') && m.Length >= 4 select m) Console.WriteLine(item);
                    break;
                case 2:
                    List<SuperString> strList = new List<SuperString>();
                    strList.Add(new SuperString("Hello world"));
                    strList.Add(new SuperString("How do you do?"));
                    strList.Add(new SuperString("Mommy daddy"));
                    strList.Add(new SuperString("all my friends are toxic"));
                    strList.Add(new SuperString("i need new friends"));
                    strList.Add(new SuperString("i feel kinda empty"));
                    strList.Add(new SuperString("i'm drowning let me breath"));
                    strList.Add(new SuperString("i'm better off all by myself"));
                    strList.Add(new SuperString("baby oh i'll make you know"));
                    strList.Add(new SuperString("you took my pride away"));
                    strList.Add(new SuperString("but you cannot take my life"));

                    // количество строк длины n и m
                    int q = Convert.ToInt32(Console.ReadLine());
                    int k = Convert.ToInt32(Console.ReadLine());
                    foreach (var tmp in strList.Where(str => str.GetNumOfSymbols() == q || str.GetNumOfSymbols() == k)) Console.WriteLine(tmp);

                    // список строк, которые содержат заданное слово.
                    string userWord = Console.ReadLine();
                    foreach (var tmp in strList.Where(str => str.StringValue.IndexOf(userWord) != -1)) Console.WriteLine(tmp);

                    // Максимальную строку
                    Console.WriteLine(strList.Max(a => a.StringValue));

                    // Первую строку, содержащую точку или ?
                    Console.WriteLine(strList.First(a => a.StringValue.Contains('.') || a.StringValue.Contains('?')));

                    // Последнюю строку с самым коротким словом
                    var orderdList = from s in strList orderby s.GetNumOfSymbols() select s;
                    Console.WriteLine(orderdList.First());

                    // Упорядоченный массив по первому слову
                    var orderdByFirstWord = from s in strList orderby s.StringValue.Split()[0] select s;
                    break;
                case 4:
                    List<SuperString> strList2 = new List<SuperString>();
                    strList2.Add(new SuperString("Hello world"));
                    strList2.Add(new SuperString("How do you do?"));
                    strList2.Add(new SuperString("Mommy daddy"));
                    strList2.Add(new SuperString("all my friends are toxic"));
                    strList2.Add(new SuperString("i need new friends"));
                    strList2.Add(new SuperString("i feel kinda empty"));
                    strList2.Add(new SuperString("i'm drowning let me breath"));
                    strList2.Add(new SuperString("i'm better off all by myself"));
                    strList2.Add(new SuperString("baby oh i'll make you know"));
                    strList2.Add(new SuperString("you took my pride away"));
                    strList2.Add(new SuperString("but you cannot take my life"));

                    int strsNum = strList2.OrderBy(str => str.GetNumOfSymbols()).Where(str => str.StringValue.Split().Length > 3).Skip(2).GroupBy(str => str.GetNumOfSymbols() > 18).Count();
                    Console.WriteLine(strsNum);
                    break;
                case 5:
                    List<SuperString> strList5 = new List<SuperString>();
                    strList5.Add(new SuperString("Hello"));
                    strList5.Add(new SuperString("neighbour "));

                    List<DataKeeper> data = new List<DataKeeper>();
                    data.Add(new DataKeeper(5, "Artsiom"));
                    data.Add(new DataKeeper(10, "Kolya"));
                    data.Add(new DataKeeper(8, "Svyat"));

                    var union = from str1 in strList5
                                join dat in data on str1.GetNumOfSymbols() equals dat.number
                                select new { strValue =  str1.StringValue, uName = dat.name};

                    foreach (var tmp in union) Console.WriteLine($"{tmp.strValue} - {tmp.uName}");
                    break;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    partial class News
    {
        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Длительность: {Duration}\n Тема: {topic}";
        }

        public void GoProgram()
        {
            Console.WriteLine("Воспроизводятся новости");
        }
    }
}

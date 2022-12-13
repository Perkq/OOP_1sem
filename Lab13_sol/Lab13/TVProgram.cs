using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
   interface IProgramGoes
   {
        void GoProgram();
   }

    [Serializable]
    public class TVProgram
    {
        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }

        
        public override string ToString()
        {
                return $"Тип: {this.GetType()}\n Длительность: {Duration}";
        }

        public TVProgram()
        {
            duration = "infinity";
        }
        
        public TVProgram(string curDuration)
        {
            duration = curDuration;
        }

    }

    [Serializable]
    class Ad : TVProgram, IProgramGoes
    {
        [NonSerialized]
        private int cost;
        public int Cost
        {
            get { return cost; }
            set
            {
                cost = value;
            }
        }

        public Ad(int curCost, string curDuration) : base(curDuration)
        {
            cost = curCost;
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Длительность: {Duration}\n Цена: {Cost}";
        }

        public void GoProgram()
        {
            Console.WriteLine("Воспроизводится реклама");
        }

    }

    [Serializable]
    class News : TVProgram, IProgramGoes
    {
        private string topic;
        public string Topic
        {
            get { return topic; }
            set
            {
                topic = value;
            }
        }

        public News(string curTopic, string curDuration) : base(curDuration)
        {
            topic = curTopic;
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Длительность: {Duration}\n Тема: {Topic}";
        }

        public void GoProgram()
        {
            Console.WriteLine("Воспроизводятся новости");
        }
    }
}

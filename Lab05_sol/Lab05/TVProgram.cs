using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
   interface IProgramGoes
   {
        void GoProgram();
   }

    abstract class TVProgram
    {
        private int duration;
        public int Duration
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

        public TVProgram(int curDuration)
        {
            Duration = curDuration;
        }

    }

    class Ad : TVProgram, IProgramGoes
    {

        private int numberOfAds;
        public int NumberOfAds
        {
            get { return numberOfAds; }
            set
            {
                numberOfAds = value;
            }
        }

        public Ad(int curNum, int curDuration) : base(curDuration)
        {
            numberOfAds = curNum;
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Длительность: {Duration}\n Цена: {NumberOfAds}";
        }

        public void GoProgram()
        {
            Console.WriteLine("Воспроизводится реклама");
        }

    }


    public struct NewsTopic
    {
        private string newsTop;

        public NewsTopic(string top)
        {
            newsTop = top;
        }

        public string NewsTop
        {
            get { return newsTop;}
            set { newsTop = value; }
        }
    }

    partial class News : TVProgram, IProgramGoes
    {
        private string topic;

        public News(NewsTopic curTopic, int curDuration) : base(curDuration)
        {
            topic = curTopic.NewsTop;
        }
    }
}

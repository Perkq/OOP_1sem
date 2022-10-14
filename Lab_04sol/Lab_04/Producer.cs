using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    abstract class Producer
    {
        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }

        public virtual void tellInfo()
        {
            Console.WriteLine("Я режиссер");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}";
        }

        public Producer(string curGender)
        {
            gender = curGender;
        }
    }

    class Film : Producer
    {
        private string rating;
        public string Rating
        {
            get { return rating; }
            set
            {
                rating = value;
            }
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Рейтинг: {Rating}";
        }

        public override void tellInfo()
        {
            Console.WriteLine("Я режиссер");
        }

        public Film(string curRating, string curGender) : base(curGender)
        {
            rating = curRating;
        }
    }

    sealed class ArtFilm : Film
    {
        private string genre;
        public string Genre
        {
            get { return genre; }
            set
            {
                genre = value;
            }
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Рейтинг: {Rating}\n Жанр: {Genre}";
        }

        public ArtFilm(string curGenre, string curRating, string curGender) : base(curRating, curGender)
        {
            genre = curGenre;
        }
    }

    sealed class Cartoon : Film
    {
        private int ageAccess;
        public int AgeAccess
        {
            get { return ageAccess; }
            set
            {
                ageAccess = value;
            }
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Рейтинг: {Rating}\n Возрастное ограничение: {AgeAccess}";
        }

        public Cartoon(int curAgeAccess, string curRating, string curGender) : base(curRating, curGender)
        {
            ageAccess = curAgeAccess;
        }
    }
}

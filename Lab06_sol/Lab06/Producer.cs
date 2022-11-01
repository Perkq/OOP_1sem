using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
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
            Console.WriteLine("Я режиссер всего подряд");
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
            if(curGender != "Male" || curGender != "Femenina")
            {
                throw new GenderException("Такого гендера нет: ", curGender);
            }
        }
    }

    class Film : Producer
    {
        private string date;
        public string Date
        {
            get { return date; }
            set
            {
                date = value;
            }
        }

        public override string ToString()
        {
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Дата рождения: {Date}";
        }

        public override void tellInfo()
        {
            Console.WriteLine("А я режиссер только фильмов");
        }

        public Film(string curDate, string curGender) : base(curGender)
        {
            Date = curDate;
            if(curDate.Length < 8)
            {
                throw new DateException("Неправильно введена дата: ", curDate);
            }
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
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Рейтинг: {Date}\n Жанр: {Genre}";
        }

        public ArtFilm(string curGenre, string curRating, string curGender) : base(curRating, curGender)
        {
            genre = curGenre;
            if(curGenre == "porno")
            {
                throw new GenreException("Сейчас недрочабрь, никакого порно", curGenre);
            }
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
            return $"Тип: {this.GetType()}\n Пол режиссера: {Gender}\n Дата выхода: {Date}\n Возрастное ограничение: {AgeAccess}";
        }

        public Cartoon(int curAgeAccess, string curRating, string curGender) : base(curRating, curGender)
        {
            ageAccess = curAgeAccess;
            if(curAgeAccess < 18 || curAgeAccess > 70)
            {
                throw new AgeAccessException("Ты слишком молодой или старый для такого: ", curAgeAccess);
            }
        }
    }
}

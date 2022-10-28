using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class FilmsController : FilmsCont
    { 
        public void searchFilms(string curDate)
        {
            foreach(Producer temp in filmsList)
            {
                Film Film = temp as Film;
                if(Film.Date == curDate)
                {
                    Console.WriteLine(Film.ToString());
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class FilmsCont
    {
        public List<Producer> filmsList = new List<Producer>();
        public List<Producer> List
        {
            get
            {
                return filmsList;
            }

            set
            {
                if(value == null)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    filmsList = value;
                }
            }
        }

        public void Add(Producer temp)
        {
            List.Add(temp);
        }

        public void Remove(Producer temp)
        {
            List.Remove(temp);
        }

        public void PrintElems()
        {
            foreach(Producer elem in List)
            {
                Console.WriteLine(elem.ToString());
            }
        }

    }
}

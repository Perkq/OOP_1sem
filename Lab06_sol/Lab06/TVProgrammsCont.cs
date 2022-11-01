using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class TVProgrammsCont
    {
        public List<TVProgram> programList = new List<TVProgram>();
        public List<TVProgram> List
        {
            get
            {
                return programList;
            }

            set
            {
                if (value == null)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    programList = value;
                }
            }
        }

        public void Add(TVProgram temp)
        {
            List.Add(temp);
        }

        public void Remove(TVProgram temp)
        {
            List.Remove(temp);
        }

        public void PrintElems()
        {
            foreach (TVProgram elem in List)
            {
                Console.WriteLine(elem.ToString());
            }
        }

    }
}

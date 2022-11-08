using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    interface ICloneable
    {
        bool DoClone();
    }
    abstract class BaseClone
    {
        public abstract bool DoClone();
    }
    class Example : BaseClone, ICloneable
    {
         public override bool DoClone()
        {
            Console.WriteLine("Клон создан успешно!!!");
            return true;
        }
    }


    public class Printer
    {
        public string IAmPrinting(object obj)
        {
            if (obj is Ad)
            {
                Ad temp = (Ad)obj;
                return temp.ToString();
            }
            
            if(obj is News)
            {
                News temp = (News)obj;
                return temp.ToString();
            }
            

            

            if (obj is ArtFilm)
            {
                ArtFilm temp = (ArtFilm)obj;
                return temp.ToString();
            } else if (obj is Cartoon)
                {
                    Cartoon temp = (Cartoon)obj;
                    return temp.ToString();
                } else if (obj is Film)
                    {
                        Film temp = (Film)obj;
                        return temp.ToString();
                    }

            return "";
        }
    }
}

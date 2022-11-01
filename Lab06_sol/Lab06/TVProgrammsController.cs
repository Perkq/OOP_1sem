using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05
{
    class TVProgrammsController : TVProgrammsCont
    {
        public int getNumAds()
        {
            int countAd = 0;
            foreach(TVProgram temp in programList)
            {
                Ad ad = temp as Ad;
                countAd += ad.NumberOfAds;
            }
            return countAd;
        }

        public int getDur()
        {
            int countDur = 0;
            foreach(TVProgram temp in programList)
            {
                countDur += temp.Duration;
            }
            return countDur;
        }

        public enum TVContrMethods
        { 
            getNumAds,
            getDur
        }

    }
}

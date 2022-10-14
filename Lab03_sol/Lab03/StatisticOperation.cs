using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    static class StatisticOperation
    {
        public static double SumElems(Matrix cur)
        {
            double sum = 0;
            for (int i = 0; i < cur.RowsNum; i++)
            {
                for (int q = 0; q < cur.ColNum; q++)
                {
                    sum += cur[i, q]; 
                }
            }

            return sum;
        }

        public static double MinMaxDif(Matrix cur)
        {
            double max = cur[0,0];
            double min = cur[0, 0];
            for (int i = 0; i < cur.RowsNum; i++)
            {
                for (int q = 0; q < cur.ColNum; q++)
                {
                    if (cur[i, q] > max) max = cur[i, q];
                    if (cur[i, q] < min) min = cur[i, q];

                }
            }

            return max - min;
        }

        public static int GetNumElem(Matrix cur)
        {
            return cur.RowsNum * cur.ColNum;
        }

        
        public static int GetIntSumRow(Matrix cur, int row)
        {
            int intSum = 0;
            for(int i = 0; i < cur.ColNum; i++)
            {

                if (cur[row, i] % 1 == 0)
                {
                    intSum += Convert.ToInt32(cur[row, i]);
                }
            }

            return intSum;
        }

        public static bool GetSqareMatr(Matrix cur)
        {
            if(cur.RowsNum == cur.ColNum)
            {
                return true;
            } else
                {
                    return false;
                }
        }

        public static bool CheckSymb(string str, char symb)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == symb) return true;
            }

            return false;
        }
    }
}

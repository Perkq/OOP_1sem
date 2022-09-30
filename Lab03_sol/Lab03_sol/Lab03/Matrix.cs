using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    class Matrix
    {
        private int rows;
        private int columns;
        private double[,] matrix;

        public int RowsNum
        {
            get
            {
                return rows;
            }
        }

        public int ColNum
        {
            get
            {
                return columns;
            }
        }


        // Конструктор 
        public Matrix(int row, int col)
        {
            matrix = new double[row, col];
        }

        public static Matrix operator -(Matrix frst, Matrix scnd)
        {
            if((frst.rows != scnd.rows) && (frst.columns != scnd.columns))
            {
                Console.WriteLine("Ошибка! Размерности матриц не совпадают! Будет возвращена первая матрица");
                return frst;
            }

            Matrix temp = new Matrix(frst.rows, frst.columns);

            for(int i = 0; i < frst.rows; i++)
            {
                for(int q = 0; q < frst.columns; q++)
                {
                    temp[i, q] = frst[i, q] - scnd[i, q];
                }
            }
        }
    }
}

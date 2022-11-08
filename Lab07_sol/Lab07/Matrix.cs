using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    interface IBasicOperations<T>
    {
        List<T> Add(T sec);
        List<T> Del(T temp);
        void Show();
    }

    class Matrix<T> : IBasicOperations<T>
    {
        private int rows;
        private int columns;
        public double[,] matrix;
        List<T> list = new List<T>();

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

        public double this[int numOfRows, int numOfCols]   //индексатор класса
        {
            get { return matrix[numOfRows, numOfCols]; }

            set
            {
                if (numOfRows <= rows + 1 && numOfCols <= columns + 1)
                {
                    matrix[numOfRows, numOfCols] = value;
                }
                else
                {
                    Console.WriteLine("Массив заполнен");
                }
            }
        }



        public List<T> Add(T sec)
        {

            list.Add(sec);
            return list;
        }

        public List<T> Del(T temp)
        {
            list.Remove(temp);
            return list;
        }

        public void Show()
        {
            Console.WriteLine("\nСодержимое матрицы\n");
            for (int i = 0; i < this.rows; i++)
            {
                for (int q = 0; q < this.columns; q++)
                {
                    Console.WriteLine(this[i, q]);
                }
                Console.WriteLine();
            }
        }


        // Конструктор 
        public Matrix(int row, int col)
        {
            matrix = new double[row, col];
            rows = row;
            columns = col;
        }

        //Методы
        public static Matrix<T> operator -(Matrix<T> frst, Matrix<T> scnd)
        {
            if((frst.rows != scnd.rows) && (frst.columns != scnd.columns))
            {
                Console.WriteLine("Ошибка! Размерности матриц не совпадают! Будет возвращена первая матрица");
                return frst;
            }

            Matrix<T> temp = new Matrix<T>(frst.rows, frst.columns);

            for(int i = 0; i < frst.rows; i++)
            {
                for(int q = 0; q < frst.columns; q++)
                {
                    temp[i, q] = frst[i, q] - scnd[i, q];
                }
            }
            
            return temp;
        }

        public static Matrix<T> operator ++(Matrix<T> current)
        {
            for (int i = 0; i < current.rows; i++)
            {
                for (int q = 0; q < current.columns; q++)
                {
                    current[i, q] += 1; 
                }
            }

            return current;
        }

        public static bool operator !=(Matrix<T> frst, Matrix<T> scnd)
        {
            if ((frst.rows != scnd.rows) && (frst.columns != scnd.columns))
            {
                Console.WriteLine("Ошибка! Размерности матриц не совпадают!");
                return false;
            }

            int count = 0;

            for (int i = 0; i < frst.rows; i++)
            {
                for (int q = 0; q < frst.columns; q++)
                {
                    if (frst.matrix[i, q] == scnd.matrix[i, q])
                    {
                        count++;
                    };
                }
            }
            if(count < frst.rows * frst.columns)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Matrix<T> frst, Matrix<T> scnd)
        {
            if ((frst.rows != scnd.rows) && (frst.columns != scnd.columns))
            {
                Console.WriteLine("Ошибка! Размерности матриц не совпадают!");
                return false;
            }


            for (int i = 0; i < frst.rows; i++)
            {
                for (int q = 0; q < frst.columns; q++)
                {
                    if (frst[i, q] != scnd[i, q])
                    {
                        return false;
                    };
                }
            }

            return true;
        }

        public static explicit operator int(Matrix<T> cur)
        {
            int count = 0;
            for (int i = 0; i < cur.rows; i++)
            {
                for (int q = 0; q < cur.columns; q++)
                {
                    if (cur[i,q] == 0)
                    {
                        count++;
                    };
                }
            }

            return count;
        }

        public class Production
        {
            private readonly int id = 123;
            private readonly string organization = "БГТУ";

            public void GetDev()
            {
                Console.WriteLine("Id: " + id);
                Console.WriteLine("Организация: " + organization);
            }
        }

        public static Production org = new Production();

        public class Developer
        {
            private readonly int id = 777;
            private readonly string FIO = "Нехаёнок Артём Олегович";
            private readonly string department = "2-4 ПОИТ";

            public void GetDev()
            {
                Console.WriteLine("Id: " + id);
                Console.WriteLine("ФИО: " + FIO);
                Console.WriteLine("Отдел: " + department);

            }
        }
    }
}

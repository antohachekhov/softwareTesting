using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{


    public class MyException : ArgumentException
    {
        public MyException(string mes) : base(mes)
        { }
    }

    public class Matrix
    {
        int[,] matrix;
        private int I, J;

        public int[] Property
        {
            get
            {
                int[] property = { I, J };
                return property;
            }
        }

        // Конструктор
        public Matrix(int i, int j)
        {
            if (i <= 0 || j <= 0)
                throw new MyException("Число стобцов или строк матрицы должно быть больше 0");
            this.matrix = new int[i, j];
            this.I = i;
            this.J = j;
            for (int r = 0; r < this.I; r++)
                for (int c = 0; c < this.J; c++)
                    matrix[r, c] = 0;
        }

        // Сложение
        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (A.I != B.I)
                throw new MyException("Число строк в матрицах должно совпадать!");
            if (A.J != B.J)
                throw new MyException("Число столбцов в матрицах должно совпадать!");

            Matrix C = new Matrix(A.I, A.J);
            for (int i = 0; i < A.I; i++)
                for (int j = 0; j < A.J; j++)
                    C.matrix[i, j] = A.matrix[i, j] + B.matrix[i, j];
            return C;
        }

        // Вычитание
        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (A.I != B.I)
                throw new MyException("Число строк в матрицах должно совпадать!");
            if (A.J != B.J)
                throw new MyException("Число столбцов в матрицах должно совпадать!");

            Matrix C = new Matrix(A.I, A.J);
            for (int i = 0; i < A.I; i++)
                for (int j = 0; j < A.J; j++)
                    C.matrix[i, j] = A.matrix[i, j] - B.matrix[i, j];
            return C;
        }

        // Умножение
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.J != B.I)
                throw new MyException("Число столбоцов в первой матрице должно быть равно числу строк во второй матрице!");

            Matrix C = new Matrix(A.I, B.J);
            for (int i = 0; i < A.I; i++)
                for (int j = 0; j < B.J; j++)
                    for (int k = 0; k < B.I; k++)
                        C.matrix[i, j] += A.matrix[i, k] * B.matrix[k, j];
            return C;
        }

        // равно
        public static bool operator ==(Matrix A, Matrix B)
        {
            if (A.I != B.I || A.J != B.J)
                throw new MyException("Число строк и/или столбцов не совпадает!");

            bool flag = true;

            for (int i = 0; i < A.I; i++)
                for (int j = 0; j < A.J; j++)
                    if (A.matrix[i, j] != B.matrix[i, j])
                    {
                        flag = false; break;
                    }
                        

            return flag;
        }

        public static bool operator !=(Matrix a, Matrix b) => !(a == b);

        // Транспонировать
        public Matrix Transp()
        {
            if (I != J)
                throw new MyException("Матрица не квадратная!");

            Matrix B = new Matrix(I, J);
            for (int j = 0; j < J; j++)
                for (int i = 0; i < J; i++)
                    B.matrix[j, i] = matrix[i, j];

            return B;
        }

        // минимальный элемент
        public int Min()
        {
            int min = matrix[0, 0];

            for (int i = 0; i < I; i++)
                for (int j = 0; j < J; j++)
                    if (matrix[i, j] < min)
                        min = matrix[i, j];

            return min;
        }


        // Преобразование матрицы в строку
        public override string ToString()
        {
            string[] matrixToString = new string[I];
            for (int i = 0; i < this.I; i++)
            {
                int[] vector = new int[J];
                for (int j = 0; j < J; j++)
                    vector[j] = this.matrix[i, j];

                matrixToString[i] = "{" + string.Join(",", vector) + "}";
            }

            return "{" + String.Join(",", matrixToString) + "}";
        }

        // Взятие элемента с позиции i и j
        // Запись элемента на позицию i и j
        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= I || j < 0 || j >= J)
                    throw new MyException("Индексы вышли за диапазон допустимых значений");
                return matrix[i, j];
            }

            set
            {
                if (i < 0 || i >= I || j < 0 || j >= J)
                    throw new MyException("Индексы вышли за диапазон допустимых значений");
                matrix[i, j] = value;
            }
        }
    }
}

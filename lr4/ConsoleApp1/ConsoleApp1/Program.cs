using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Matrix;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Создаём матрицу a.
                Matrix a = new Matrix(3, 3);
                //Создаём матрицу b.
                Matrix b = new Matrix(3, 3);
                //Объявляем матрицу c.
                Matrix c;
                //Заполняем матрицу a.
                for (int i = 0; i < a.Property[0]; i++)
                {
                    for (int j = 0; j < a.Property[1]; j++)
                    {
                        a[i, j] = a.Property[1] * i + j;
                    }
                }
                //Выводим матрицу a.
                Console.WriteLine(a.ToString());
                //Заполняем матрицу b.
                for (int i = 0; i < a.Property[0]; i++)
                {
                    for (int j = 0; j < a.Property[1]; j++)
                    {
                        b[i, j] = a.Property[1] * i + j + 1;
                    }
                }
                //Выводим матрицу a.
                Console.WriteLine(b.ToString());
                //Складываем матрицы a и b.
                c = a + b;
                //Выводим матрицу c.
                Console.WriteLine(c.ToString());
                Console.WriteLine(c.Transp());
                Console.WriteLine(c.Min());
                Console.WriteLine(c == a);
                Console.WriteLine(c == c);

            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ArrayClass
    {
        // 1 Функция получает два одномерных массива.В массиве int[] ind хранятся индексы компонентов массива v.
        // Найдите произведение ненулевых компонентов массива v, индексы которых хранятся в массиве ind.
        public static double calcMultElemsByInd(double[] v, int[] ind)
        {
            double mult = 1.0;
            for (int i = 0; i < ind.Length; i++)
            {
                int iv = ind[i];
                if (v[iv] != 0)
                {
                    mult *= v[iv];
                }
            }
            return mult;
        }


        // 2 Функция получает одномерный массив целых переменных.Вычисляет и возвращает минимальный по значению элемент этого массива и
        // номер его индекса.
        public static int[] findMinElemWithIndex(int[] arr)
        {
            int min = arr[0];
            int indexOfMin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    indexOfMin = i;
                }
            }

            int[] result = { min, indexOfMin };
            return result;
        }

        // 3 Функция получает одномерный массив вещественных переменных. В полученном массиве функция переставляет значения компонентов
        // массива в обратном порядке.
        public static void reverseArray(ref double[] arr)
        {
            double[] revArr = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                revArr[i] = arr[arr.Length - i - 1];
            }
            arr = revArr;
        }
    }
}

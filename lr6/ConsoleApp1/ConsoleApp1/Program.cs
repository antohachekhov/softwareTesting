using System;
using System.Numerics;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // 1. Отыскать минимальный элемент одномерного массива целых, его значение и значение его индекса.
        public static(int, int) Min(int[] arr)
        {
            int min = arr[0];
            int imin = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (min >= arr[i])
                {
                    min = arr[i];
                    imin = i;
                }
            }

            return (min, imin);
        }

        // 2. Сортировка одномерного массива в порядке возрастания методом пузырька.
        public static void SortBubble(ref int[] arr)
        {
            int z;

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        z = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = z;
                    }
                }
            }
        }

        // 3. Бинарный поиск элемента в упорядоченном одномерном массиве.
        public static int BinarySearch(int[] arr, int number)
        {
            return BinarySearchStep(arr, number, 0, arr.Length);
        }
        static int BinarySearchStep(int[] arr, int number, int start, int end)
        {
            int trueIndex = (end - start) / 2 + start;
            if (arr[trueIndex] > number)
                trueIndex = BinarySearchStep(arr, number, start, trueIndex);
            else if (arr[trueIndex] < number)
                trueIndex = BinarySearchStep(arr, number, trueIndex, end);

            return trueIndex;
        }

        // 4. Отыскать минимальный элемент двумерного массива целых, его значение и значение его индексов.
        public static(int, int, int) Min2(int[,] arr)
        {
            int min = arr[0, 0];
            int imin = 0;
            int jmin = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (min >= arr[i, j])
                    {
                        min = arr[i, j];
                        imin = i;
                        jmin = j;
                    }
                }    
            }

            return (min, imin, jmin);
        }

        // 5. Осуществить перестановку значений элементов одномерного массива в обратном порядке.
        public static void Inverse(ref int[] arr)
        {
            int a;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                a = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = a;
            }
        }

        // 7. Заменить все вхождения целочисленного значения в целочисленный массив.
        public static void Replace(ref int[] arr, int valAreChanging, int valToWhichChange)
        {
            for(int i =0; i < arr.Length; i++)
                if (arr[i] == valAreChanging)
                    arr[i] = valToWhichChange;
        }

        // 6. Осуществлять циклический сдвиг элементов одномерного массива на заданное число позиций влево.
        static void ReplaceByShift(ref int[] arr, int shift, int oldInd)
        {
            int value = arr[oldInd];
            int newInd = (arr.Length + oldInd - shift % arr.Length) % arr.Length;
            if (newInd != 0)
                ReplaceByShift(ref arr, shift, newInd);

            arr[newInd] = value;
        }
        public static void CyclicShift(ref int[] arr, int shift)
        {
            ReplaceByShift(ref arr, shift, 0);
        }
    }
}

using System;

namespace Program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] ind = { 1, 2, 3 };
            double[] v = { 1.0, 2.0, 3.0, 4.0 };
            Console.WriteLine("Произведение: " + ArrayClass.calcMultElemsByInd(v, ind));

            int[] arr2 = { -20, 10000, 5, 7, -100000 };
            int[] res2 = ArrayClass.findMinElemWithIndex(arr2);
            Console.WriteLine("Минимальный элемент = " + Convert.ToString(res2[0]) + " и его индекс = " + Convert.ToString(res2[1]));

            double[] check3 = { 1.24, 0.5, 4 };
            ArrayClass.reverseArray(ref check3);
            Console.Write("check3 reverse = " + string.Join(", ", check3));
        }
    }

}
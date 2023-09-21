namespace ClassLibrary1
{
    public class Class1
    {

        // Поиск минимума из трёх чисел
        public static double findMin(double a, double b, double c)
        {
            double min;
            if (a < b)
            {
                min = a;
                if (c < min)
                    min = c;
            }
            else
            {
                min = b;
                if (c < min)
                    min = c;
            }
            return min;
        }

        // Функция получает двумерный массив вещественных переменных A.
        // Отыскивает и возвращает сумму значений компонентов массива, у которых сумма значений индексов – чётная.
        public static double findSumElements(double[,] A)
        {
            double sum = 0;
            for (int i = 0;
                i < A.GetLength(0);
                i++)
                for (int j = 0;
                j < A.GetLength(1);
                j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += A[i,j];
                }

            return sum;
        }

        // Функция получает двумерный массив вещественных переменных A. 
        // Отыскивает и возвращает максимальное значение компонентов массива, лежащих на и ниже главной диагонали
        public static double maxElem(double[,] A)
        {
            double maxA = A[0,0];
            for (int i = 0; 
                i < A.GetLength(0);
                i++)
            {
                for (int j = 0; 
                    j <= i; 
                    j++)
                {
                    if (A[i,j] > maxA)
                        maxA = A[i,j];
                }
            }
            return maxA;
        }
    }
}

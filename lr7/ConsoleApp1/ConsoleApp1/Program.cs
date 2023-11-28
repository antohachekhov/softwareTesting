using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод парамметра ню со звездой 2
            Console.WriteLine("Введите nu*2:\n");
            int nuz2 = Convert.ToInt32(Console.ReadLine());


            // Первый пункт - числа уровней иерархии в схеме иерархии логических модулей
            // расчет k
            double k = (int)(nuz2 / 8); // число исполнительных модулей
            Console.WriteLine("Число исполнительных модулей:" + k);

            int i = 2;
            

            // если k > 8, то считаем i
            if (k > 8)
            {
                i = (int)(Math.Log2(nuz2) / 3) + 1;
            }
            // если меньше то по сути у нас 1 уровень

            int[] modules = new int[i];
            modules[0] = 1;
            for (int j = 1; j < i; j++)
            {
                modules[j] = (int)(nuz2 / Math.Pow(8, i - j));
            }

            int K = modules.Sum();

            Console.WriteLine("Количество уровней иерархии (i):" + i);
            Console.WriteLine("Количество модулей на каждом уровне (от 1 до i):" + String.Join(" - ", modules));
            Console.WriteLine("Общее число модулей в ПС:" + K);

            // Второй пункт - календарного времени программирования
            int nuz2k = nuz2 / K;
            int nu2k = (int)(nuz2k * Math.Log2(nuz2k));
            int N2k = (int)(nu2k * Math.Log2(nu2k));
            int Nk = 2 * N2k;
            int N = K * Nk;
            Console.WriteLine("Длина программы:" + N);
            int P = (int)((3.0 / 8.0) * N);
            int v = 20; // число отлаженных команд ассемблера
            int n = 5; // число программистов 5 
            int Tk = P / (n * v); 
            Console.WriteLine("Расчетное время:" + Tk);

            // Третий пункт - начальной надежности ПС
            int tau = (int)(0.5 * Tk);  // начальное количество ошибок
            int V = (int)(K * Nk * Math.Log2(nu2k * 2));
            int B0 = V / 3000;
            int tk = (int)(tau / Math.Log(B0, Math.Exp(1)));
            Console.WriteLine("Начальная надежность ПС:" + tk);

        }
    }
}

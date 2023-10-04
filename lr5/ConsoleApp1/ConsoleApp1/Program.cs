using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public static Random rnd = new Random();


        static void Main(string[] args)
        {
            int[] nus = { 16, 32, 64, 128 };

            for (int i = 0; i < nus.Length; i++)
            {
                double[] Ls = new double[100];
                double teorL;
                double D, teorD;
                double Std, teorStd;
                double Delta, teorDelta;


                // generate 100 program texts
                for (int j = 0; j < 100; j++)
                {
                    List<int> programText = generateProgramText(nus[i]);
                    Ls[j] = calcPractL(programText);
                }

                D = calcPractDisp(Ls);
                Std = calcPractStd(Ls);
                Delta = calcPractDelta(Ls);

                teorL = calcL(nus[i]);
                teorD = calcDisp(nus[i]);
                teorStd = calcStd(nus[i]);
                teorDelta = calcDelta(nus[i]);

                Console.WriteLine("Etta: " + nus[i]);

                Console.WriteLine("Длина программы L:");
                Console.WriteLine("П: " + Ls.Average() + "\tТ:" + teorL);

                Console.WriteLine("Дисперсии длины D:");
                Console.WriteLine("П: " + D + "\tТ:" + teorD);

                Console.WriteLine("Среднеквадратического отклонения Std:");
                Console.WriteLine("П: " + Std + "\tТ:" + teorStd);

                Console.WriteLine("Относительной ожидаемой погрешности Delta:");
                Console.WriteLine("П: " + Delta + "\tТ:" + teorDelta + "\n");

            }

            Console.ReadKey();
        }

        public static List<int> generateProgramText(int nu)
        {
            List<int> programText = new List<int>();

            int[] isTicketInText = new int[nu];
            
            while (isTicketInText.Sum() != nu)
            {
                int tmp = rnd.Next(nu);
                programText.Add(tmp);

                isTicketInText[tmp] = 1;
            };

            return programText;
        }

        static double calcL(int etta)
        {
            return 0.9 * etta * Math.Log(etta, 2);
        }

        static double calcPractL(List<int> programText)
        {
            return programText.Count;
        }

        static double calcDisp(int etta)
        {
            return Math.Pow(Math.PI, 2) * Math.Pow(etta, 2);
        }

        static double calcPractDisp(double[] Ls)
        {
            double disp = 0;

            double mean = Ls.Average();
            for (int i = 0; i < Ls.Length; i++)
            {
                disp += Math.Pow(Ls[i] - mean, 2);
            }

            disp /= Ls.Length;

            return disp;
        }

        static double calcStd(int etta)
        {
            return Math.Sqrt(calcDisp(etta));
        }

        static double calcPractStd(double[] Ls)
        {
            return Math.Sqrt(calcPractDisp(Ls));
        }

        static double calcDelta(int etta)
        {
            return 1 / (2 * Math.Pow(etta, 2));
        }

        static double calcPractDelta(double[] Ls)
        {
            return calcPractStd(Ls) / Ls.Average();
        }
    }
}



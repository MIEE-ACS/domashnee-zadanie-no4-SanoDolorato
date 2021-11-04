using System;

namespace domashnee_zadanie_no4_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Двумерный массив");

            while (n < 1)
            {
                Console.WriteLine("Введите стороны двумерного массива (n>0):");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 1)
                {
                    Console.WriteLine("Данные введены некорректно");
                }
            }
            int[,] myMatrix = new int[n, n];
            completionarray(n, myMatrix);
            conclusionarray(n, myMatrix);
            Console.WriteLine("Произведения элементов в тех строках, которые не содержат отрицательных элементов");

            for (int i = 0; i < n; i++)
            {
                int k = 1;
                int flag = 1;//
                for (int j = 0; j < n; j++)
                {

                    if (myMatrix[i, j] < 0)
                        flag = 0;
                    k = k * myMatrix[i, j];
                }
                if (flag == 1)
                {
                    Console.WriteLine($"Произведение элементов в {i + 1} строке: {k}");
                }
            }
        }

        private static void completionarray(int n, int[,] myMatrix)
        {
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    myMatrix[i, j] = random.Next(-4, 15);
        }

        private static void conclusionarray(int n, int[,] myMatrix)
        {
            Console.WriteLine("Вывод матрицы");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", myMatrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}

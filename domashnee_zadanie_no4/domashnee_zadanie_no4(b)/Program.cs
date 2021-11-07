using System;
using System.Collections;
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
            task1(n, myMatrix);
            Console.WriteLine("Максимум среди сумм элементов диагоналей, параллельных главной диагонали матрицы");
            ArrayList list = new ArrayList();

            for (int i = 0; i < myMatrix.GetLength(0) - 1; i++)
            {
                int sum1 = 0, sum2 = 0;
                for (int j = i + 1; j < myMatrix.GetLength(0); j++)
                {
                    sum1 += myMatrix[j - i - 1, j];
                    sum2 += myMatrix[j, j - i - 1];
                }
                list.Add(sum1);
                list.Add(sum2);
            }
            Console.WriteLine("\nMax: " + ListMax(list));

        }

        private static void task1(int n, int[,] myMatrix)
        {
            Console.WriteLine("Произведения элементов в тех строках, которые не содержат отрицательных элементов:");

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
                else
                {
                    Console.WriteLine($"Строка {i + 1} содержит отрицательные элементы");
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
        static int ListMax(ArrayList list)
        {
            int result = (int)list[0];
            for (int i = 1; i < list.Count; i++)
                if ((int)list[i] > result)
                    result = (int)list[i];
            return result;
        }
    }
}

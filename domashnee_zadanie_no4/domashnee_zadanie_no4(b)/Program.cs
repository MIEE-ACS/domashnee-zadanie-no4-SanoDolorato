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
                Console.WriteLine("Введите количество элементов массива (n>0):");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 1)
                {
                    Console.WriteLine("Данные введены некорректно");
                }
            }
            int[,] myMatrix = new int[n,n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    myMatrix[i,j] = random.Next(-15, 15);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", myMatrix[i, j]);
                Console.WriteLine();
            }

        }
    }
}

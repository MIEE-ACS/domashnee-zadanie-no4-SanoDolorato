using System;

namespace beta_domashnee_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Одномерный массив");
            
            while (n < 1)
            {
                Console.WriteLine("Введите количество элементов массива (n>0):");
                n = Convert.ToInt32(Console.ReadLine());
                if(n<1)
                {
                    Console.WriteLine("Данные введены некорректно");
                }
            }
            double[] myArray = new double[n];
            Random random = new Random();
            completionarray(myArray, random);//заполнение массива рандомными числами
            conclusionarray(myArray);//вывод массива
            //вычислим сумму элементов массива с нечетными номерами
            Console.WriteLine("Сумма элементов массива с нечетными номерами:");
            oddsumms(myArray);
            //сумма элементов массива, между первым и последним отрицательным элементом
            Console.WriteLine("Cумма элементов массива, между первым и последним отрицательным элементом:");
            NegSumm(myArray);
            //сжатие массива по правилам из задания
            Console.WriteLine("Сжатый массив:");
            modulArray(myArray);
            

        }

        private static void modulArray(double[] myArray)
        {
            string strArray = "";
            int counter = 0;//счетчик элементов, модуль которых меньше нуля
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                if ((Math.Abs(myArray[i]) - 1) > 0)
                {
                    strArray += myArray[i];
                    strArray += " ";
                }
                else
                {
                    counter++;
                }
            }
            while (counter > 0)
            {
                strArray += " 0";
                counter--;
            }
            Console.WriteLine(strArray);
        }

        private static void NegSumm(double[] myArray)
        {
            int flagnumber1 = 0; // индекс отрицательного числа первой границы
            int flagnumber2 = 0; // индекс отрицательного числа второй границы
            double summnumber = 0;
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                if (myArray[i] < 0)
                {
                    flagnumber1 = i;
                    break;
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                if (myArray[i] < 0)
                {
                    flagnumber2 = i;
                }
            }
            for (int i = flagnumber1; i < flagnumber2; i++)
            {
                summnumber += myArray[i];
            }
            Console.WriteLine(summnumber);
        }

        private static void conclusionarray(double[] myArray)
        {
            Console.WriteLine("Вывод одномерного массива:");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        private static void completionarray(double[] myArray, Random random)
        {
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    myArray[i] = random.NextDouble() + 0.5;
                    myArray[i] = Math.Round(myArray[i], 3);
                }
                else
                {
                    myArray[i] = -1 * (random.NextDouble()) - 0.5;
                    myArray[i] = Math.Round(myArray[i], 3);
                }
            }
        }

        private static void oddsumms(double[] myArray)
        {
            double oddsumm = 0;
            for (int i = 0; i < myArray.GetLength(0); i += 2)
            {
                oddsumm += myArray[i];
            }
            Console.WriteLine(oddsumm);
        }
    }
}

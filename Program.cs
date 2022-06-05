using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Преобразовать массив так, чтобы сначала шли все отрицательные элементы, 
            а потом положительные (0 считать положительным) */

            //1.Создание и заполнение массива
            int[] arr = new int[25];
            int temp;
            //int[] arr2 = new int[25]; //Для варианта с двумя массивами
            Random rand = new Random(); //Для заполнения массива произвольными значениями

            //2.Заполнение массива и вывод на экран
            for (int i = 0; i < 25; i++)
            {
                arr[i] = rand.Next(-25, 26);
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("\n");

            //3.Решение с двумя массивамя
        /*  int k = 0, b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr2[k] = arr[i];
                    k++;
                } else if (arr[i] >= 0)
                {
                    arr2[24 - b] = arr[i];
                    b++;
                }
            }
            */

            //3.Решение с перебором
            for (int i = 0; i < 24; i++)
            {
                for (int j = i; j < 25; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            //4.Вывод полученного массива на экран
            for (int i = 0; i < 25; i++)
            {
                Console.Write(" " + arr[i]);
                //Console.Write(" " + arr2[i]);
            }
            Console.WriteLine("\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2
{
    internal class Block1
    {
        static int[] RandFillArray(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 10);
            }
            return array;
        }
        static int[] FillArray(int n)
        {

            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int CountMax(int[] array, int max)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max == array[i])
                {
                    if ((i + 1) % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int[] ReplacementOfValues(int[] array, int count, int max)
        {
            int[] new_arr = new int[array.Length + count];
            int l = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    if ((i + 1) % 2 == 0)
                    {
                        new_arr[i + l] = array[i] / 2;
                        k++;
                        new_arr[i + k] = array[i] / 2;
                        l++;
                    }
                    else
                    {
                        new_arr[i + l] = array[i];
                    }
                }
                else
                {
                    new_arr[i + l] = array[i];
                }
            }
            return new_arr;
        }
        public static void BlockOne()
        {
            Console.WriteLine("Введіть розмір масиву");
            int n = int.Parse(Console.ReadLine());
            int[] arr = FillArray(n);
            ShowArray(arr);
            Console.WriteLine();
            ShowArray(ReplacementOfValues(arr, CountMax(arr, FindMax(arr)), FindMax(arr)));
        }
    }
}

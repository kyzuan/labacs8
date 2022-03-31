using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    public class BlockOne
    {
        // Создание нового массива и внос изменений в него.
        static int[] ModificationInArray(int[] array, int n)
        {
            int countPN = CountOfPairNums(array);
            int[] newArray = new int[n + countPN];
            int lead = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    newArray[i + lead] = array[i];
                }
                else
                {
                    newArray[i + lead] = array[i];
                    lead++;
                    newArray[i + lead] = 0;
                }
            }
            return newArray;
        }
        // Счетчик количества парных чисел.
        static int CountOfPairNums(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static int[] RandFillArray(int n)
        {
            Random rand = new Random();
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 100);
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
        public static void DoBlock()
        {  
            Console.WriteLine("Введите размерность одномерного массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = RandFillArray(n);
            ShowArray(array);
            Console.WriteLine();
            Console.WriteLine("Результат выполнения программы: ");
            ShowArray(ModificationInArray(array, n));
        }

    }
}

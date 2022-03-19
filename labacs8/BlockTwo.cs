using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    public class BlockTwo
    {
        //Создание нового зубчастого массива и внов модификации в него.
        static int[][] ModificationInJagArray(int[][] zubArray)
        {
            int[][] nZubArray = new int[zubArray.Length + 1][];
            int needIndex = FindMinElementInZubArray(zubArray);
            int lead = 0;
            for (int i = 0; i < zubArray.Length; i++)
            {              
                if (i == needIndex)
                {
                    nZubArray[i] = new int[zubArray[i].Length];
                    for (int j = 0; j < zubArray[i].Length; j++)
                    {
                        nZubArray[i][j] = 1488;
                    }
                    lead++;
                }
                nZubArray[i + lead] = zubArray[i];
            }
            return nZubArray;
        }
        //Поиск минимального элемента в зубчастом массиве.
        static int FindMinElementInZubArray(int[][] zubArray)
        {
            int number = zubArray[0][0];
            int index = 0;
            for (int i = 0; i < zubArray.Length; i++)
            {
                for (int j = 0; j < zubArray[i].Length; j++)
                {
                    if (number > zubArray[i][j])
                    {
                        number = zubArray[i][j];
                        index = i;
                    }
                }
            }
            return index;
        }
        static int[][] RandFillZubArray(int r)
        {
            Random rand = new Random();
            int[][] zubArray = new int[r][];
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"Введите количество чисел которое должно быть в {i+1} строке: ");
                int col = int.Parse(Console.ReadLine());
                zubArray[i] = new int[col];
            }
            for (int i = 0; i < zubArray.Length; i++)
            {
                for (int j = 0; j < zubArray[i].Length; j++)
                {
                    zubArray[i][j] = rand.Next(1, 100);
                }
            }
            return zubArray;

        }
        static void ShowZubArray(int[][] zubArray)
        {
            for (int i = 0; i < zubArray.Length; i++)
            {
                for (int j = 0; j < zubArray[i].Length; j++)
                {
                    Console.Write(zubArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void DoBlock()
        {
            Console.WriteLine("Введите количество строк которое должно быть в зубчастом массиве: ");
            int r = int.Parse(Console.ReadLine());
            int[][] zubArray = RandFillZubArray(r);
            Console.WriteLine("Изначальный зубчастый массив:");
            ShowZubArray(zubArray);
            Console.WriteLine();
            Console.WriteLine("Массив после добавления строки:");
            ShowZubArray(ModificationInJagArray(zubArray));
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    public class Block2
    {
        static int[][] ModificationInJagArray(int[][] zubArray)
        {
            int[][] nZubArray = new int[zubArray.Length + 1][];
            int needIndex = FindMaxElementInZubArray(zubArray);
            int lead = 0;
            for (int i = 0; i < zubArray.Length; i++)
            {
                nZubArray[i + lead] = zubArray[i];
                if (i == needIndex)
                {
                    
                    nZubArray[i+1] = new int[zubArray[i].Length];
                    for (int j = 0; j < zubArray[i].Length; j++)
                    {
                        nZubArray[i+1][j] = 1;
                    }
                    lead++;
                }
            }
            return nZubArray;
        }
        static int FindMaxElementInZubArray(int[][] zubArray)
        {
            int number = zubArray[0][0];
            int max = 0;
            for (int i = 0; i < zubArray.Length; i++)
            {
                for (int j = 0; j < zubArray[i].Length; j++)
                {
                    if (number < zubArray[i][j])
                    {
                        number = zubArray[i][j];
                        max = i;
                    }
                }
            }
            return max;
        }
        static int[][] RandFillZubArray(int r)
        {
            Random rand = new Random();
            int[][] zubArray = new int[r][];
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"Введите количество чисел которое должно быть в {i + 1} строке: ");
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
        public static void BlockTwo()
        {
            Console.WriteLine("Введите количество строк которое должно быть в зубчастом массиве: ");
            int r = int.Parse(Console.ReadLine());
            int[][] zubArray = RandFillZubArray(r);
            ShowZubArray(zubArray);
            Console.WriteLine();
            Console.WriteLine();
            ShowZubArray(ModificationInJagArray(zubArray));
        }
    }
}

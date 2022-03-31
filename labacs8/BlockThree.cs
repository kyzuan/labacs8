using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    public class BlockThree
    {
        // Сложение двух массивов
        static int[][] ModificattionInJugArray(int[][] fArr, int[][] sArr)
        {
            int[][] nArr = new int[fArr.Length][];
            for (int i = 0; i < nArr.Length; i++)
            {
                nArr[i] = new int[nArr.Length];
            }
            for (int i = 0; i < nArr.Length; i++)
            {
                for (int j = 0; j < nArr[i].Length; j++)
                {
                    nArr[i][j] = fArr[i][j] + sArr[i][j];
                }
                Array.Reverse(nArr[i]);
            }
            
            return nArr;
        }
        // Модификация второго массива в квадратную матрицу.
        static int[][] ModificationInSecondArray(int[][] fArr, int[][] sArr)
        {
            int[][] nSArray = new int[fArr.Length][];
            for (int i = 0; i < nSArray.Length; i++)
            {
                nSArray[i] = new int[nSArray.Length];
            }
            for (int i = 0; i < sArr.Length; i++)
            {
                for (int j = 0; j < sArr[i].Length; j++)
                {
                    nSArray[i][j] = sArr[i][j];
                }
            }
            return nSArray;
        }
        static int[][] InitSecondArray(int[][] fArr)
        {
            Random rand = new Random();
            omt:
            Console.WriteLine($"Введите значение размерности второго массива(Не больше {fArr.Length}):");
            int cr = int.Parse(Console.ReadLine());
            if (cr > fArr.Length)
            {
                goto omt; 
            }
            int[][] zubArray = new int[cr][];
            for (int i = 0; i < zubArray.Length; i++)
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
        static int[][] InitFirstArray()
        {
            Random rand = new Random();
            Console.WriteLine("Введите размерность зубчастого массива(квадратная матрица):");
            int cr = int.Parse(Console.ReadLine());
            int[][] arr = new int[cr][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[cr];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(1, 100);
                }
            }
            return arr;
        }
        static void ShowJagArray(int[][] jagArray)
        {
            for (int i = 0; i < jagArray.Length; i++)
            {
                for (int j = 0; j < jagArray[i].Length; j++)
                {
                    Console.Write(jagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static void DoBlock()
        {
            int[][] fArr = InitFirstArray();
            Console.WriteLine("Полученый массив: ");
            ShowJagArray(fArr);
            Console.WriteLine();
            int[][] sArr = InitSecondArray(fArr);
            Console.WriteLine("Полученый массив:");
            ShowJagArray(sArr);
            Console.WriteLine();
            Console.WriteLine("Результат после сложения двух массивов:");
            ShowJagArray(ModificattionInJugArray(fArr, ModificationInSecondArray(fArr,sArr)));
        }
        
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    internal class BlockTwoListVer
    {
        static List<List<int>> ModificationInArray(List<List<int>> array)
        {
            List<List<int>> nArray = new List<List<int>>();
            for (int i = 0; i < array.Count + 1; i++)
            {
                nArray.Add(new List<int>());
            }
            for (int i = 0; i < nArray.Count; i++)
            {
                for (int j = 0; j < nArray[i].Count; j++)
                {

                }
            }
            return nArray;
        }
        static int FindMinElementInArray(List<List<int>> array)
        {
            int index = 0;
            int min = array[0][0];
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i][j] < min)
                    {
                        min = array[i][j];
                        index = i;
                    }
                }
            }
            return index;
        }
        static List<List<int>> InitMulDimArray()
        {
            Random rand = new Random();
            Console.WriteLine("Введите размерность массива(квадратная матрица): ");
            int rc = int.Parse(Console.ReadLine());
            List<List<int>> twoDimList = new List<List<int>>();
            for (int i = 0; i < rc; i++)
            {
                twoDimList.Add(new List<int>());
            }
            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < rc; j++)
                {
                    twoDimList[i].Add(rand.Next(1,100));
                }
            }
            return twoDimList;   
        }
        static void ShowArray(List<List<int>> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void DoBlock()
        {
            List<List<int>> twoDimList = InitMulDimArray();
            ShowArray(twoDimList);
            Console.WriteLine();
            ShowArray(ModificationInArray(twoDimList));
            
        }
    }
}

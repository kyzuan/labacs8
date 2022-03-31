using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    public class Block3
    {    
        static void InitSecondArray(int[,] arr)
        {
            int[][] zubArray = new int[arr.GetLength(0)][];
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                zubArray[i] = new int[0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 != 0)
                    {
                        Array.Resize(ref zubArray[i], zubArray[i].Length + 1);
                        zubArray[i][zubArray[i].Length - 1] = arr[i, j];
                        count++;
                    }
                }
            }
            foreach (var m in zubArray)
                Array.Sort(m);
            ShowJagArray(zubArray);
            Console.WriteLine();         
            int[] res = new int[count];
            int index = 0;
            for(int i = 0; i < zubArray.Length;i++)
            {
                for(int j = 0; j < zubArray[i].Length; j++)
                {
                    res[index++] = zubArray[i][j];
                   
                }
            }
            ShowArray(res);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == i)
                {
                    Console.Write(i + "\t");
                }
            }
            
        }
        static void ShowArray(int[] array)
        {        
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }       
        }    
        static void OutputArr(int a,int[,] arr)
        {       
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"\t {arr[i, j]} ");
                }
                Console.WriteLine();
            }          
        }
         
        static int[,] RandomArr(int a)
        {
            int[,] arr = new int[a, a];
            Random r = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = r.Next(0, 100);
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
        public static void BlockThree()
        {
            Console.WriteLine("Введіть розмір матриці");
            int a = int.Parse(Console.ReadLine());
            int[,] arr = RandomArr(a);
            OutputArr(a,arr);
            Console.WriteLine();
            InitSecondArray(arr);          
        }

    }
}

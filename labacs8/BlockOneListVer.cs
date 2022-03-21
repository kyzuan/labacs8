using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labacs8
{
    internal class BlockOneListVer
    {
        static List<int> ModificationInArray(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 == 0 && array[i] != 0)
                {          
                    array.Insert(i + 1, 0);
                }
            }
            return array;
        }
        static List<int> InitArray()
        {
            Random random = new Random();
            var nList = new List<int>();
            Console.WriteLine();
            Console.WriteLine("Введите количество символов которое должно быть в массиве: ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {            
                nList.Add(random.Next(1,100));
            }
            return nList;
        }
        static void ShowArray(List<int> array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public static void DoBlock()
        {
            var nList = InitArray();
            ShowArray(nList);
            Console.WriteLine();
            ShowArray(ModificationInArray(nList));
            
        }
    }
}

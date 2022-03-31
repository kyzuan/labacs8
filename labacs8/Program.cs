using System;

namespace labacs8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cho;
            do
            {
                Console.Clear();
                Console.WriteLine("Введите - 1 для исполнения 1-го блока + List версия");
                Console.WriteLine("Введите - 2 для исполнения 2-го блока");
                Console.WriteLine("Введите - 3 для исполнения 3-го блока");
                Console.WriteLine("Введите - 0 для выхода");
                cho = char.Parse(Console.ReadLine());
                switch (cho)
                {
                    case '1':
                        BlockOne.DoBlock();
                        BlockOneListVer.DoBlock();
                        Console.ReadLine();
                        break;
                    case '2':
                        BlockTwo.DoBlock();
                        Console.ReadLine();
                        break;
                    case '3':
                        BlockThree.DoBlock();
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (cho != '0');
        }
    }
}

using System;

namespace labacs8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char cho;
            char cho1;
            do
            {
                again:
                Console.Clear();
                Console.WriteLine("Введите - 1 для просмотра блоков Варианта 13 (Кузьменко Никита)");
                Console.WriteLine("Введите - 2 для просмотра блоков Варината 11 (Шавлак Игорь)");
                Console.WriteLine("Введите - 0 для выхода");
                cho = char.Parse(Console.ReadLine());
                switch (cho)
                {
                    case '1':
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Кузьменко Никита (13 вариант)");
                            Console.WriteLine("Введите - 1 для исполнения 1-го блока + List версия");
                            Console.WriteLine("Введите - 2 для исполнения 2-го блока");
                            Console.WriteLine("Введите - 3 для исполнения 3-го блока");
                            Console.WriteLine("Введите - 0 для выхода");
                            cho1 = char.Parse(Console.ReadLine());
                            switch (cho1)
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
                                    goto again;
                                    break;
                            }
                        } while (cho1 != 0);
                        break;
                    case '2':
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Шавлак Игорь (11 вариант)");
                            Console.WriteLine("Введите - 1 для исполнения 1-го блока");
                            Console.WriteLine("Введите - 2 для исполнения 2-го блока");
                            Console.WriteLine("Введите - 3 для исполнения 3-го блока");
                            Console.WriteLine("Введите - 0 для выхода");
                            cho1 = char.Parse(Console.ReadLine());
                            switch (cho1)
                            {
                                case '1':
                                    Block1.BlockOne();
                                    Console.ReadLine();
                                    break;
                                case '2':
                                    Block2.BlockTwo();
                                    Console.ReadLine();
                                    break;
                                case '3':
                                    Block3.BlockThree();
                                    Console.ReadLine();
                                    break;
                                default:
                                    goto again;
                                    break;
                            }
                        } while (cho1 != 0);
                        break;                          
                }
            } while (cho != 0);
           
        }
    }
}

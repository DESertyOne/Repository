using System;

namespace PracticalWork4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поиграем в игру Угадай число =)" +
                "\nВведите максимально целое число диапозона:");
            int maxRange = int.Parse(Console.ReadLine());

            Random random = new Random();
            int numbRandom = random.Next(0, maxRange);

            Console.WriteLine("Если вы устанете играть, то просто нажмите клавишу Enter" +
                "\nдля завершения игры.");

            while (true)
            {
                Console.Write("Введите число: ");
                int numb = int.Parse(Console.ReadLine());
                int count = 0; // если вдруг надо будет подключить счетчик для вывода количества попыток
                
                if (numbRandom < numb)
                {
                    Console.WriteLine("Ваше число больше загаданного,попробуй еще раз =)");
                }
                else if (numbRandom > numb)
                {
                    Console.WriteLine("Ваше число меньше загаданного,попробуй еще раз =)");
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы угадали число!!!");
                    break;
                }
            }
        }

    }
}


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

                string numb = Console.ReadLine();
                int count = 0; // если вдруг надо будет подключить счетчик для вывода количества попыток

                if (string.IsNullOrWhiteSpace(numb))
                {
                    Console.WriteLine($"Загаданное число {numbRandom}");
                    break;
                }
                bool result = int.TryParse(numb, out var numbUser);
                if (numbRandom < numbUser)
                {
                    Console.WriteLine("Ваше число больше загаданного,попробуй еще раз =)");
                }
                else if (numbRandom > numbUser)
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



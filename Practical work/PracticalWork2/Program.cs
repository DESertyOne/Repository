using System;

namespace PracticalWork2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int sum = 0;

            Console.WriteLine("Приветсятвую Вас, я могу помочь вам подсчитать очки в карточной игре Blackjack" +
                "\nСколько у вас карт на руках?:");
            int numberCard = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberCard; i++)
            {
                Console.Write($"Введите номинал {i} карты: ");
                string cardNumber = (Console.ReadLine());

                switch (cardNumber)
                {
                    case "2": sum += 2; break;
                    case "3": sum += 3; break;
                    case "4": sum += 4; break;
                    case "5": sum += 5; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10": sum += 10; break;
                    case "J": sum += 10; break;
                    case "Q": sum += 10; break;
                    case "K": sum += 10; break;
                    case "T": sum += 10; break;
                    default:
                        Console.WriteLine("Не существует карты с таким номиналом :)");
                        break;
                }
            }
            Console.WriteLine($"Сумма карт: {sum}");
            Console.ReadKey();
        }

    }
}

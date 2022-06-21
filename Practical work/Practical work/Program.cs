using System;

namespace Practical_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"Число является четным ");
            }
            else
            {
                Console.WriteLine($"Число является нечетным ");
            }
        }
    }
}

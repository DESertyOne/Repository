using System;

namespace PracticalWork4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности чисел: ");
            int numb = int.Parse(Console.ReadLine());
            var massiv = new int[numb];
            int minNumber = int.MaxValue;

            Console.WriteLine("Введите полседовательно целые числа: ");

            for (int i = 0; i < numb; i++)
            {
                massiv[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numb; i++)
            {
                if (massiv[i] < minNumber) minNumber = massiv[i];
            }
                Console.WriteLine($"Наименьшее число: {minNumber}");
        }
    }
}

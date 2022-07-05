using System;

namespace PracticalWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int numbString = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int numbColumn = int.Parse(Console.ReadLine());

            var matrix = new int[numbString, numbColumn];
            Random r = new Random();
            int sum = 0;

            for (int i = 0; i < numbString; i++)
            {
                for (int j = 0; j < numbColumn; j++)
                {
                    matrix[i, j] = r.Next();
                    sum += matrix[i, j];

                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма чисел = {sum}");
        }
    }
}

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

            int[,] matrix = new int[numbString, numbColumn];
            Random r = new Random();

            for (int i = 0; i < numbString; i++)
            {
                for (int j = 0; j < numbColumn; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

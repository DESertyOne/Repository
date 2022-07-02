using System;

namespace PracticalWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int numbString = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int numbColumn = int.Parse(Console.ReadLine());

            Random r = new Random();

            int[,] matrix = new int[numbString, numbColumn];

            for (int i = 0; i < numbString; i++)
            {
                for (int j = 0; j < numbColumn; j++)
                {
                    matrix[i, j] = r.Next(10);
                    Console.WriteLine($"{matrix[i, j]} ");
                }
                Console.ReadKey();
            }
        }
    }
}

using System;

namespace PracticalWork5
{
    internal class Program
    {
        public static void WordDivision()
        {
            string word = Console.ReadLine();
            string [] words = word.Split(' ');
            foreach (var less in words)
            {
                Console.WriteLine($"{less}");
            }
        }
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void Main()
        {
            WordDivision();
            Pause();
        }
    }
}

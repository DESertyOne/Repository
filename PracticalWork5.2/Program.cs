using System;

namespace PracticalWork5._2
{
    internal class Program
    {
        private static string WordDivision(string text) // 
        {
            string[] WordDivision = text.Split(' ');
            string newText = ReverseWord(WordDivision);
            return newText;
        }

        private static string ReverseWord(string[] text) // 
        {
            Array.Reverse(text);
            string resultWord = string.Join(" ", text);
            return resultWord;
        }

        private static void Main()
        {
            string newWord = Console.ReadLine();
            newWord = WordDivision(newWord);


            Console.WriteLine(newWord);
            _ = Console.ReadLine();
        }
    }
}

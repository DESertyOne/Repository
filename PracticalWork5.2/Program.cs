using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace PracticalWork5._2
{
    internal class Program
    {
        public static void WordDivision()
        {
            string word = Console.ReadLine();
            string [] words = word.Split(' ');

        }
        public static void ReversWords(string inputPharse)
        {
            Console.ReadLine();
            inputPharse.Reverse();
            foreach (var revers in inputPharse)
            {
                Console.WriteLine($"{revers}");
            }
        }
        private static void Main()
        {
            ReversWords("");
            {
                WordDivision();
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

             static void wordDivision()
            {
                string[] strings = word.Split(' ', '.');
            }
             static void wordOutput()
            {
                foreach(var words in wordDivision())
                {
                    Console.WriteLine($"{words}");
                }
            }
        }
    }
}

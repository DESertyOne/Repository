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

              void WordDivision()
              {
                string[] strings = word.Split(' ', '.');
              }
              void WordOutput()
              {
                foreach(var words in word)
                {
                    Console.WriteLine($"{words}");
                }
              }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public void WordDivision()
        {
            string word = Console.ReadLine();
            string[] words = word.Split(' ');
        }
        public void WordOutput()
        {
            foreach (var less in WordDivision())
                Console.WriteLine($"{less}");
        }
    }
}

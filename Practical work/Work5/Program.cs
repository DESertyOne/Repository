using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Work5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            void WordDivision()
            {
                string[] words = word.Split(' ');
            }
            void WordOutput()
            {
                foreach(var less in word)
                    Console.WriteLine(less);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности чисел: ");
            int numb = int.Parse(Console.ReadLine());
            int numbMassiv = 0;
            var  massiv = new int[numb];
            
            for (int i = 0; i < numb; i++)
            {
                Console.Write("Введите полседовательно целые числа: ");
                numbMassiv = int.Parse(Console.ReadLine());
                numbMassiv = massiv[0];
            }
            for (int j = 0; j >= int.MaxValue; j--)
            {
                Console.WriteLine($"Наименьшее число: {j}");
            }
        }
    }
}

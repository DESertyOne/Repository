using System;

namespace PracticalWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool simpleNumb = true;
            int N = 1;

            Console.Write("Я помогу вам узнать является ли число простым");

            Console.Write("\nВведите ваше число: ");
            double numb = Convert.ToDouble(Console.ReadLine());

            while (N < numb - 1)
            {
                N++;
                if (numb % N == 0)
                {
                    simpleNumb = false;
                    break;
                }
            }
            if (simpleNumb)
            {
                Console.WriteLine($"Число простое");
            }
            else
            {
                Console.WriteLine($"Число не простое");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace PracticalWork6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("db.csv", true, Encoding.Unicode))
            {
                char key = 'y';
                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите ID сотрудника: ");
                    note += $"{Console.ReadLine()}\t";

                    string now = DateTime.Now.ToShortDateString();
                    note += $"{now}\t";
                    
                    Console.Write("Введите Ф.И.О.: ");
                    string fdr = Console.ReadLine();
                    note += $"{fdr}\t";
                    
                    Console.Write("Введите возраст сотрудника: ");
                    string age = Console.ReadLine();
                    note += $"{age}\t";

                    Console.Write("Введите рост сотрудника: ");
                    string dss = Console.ReadLine();
                    note += $"{dss}\t";

                    Console.Write("Введите дату рождения сотрудника: ");
                    string htc = Console.ReadLine();
                    note += $"{htc}\t";

                    Console.Write("Введите место рождения сотрудника: ");
                    string brp = Console.ReadLine();
                    note += $"{brp}\t";
                    sw.WriteLine(note);

                    Console.Write("Продожить N/Y"); key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'y');
            }
        }
    }
}

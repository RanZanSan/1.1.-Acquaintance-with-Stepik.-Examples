using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // считываем две строки
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            /* выводим их объединение */
            Console.WriteLine(str1 + str2);
            Console.ReadKey();
        }
    }
}
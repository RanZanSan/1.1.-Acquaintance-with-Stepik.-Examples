using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesToo
{
    class Program
    {
        static void Main(string[] args)
        {
            // считываем переданное число
            int a = int.Parse(Console.ReadLine());
            // выводим сумму числа и единицы
            Console.WriteLine(a + 1);
        }
    }
}
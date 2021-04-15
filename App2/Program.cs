using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r % 7 == 0 &
                r % 3 == 0)
            {
                Console.WriteLine("Четко");
            }
            else
            {
                Console.WriteLine("Не Четко");
            }
            Console.ReadKey();
        }
    }
}

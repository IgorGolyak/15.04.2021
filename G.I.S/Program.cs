using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G.I.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r % 5 == 0)
            {
                Console.WriteLine("Четко");
            }
            else
            {
                Console.WriteLine("Не четко");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r % 2 == 0)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HW_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 8;
            int additional = x + y;
            int difference = x - y;
            int difference2 = y-x;
            int multiplication = x * y;
            decimal division = (decimal)x / (decimal)y;//для коректного відображення розрахунків перетворюємо int в decimal
            int division2 = y / x;
            int remainder = x % y;
            int remainder2 = y % x;
            Console.WriteLine(additional);
            Console.WriteLine(difference);
            Console.WriteLine(difference2);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(division2);
            Console.WriteLine(remainder);
            Console.WriteLine(remainder2);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_HW_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y=12, z=3;
            x+= y - x++ * z;
            Console.WriteLine("{0} {1} {2}", x, y, z);

            x = 10; y = 12; z = 3;
            z = --x - y * 5;
            Console.WriteLine("{0} {1} {2}", x, y, z);

            x = 10; y = 12; z = 3;
            y /= x + 5 % z;
            Console.WriteLine("{0} {1} {2}", x, y, z);

            x = 10; y = 12; z = 3;
            z = x++ + y*5;
            Console.WriteLine("{0} {1} {2}", x, y, z);

            x = 10; y = 12; z = 3;
            x = y - x++ * z;
            Console.WriteLine("{0} {1} {2}", x, y, z);
            Console.ReadLine();

        }
    }
}

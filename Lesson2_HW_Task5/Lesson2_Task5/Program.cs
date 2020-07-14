using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            sbyte h = 4;
            sbyte r = 2;
            double volume = PI * r * r * h;
            double area = 2*PI*r*(r+h);
            Console.WriteLine("V= {0}", volume);
            Console.WriteLine("S= {0}", area);
            Console.ReadLine();

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10, c = 20;
            double arithmeticalMean = ((double)a + (double)b + (double)c) / 3; //для отримання точних рорахунків 
                                                                               //потрібно перетворити змінні з типу 
                                                                               //int у тип double або decimal
            Console.WriteLine("Середнє арифметичне= {0}", arithmeticalMean);
            Console.ReadKey();
        }
    }
}

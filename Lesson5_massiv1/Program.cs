using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_massiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            for (int i = 0; i < 7; i++) 
            {
                Console.WriteLine("Введите элемент {0}", i + 1);

                array[i] = int.Parse(Console.ReadLine());

            }
            int summ = 0;
            foreach (int a in array) 
            {
                summ += a;
            }
            double average = (double)summ / 7;
            Console.WriteLine("Среднее арифметическое = {0}", average);
            Console.ReadKey();
            



        }
    }
}

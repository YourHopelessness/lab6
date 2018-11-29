using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
       static void Main(string[] argv)
        {
            Console.WriteLine("Введите множители ");
            string[] input = Console.ReadLine().Split(' ');

            Console.WriteLine("Произведение = {0}", Multiple(int.Parse(input[0]), int.Parse(input[1])));
        }
        static long Multiple(int first, int second)
        {
            long mult = first;
            for (int i = 1; i < second; i++)
                mult += first;
            return mult;
        }
    }
}

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
            bool flag = false;
            int fMult, sMult;
            fMult = sMult = 0;
            Console.WriteLine("Введите множители ");

            while (!flag)
            {
                string[] input = Console.ReadLine().Split(' ');
                
                flag = true;
                try
                {
                    fMult = int.Parse(input[0]);
                    sMult = int.Parse(input[1]);
                }
                catch
                {
                    flag = false;
                    Console.WriteLine("Неккоректный ввод");
                }
            }

            Console.WriteLine("Произведение = {0}", Multiple(fMult, sMult));
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

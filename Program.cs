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
            float fMult, sMult;
            fMult = sMult = 0;
            Console.WriteLine("Введите множители ");

            while (!flag)
            {
                string[] input = Console.ReadLine().Split(' ');
                
                flag = true;
                try
                {
                    fMult = float.Parse(input[0]);
                    sMult = float.Parse(input[1]);
                }
                catch
                {
                    flag = false;
                    Console.WriteLine("Неккоректный ввод");
                }
            }

            Console.WriteLine("Произведение = {0}", Multiple(fMult, sMult));
        }
        static float Multiple(float first, float second)
        {
            return first * second; 
        }
    }
}

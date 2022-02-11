using System;

namespace ConsoleApp1.Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*4) 1-50 arasi (1 ve 50 de daxil olmaqla [1,50]) 
            * butun tek ededleri cap etmek */

            for (int i = 1; i <= (50); i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i); 
                }
            }
        }
    }
}

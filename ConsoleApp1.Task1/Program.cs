using System;

namespace ConsoleApp1.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) 73 ededinin tek ve ya cut oldugunu 
             * cap ede bilen alqoritma yazmali*/

            int a = 73;
            a %= 2;

            if (a == 1)
            {
                Console.WriteLine("Tek eded");
            }

            else
            {
                Console.WriteLine("Cut eded");
            }
        }
    }
}

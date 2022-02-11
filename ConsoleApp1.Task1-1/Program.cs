using System;

namespace ConsoleApp1.Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2) Ededin 4-e bolunub bolunmediyini 
             * cap eden alqoritma yazmali*/

            int b = 18;
            int c = b / 4;

            if (c == 1 || c == 4)
            {
                Console.WriteLine("eded 4-e bolunur");
            }

            else
            {
                Console.WriteLine("eded 4-e bolunmur");
            }
        }
    }
}

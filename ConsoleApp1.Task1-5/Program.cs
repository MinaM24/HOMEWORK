using System;

namespace ConsoleApp1.Task1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) 1-50 arasi ancaq 5-e ya da 3-e bolunen 
             * ededleri cap etmek (misal ucun 3,5,9,12,15)*/

            for (int i = 1; i <= (50); i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

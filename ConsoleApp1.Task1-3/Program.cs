using System;

namespace ConsoleApp1.Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3) 4 eded verilib (a,b,c,d). bu ededlerin ilk ikisini cemleyib, 
             * son ikisinin hasilini tapmaq.  
             * sonda ise cemi hasile bolmek. 
             * ve cavabi ekrana cap etmek ( cem / hasil)*/
            
            int a = 10;
            int b = 5;
            int c = 1;
            int d = 5;

            int e = a + b;
            int f = c * d;
            int g = e / f;

            Console.WriteLine(g);

            //Console.WriteLine((a + b) / (c * d));


        }
    }
}

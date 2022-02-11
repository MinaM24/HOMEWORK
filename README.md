# HOMEWORK
using System;

namespace ConsoleApp_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("73 ededinin tek ve ya cut oldugunu cap ede bilen alqoritma yazmali   -");

            int a = 73;
            a %= 2;

            if(a == 1)
            {
                Console.WriteLine("Tek eded");
            }

            else
            {
                Console.WriteLine("Cut eded");
            }


            Console.Write("Ededin 4-e bolunub bolunmediyini cap eden alqoritma yazmali   -");

            int b = 16;
            int c = b / 4;

            if (c == 1 || c==4)
            {
                Console.WriteLine("eded 4-e bolunur");
            }

            else
            {
                Console.WriteLine("eded 4-e bolunmur");
            }



            Console.WriteLine("4 eded verilib (a,b,c,d). bu ededlerin ilk ikisini cemleyib, son ikisinin hasilini tapmaq.  sonda ise cemi hasile bolmek. ve cavabi ekrana cap etmek ( cem / hasil)");

            int a = 10;
            int b = 5;
            int c = 1;
            int d = 5;
            
            int e = a + b;
            int f = c * d;
            int g = e / f;

            Console.WriteLine(g);
            
            //Console.WriteLine((d + e) / (f * g));

            
            
            Console.WriteLine("1-50 arasi (1 ve 50 de daxil olmaqla [1,50]) butun tek ededleri cap etmek");

            for (int i = 1; i <= (50); i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

           
            Console.WriteLine("1-50 arasi ancaq 5-e ya da 3-e bolunen ededleri cap etmek (misal ucun 3,5,9,12,15)");

            for (int i = 1; i <=(50); i++)
            {
                if (i % 3 ==0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }








        }

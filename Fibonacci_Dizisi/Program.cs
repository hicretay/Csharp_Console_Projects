using System;

namespace Fibonacci_Dizisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dizi kaç elemandan oluşsun: ");
            int sayi = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 1;
            int sonuc = 0;
            for (int i = 0; i < sayi; i++)
            {   
                a = b;
                b=sonuc;
                sonuc = a + b;
                Console.WriteLine(sonuc);
            }
            
            Console.ReadLine();
        }
    }
}

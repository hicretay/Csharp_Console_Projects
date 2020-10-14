using System;
using System.Collections;

namespace example_2
{
    class Program
    {
        static void Harf_Sil()
        {

            Console.WriteLine("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();

            Console.WriteLine("Kaçıncı karakter kaldırılsın: ");
            int sayi = int.Parse(Console.ReadLine());

            if ((kelime.Length >= sayi)|| (sayi < 0))
            {
                string rem = kelime.Remove(sayi - 1, 1);
                Console.WriteLine(rem);
            }
            else
            {

                Console.WriteLine("Hatalı giriş !");
                
            }
        }

        static void Main(string[] args)
        {

            Harf_Sil();
            Console.ReadLine();
        }
        
    }
}

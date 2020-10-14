using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Toplam
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Dizi kaç elemandan oluşsun: ");
            int el_sayisi = int.Parse(Console.ReadLine());
            int toplam = 0;
            int[] dizi = new int[el_sayisi];

            for (int i = 0; i < el_sayisi; i++)
            {
                Console.WriteLine("Dizinin {0}. elemanını girin: ",i);
                int sayi = int.Parse(Console.ReadLine());
                dizi[i] = sayi;
            }
            foreach (var item in dizi)
            {
                toplam += item;                
            }
            Console.WriteLine("Elemanlarin Toplami: {0}", toplam);
            Console.ReadLine();
                
        }
    }
}

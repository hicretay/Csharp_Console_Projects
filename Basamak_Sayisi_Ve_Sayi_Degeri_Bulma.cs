using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace example_4
{
    class Program
    {
        //2 - Kullanıcının girdiği sayıyı bı önceki sorudaki gibi basamaklarına bölen ve tek tek yazdıran kodu yazınız

        static void Main(string[] args)
        {
            Basamak_Bul();
            Console.ReadLine();
        }

        public static void Basamak_Bul()
        {
            int sayac=0, deger=0,sayi,temp,sonuc;
            Console.WriteLine("Basamaklarına ayrılacak sayıyı giriniz: ");
            sayi = int.Parse(Console.ReadLine());
            temp = sayi;

            while (temp>=1)
            {
                temp /= 10;
                sayac++;
            }
            Console.WriteLine("Girilen sayının basamak sayısı: {0}", sayac + System.Environment.NewLine);
            for (int i = sayac ; i > 0; --i)
            {                
                deger = (int)(Math.Pow(10, i));
                sonuc = (sayi % deger) / (deger / 10);
                Console.WriteLine("Girilen sayının basamakların değeri: {0}", sonuc);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girilen_sayiya_kadar_karelerini_toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayi;
            int toplam = 0;

            Console.WriteLine("kaca kadar toplansin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=sayi; i++)
            {
                toplam = toplam + (i * i);
            }
            Console.Write("toplam: " + toplam);
            Console.ReadLine();


        }
    }
}

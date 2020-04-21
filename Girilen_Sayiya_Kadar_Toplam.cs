using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardisik_sayi_bastiran_kod
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi;
            Console.WriteLine("kac sayi girilsin: ");
            sayi = int.Parse(Console.ReadLine());

            for ( int i=0;i<=sayi;i++)
            {
                toplam = toplam + i;   //girilen sayıya kadar olan sayıların toplamı
            }
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}

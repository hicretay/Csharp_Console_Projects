using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizideki_tek_ve_cift_sayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];
            int i;
            for(i=0;i<10;i++)
            {
                Console.WriteLine("sayi giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("tek sayilar: ");
            for(i=0;i<=9;i++)
            {
                if(dizi[i]%2==1)
                {
                    Console.WriteLine(dizi[i]);
                }

            }
            Console.WriteLine("cift sayilar: ");
            for(i=0;i<=9;i++)
            {
                if(dizi[i]%2==0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantik_islemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a sayisini giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b sayisini giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
                Console.WriteLine("b sayisi a sayisindan büyüktür");
            if(a>b)
                Console.WriteLine("a sayisi b sayisindan büyüktür");
            if(a == b) 
            Console.WriteLine("sayilar esittir");

            Console.ReadLine();

        }
    }
}

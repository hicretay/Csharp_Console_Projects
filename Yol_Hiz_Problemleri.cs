using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yol_hiz_problemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int yol, hiz, zaman;
            Console.WriteLine("yol uzunlugunu giriniz: ");
            yol = int.Parse(Console.ReadLine());

            Console.WriteLine("hizi giriniz: ");
            hiz = int.Parse(Console.ReadLine());

            zaman = (yol / hiz);

            Console.WriteLine("yolun alınma suresi: " + zaman);
            Console.ReadLine();
        }
    }
}

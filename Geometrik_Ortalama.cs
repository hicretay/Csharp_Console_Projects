using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrik_ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, geoort;
            Console.WriteLine("birinci sayiyi giriniz: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi giriniz: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            double v = Math.Sqrt(sayi1 * sayi2);
            geoort = v;

            Console.WriteLine("geometrik ortalama: " + v);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalan_borc_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("toplam borc tutarini giriniz: ");
            double borc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("aylik odenen tutari giriniz: ");
            double odenen = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("odenen ay sayisini giriniz: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            double kalan = borc - (odenen * ay);
            Console.WriteLine("kalan borc: " + kalan);

            Console.ReadLine();
        }
    }
}

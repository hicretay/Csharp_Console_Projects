using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikinci_dereceden_polinom
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, sonuc1, sonuc2;

            Console.WriteLine("a degerini giriniz: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("b degerini giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("c degerini giriniz: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta==0)
            {
                sonuc2 = sonuc1 = ((-b) / 2 * a);
                Console.WriteLine("cozum kumesi: {0},{1})" + sonuc1, sonuc2);
            }

            if(delta>0)
            {
                sonuc1 = (((-b) + Math.Sqrt(delta))/2*a);
                sonuc2 = (((-b) - Math.Sqrt(delta)) / 2 * a);
                Console.WriteLine("cozum kumesi: {0},{1})" + sonuc1, sonuc2);
            }

            if(delta<0)
            {
                Console.WriteLine("hesaplanamaz");
                Console.ReadLine();

            }
        }
    }
}

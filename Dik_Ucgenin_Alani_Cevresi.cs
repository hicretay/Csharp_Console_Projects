using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dik_ucgenın_alanı_ve_cevresi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ucgenin birinci kenarini giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ucgenin ikinci kenarini giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hipotenus = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Hipotenus: {0}", hipotenus);
            Console.ReadLine();

            Console.WriteLine("Dik üçgenin Alanı= {0}", Alani(a, b));
            Console.WriteLine("Dik üçgenin çevresi = {0}", Cevresi(a, b, hipotenus));
            Console.ReadKey();
        }
        static int Alani(int a, int b)
        {
            int alan = (a * b) / 2;
            return alan;
        }

        static int Cevresi(int a, int b, int hipotenus)
        {
            int cevre = (a + b + hipotenus);
            return cevre;
        }
    }
}

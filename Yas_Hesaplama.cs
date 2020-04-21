using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yas_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bugunun tarihini giriniz: ");
            int bugun = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("dogum tarihinizi giriniz: ");
            int dogum = Convert.ToInt32(Console.ReadLine());

            int yas = bugun - dogum;
            Console.WriteLine("yasınız: " + yas);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mutlak_deger_donduren_kod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayi girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int mutlak;
            if(sayi<0)
            {
                mutlak = sayi * (-1);
            }
            else
            {
                mutlak = sayi;
            }
            Console.WriteLine(sayi);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayi_karsilastirma
{
    class Program
    {
        static int Karsilastir(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("a ve b yi giriniz: ");
            int a, b = Convert.ToInt32(Console.ReadLine());
        }
    }
}

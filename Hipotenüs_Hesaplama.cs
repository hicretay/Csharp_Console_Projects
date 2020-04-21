using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hipotenüs_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("a kenarının uzunlugunu girin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b kenarının uzunlugunu girin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int hipotenus = (int)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Hipotenus: {hipotenus}");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aylik_mesai_ucreti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saatlik ucreti giriniz: ");
            double ucret = double.Parse(Console.ReadLine());

            Console.WriteLine("calisma saatini giriniz: ");
            int saat = Convert.ToInt32(Console.ReadLine());

            double maas = ucret * saat;
            Console.WriteLine("aylik kazanciniz: " + maas);
            Console.ReadLine();
        }
    }
}

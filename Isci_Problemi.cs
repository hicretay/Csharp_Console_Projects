using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isci_problemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("isci sayisini giriniz: ");
            int isci = int.Parse(Console.ReadLine());

            Console.WriteLine("bir iscinin isi bitirme suresini giriniz: ");
            int zaman = int.Parse(Console.ReadLine());

            int bitirmesuresi = (zaman / isci);
            Console.WriteLine("isin bitme suresi: " + bitirmesuresi);
            Console.ReadLine();
        }
    }
}

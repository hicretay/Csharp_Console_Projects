using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizideki_elemanlarin_ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double top = 0, ort = 0;
            Console.WriteLine("dizinin eleman sayisini giriniz: ");
            int a = Int32.Parse(Console.ReadLine());
            double[] dizi = new double[a];
            for (int i=0;i<dizi.Length;i++)
            {
                Console.Write(i + 1);
                dizi[i] = Convert.ToDouble(Console.ReadLine());
                top += dizi[i];
            }
            ort = top / dizi.Length;
            Console.WriteLine(top);
            Console.WriteLine(ort);
            Console.ReadLine();

        }
    }
}

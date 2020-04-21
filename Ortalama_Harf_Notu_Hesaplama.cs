using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortalama_ve_harf_notu_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
           int vize, final, final2, ort;

            Console.Write("vize notunu giriniz: ");
            int.Parse(Console.ReadLine());

            Console.Write("final notunu giriniz: ");
            int.Parse(Console.ReadLine());

            vize = vize*(4 / 10);
            final2 = final*(6 / 10);
            ort = vize + final2;



            if (final < 50)

            {
                Console.Write("ortalama: " + ort + "harf notu: FF");
                Console.Write("kaldiniz");
            }

            else

            {
                if (ort >= 90 && ort <= 100)
                {
                    Console.Write("ortalamanız: " + ort + " harf notunuz: AA");
                }

                else if (ort >= 80 && ort < 90)

                {
                    Console.Write(" ortalamanız: " + ort + " harf notunuz: BA");
                }

                else if (ort >= 70 && ort < 80)

                {
                    Console.Write(" ortalamanız: " + ort + " harf Notunuz: BB");
                }

                else if (ort >= 60 && ort < 70)

                {
                    Console.Write(" ortalamanız: " + ort + " harf notunuz: CB");
                }

                else if (ort >= 50 && ort < 60)

                {
                    Console.Write(" ortalamanız: " + ort + " harf notunuz: CC");
                }

                else if (ort >= 45 && ort < 50)

                {
                    Console.Write(" ortalamanız: " + ort + " harf notunuz: DD");
                }

                else if (ort >= 0 && ort < 45)

                {
                    Console.Write(" ortalamanız: " + ort + " harf notunuz: FF");
                }
            }
            Console.ReadKey();
        }
    }
}

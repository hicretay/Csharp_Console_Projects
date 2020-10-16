using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sayi_Tahmin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0;
            Random rnd = new Random();
            int sayi = rnd.Next(0, 101);
            Console.WriteLine(sayi);
            //hile
            while (tahmin!=sayi)
            {
                Console.WriteLine("0-100 arası bir sayı tahmin ediniz: ");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin==sayi)
                {
                    Console.WriteLine("Doğru tahminn");
                    break;
                }
                else if ((Math.Abs(tahmin-sayi)<=10)&&(Math.Abs(tahmin-sayi)>=5))
                {
                    Console.WriteLine("Yanlış tahmiin");
                    Console.WriteLine("ılıık");
                }
                else if ((Math.Abs(tahmin - sayi) <= 5) && (Math.Abs(tahmin - sayi) >= 0))  
                {
                    Console.WriteLine("Yanlış tahmiin");
                    Console.WriteLine("sıcaak");
                }
                else if(tahmin - sayi >= 10)
                {
                    Console.WriteLine("Yanlış tahmiin");
                    Console.WriteLine("soğuuuk");
                }   
                
            }
            Console.ReadLine();
        }
    }
}

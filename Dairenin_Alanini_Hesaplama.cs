using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairenin_alanini_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            double alan, yaricap;
            Console.WriteLine("yaricapi giriniz: ");
            yaricap = double.Parse(Console.ReadLine());

            alan = Math.PI * yaricap * yaricap;
            Console.WriteLine("dairenin alani: " + alan);
            Console.ReadLine();
        }
    }
}

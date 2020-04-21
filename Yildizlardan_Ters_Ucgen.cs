using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yildizlardan_ters_ucgen_yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ucgen kac satirdan olussun: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<sayi;i++)
            {
                for(int j=sayi;j>i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}

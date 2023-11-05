using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9_BedenİndeksiProgramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle İndeksi Program'ına Hoşgeldiniz.");

            Console.Write("Kilonuzu giriniz(Lütfen yazarken araya (,) koyunuz. Örnek: 80,50):");
            double kilo=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilonuz:" + kilo);

            Console.Write("Boyunuzu giriniz(Lütfen yazarken araya (,) koyunuz. Örnek: 1,86:");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Boyunuz:" + boy);

            double indeks = kilo / (boy * boy);

            if(indeks>18 && indeks < 25)
            {
                Console.WriteLine("İndeksiniz: Normal :) ");
            }
            else if(indeks<18 )
            {
                Console.WriteLine("İndeksiniz: Zayıf :(");
            }
            else if (indeks > 25)
            {
                Console.WriteLine("İndeksiniz: Yüksek :/");
            }
            Console.ReadLine();
        }
    }
}

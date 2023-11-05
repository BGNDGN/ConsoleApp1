using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çıkarmak İstediğiniz 2 Sayıyı Giriniz.");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çıkartılacak Sayılar: " + c + " " + "Ve" + " " + d);
            if (c >= d)
            {
                Console.Write("Sonuc:" + (c-d));
            }
            else if (d > c)
            {
                Console.WriteLine("İlk Girdiğiniz Sayı, İkinci Girdiğiniz Sayıdan büyük olmak zorunda.");
            }
            Console.ReadLine();
        }
    }
}

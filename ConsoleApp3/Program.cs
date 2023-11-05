using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpmak İstediğiniz 2 Sayıyı Giriniz.");
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çarpılacak Sayılar: " + e + " " + "Ve" + " " + f);

            Console.Write("Çarpma Sonucu:" + (e * f));
            Console.ReadLine();
        }
    }
}

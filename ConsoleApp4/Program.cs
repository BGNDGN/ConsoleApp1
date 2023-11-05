using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bölmek İstediğiniz 2 Sayıyı Giriniz. Bu iki birbirine tam bölünmek(kalansız) zorunda.");
            int ğ = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bölünecek Sayılar: " + ğ + " " + "Ve" + " " + h);

            Console.Write("Bölme Sonucu:");
            if (ğ >= h)
            {
                Console.Write(ğ / h);
            }
            else if (h > ğ)
            {
                Console.WriteLine("İlk Girdiğiniz Sayı, İkinci Girdiğiniz Sayıdan büyük olmak zorunda.");
            }
            Console.ReadLine();
        }
    }
}

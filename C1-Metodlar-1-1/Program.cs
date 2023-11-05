using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1_Metodlar_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Selam();

            // sayilar(10,20);

            /* int Dönendeğer=toplama(1, 2, 3);
            if (Dönendeğer > 10)
            {
                Console.WriteLine("Toplam 10'dan büyük.");
            }
            else
            {
                Console.WriteLine("Toplam 10'dan küçük.");
            }
            Console.ReadLine(); */

            /*string d=isimsoyisim("Burak", "Gündoğan");
            Console.WriteLine(d);
            Console.ReadLine();*/

            Console.WriteLine("bir sayi giriniz.");
            int sayi=Convert.ToInt32(Console.ReadLine());
            int cevap = üsalma(sayi);
            if(cevap == 25) 
            {
                Console.WriteLine("Sonucu 25 olmayan bir sayı giriniz.");
            }
            else if(cevap>25)
            {
                Console.WriteLine("Sonucunuz 25'ten büyük.");
            }
            else if (cevap < 25)
            {
                Console.WriteLine("Sonucunuz 25'ten küçük.");
            }
            Console.ReadLine();
        }
        static void Selam()
        {
            Console.WriteLine("Selam:)");
            Console.ReadLine();
        }
        static void sayilar(int sayi1, int sayi2)
        {
            Console.WriteLine("SONUC:"+(sayi1 + sayi2));
            Console.ReadLine();
        }
        static int toplama(int sayi1, int sayi2, int sayi3)
        {
            int sonuc = sayi1 + sayi2 + sayi3;
            Console.WriteLine("Sonuc:" + sonuc);
            Console.ReadLine();
            return sonuc;
        }
        static string isimsoyisim(string a, string b)
        {
            string sonuc = a + " " + b;
            return sonuc;
        }
        static int üsalma(int sayi1)
        {
            int sonuc = sayi1 * sayi1;
            Console.ReadLine();
            return sonuc;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10_SwitchileMiniATMMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 1000;

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz...");
            Console.WriteLine("1-Bakiyeyi Göster.");
            Console.WriteLine("2-Hesabına para çek.");
            Console.WriteLine("3-Hesabından para yatır.");
            Console.WriteLine("4-ATM'den çıkiş yap...");

            string secim = Console.ReadLine();

            Console.WriteLine("Yaptığınız seçim:" + secim);
            Console.WriteLine("");

            switch(secim)
            {
                case "1":

                Console.WriteLine("Bakiyeniz:TL" + bakiye);
                    break;


                case "2":
            
                Console.Write("Hesabınızdan çekeceğiniz tutarı giriniz:");
                double cekilecek_para = Convert.ToDouble(Console.ReadLine());

                if (cekilecek_para > bakiye)
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz. Bakiyenizi kontrol edip tekrar deneyiniz.");
                }

                else if (bakiye > cekilecek_para)
                {
                    Console.WriteLine("Yeni bakiyeniz:TL" + (bakiye - cekilecek_para));
                }
                    break;


                case "3":
            
                Console.Write("Yatırılacak miktarı giriniz:");
                double yatırılacak_para = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatırılacak_para));
                    break;

                case "4":
            
                Console.Write("ATM'den çıkış yapılıyor.");
                Console.Write("Çıkış yapıldı. İyi günler...");
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8_KararYapılarınıKullanarakMiniATMMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 1000;

            Console.Write("Yapmak İstediğiniz İşlemi Seçiniz.\n");
            Console.WriteLine("1-Bakiyeyi Görüntüle.");
            Console.WriteLine("2-Hesabıma Para Yatır.");
            Console.WriteLine("3-Hesabımdan Para Çek.");
            Console.WriteLine("4-ATM'den Çık.");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("Bakiyeniz:" + " " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                double yatıralacak_para = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yatırmak İstediğiniz Miktarı Giriniz:" + yatıralacak_para);
                Console.WriteLine("Yeni bakiyeniz: TL" + (bakiye + yatıralacak_para));

            }
            else if (secim == "3")
            {
                Console.WriteLine("Hesabınızdan Çekme İstediğiniz Parayı Giriniz:");
                double cekilece_para = Convert.ToDouble(Console.ReadLine());
                    
                if (cekilece_para > bakiye)
                {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz.");
                    Console.ReadLine();
                }
                else if (bakiye > cekilece_para)
                {
                    Console.WriteLine("Yeni Bakiyeniz:" + (bakiye - cekilece_para));
                    Console.ReadLine();
                }
                else if (secim == "4")
                {
                    Console.WriteLine("ATM'den Çıkış Yapılıyor...");
                    Console.WriteLine("Çıkış Yapıldı. İyi Günler Dileriz.");
                    Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}

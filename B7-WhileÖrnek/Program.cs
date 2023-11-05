using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace B7_WhileÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 3;

            while(true)
            {
                Console.Write("Kullanıcı Adınızı Giriniz:");
                string kullanıcı_adı=Console.ReadLine();
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı_adı);
                Console.WriteLine(" ");
                Console.Write("Şifrenizi Giriniz.(Sadece Sayılardan Oluşmaktadır.):");
                int sifre = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Şifreniz:" + sifre);
                Console.WriteLine(" ");

                if (kullanıcı_adı == "fantastic" && sifre==1234)
                {
                    Console.WriteLine("Giriş Yapılıyor...");
                    Console.WriteLine("Giriş Yapıldı!");
                    break;
                }
                else 
                {
                    Console.WriteLine("Kullanıcı adı veya şifreniz yanlış.");
                
                    if (hak >= 3)
                    {
                        hak--;
                        Console.WriteLine("Hakkınız:" + hak--);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

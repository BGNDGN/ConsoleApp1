using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C3_ClassÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Öğrenci öğrenci1=new Öğrenci("Burak", "Gündoğan", 60, 80, 90, 204, "Topkapı Üniversitesi");
            
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
                Console.WriteLine("1-Öğenci Bilgilerini Göster.");
                Console.WriteLine("2-Ortalamayı Göster.");
                Console.WriteLine("3-Okul Adını Göster.");
                Console.WriteLine("4-Çıkış yap.");
                      
                string secim = Console.ReadLine();

                switch(secim)
                {

                    case "1":
                    öğrenci1.öğrencibilgileri();
                    break;

                    case "2":
                    öğrenci1.ortalamayıgöster(); 
                    break;

                    case "3":
                    öğrenci1.okulismi();
                    break;

                    case "4":
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
            

          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C4_ClassÖrnek_2_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aile aile1= new Aile("Şennur", "Nurittin","Nuri", 50, 55, 26);

            Console.WriteLine("1-Aile Adlarını Göster:");
            Console.WriteLine("2-Aile Yaşlarını Göster:");
            Console.WriteLine("3-Çıkış Yap.");

            string secim=Console.ReadLine();

            switch(secim) 
            {
                case "1":
                    aile1.ailead();
                    break;

                    case "2":
                    aile1.aileyaş(); break; 
                    case "3":
                    Console.WriteLine("Çıkış Yapılıyor...(ENTER'A BASINIZ.");
                    break;   
            }
            Console.ReadLine();
        }
    }
}

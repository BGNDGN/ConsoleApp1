using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_ClassÖrnek3_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 KişiselBilgilerim = new Class1("Burak", "Gündoğan", 19, 342, "Topkapı Üniversitesi");

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("1-İsim ve Soyisim bilgilerimi göster.");
            Console.WriteLine("2-Yaşımı Göster.");
            Console.WriteLine("3-YKS Puanımı Göster.");
            Console.WriteLine("4-Okulumun Adını Göster.");

            string secim=Console.ReadLine();

            switch(secim)
            {
                case "1": KişiselBilgilerim.isimsoyisim();
                    break;
                case "2": KişiselBilgilerim.yas();
                    break;
                case "3": KişiselBilgilerim.ykspuan();
                    break;
                case "4": KişiselBilgilerim.OkulAdı();
                    break;
            }
            Console.ReadLine();
        }
    }
}

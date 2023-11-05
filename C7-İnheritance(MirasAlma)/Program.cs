using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_İnheritance_MirasAlma_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan=new Hayvan();

            hayvan.köpekyaşı = 2;
            hayvan.köpekrengi = "Beyaz";
            hayvan.köpekadi = "Boncuk";
            hayvan.köpekcinsiyeti = "AdamYaAdamYaVallahiGeldiAdam";

            hayvan.köpekbilgileri();

            Console.ReadLine();

            //Köpek Class'ının içine girdiğimiz bilgileri "Hayvan" Class'ına entegre edip "Main" sınıfı içerisinden de girdiğimiz bilgilere değer verip ekrana yazdırdık.
        }
    }
}

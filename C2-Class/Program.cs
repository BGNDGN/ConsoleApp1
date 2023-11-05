using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();

            araba.arabarengi = "KIRMIZI";
            araba.arabamodeli = "BMW";
            araba.kapisayisi = 4;

            araba.kapılarıkitle();
            araba.motorcalistir();

            Console.WriteLine("Arabanın rengi:" + araba.arabarengi);
            Console.WriteLine("Arabanın modeli:" + araba.arabamodeli);
            Console.WriteLine("Arabanın kapı sayısı:" + araba.kapisayisi);
            Console.ReadLine();
        }
    }
}

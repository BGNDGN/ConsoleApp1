using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_KararYapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aldığnız 2 Sınav Notunuzu Ard Arda Yazınız:");

            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());

            double sonuc = (a + b) / 2;

            Console.WriteLine("Aldığınız Notlar:" + " " + a + " " + "Ve" + " " + b);
            Console.WriteLine("Ortalamanız:" + sonuc);

            if (sonuc >= 50)
            {
                Console.WriteLine("Tebrikler. Dersten Başarıyla Geçtiniz :)");
                Console.WriteLine("Geçme Notunuz:" + sonuc);
            }
            else if (sonuc <=50)
            {
                Console.WriteLine("Üzgünüz. Dersten Geçemediniz :(");
                Console.WriteLine("Kalma Notunuz:" + sonuc);
            }
            Console.ReadLine();
        }
    }
}

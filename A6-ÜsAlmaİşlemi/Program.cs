using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_ÜsAlmaİşlemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üssünü almak istediğiniz sayıyı giriniz.");

            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üssü Alınacak Sayı:"+ " " + a  );

            int sonuc = a * a;

            Console.Write("Sonucunuz:" + sonuc);
            Console.ReadLine();
        }
    }
}

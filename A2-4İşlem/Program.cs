using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_4İşlem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplayacağınız Sayıları Giriniz:");

            int a=Convert.ToInt32(Console.ReadLine()); //C#'ta kullanıcıdan aldığımız her değer "string değer olarak başlar. Bu yüzden
                                                       //"Convert" koduyla string değerden integer değerine dönüştürüyoruz.
            int b=Convert.ToInt32(Console.ReadLine());  


            Console.Write("Toplama Sonucu:" + (a + b));
            Console.ReadLine();
        }
    }
}

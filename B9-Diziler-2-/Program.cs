using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9_Diziler_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[6];

            for(int a=0; a<sayilar.Length; a++)
            {
                Console.Write("6 Tane Sayıyı Giriniz:");
                sayilar[a] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" ");
            Console.WriteLine("***********************");
            Console.WriteLine(" ");
            for (int b=0; b<sayilar.Length; b++)
            {
                Console.WriteLine(sayilar[b]);
            }
            Console.ReadLine();
        }
    }
}

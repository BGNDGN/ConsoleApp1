using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Diziler_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] sayılar = new int[3];

             sayılar[0] = 10;
             sayılar[1] = 20;
             sayılar[2] = 30;

             for(int a = 0; a<sayılar.Length; a++)
             {
                 Console.WriteLine(sayılar[a]);
             }
             Console.ReadLine();*/

            /*-----------------------------------------------------------*/

            /*string[] isimler = { "Burak", "Şennur", "Nuri", "Nurittin" }; 
             * 
            

            for (int a = 0; a < isimler.Length; a++)
            {
                Console.WriteLine(isimler[a]);
            }
            Console.ReadLine();*/

            /*-----------------------------------------------------------*/

            char[] harfler = { 'B', 'U', 'R', 'A', 'K' };

            for (int a = 0; a < harfler.Length; a++)
            {
                Console.Write(harfler[a]);
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}

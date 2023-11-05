using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_ForDöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1'den 10'a kadar olan sayılar alt alta yazılacakltır:");

            for(int a=1;  a <= 10; a++)
            {
                Console.WriteLine(a);
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_ContinueVeBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(int a=1; a<=10; a++)
            {
                if (a == 6)
                {
                    break;                    //"Break" komutu belirttiğimiz yerden sonra döngüden çıkmamız için kullanılır. 
                }
                Console.WriteLine(a);
            }*/

            for (int b=1; b<=10;b++)
            {
                if (b == 6)
                {
                    continue;                //"Continue" komutu belirttiğimiz yeri döngüde yokmuşçasına atlayıp devam eder.
                }
                Console.WriteLine(b);
            }
            Console.ReadLine();
        }
    }
}

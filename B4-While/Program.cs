using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int aa = 1;

            while(aa >= 10)
            {
                Console.Write(aa);
                aa++;
            }*/

            int a = 100;

            while (a >= 0)
            {
                Console.WriteLine(a);
                a=a-2;
            }
            Console.ReadLine();
        }
    }
}

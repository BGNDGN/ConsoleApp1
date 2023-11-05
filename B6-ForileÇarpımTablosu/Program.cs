using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_ForileÇarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a=1; a<=10; a++)
            {
                for(int b=1; b<=10; b++)
                {
                   Console.WriteLine(+a+"x"+b+"="+(a * b));
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}

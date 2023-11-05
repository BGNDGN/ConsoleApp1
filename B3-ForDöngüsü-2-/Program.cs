using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_ForDöngüsü_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int a=1; a<=10; a++)
            {
                for(int b=1; b<=a; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();    
        }
    }
}

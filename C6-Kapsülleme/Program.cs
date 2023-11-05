using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C6_Kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İsim isim=new İsim();

            isim.setİSİM("Burak");
            string Gelenİsim=isim.getİSİM();
            Console.WriteLine(Gelenİsim);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Class
{
    public class Araba
    {
        public int kapisayisi;
        public string arabamodeli;
        public string arabarengi;

        public void motorcalistir()
        {
            Console.WriteLine("Motor Çalışıyor...");
        }

        public void kapılarıkitle()
        {
            Console.WriteLine("Kapılar Kitleniyor...");
        }
    }
}

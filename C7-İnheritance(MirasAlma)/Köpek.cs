using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7_İnheritance_MirasAlma_
{
    public class Köpek
    {
        public string köpekadi;
        public string köpekrengi;
        public string köpekcinsiyeti;
        public int köpekyaşı;

        public void köpekbilgileri()
        {
            Console.WriteLine("Köpeğin Adı:" + köpekadi);
            Console.WriteLine("Köpeğin Rengi:" + köpekrengi);
            Console.WriteLine("Köpeğin Cinsiyeti:" + köpekcinsiyeti);
            Console.WriteLine("Köpeğin Yaşı:" + köpekyaşı);
        }
    }
}

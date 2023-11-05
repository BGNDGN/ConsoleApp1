using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C5_ClassÖrnek3_3
{
    public class Class1
    {
        public string ad;
        public string soyad;
        public int yaş;
        public int ykspuanı;
        public string okuladı;


        public Class1(string ad1, string soyad1, int yaş1, int ykspuanı1, string okuladı1)
        {
            ad = ad1;
            soyad = soyad1;
            yaş = yaş1;
            ykspuanı = ykspuanı1;
            okuladı = okuladı1;
        }

        public void isimsoyisim()
        {
            Console.WriteLine("Ad ve Soyad:" + ad,soyad);
        }

        public void yas() 
        {
            Console.WriteLine("Yaş:"+yaş);
        }

        public void ykspuan()
        {
            Console.WriteLine("YKS Puanı:" + ykspuanı);
        }

        public void OkulAdı()
        {
            Console.WriteLine("Okul Adı:"+okuladı);
        }
    }
}

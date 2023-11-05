using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3_ClassÖrnek
{
    public class Öğrenci
    {
        private string öğrencismi;
        private string öğrencisoyismi;
        private double vize1;
        private double vize2;
        private double final;
        private int öğrencinumarası;
        private string okulunadı;

        public Öğrenci(string _öğrencismi, string _öğrencisoyismi, double _vize1, double _vize2, double _final, int _öğrencinumarası, string _okulunadı)
        {
            öğrencismi = _öğrencismi;
            öğrencisoyismi = _öğrencisoyismi;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            öğrencinumarası = _öğrencinumarası;
            okulunadı = _okulunadı;
        }

        public void öğrencibilgileri()
        {
            Console.WriteLine("Ad:" + öğrencismi);
            Console.WriteLine("SoyAd:" + öğrencisoyismi);
            Console.WriteLine("Numara:" + öğrencinumarası);
            Console.ReadLine();
        }

        public void  ortalamayıgöster()
        {
            Console.WriteLine("1.Vize:" + vize1);
            Console.WriteLine("2.Vize:" + vize2);
            Console.WriteLine("Final:" + final);

            double ortalama=(vize1+vize2+final)/3;
            Console.WriteLine("Ortalama:" + ortalama);

            if(ortalama>=50) 
            {
                Console.WriteLine("Dersten Geçtiniz :)");
            }

            else if(ortalama<50)
            {
                Console.WriteLine("Dersten Kaldınız :(");
            }

            Console.ReadLine();
        }

        public void okulismi()
        {
            Console.WriteLine("Okulun İsmi:" + okulunadı);
            Console.ReadLine();
        }
        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C4_ClassÖrnek_2_
{
    public class Aile
    {
        private string anneadı;
        private string babaadı;
        private string abiablakardeşadı;
        private int anneyaş;
        private int babayaş;
        private int abiablakardeşyaş;


        public Aile(string anneadı1, string babaadı1, string abiablakardeşadı1, int anneyaş1, int babayaş1, int abiablakardeşyaş1) 
        {
            anneadı = anneadı1;
            babaadı = babaadı1;
            abiablakardeşadı = abiablakardeşadı1;
            anneyaş = anneyaş1;
            babayaş = babayaş1;
            abiablakardeşyaş = abiablakardeşyaş1;
        }

        public void ailead()
        {
            Console.WriteLine("Anne Adı:" + anneadı);
            Console.WriteLine("Baba Adı:" + babaadı);
            Console.WriteLine("Abi Adı:" + abiablakardeşadı);
        }

        public void aileyaş()
        {
            Console.WriteLine("Anne Yaş:" + anneyaş);
            Console.WriteLine("Baba Yaş:" + babayaş);
            Console.WriteLine("Abi Yaş:" + abiablakardeşyaş);
            Console.ReadLine();
        }
    }
}

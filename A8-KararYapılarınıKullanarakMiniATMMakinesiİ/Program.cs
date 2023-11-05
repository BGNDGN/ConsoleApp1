using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A8_KararYapılarınıKullanarakMiniATMMakinesiİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 1000;

            Console.WriteLine("Select the action you want to perform...");
            Console.WriteLine("1-Show balance.");
            Console.WriteLine("2-Overdraw an account.");
            Console.WriteLine("3-Deposit money into your account.");
            Console.WriteLine("4-Quit from ATM...");

            string secim=Console.ReadLine();

            Console.WriteLine("Your choice:" + secim);
            Console.WriteLine("");

            if(secim=="1")
            {
                Console.WriteLine("Your balance:" + bakiye + " " + "Dolar");
            }

            else if(secim=="2")
            {
                Console.Write("Enter the amount you will withdraw from your account:");
                double cekilecek_para=Convert.ToDouble(Console.ReadLine());

                if(cekilecek_para>bakiye)
                {
                    Console.WriteLine("You cannot withdraw more money than your balance. Please check your balance and try again.");
                }
                
                else if(bakiye>cekilecek_para)
                {
                    Console.WriteLine("Your new balance:" + (bakiye - cekilecek_para + " " + "Dolar"));
                }
            }
            
            else if(secim=="3")
            {
                Console.Write("Enter the amount to deposit:");
                double yatırılacak_para=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatırılacak_para) + " " + "Dolar");
            }

            else if(secim=="4")
            {
                Console.Write("Quitting from ATM.\n\n");
                Console.Write("It's quited. Have a nice day...");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWHİLE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uretilensayi = rnd.Next(20, 35);
            int sayi;
            int hak = 5;
            Console.WriteLine("URETİLEN SAYI {0}", uretilensayi);
            do
            {
                
                Console.WriteLine("ÜRETİEN SAYIYI  TAHMİN EDİN : ");
                4sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi==uretilensayi)
                {
                    Console.WriteLine("TAHMİNİNİZ DOĞRU!");

                }
                
                else
                {
                    hak--;
                    if (hak==0)
                    {
                        Console.WriteLine("TAHMİN HAKKINIZI KAYBETTİNİZ");

                    }
                    else
                    {
                        Console.WriteLine("YANLIŞ TAHMİN TEKRAR DENEYİN");
                    }
                }

            } while (hak!=0 && sayi!=uretilensayi);
            Console.ReadKey();
        }
    }
}

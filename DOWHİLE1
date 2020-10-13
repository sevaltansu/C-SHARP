using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWHİLE
{
    class Program
    {
        static void Main(string[] args)
        {
            string kad = "seval", ksifre = "123";
            string kullacıcıad, kullanıcısifre;
            int hak = 3;
            do
            {
                Console.WriteLine("kullanıcı adını giriniz : ");
                kullacıcıad = Console.ReadLine();
                Console.WriteLine("kullanıcı şifresini giriniz : ");
                kullanıcısifre = Console.ReadLine();
                if (kullacıcıad==kad && kullanıcısifre==ksifre)
                {
                    Console.WriteLine("BAŞARIYLA GİRİŞ YAPTINIZ!");


                }
                else
                {
                    hak--;
                    if (hak==0)
                    {
                        Console.WriteLine("GİRİŞ HAKKINIZI KAYBETTİNİZ. MÜŞTERİ HİZMETLERİNE BAĞLANIN ");
                    }
                }

            } while ((kullanıcısifre!=ksifre || kullacıcıad!=kad)&& hak!=0);
            Console.ReadKey();
            
        }
    } 
}

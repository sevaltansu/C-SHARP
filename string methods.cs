using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {  

            Console.Write("Belirlediğiniz Kullanıcı Adını Giriniz>> ");
            string ad = Console.ReadLine();
            TEKRAR:
            

            Console.Write("Belirlediğiniz Şifreyi Giriniz>> ");
            string sifre1 = Console.ReadLine();
            Console.Write("Şifreyi Tekrar Giriniz>> ");
        
            
            string sifre2 = Console.ReadLine();
            int karşılaştırma = string.Compare(sifre1, sifre2);
            if (karşılaştırma==0)
            {
                Console.WriteLine("ŞİFRELER EŞLEŞTİ");

            }
            else
            {
                Console.WriteLine("ŞİFRELER EŞLEŞMİYOR LÜTFEN TEKRAR DENEYİNİZ!!");
                goto TEKRAR;
                
            }
            Console.ReadKey();
        }
    }
}

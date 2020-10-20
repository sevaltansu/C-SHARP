using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOLDERCREATİON
{
    class Program
    {
        static void Main(string[] args)
        {BASADON:
            
            Console.Write("ÖĞRENCİ NUMARANIZI GİRİN>>");
            string ognu = Console.ReadLine();
            Console.Write("KAYIT OLMAK İSTEDİĞİNİZ SINIFI SEÇİN>>");
            string sınıf = Console.ReadLine();

            string klasoradıyolu = @"c:\okul\" + sınıf;
            if (System.IO.Directory.Exists(klasoradıyolu)==true)
            {
                string ogrenciklasor = @"c:\okul\" + sınıf + "\\" + ognu;
                System.IO.Directory.CreateDirectory(ogrenciklasor);
                Console.Write("öğrencinin klasörü oluşturuldu");
            }
            else
            {
                Console.Write("böyle bir sınıf mevcut değildir lütfen tekrar deneyin");
               
                goto BASADON;
                
            }
            Console.ReadKey();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            char secim;
            Console.WriteLine("1- MATEMATİK");
            Console.WriteLine("2- FİZİK");
            Console.WriteLine("3- BİYOLOJİ");
            MENU:
            Console.WriteLine("LÜTFEN BİLGİ ALMAK İSTEDİĞİNİZ DERSİ SEÇİN :[1-2-3?]");
            secim = Convert.ToChar(Console.ReadLine());
            
            switch (secim)

            {
                case '1':
                    Console.WriteLine("MATEMATİK");
                    Console.WriteLine("HAFTANIN 3 GÜNÜ");
                    Console.WriteLine("HAFTADA TOPLAM 8 SAAT ");
                break;
                case '2':
                    Console.WriteLine("FİZİK");
                    Console.WriteLine("HAFTANIN İKİ GÜNÜ");
                    Console.WriteLine("HAFTADA TOPLAM 5 SAAT ");
                    break;
                case '3':
                    Console.WriteLine("BİYOLOJİ");
                    Console.WriteLine("HAFTADA 2 GÜN");
                    Console.WriteLine("HAFTADA TOPLAM 4 SAAT ");
                    break;
                default:
                    Console.WriteLine("LÜTFEN BİLGİ ALMAK İSTEDİĞİNİZ DERSİ SEÇİN :[1-2-3?]");
                    break;
                    

            } Console.Clear();
            goto MENU;
            Console.ReadLine();
        }
    }
}

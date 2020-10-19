using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYLOGGER2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tusbilgisi;
            do
            {
                Console.Clear();
                Console.WriteLine("CTRL+K: KUP HACMİ HESAPLAMA ");
                Console.WriteLine("ALT+O: KONİ HACMİ HESAPLAMA ");
                Console.WriteLine("SHİFT+S: SİLİNDİR HACMİ HESAPLAMA ");
                Console.WriteLine("SEÇİMİZİ YAPIN K?S?O?");
                tusbilgisi = Console.ReadKey();
                if ((tusbilgisi.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    if (tusbilgisi.Key.ToString() == "K")
                    {
                        Console.Write("KÜPÜN KENAR UZUNLUĞUNU GİRİN ");
                        double kenar = Convert.ToDouble(Console.ReadLine());
                        double sonuc = GEOMETRİ.kuphacimhesaplama(kenar);
                        Console.Write("kupun hacmi {0}", sonuc);

                    }
                }
                else if ((tusbilgisi.Modifiers & ConsoleModifiers.Alt)!=0)

                {
                    if (tusbilgisi.Key.ToString()=="O");
                    {
                        Console.Write("KONİNİN YARIÇAPINI GİRİN");
                        double yarıcap = Convert.ToDouble(Console.ReadLine());
                        Console.Write("KONİNİN YÜKSEKLİĞİNİ GİRİN");
                        double yukseklik = Convert.ToDouble(Console.ReadLine());
                        double sonuc = GEOMETRİ.silindirhacimhesaplama(yukseklik, yarıcap);
                        Console.Write("KONİNİN HACMİ {0}", sonuc);
                    }

                }
                else if( (tusbilgisi.Modifiers & ConsoleModifiers.Shift)!=0)
                {
                    if (tusbilgisi.Key.ToString()=="S")
                    {
                        Console.Write("SİLİNDİRİN YÜKSEKLİĞİNİ GİRİN ");
                        double yukseklik = Convert.ToDouble(Console.ReadLine());
                        Console.Write("SİLİNDİRİN YARIÇAPINI GİRİN ");
                        double yarıcap = Convert.ToDouble(Console.ReadLine());
                        double sonuc = GEOMETRİ.silindirhacimhesaplama(yukseklik, yarıcap);
                        Console.Write("SİLİNDİRİN HACMİ  {0}", sonuc);

                    }
                }




            } while (Console.ReadKey().Key.ToString()!="ESCAPE");

            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakıt_Projesi1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dizel = 3.12, benzin = 3.28, lpg = 1.78;
            double dizeltank = 1000, benzintank = 1000, lpgtank = 1000;
            double satışmiktarı = 0;
            char anamenüseçim = '0', altmenüseçim ='0', akaryakıtfiyatıgüncelle = '0', akaryakıtsatıştipi = '0';

        MENU:
            Console.WriteLine("AKARYAKIT SATIŞ TAKİBİ ");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1-BİRİM FİYATI GÖSTER ");
            Console.WriteLine("2-BİRİM FİYAT GÜNCELLE ");
            Console.WriteLine("3-AKARYAKIT SATIŞI YAP ");
            Console.WriteLine("4-DEPO DURUMUNU GÖSTER ");
            Console.WriteLine("5-TOPLAM SATIŞLARI GÖSTER");
            Console.WriteLine("6-ÇIKIŞ");
            Console.WriteLine("SEÇİMİNİZİ YAPIN :[1-2-3-4-5-6]");
            anamenüseçim = Convert.ToChar(Console.ReadLine());
            if (anamenüseçim=='1')
            {
                Console.Clear();
                Console.WriteLine("BİRİM FİYATLARI");
                Console.WriteLine("----------------");
                Console.WriteLine("DİZEL:{0},BENZİN:{1},LPG:{2}", dizel, benzin, lpg);
                ALTMENU:
                Console.WriteLine("SEÇİMİNİZİ YAPIN:[1-ANA MENÜ ,2-ÇIKIŞ]");
                altmenüseçim = Convert.ToChar(Console.ReadLine());
                if (altmenüseçim=='1')
                {
                    Console.Clear();
                    goto MENU;


                }
                else if (altmenüseçim=='2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ ");
                    goto ALTMENU;
                }


            }
            else if (anamenüseçim=='2')
            {
                Console.Clear();
            AKARYAKITTİPİ:
                Console.WriteLine("AKARYAKIT TİPİNİ SEÇİN :(D,B,L)");
                akaryakıtfiyatıgüncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakıtfiyatıgüncelle=='d'|| akaryakıtfiyatıgüncelle=='D')
                {
                    Console.WriteLine("DİZEL (D):{0}", dizel);
                    Console.WriteLine("DİZEL YAKIT İÇİN YENİ FİYAT GİRİNİZ : ");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("YENİ DİZEL FİYATI GÜNCELLENMİŞTİR.");
                    Console.WriteLine("DİZEL (D):{0}", dizel);


                }
                else if (akaryakıtfiyatıgüncelle=='B' || akaryakıtfiyatıgüncelle=='b')
                {
                    Console.WriteLine("BENZİN (B):{0}", benzin);
                    Console.WriteLine("BENZİN İÇİN YENİ FİYAT GİRİNİZ : ");
                   benzin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("YENİ BENZİN FİYATI GÜNCELLENMİŞTİR.");
                    Console.WriteLine("BENZİN (B):{0}", benzin);
                }
                else if (akaryakıtfiyatıgüncelle=='L' || akaryakıtfiyatıgüncelle=='l')
                {
                    Console.WriteLine("LPG (L):{0}", lpg);
                    Console.WriteLine("LPG İÇİN YENİ FİYAT GİRİNİZ : ");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("YENİ LPG FİYATI GÜNCELLENMİŞTİR.");
                    Console.WriteLine("LPG (L):{0}", lpg);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ ");
                    goto AKARYAKITTİPİ;
                }
            ALTMENU:
                Console.WriteLine("SEÇİMİNİZİ YAPIN:[1-ANA MENÜ ,2-ÇIKIŞ]");
                altmenüseçim = Convert.ToChar(Console.ReadLine());
                if (altmenüseçim == '1')
                {
                    Console.Clear();
                    goto MENU;


                }
                else if (altmenüseçim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ ");
                    goto ALTMENU;
                }
            }
            else if (anamenüseçim=='3')
            {
                Console.Clear();
            AKARYAKITSATIŞI:
                Console.WriteLine("AKARYAKIT TİPİNİ SEÇİN : ");
                akaryakıtsatıştipi = Convert.ToChar(Console.ReadLine());
                if (akaryakıtsatıştipi=='D' ||akaryakıtsatıştipi=='d')
                {
                    if (dizeltank==0)
                    {
                        Console.WriteLine("YAKIT TANKINDA HİÇ DİZEL KALMAMIŞTIR!");
                            goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("NE KADARLIK YAKIT ALACAKSINIZ : ");
                        satışmiktarı = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank<satışmiktarı)
                        {
                            Console.WriteLine("DİZEL TANKINDA {0} DİZEL VARDIR. İŞLEM YAPILAMADI!",dizeltank);
                            goto MENU;

                        }
                        else if (satışmiktarı<=dizeltank)
                        {
                            dizeltank = dizeltank - satışmiktarı;
                            Console.WriteLine("YAKIT DOLUMU TAMAMLANMIŞTIR");
                            Console.WriteLine("KALAN YAKIT MİKTARI: {0}", dizeltank);


                        }
                    }

                }
               else if (akaryakıtsatıştipi == 'B' || akaryakıtsatıştipi=='b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("YAKIT TANKINDA HİÇ BENZİN KALMAMIŞTIR!");
                            goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("NE KADARLIK YAKIT ALACAKSINIZ : ");
                        satışmiktarı = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satışmiktarı)
                        {
                            Console.WriteLine("BENZİN TANKINDA {0} BENZİN  VARDIR. İŞLEM YAPILAMADI!", benzintank);
                            goto MENU;

                        }
                        else if (satışmiktarı <= benzintank)
                        {
                            benzintank= benzintank- satışmiktarı;
                            Console.WriteLine("YAKIT DOLUMU TAMAMLANMIŞTIR");
                            Console.WriteLine("KALAN YAKIT MİKTARI: {0}", benzintank);


                        }
                    }

                }
               else if (akaryakıtsatıştipi == 'L' || akaryakıtsatıştipi=='l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("YAKIT TANKINDA HİÇ LPG KALMAMIŞTIR!");
                            goto MENU;

                    }
                    else
                    {
                        Console.WriteLine("NE KADARLIK YAKIT ALACAKSINIZ : ");
                        satışmiktarı = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satışmiktarı)
                        {
                            
                            Console.WriteLine("LPG TANKINDA {0} LPG VARDIR. İŞLEM YAPILAMADI!", lpgtank);
                            Console.Clear();
                            goto MENU;

                        }
                        else if (satışmiktarı <= lpgtank)
                        {
                            lpgtank = lpgtank - satışmiktarı;
                            Console.WriteLine("YAKIT DOLUMU TAMAMLANMIŞTIR");
                            Console.WriteLine("KALAN YAKIT MİKTARI: {0}", lpgtank);


                        }
                    }

                }
                else
                {
                    
                    Console.WriteLine("HATALI SEÇİM YAPTINIZ ");
                    goto AKARYAKITSATIŞI;
                }

            }
            Console.ReadKey();

        }
    } 
}

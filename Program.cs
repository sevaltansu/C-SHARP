using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uretilensayi = rnd.Next(10, 20);
            int hak = 3;
            Console.WriteLine("ÜRETÝLEN SAYI:{0}", uretilensayi);
            BASADON:
            Console.WriteLine("BÝR TAHMÝNDE BULUNUN : ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (uretilensayi==tahmin)
            {
                Console.WriteLine("TEBRÝKLER! DOÐRU TAHMÝN! PUANINIZ {0}", hak * 10);


            }
            else if (tahmin<uretilensayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("OYUNU KAYBETTÝNÝZ!");

                }
                else
                {
                    Console.WriteLine("TAHMÝNÝNÝZÝ BÜYÜLTÜN");
                    goto BASADON;
                   
                }
            }
            else if (tahmin>uretilensayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("oyunu kaybettiniz ");

                }
                else
                {
                    Console.WriteLine("TAHMÝNÝNÝZÝ KÜÇÜLTÜN ");
                    goto BASADON;
                }

            }
            Console.ReadLine();

        } 
    }
}

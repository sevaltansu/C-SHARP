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
            Console.WriteLine("�RET�LEN SAYI:{0}", uretilensayi);
            BASADON:
            Console.WriteLine("B�R TAHM�NDE BULUNUN : ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            if (uretilensayi==tahmin)
            {
                Console.WriteLine("TEBR�KLER! DO�RU TAHM�N! PUANINIZ {0}", hak * 10);


            }
            else if (tahmin<uretilensayi)
            {
                hak--;
                if (hak==0)
                {
                    Console.WriteLine("OYUNU KAYBETT�N�Z!");

                }
                else
                {
                    Console.WriteLine("TAHM�N�N�Z� B�Y�LT�N");
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
                    Console.WriteLine("TAHM�N�N�Z� K���LT�N ");
                    goto BASADON;
                }

            }
            Console.ReadLine();

        } 
    }
}

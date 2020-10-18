using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYLOGGER
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo tusbilgisi;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("bir tuşa veya CTRL,ALT,SHİFT+ BİR TUŞA BASINIZ ");
            Console.WriteLine("ÇIKMAK İÇİN ESC TUŞUNA BASINIZ ");
            do
            {
                tusbilgisi = Console.ReadKey();
                Console.Write("BASILAN TUŞ");
                if ((tusbilgisi.Modifiers & ConsoleModifiers.Alt)!=0 )

                {
                    if (tusbilgisi.Key.ToString()=="B")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    Console.Write("ALT+{0}", tusbilgisi.Key.ToString());
                }
                else if ((tusbilgisi.Modifiers & ConsoleModifiers.Control)!=0)
                {
                    if (tusbilgisi.Key.ToString()== "R")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write("CTRL+{0}", tusbilgisi.Key.ToString());
                }
                else if ((tusbilgisi.Modifiers & ConsoleModifiers.Shift)!=0)
                {
                    Console.WriteLine("SHİFT+{0}", tusbilgisi.Key.ToString());
                }
                else
                {
                    Console.WriteLine(tusbilgisi.Key.ToString());
                }

            } while (tusbilgisi.Key!=ConsoleKey.Escape);


            Console.ReadKey();
        }
    }
}

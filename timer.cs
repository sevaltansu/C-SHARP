using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TİMER
{
    class Program
    {
        private static int x =10;
            private static Timer sayac = new Timer();
        static void Main(string[] args)
        {
            sayac.Interval = 1000;
            sayac.Elapsed += görev;
            sayac.Start();
            Console.ReadKey();
          
            }
        private static void görev(object source, System.Timers.ElapsedEventArgs e)
        {
            x--;
            Console.Clear();
            Console.WriteLine(x);
            if (x==0)
            {
                Console.WriteLine("süre doldu!!");
                sayac.Stop();

            }
            
        }
        }          
     
    }


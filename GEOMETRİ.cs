using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEYLOGGER2
{
    class GEOMETRİ
    {
        public static double kuphacimhesaplama(double kupkenar)
        {
           double kuphacimmetot = Math.Pow(kupkenar, 3);
            return (kuphacimmetot);
        }
        public static double konihacimhesaplama(double koniyaricapmetot,double koniyuseklikmetot)
        {
            const double pi = 3.14;
            double konihacimmetot = (pi * Math.Pow(koniyaricapmetot, 2) * koniyuseklikmetot)/3;
            return (konihacimmetot);
        } public static double silindirhacimhesaplama(double silindiryukseklikmetot,double silindiryarıcapmetot)
        {
            const double pi = 3.14;
            double silindirhacimmetot = (pi * Math.Pow(silindiryarıcapmetot, 2) * silindiryukseklikmetot);
            return (silindirhacimmetot);
        }
    }

}

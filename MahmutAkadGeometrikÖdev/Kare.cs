using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    class Kare : IDörtgen
    {
        public double UzunKenar { get ; set ; }

        public double DortgenAlanHesapla()
        {
            return UzunKenar * UzunKenar;
        }

        public double DortgenCevreHesapla()
        {
            return (UzunKenar + UzunKenar) * 2;
        }
    }
}

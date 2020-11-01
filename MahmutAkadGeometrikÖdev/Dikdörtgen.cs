using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    class Dikdörtgen : IDörtgen
    {
        public double UzunKenar { get ; set ; }
        public double KısaKenar { get; set; }

        public double DortgenAlanHesapla()
        {
            return UzunKenar * KısaKenar;
        }

        public double DortgenCevreHesapla()
        {
            return (UzunKenar + KısaKenar) * 2;
        }
    }
}

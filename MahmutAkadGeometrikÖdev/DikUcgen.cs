using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    class DikUcgen : IUcgen
    {
        public double TabanKenar { get ; set ; }
        public double Yükseklik { get; set; }

        public double UcgenAlanHesapla()
        {
            return (TabanKenar * Yükseklik) / 2;
        }

        public double UcgenCevreHesapla()
        {
            double hipotenus = Math.Sqrt(Math.Pow(TabanKenar, 2) + Math.Pow(Yükseklik, 2));
            return hipotenus + TabanKenar + Yükseklik;
        }
    }
}

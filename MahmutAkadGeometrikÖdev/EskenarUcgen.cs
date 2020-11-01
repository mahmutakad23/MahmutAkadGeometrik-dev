using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    class EskenarUcgen : IUcgen
    {
        public double TabanKenar { get ; set ; }

        public double UcgenAlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * TabanKenar * TabanKenar;
        }

        public double UcgenCevreHesapla()
        {
            return TabanKenar * 3;
        }
    }
}

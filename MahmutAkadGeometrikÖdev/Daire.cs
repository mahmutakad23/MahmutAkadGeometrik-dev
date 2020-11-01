using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    class Daire
    {
        public const double PI = 3.1415926535897931;
        public double YarıCap { get; set; }
        public double AlanHesapla()
        {
            return PI * YarıCap * YarıCap;
        }
        public double CevreHesapla()
        {
            return 2 * PI * YarıCap;
        }
    }
}

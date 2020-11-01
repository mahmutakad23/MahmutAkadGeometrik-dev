using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    interface IDörtgen
    {
        double UzunKenar { get; set; }
        double DortgenCevreHesapla();
        double DortgenAlanHesapla();
    }
}

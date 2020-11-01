using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahmutAkadGeometrikÖdev
{
    interface IUcgen
    {
        double TabanKenar { get; set; }
        double UcgenAlanHesapla();
        double UcgenCevreHesapla();
    }
}

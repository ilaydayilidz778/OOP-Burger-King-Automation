using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci.Data
{
    public class EkstraMalzeme
    {
        public string EkstraMalzemeAd { get; set; } = string.Empty;
        public decimal SabitBirimFiyat { get; set; } = 5m;
        public override string ToString()
        {
            return $"{EkstraMalzemeAd} ";
        }
    }
}

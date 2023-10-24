using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci.Data
{
    public  class Menu
    {
        public string MenuAd { get; set; } = string.Empty;
        public  decimal BirimFiyat { get; set; }
        public override string ToString()
        {
            return $"{MenuAd} ({BirimFiyat:c2})";
        }
    }
}

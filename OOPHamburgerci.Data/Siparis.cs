using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHamburgerci.Data
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public List<EkstraMalzeme> SecilenEkstaMalzemler { get; set; } = new List<EkstraMalzeme>();
        public List<Siparis> SiparisDetaylar { get; set; } = new List<Siparis>();
        public MenuBoyut Boyut { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal SabitBirimFiyat { get; set; } = 5m;
        public int ID { get; set; } 
        public int Adet { get; set; }
        public string TutarTL { get { return TutarHesapla().ToString("c2"); } }
        public string EkstraMalzemlerTutarTL { get { return EkstraMalzemlerTutarHesapla().ToString("c2"); } }
        public decimal TutarHesapla()
        {
            if (SecilenEkstaMalzemler.Count > 0)
            {
                if (Boyut == MenuBoyut.Buyuk)
                    return Adet * (BirimFiyat + 20) + EkstraMalzemlerTutarHesapla();
                else if (Boyut == MenuBoyut.Orta)
                    return Adet * (BirimFiyat +10) + EkstraMalzemlerTutarHesapla();
                else if (Boyut == MenuBoyut.Kucuk)
                    return Adet * BirimFiyat + EkstraMalzemlerTutarHesapla();
            }
            return Adet * BirimFiyat;
        }
        public decimal EkstraMalzemlerTutarHesapla()
        {
            return SecilenEkstaMalzemler.Count * SabitBirimFiyat * Adet;
        }


    }
}




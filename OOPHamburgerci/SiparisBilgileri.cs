using OOPHamburgerci.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPHamburgerci
{
    public partial class SiparisBilgileri : Form
    {
        
        public SiparisBilgileri()
        {
            
            InitializeComponent();
            dgvTumSiparislerListesi.DataSource = HamburgerciVeri.TumSiparisler;
            int toplamSiparisSayisi = 0;
            decimal toplamGelir = 0;
            decimal toplamEkstraMalzemeTutari = 0;
            if (HamburgerciVeri.TumSiparisler.Count > 0)
            {
                toplamGelir = HamburgerciVeri.TumSiparisler.Sum(sd => sd.TutarHesapla());
                lblCiro.Text = toplamGelir.ToString();

                toplamSiparisSayisi = HamburgerciVeri.TumSiparisler.Count;
                lblToplamSiparisSayisi.Text = toplamSiparisSayisi.ToString("c2");

                toplamEkstraMalzemeTutari = HamburgerciVeri.TumSiparisler.Sum(sd => sd.EkstraMalzemlerTutarHesapla());
                lblEkstraMalzemeGeliri.Text = toplamEkstraMalzemeTutari.ToString("c2");
            }
            else
            {
                MessageBox.Show("Hiçbir sipariş eklenmedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                lblCiro.Text = toplamGelir.ToString("c2");
                lblToplamSiparisSayisi.Text = toplamSiparisSayisi.ToString();
                lblEkstraMalzemeGeliri.Text = toplamEkstraMalzemeTutari.ToString("c2");
            }

        }

    }
}


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
    public partial class AnaForm : Form
    {

        Siparis siparis = new Siparis();
        Menu menu = new Menu();
        EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
        public AnaForm()
        {
            InitializeComponent();
            HamburgerciVeri.VerileriYukle();
            HazirMenuleriYukle();
            HazirEkstraMalzemeleriYukle();
        }
        private void HazirEkstraMalzemeleriYukle()
        {
            if (HamburgerciVeri.EkstraMalzemeler.Count == 0)
            {
                string[] ekstraMalzemeAdlari = { "Ketçap", "Mayonez", "BBQ", "Ranch", "Hardal", "Buffalo" };

                foreach (string malzemeAdi in ekstraMalzemeAdlari)
                {
                    HamburgerciVeri.EkstraMalzemeler.Add(new EkstraMalzeme { EkstraMalzemeAd = malzemeAdi });
                }
            }
        }
        private void HazirMenuleriYukle()
        {
            if (HamburgerciVeri.Menuler.Count == 0)
            {
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "Big Tasty Menü", BirimFiyat = 180.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "Big Tasty Tavuklu Menü", BirimFiyat = 150.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "Gamer Menü", BirimFiyat = 195.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "Big Mac Menü", BirimFiyat = 175.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "4'lü Crispy Tenders Menü", BirimFiyat = 120.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "McChicken Menü", BirimFiyat = 160.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "Double Cheeseburger Menü", BirimFiyat = 160.00m });
                HamburgerciVeri.Menuler.Add(new Menu() { MenuAd = "McRoyal Menü", BirimFiyat = 190.00m });
            }
        }
        public void FormGoster(Form SecilenForm)
        {
            SecilenForm.StartPosition = 0;
            bool durum = false;
            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == SecilenForm.Text)
                {
                    durum = true;
                    form.Show();
                }
                else
                {
                    form.Close();
                }
            }
            if (!durum)
            {
                SecilenForm.MdiParent = this;
                SecilenForm.Show();
            }
        }
        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisOlustur(siparis));
        }
        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgileri());
        }
        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new MenuEkle(menu));
        }
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraMalzemeEkle(ekstraMalzeme));
        }
    }
}


























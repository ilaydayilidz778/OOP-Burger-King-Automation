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
    public partial class MenuEkle : Form
    {
        private Menu _menu;
        public MenuEkle(Menu menu)
        {
            InitializeComponent();
            _menu = menu;
        }
        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            Menu olusturulanMenu = new Menu();
            olusturulanMenu.MenuAd = txtMenuAdi.Text;
            olusturulanMenu.BirimFiyat = nudMenuFiyati.Value;
            if (!HamburgerciVeri.Menuler.Any(m => m.MenuAd == olusturulanMenu.MenuAd))
            {
                HamburgerciVeri.Menuler.Add(olusturulanMenu);
            }
            MessageBox.Show("Menü başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HamburgerciVeri.VerileriKaydet();
        }
    }
}















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
    public partial class EkstraMalzemeEkle : Form
    {

        private EkstraMalzeme _ekstraMalzeme;


        public EkstraMalzemeEkle(EkstraMalzeme ekstraMalzeme)
        {

            _ekstraMalzeme = ekstraMalzeme;


            InitializeComponent();
        }

        private void btnEkstraMalzemeyiKaydet_Click(object sender, EventArgs e)
        {
            EkstraMalzeme olusturulanEkstraMalzeme = new EkstraMalzeme();
            olusturulanEkstraMalzeme.EkstraMalzemeAd = txtEkstraMalzemeAdi.Text;
            olusturulanEkstraMalzeme.SabitBirimFiyat = nudEkstraMalzemeFiyati.Value;

            if (!HamburgerciVeri.EkstraMalzemeler.Any(x => x.EkstraMalzemeAd == olusturulanEkstraMalzeme.EkstraMalzemeAd))
            {
                HamburgerciVeri.EkstraMalzemeler.Add(olusturulanEkstraMalzeme);
                MessageBox.Show("Ekstra Malzeme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eklemek istediğiniz ekstra malzeme zaten mevcut","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            HamburgerciVeri.VerileriKaydet();



        }

    }
}

using OOPHamburgerci.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Menu = OOPHamburgerci.Data.Menu;

namespace OOPHamburgerci
{
    public partial class SiparisOlustur : Form
    {

        private Siparis _siparis;
        private int siparisId = 1;

        public SiparisOlustur(Siparis siparis)
        {
            _siparis = siparis;
            InitializeComponent();


            cboMenu.DataSource = HamburgerciVeri.Menuler;
            MenuListesiniYukleGuncelle();

            EkstraMalzemeListesiniYukle();

        }
        private void EkstraMalzemeListesiniYukle()
        {
            //Ekstra Malzemleri 3 sütun olacak şekilde yerleştirmek isteersek Başlangıç yüksekliği, dikey ve yatay boşluk değişkenleri oluşturdum.

            int checkBoxTop = 50;
            int checkBoxArasiDikeyBosluk = 10;
            int checkBoxArasiYatayBosluk = 10;
            int sutun = 0;

            for (int i = 0; i < HamburgerciVeri.EkstraMalzemeler.Count; i++)
            {
                CheckBox yenicheckBox = new CheckBox();
                yenicheckBox.Text = HamburgerciVeri.EkstraMalzemeler[i].EkstraMalzemeAd;

                yenicheckBox.Width = 120;
                yenicheckBox.Height = 30;
                yenicheckBox.Left = 10;
                int yatayKonum = sutun * (yenicheckBox.Width + checkBoxArasiYatayBosluk);

                yenicheckBox.Left = 10 + yatayKonum;
                yenicheckBox.Top = checkBoxTop + (i / 3) * (checkBoxArasiDikeyBosluk + yenicheckBox.Height);

                gboEkstraMalzemler.Controls.Add(yenicheckBox);

                sutun = (sutun + 1) % 3;
            }

        }

        private void MenuListesiniYukleGuncelle()
        {
            cboMenu.Refresh();
            cboMenu.DataSource = HamburgerciVeri.Menuler;
        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (cboMenu.SelectedItem == null && nudSiparisAdet.Value == 0)
            {
                MessageBox.Show("Siparşiniz Doğru Bir Şekilde Eklenememiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new Exception();
            }
            else
            {
                Menu menu = (Menu)cboMenu.SelectedItem;
                Siparis siparisDetay = new Siparis();
                siparisDetay.SecilenEkstaMalzemler = new List<EkstraMalzeme>();
                foreach (Control control in gboEkstraMalzemler.Controls)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (checkBox.Checked)
                    {
                        EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
                        ekstraMalzeme.EkstraMalzemeAd = checkBox.Text;
                        siparisDetay.SecilenEkstaMalzemler.Add(ekstraMalzeme);
                    }
                }
                foreach (Control control in gboBoyut.Controls)
                {

                    if (control == rdbOrta && rdbOrta.Checked)
                        siparisDetay.Boyut = MenuBoyut.Orta;
                    else if (control == rdbKucuk && rdbKucuk.Checked)
                        siparisDetay.Boyut = MenuBoyut.Kucuk;
                    else if (control == rdbBuyuk && rdbBuyuk.Checked)
                        siparisDetay.Boyut = MenuBoyut.Buyuk;
                }
                siparisDetay.Menu = (Menu)cboMenu.SelectedItem;
                siparisDetay.ID = siparisId;
                siparisId++;
                siparisDetay.BirimFiyat = menu.BirimFiyat;
                siparisDetay.Adet = (int)nudSiparisAdet.Value;
                _siparis.SiparisDetaylar.Add(siparisDetay);

                SiparisListesineEkle();

            }
        }
        private void SiparisListesineEkle()
        {
            dgvSiparisListesi.DataSource = _siparis.SiparisDetaylar.ToList();
            if (dgvSiparisListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSiparisListesi.SelectedRows[0];
                Siparis selectedSiparisDetay = (Siparis)selectedRow.DataBoundItem;
            }
            lblToplamTutar.Text = _siparis.SiparisDetaylar.Sum(sd => sd.TutarHesapla()).ToString();
        }
        private void SiparisListesindenÇikar()
        {
            if (dgvSiparisListesi.SelectedRows.Count > 0)
            {
                DataGridViewRow seciliSira = dgvSiparisListesi.SelectedRows[0];
                Siparis seciliSiparisDetay = (Siparis)seciliSira.DataBoundItem;
                _siparis.SiparisDetaylar.Remove(seciliSiparisDetay);
            }

            dgvSiparisListesi.DataSource = _siparis.SiparisDetaylar.ToList();
            lblToplamTutar.Text = _siparis.SiparisDetaylar.Sum(sd => sd.TutarHesapla()).ToString();
        }
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            if (_siparis.SiparisDetaylar.Count > 0)
            {
                HamburgerciVeri.TumSiparisler.AddRange(_siparis.SiparisDetaylar);

            }
            dgvSiparisListesi.DataSource = null;
        }
        private void btnSiparisÇikar_Click(object sender, EventArgs e)
        {
            SiparisListesindenÇikar();
        }
        private void btnSiparisiIptalEt_Click(object sender, EventArgs e)
        {
            if (_siparis.SiparisDetaylar.Count > 0)
            {
                _siparis.SiparisDetaylar.Clear();
                dgvSiparisListesi.DataSource = null;

                lblToplamTutar.Text = "0.00₺";
            }
        }

        private void dgvSiparisListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvSiparisListesi.Rows[e.RowIndex];
                int secilenSiparisID;
                if (int.TryParse(selectedRow.Cells["ID"].Value.ToString(), out secilenSiparisID))
                {
                    SiparisDetayGuncelle(secilenSiparisID);
                }
            }
        }
        private void SiparisDetayGuncelle(int secilenSiparisID)
        {
            Siparis secilenSiparisDetay = _siparis.SiparisDetaylar.FirstOrDefault(sd => sd.ID == secilenSiparisID);
            secilenSiparisDetay.Menu = (Menu)cboMenu.SelectedItem;
            secilenSiparisDetay.ID = secilenSiparisID;
            secilenSiparisDetay.ID = _siparis.SiparisDetaylar.Count + 1;
            secilenSiparisDetay.Adet = (int)nudSiparisAdet.Value;
            foreach (Control control in gboEkstraMalzemler.Controls)
            {
                CheckBox checkBox = (CheckBox)control;
                string ekstraMalzemeAdi = checkBox.Text;
                bool secilmis = secilenSiparisDetay.SecilenEkstaMalzemler.Any(sdek => sdek.EkstraMalzemeAd == ekstraMalzemeAdi);
                checkBox.Checked = secilmis;
            }
            switch (secilenSiparisDetay.Boyut)
            {
                case MenuBoyut.Buyuk:
                    rdbBuyuk.Checked = true;
                    break;
                case MenuBoyut.Orta:
                    rdbOrta.Checked = true;
                    break;
                case MenuBoyut.Kucuk:
                    rdbKucuk.Checked = true;
                    break;
            }

            SiparisListesiniGuncelle();
        }
        private void SiparisListesiniGuncelle()
        {
            dgvSiparisListesi.DataSource = null;
            dgvSiparisListesi.DataSource = _siparis.SiparisDetaylar.ToList();
            lblToplamTutar.Text = _siparis.SiparisDetaylar.Sum(sd => sd.TutarHesapla()).ToString();
        }

    }
}























































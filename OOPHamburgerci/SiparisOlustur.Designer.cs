namespace OOPHamburgerci
{
    partial class SiparisOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pbHamburgerGorseli = new PictureBox();
            label1 = new Label();
            cboMenu = new ComboBox();
            rdbKucuk = new RadioButton();
            rdbOrta = new RadioButton();
            rdbBuyuk = new RadioButton();
            gboBoyut = new GroupBox();
            gboEkstraMalzemler = new GroupBox();
            btnSiparisEkle = new Button();
            nudSiparisAdet = new NumericUpDown();
            label2 = new Label();
            dgvSiparisListesi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnSiparisiTamamla = new Button();
            btnSiparisiIptalEt = new Button();
            label3 = new Label();
            lblToplamTutar = new Label();
            btnSiparisÇikar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbHamburgerGorseli).BeginInit();
            gboBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSiparisAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisListesi).BeginInit();
            SuspendLayout();
            // 
            // pbHamburgerGorseli
            // 
            pbHamburgerGorseli.Image = Properties.Resources.Hamburger;
            pbHamburgerGorseli.Location = new Point(13, 12);
            pbHamburgerGorseli.Name = "pbHamburgerGorseli";
            pbHamburgerGorseli.Size = new Size(438, 201);
            pbHamburgerGorseli.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHamburgerGorseli.TabIndex = 0;
            pbHamburgerGorseli.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 227);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 1;
            label1.Text = "MENÜ SEÇİNİZ";
            // 
            // cboMenu
            // 
            cboMenu.FormattingEnabled = true;
            cboMenu.Location = new Point(13, 255);
            cboMenu.Name = "cboMenu";
            cboMenu.Size = new Size(438, 33);
            cboMenu.TabIndex = 2;
            // 
            // rdbKucuk
            // 
            rdbKucuk.AutoSize = true;
            rdbKucuk.Location = new Point(16, 47);
            rdbKucuk.Name = "rdbKucuk";
            rdbKucuk.Size = new Size(90, 29);
            rdbKucuk.TabIndex = 3;
            rdbKucuk.TabStop = true;
            rdbKucuk.Text = "Küçük";
            rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            rdbOrta.AutoSize = true;
            rdbOrta.Location = new Point(148, 47);
            rdbOrta.Name = "rdbOrta";
            rdbOrta.Size = new Size(76, 29);
            rdbOrta.TabIndex = 4;
            rdbOrta.TabStop = true;
            rdbOrta.Text = "Orta";
            rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            rdbBuyuk.AutoSize = true;
            rdbBuyuk.Location = new Point(269, 47);
            rdbBuyuk.Name = "rdbBuyuk";
            rdbBuyuk.Size = new Size(91, 29);
            rdbBuyuk.TabIndex = 5;
            rdbBuyuk.TabStop = true;
            rdbBuyuk.Text = "Büyük";
            rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // gboBoyut
            // 
            gboBoyut.Controls.Add(rdbKucuk);
            gboBoyut.Controls.Add(rdbBuyuk);
            gboBoyut.Controls.Add(rdbOrta);
            gboBoyut.Location = new Point(13, 308);
            gboBoyut.Name = "gboBoyut";
            gboBoyut.Size = new Size(438, 84);
            gboBoyut.TabIndex = 6;
            gboBoyut.TabStop = false;
            gboBoyut.Text = "BOYUT SEÇİNİZ";
            // 
            // gboEkstraMalzemler
            // 
            gboEkstraMalzemler.Location = new Point(12, 414);
            gboEkstraMalzemler.Name = "gboEkstraMalzemler";
            gboEkstraMalzemler.Size = new Size(439, 218);
            gboEkstraMalzemler.TabIndex = 7;
            gboEkstraMalzemler.TabStop = false;
            gboEkstraMalzemler.Text = "EKSTRA MALZEME SEÇİNİZ";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(13, 706);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(438, 45);
            btnSiparisEkle.TabIndex = 8;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // nudSiparisAdet
            // 
            nudSiparisAdet.Location = new Point(161, 654);
            nudSiparisAdet.Name = "nudSiparisAdet";
            nudSiparisAdet.Size = new Size(215, 31);
            nudSiparisAdet.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 656);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 10;
            label2.Text = "ADET";
            // 
            // dgvSiparisListesi
            // 
            dgvSiparisListesi.AllowUserToAddRows = false;
            dgvSiparisListesi.AllowUserToDeleteRows = false;
            dgvSiparisListesi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvSiparisListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSiparisListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSiparisListesi.BackgroundColor = SystemColors.ButtonFace;
            dgvSiparisListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisListesi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvSiparisListesi.Location = new Point(481, 12);
            dgvSiparisListesi.MultiSelect = false;
            dgvSiparisListesi.Name = "dgvSiparisListesi";
            dgvSiparisListesi.ReadOnly = true;
            dgvSiparisListesi.RowHeadersVisible = false;
            dgvSiparisListesi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvSiparisListesi.RowTemplate.Height = 33;
            dgvSiparisListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisListesi.Size = new Size(632, 797);
            dgvSiparisListesi.TabIndex = 11;
            dgvSiparisListesi.CellDoubleClick += dgvSiparisListesi_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Menu";
            Column1.FillWeight = 200F;
            Column1.Frozen = true;
            Column1.HeaderText = "Menü";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 97;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "boyut";
            Column2.HeaderText = "Menü Boyut";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 141;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle3.Format = "c2";
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "Fiyat";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 89;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Adet";
            Column4.HeaderText = "Adet";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 89;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SabitBirimFiyat";
            dataGridViewCellStyle4.Format = "c2";
            Column5.DefaultCellStyle = dataGridViewCellStyle4;
            Column5.HeaderText = "Ekstra Malzeme Fiyatı";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 213;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Adet";
            Column6.HeaderText = "Adet";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 89;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TutarTL";
            Column7.HeaderText = "Tutar";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 93;
            // 
            // btnSiparisiTamamla
            // 
            btnSiparisiTamamla.Location = new Point(13, 822);
            btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            btnSiparisiTamamla.Size = new Size(210, 54);
            btnSiparisiTamamla.TabIndex = 12;
            btnSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA\r\n";
            btnSiparisiTamamla.UseVisualStyleBackColor = true;
            btnSiparisiTamamla.Click += btnSiparisiTamamla_Click;
            // 
            // btnSiparisiIptalEt
            // 
            btnSiparisiIptalEt.Location = new Point(239, 822);
            btnSiparisiIptalEt.Name = "btnSiparisiIptalEt";
            btnSiparisiIptalEt.Size = new Size(211, 54);
            btnSiparisiIptalEt.TabIndex = 13;
            btnSiparisiIptalEt.Text = "SİPARİŞİ İPTAL ET";
            btnSiparisiIptalEt.UseVisualStyleBackColor = true;
            btnSiparisiIptalEt.Click += btnSiparisiIptalEt_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(763, 834);
            label3.Name = "label3";
            label3.Size = new Size(257, 28);
            label3.TabIndex = 15;
            label3.Text = "TOPLAM ÖDEME TUTARI :\r\n";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblToplamTutar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamTutar.ForeColor = Color.Brown;
            lblToplamTutar.Location = new Point(1026, 834);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(73, 39);
            lblToplamTutar.TabIndex = 16;
            lblToplamTutar.Text = "0.00₺";
            // 
            // btnSiparisÇikar
            // 
            btnSiparisÇikar.Location = new Point(12, 764);
            btnSiparisÇikar.Name = "btnSiparisÇikar";
            btnSiparisÇikar.Size = new Size(438, 45);
            btnSiparisÇikar.TabIndex = 17;
            btnSiparisÇikar.Text = "SİPARİŞ ÇIKAR";
            btnSiparisÇikar.UseVisualStyleBackColor = true;
            btnSiparisÇikar.Click += btnSiparisÇikar_Click;
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 912);
            Controls.Add(btnSiparisÇikar);
            Controls.Add(lblToplamTutar);
            Controls.Add(label3);
            Controls.Add(btnSiparisiIptalEt);
            Controls.Add(btnSiparisiTamamla);
            Controls.Add(dgvSiparisListesi);
            Controls.Add(label2);
            Controls.Add(nudSiparisAdet);
            Controls.Add(btnSiparisEkle);
            Controls.Add(gboEkstraMalzemler);
            Controls.Add(gboBoyut);
            Controls.Add(cboMenu);
            Controls.Add(label1);
            Controls.Add(pbHamburgerGorseli);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "SiparisOlustur";
            Text = "Sipariş Oluştur";
            ((System.ComponentModel.ISupportInitialize)pbHamburgerGorseli).EndInit();
            gboBoyut.ResumeLayout(false);
            gboBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSiparisAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbHamburgerGorseli;
        private Label label1;
        private ComboBox cboMenu;
        private RadioButton rdbKucuk;
        private RadioButton rdbOrta;
        private RadioButton rdbBuyuk;
        private GroupBox gboBoyut;
        private GroupBox gboEkstraMalzemler;
        private Button btnSiparisEkle;
        private NumericUpDown nudSiparisAdet;
        private Label label2;
        private DataGridView dgvSiparisListesi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnSiparisiTamamla;
        private Button btnSiparisiIptalEt;
        private Label label3;
        private Label lblToplamTutar;
        private Button btnSiparisÇikar;
    }
}
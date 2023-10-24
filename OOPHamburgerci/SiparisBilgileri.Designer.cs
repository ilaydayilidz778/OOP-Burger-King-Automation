namespace OOPHamburgerci
{
    partial class SiparisBilgileri
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
            label1 = new Label();
            gbCiro = new GroupBox();
            lblCiro = new Label();
            gbToplamSiparisSayisi = new GroupBox();
            lblToplamSiparisSayisi = new Label();
            gbEkstraMalzemeGeliri = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            dgvTumSiparislerListesi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            gbCiro.SuspendLayout();
            gbToplamSiparisSayisi.SuspendLayout();
            gbEkstraMalzemeGeliri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTumSiparislerListesi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // gbCiro
            // 
            gbCiro.Controls.Add(lblCiro);
            gbCiro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbCiro.Location = new Point(726, 56);
            gbCiro.Name = "gbCiro";
            gbCiro.Size = new Size(216, 91);
            gbCiro.TabIndex = 1;
            gbCiro.TabStop = false;
            gbCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.AutoSize = true;
            lblCiro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Brown;
            lblCiro.Location = new Point(15, 40);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(53, 28);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "0,00";
            // 
            // gbToplamSiparisSayisi
            // 
            gbToplamSiparisSayisi.Controls.Add(lblToplamSiparisSayisi);
            gbToplamSiparisSayisi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbToplamSiparisSayisi.Location = new Point(726, 166);
            gbToplamSiparisSayisi.Name = "gbToplamSiparisSayisi";
            gbToplamSiparisSayisi.Size = new Size(216, 86);
            gbToplamSiparisSayisi.TabIndex = 2;
            gbToplamSiparisSayisi.TabStop = false;
            gbToplamSiparisSayisi.Text = "Toplam Sipariş Sayısı";
            // 
            // lblToplamSiparisSayisi
            // 
            lblToplamSiparisSayisi.AutoSize = true;
            lblToplamSiparisSayisi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparisSayisi.ForeColor = Color.Brown;
            lblToplamSiparisSayisi.Location = new Point(15, 44);
            lblToplamSiparisSayisi.Name = "lblToplamSiparisSayisi";
            lblToplamSiparisSayisi.Size = new Size(53, 28);
            lblToplamSiparisSayisi.TabIndex = 1;
            lblToplamSiparisSayisi.Text = "0,00";
            // 
            // gbEkstraMalzemeGeliri
            // 
            gbEkstraMalzemeGeliri.Controls.Add(lblEkstraMalzemeGeliri);
            gbEkstraMalzemeGeliri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbEkstraMalzemeGeliri.Location = new Point(726, 272);
            gbEkstraMalzemeGeliri.Name = "gbEkstraMalzemeGeliri";
            gbEkstraMalzemeGeliri.Size = new Size(216, 96);
            gbEkstraMalzemeGeliri.TabIndex = 3;
            gbEkstraMalzemeGeliri.TabStop = false;
            gbEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Brown;
            lblEkstraMalzemeGeliri.Location = new Point(15, 43);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(53, 28);
            lblEkstraMalzemeGeliri.TabIndex = 2;
            lblEkstraMalzemeGeliri.Text = "0,00";
            // 
            // dgvTumSiparislerListesi
            // 
            dgvTumSiparislerListesi.AllowUserToAddRows = false;
            dgvTumSiparislerListesi.AllowUserToDeleteRows = false;
            dgvTumSiparislerListesi.BackgroundColor = SystemColors.ButtonFace;
            dgvTumSiparislerListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumSiparislerListesi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvTumSiparislerListesi.Location = new Point(12, 56);
            dgvTumSiparislerListesi.MultiSelect = false;
            dgvTumSiparislerListesi.Name = "dgvTumSiparislerListesi";
            dgvTumSiparislerListesi.ReadOnly = true;
            dgvTumSiparislerListesi.RowHeadersVisible = false;
            dgvTumSiparislerListesi.RowHeadersWidth = 62;
            dgvTumSiparislerListesi.RowTemplate.Height = 33;
            dgvTumSiparislerListesi.Size = new Size(708, 506);
            dgvTumSiparislerListesi.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Menu";
            Column1.HeaderText = "Menü";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 101;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Boyut";
            Column2.HeaderText = "Boyut";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BirimFiyat";
            Column3.HeaderText = "Birim Fiyat";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 101;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SabitBirimFiyat";
            Column4.HeaderText = "Sabit Birim Fiyat";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 101;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Adet";
            Column5.HeaderText = "Adet";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 101;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TutarTL";
            Column6.HeaderText = "Tutar ";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "EkstraMalzemlerTutarTL";
            Column7.HeaderText = "Ekstra Malzeme Tutar";
            Column7.MinimumWidth = 8;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 101;
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 574);
            Controls.Add(dgvTumSiparislerListesi);
            Controls.Add(gbEkstraMalzemeGeliri);
            Controls.Add(gbToplamSiparisSayisi);
            Controls.Add(gbCiro);
            Controls.Add(label1);
            Name = "SiparisBilgileri";
            Text = "Sipariş Bilgileri";
            gbCiro.ResumeLayout(false);
            gbCiro.PerformLayout();
            gbToplamSiparisSayisi.ResumeLayout(false);
            gbToplamSiparisSayisi.PerformLayout();
            gbEkstraMalzemeGeliri.ResumeLayout(false);
            gbEkstraMalzemeGeliri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTumSiparislerListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbCiro;
        private Label lblCiro;
        private GroupBox gbToplamSiparisSayisi;
        private Label lblToplamSiparisSayisi;
        private GroupBox gbEkstraMalzemeGeliri;
        private Label lblEkstraMalzemeGeliri;
        private DataGridView dgvTumSiparislerListesi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
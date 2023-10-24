namespace OOPHamburgerci
{
    partial class EkstraMalzemeEkle
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
            groupBox1 = new GroupBox();
            btnEkstraMalzemeyiKaydet = new Button();
            nudEkstraMalzemeFiyati = new NumericUpDown();
            txtEkstraMalzemeAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEkstraMalzemeyiKaydet);
            groupBox1.Controls.Add(nudEkstraMalzemeFiyati);
            groupBox1.Controls.Add(txtEkstraMalzemeAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 262);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeyiKaydet
            // 
            btnEkstraMalzemeyiKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnEkstraMalzemeyiKaydet.Location = new Point(235, 171);
            btnEkstraMalzemeyiKaydet.Name = "btnEkstraMalzemeyiKaydet";
            btnEkstraMalzemeyiKaydet.Size = new Size(280, 59);
            btnEkstraMalzemeyiKaydet.TabIndex = 4;
            btnEkstraMalzemeyiKaydet.Text = "Ekstra Malzemeyi Kaydet";
            btnEkstraMalzemeyiKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeyiKaydet.Click += btnEkstraMalzemeyiKaydet_Click;
            // 
            // nudEkstraMalzemeFiyati
            // 
            nudEkstraMalzemeFiyati.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudEkstraMalzemeFiyati.Location = new Point(235, 101);
            nudEkstraMalzemeFiyati.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudEkstraMalzemeFiyati.Name = "nudEkstraMalzemeFiyati";
            nudEkstraMalzemeFiyati.Size = new Size(280, 31);
            nudEkstraMalzemeFiyati.TabIndex = 3;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEkstraMalzemeAdi.Location = new Point(235, 53);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(280, 31);
            txtEkstraMalzemeAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 101);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı :\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 53);
            label1.Name = "label1";
            label1.Size = new Size(192, 28);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı :";
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 295);
            Controls.Add(groupBox1);
            Name = "EkstraMalzemeEkle";
            Text = "Ekstra Malzeme Ekle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEkstraMalzemeFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown nudEkstraMalzemeFiyati;
        private TextBox txtEkstraMalzemeAdi;
        private Label label2;
        private Label label1;
        private Button btnEkstraMalzemeyiKaydet;
    }
}
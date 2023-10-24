namespace OOPHamburgerci
{
    partial class MenuEkle
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
            nudMenuFiyati = new NumericUpDown();
            txtMenuAdi = new TextBox();
            btnMenuyuKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudMenuFiyati);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(btnMenuyuKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 271);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // nudMenuFiyati
            // 
            nudMenuFiyati.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nudMenuFiyati.Location = new Point(154, 112);
            nudMenuFiyati.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMenuFiyati.Name = "nudMenuFiyati";
            nudMenuFiyati.Size = new Size(280, 31);
            nudMenuFiyati.TabIndex = 7;
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMenuAdi.Location = new Point(154, 64);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(280, 31);
            txtMenuAdi.TabIndex = 6;
            // 
            // btnMenuyuKaydet
            // 
            btnMenuyuKaydet.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuyuKaydet.Location = new Point(154, 183);
            btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            btnMenuyuKaydet.Size = new Size(280, 59);
            btnMenuyuKaydet.TabIndex = 5;
            btnMenuyuKaydet.Text = "Menüyü Kaydet";
            btnMenuyuKaydet.UseVisualStyleBackColor = true;
            btnMenuyuKaydet.Click += btnMenuyuKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 109);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı :\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı :";
            // 
            // MenuEkle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 298);
            Controls.Add(groupBox1);
            Name = "MenuEkle";
            Text = "Menü Ekle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMenuFiyati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnMenuyuKaydet;
        private NumericUpDown nudMenuFiyati;
        private TextBox txtMenuAdi;
    }
}
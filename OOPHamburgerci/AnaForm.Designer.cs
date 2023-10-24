namespace OOPHamburgerci
{
    partial class AnaForm
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
            menuStrip = new MenuStrip();
            siparisYonetimiToolStripMenuItem = new ToolStripMenuItem();
            siparisOlusturToolStripMenuItem = new ToolStripMenuItem();
            siparisBilgileriToolStripMenuItem = new ToolStripMenuItem();
            urunYonetimiToolStripMenuItem = new ToolStripMenuItem();
            menuEkleToolStripMenuItem = new ToolStripMenuItem();
            ekstraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { siparisYonetimiToolStripMenuItem, urunYonetimiToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1319, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparisOlusturToolStripMenuItem, siparisBilgileriToolStripMenuItem });
            siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            siparisYonetimiToolStripMenuItem.Size = new Size(153, 29);
            siparisYonetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            siparisOlusturToolStripMenuItem.Size = new Size(229, 34);
            siparisOlusturToolStripMenuItem.Text = "Sipariş Oluştur";
            siparisOlusturToolStripMenuItem.Click += siparisOlusturToolStripMenuItem_Click;
            // 
            // siparisBilgileriToolStripMenuItem
            // 
            siparisBilgileriToolStripMenuItem.Name = "siparisBilgileriToolStripMenuItem";
            siparisBilgileriToolStripMenuItem.Size = new Size(229, 34);
            siparisBilgileriToolStripMenuItem.Text = "Sipariş Bilgileri";
            siparisBilgileriToolStripMenuItem.Click += siparisBilgileriToolStripMenuItem_Click;
            // 
            // urunYonetimiToolStripMenuItem
            // 
            urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEkleToolStripMenuItem, ekstraMalzemeEkleToolStripMenuItem });
            urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            urunYonetimiToolStripMenuItem.Size = new Size(139, 29);
            urunYonetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuEkleToolStripMenuItem
            // 
            menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            menuEkleToolStripMenuItem.Size = new Size(273, 34);
            menuEkleToolStripMenuItem.Text = "Menü Ekle";
            menuEkleToolStripMenuItem.Click += menuEkleToolStripMenuItem_Click;
            // 
            // ekstraMalzemeEkleToolStripMenuItem
            // 
            ekstraMalzemeEkleToolStripMenuItem.Name = "ekstraMalzemeEkleToolStripMenuItem";
            ekstraMalzemeEkleToolStripMenuItem.Size = new Size(273, 34);
            ekstraMalzemeEkleToolStripMenuItem.Text = "Ekstra Malzeme Ekle";
            ekstraMalzemeEkleToolStripMenuItem.Click += ekstraMalzemeEkleToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 994);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1341, 968);
            Name = "AnaForm";
            Text = "AnaForm";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private ToolStripMenuItem menuEkleToolStripMenuItem;
        private ToolStripMenuItem ekstraMalzemeEkleToolStripMenuItem;
        private ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private ToolStripMenuItem siparisBilgileriToolStripMenuItem;
    }
}
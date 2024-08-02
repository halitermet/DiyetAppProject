namespace _03DiyetProjesi.PL
{
    partial class AdminEkran
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
            menuStrip1 = new MenuStrip();
            öğünEkranıToolStripMenuItem = new ToolStripMenuItem();
            yiyecekEkranıToolStripMenuItem = new ToolStripMenuItem();
            porsiyonEkranıToolStripMenuItem = new ToolStripMenuItem();
            kıyaslamaEkranıToolStripMenuItem = new ToolStripMenuItem();
            enÇokYenenYemekEkranıToolStripMenuItem = new ToolStripMenuItem();
            tümKullanıcılarEkranıToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğünEkranıToolStripMenuItem, yiyecekEkranıToolStripMenuItem, porsiyonEkranıToolStripMenuItem, kıyaslamaEkranıToolStripMenuItem, enÇokYenenYemekEkranıToolStripMenuItem, tümKullanıcılarEkranıToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1213, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğünEkranıToolStripMenuItem
            // 
            öğünEkranıToolStripMenuItem.Name = "öğünEkranıToolStripMenuItem";
            öğünEkranıToolStripMenuItem.Size = new Size(103, 24);
            öğünEkranıToolStripMenuItem.Text = "Öğün Ekranı";
            öğünEkranıToolStripMenuItem.Click += öğünEkranıToolStripMenuItem_Click;
            // 
            // yiyecekEkranıToolStripMenuItem
            // 
            yiyecekEkranıToolStripMenuItem.Name = "yiyecekEkranıToolStripMenuItem";
            yiyecekEkranıToolStripMenuItem.Size = new Size(116, 24);
            yiyecekEkranıToolStripMenuItem.Text = "Yiyecek Ekranı";
            yiyecekEkranıToolStripMenuItem.Click += yiyecekEkranıToolStripMenuItem_Click;
            // 
            // porsiyonEkranıToolStripMenuItem
            // 
            porsiyonEkranıToolStripMenuItem.Name = "porsiyonEkranıToolStripMenuItem";
            porsiyonEkranıToolStripMenuItem.Size = new Size(122, 24);
            porsiyonEkranıToolStripMenuItem.Text = "Porsiyon Ekranı";
            porsiyonEkranıToolStripMenuItem.Click += porsiyonEkranıToolStripMenuItem_Click;
            // 
            // kıyaslamaEkranıToolStripMenuItem
            // 
            kıyaslamaEkranıToolStripMenuItem.Name = "kıyaslamaEkranıToolStripMenuItem";
            kıyaslamaEkranıToolStripMenuItem.Size = new Size(134, 24);
            kıyaslamaEkranıToolStripMenuItem.Text = "Kıyaslama Ekranı";
            kıyaslamaEkranıToolStripMenuItem.Click += kıyaslamaEkranıToolStripMenuItem_Click;
            // 
            // enÇokYenenYemekEkranıToolStripMenuItem
            // 
            enÇokYenenYemekEkranıToolStripMenuItem.Name = "enÇokYenenYemekEkranıToolStripMenuItem";
            enÇokYenenYemekEkranıToolStripMenuItem.Size = new Size(202, 24);
            enÇokYenenYemekEkranıToolStripMenuItem.Text = "En Çok Yenen Yemek Ekranı";
            enÇokYenenYemekEkranıToolStripMenuItem.Click += enÇokYenenYemekEkranıToolStripMenuItem_Click;
            // 
            // tümKullanıcılarEkranıToolStripMenuItem
            // 
            tümKullanıcılarEkranıToolStripMenuItem.Name = "tümKullanıcılarEkranıToolStripMenuItem";
            tümKullanıcılarEkranıToolStripMenuItem.Size = new Size(173, 24);
            tümKullanıcılarEkranıToolStripMenuItem.Text = "Tüm Kullanıcılar Ekranı";
            tümKullanıcılarEkranıToolStripMenuItem.Click += tümKullanıcılarEkranıToolStripMenuItem_Click;
            // 
            // AdminEkran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 527);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AdminEkran";
            Text = "AdminEkran";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğünEkranıToolStripMenuItem;
        private ToolStripMenuItem yiyecekEkranıToolStripMenuItem;
        private ToolStripMenuItem porsiyonEkranıToolStripMenuItem;
        private ToolStripMenuItem kıyaslamaEkranıToolStripMenuItem;
        private ToolStripMenuItem enÇokYenenYemekEkranıToolStripMenuItem;
        private ToolStripMenuItem tümKullanıcılarEkranıToolStripMenuItem;
    }
}
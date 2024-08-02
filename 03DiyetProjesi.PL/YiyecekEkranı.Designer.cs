namespace _03DiyetProjesi.PL
{
    partial class YiyecekEkranı
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
            btnYiyecekGuncelle = new Button();
            btnYiyecekSil = new Button();
            btnYiyecekEkle = new Button();
            dgvYiyecekEkrani = new DataGridView();
            label1 = new Label();
            txtYiyecekAdi = new TextBox();
            txtKalori = new TextBox();
            llblkalori = new Label();
            pbYiyecekResmi = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYiyecekResmi).BeginInit();
            SuspendLayout();
            // 
            // btnYiyecekGuncelle
            // 
            btnYiyecekGuncelle.Location = new Point(549, 495);
            btnYiyecekGuncelle.Name = "btnYiyecekGuncelle";
            btnYiyecekGuncelle.Size = new Size(130, 38);
            btnYiyecekGuncelle.TabIndex = 11;
            btnYiyecekGuncelle.Text = "GÜNCELLE";
            btnYiyecekGuncelle.UseVisualStyleBackColor = true;
            btnYiyecekGuncelle.Click += btnYiyecekGuncelle_Click;
            // 
            // btnYiyecekSil
            // 
            btnYiyecekSil.Location = new Point(345, 495);
            btnYiyecekSil.Name = "btnYiyecekSil";
            btnYiyecekSil.Size = new Size(130, 38);
            btnYiyecekSil.TabIndex = 10;
            btnYiyecekSil.Text = "SİL";
            btnYiyecekSil.UseVisualStyleBackColor = true;
            btnYiyecekSil.Click += btnYiyecekSil_Click;
            // 
            // btnYiyecekEkle
            // 
            btnYiyecekEkle.Location = new Point(146, 495);
            btnYiyecekEkle.Name = "btnYiyecekEkle";
            btnYiyecekEkle.Size = new Size(130, 38);
            btnYiyecekEkle.TabIndex = 9;
            btnYiyecekEkle.Text = "EKLE";
            btnYiyecekEkle.UseVisualStyleBackColor = true;
            btnYiyecekEkle.Click += btnYiyecekEkle_Click;
            // 
            // dgvYiyecekEkrani
            // 
            dgvYiyecekEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYiyecekEkrani.Location = new Point(146, 189);
            dgvYiyecekEkrani.Name = "dgvYiyecekEkrani";
            dgvYiyecekEkrani.RowHeadersWidth = 51;
            dgvYiyecekEkrani.Size = new Size(533, 283);
            dgvYiyecekEkrani.TabIndex = 8;
            dgvYiyecekEkrani.CellClick += dgvYiyecekEkrani_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 42);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 7;
            label1.Text = "Yiyecek Adı:";
            // 
            // txtYiyecekAdi
            // 
            txtYiyecekAdi.Location = new Point(247, 38);
            txtYiyecekAdi.Name = "txtYiyecekAdi";
            txtYiyecekAdi.Size = new Size(140, 27);
            txtYiyecekAdi.TabIndex = 6;
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(247, 85);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(140, 27);
            txtKalori.TabIndex = 12;
            // 
            // llblkalori
            // 
            llblkalori.AutoSize = true;
            llblkalori.Location = new Point(146, 85);
            llblkalori.Name = "llblkalori";
            llblkalori.Size = new Size(51, 20);
            llblkalori.TabIndex = 13;
            llblkalori.Text = "Kalori:";
            // 
            // pbYiyecekResmi
            // 
            pbYiyecekResmi.BorderStyle = BorderStyle.FixedSingle;
            pbYiyecekResmi.Location = new Point(417, 29);
            pbYiyecekResmi.Name = "pbYiyecekResmi";
            pbYiyecekResmi.Size = new Size(262, 133);
            pbYiyecekResmi.TabIndex = 14;
            pbYiyecekResmi.TabStop = false;
            // 
            // YiyecekEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 593);
            Controls.Add(pbYiyecekResmi);
            Controls.Add(llblkalori);
            Controls.Add(txtKalori);
            Controls.Add(btnYiyecekGuncelle);
            Controls.Add(btnYiyecekSil);
            Controls.Add(btnYiyecekEkle);
            Controls.Add(dgvYiyecekEkrani);
            Controls.Add(label1);
            Controls.Add(txtYiyecekAdi);
            Name = "YiyecekEkranı";
            Text = "YiyecekEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekEkrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYiyecekResmi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnYiyecekGuncelle;
        private Button btnYiyecekSil;
        private Button btnYiyecekEkle;
        private DataGridView dgvYiyecekEkrani;
        private Label label1;
        private TextBox txtYiyecekAdi;
        private TextBox txtKalori;
        private Label llblkalori;
        private PictureBox pbYiyecekResmi;
    }
}
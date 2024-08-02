namespace _03DiyetProjesi.PL
{
    partial class YiyecekİslemleriEkrani
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxYiyecekSec = new ComboBox();
            cbxOgunSec = new ComboBox();
            cbxPorsiyonSec = new ComboBox();
            dgvYiyecekİslemleri = new DataGridView();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            nUd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUd).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Yiyecek Seçiniz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 44);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğün Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(439, 44);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Porsiyon Seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(641, 44);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Miktar Seçiniz";
            // 
            // cbxYiyecekSec
            // 
            cbxYiyecekSec.FormattingEnabled = true;
            cbxYiyecekSec.Location = new Point(24, 68);
            cbxYiyecekSec.Margin = new Padding(3, 4, 3, 4);
            cbxYiyecekSec.Name = "cbxYiyecekSec";
            cbxYiyecekSec.Size = new Size(138, 28);
            cbxYiyecekSec.TabIndex = 4;
            cbxYiyecekSec.SelectedIndexChanged += cbxYiyecekSec_SelectedIndexChanged;
            // 
            // cbxOgunSec
            // 
            cbxOgunSec.FormattingEnabled = true;
            cbxOgunSec.Location = new Point(231, 68);
            cbxOgunSec.Margin = new Padding(3, 4, 3, 4);
            cbxOgunSec.Name = "cbxOgunSec";
            cbxOgunSec.Size = new Size(138, 28);
            cbxOgunSec.TabIndex = 5;
            // 
            // cbxPorsiyonSec
            // 
            cbxPorsiyonSec.FormattingEnabled = true;
            cbxPorsiyonSec.Location = new Point(439, 68);
            cbxPorsiyonSec.Margin = new Padding(3, 4, 3, 4);
            cbxPorsiyonSec.Name = "cbxPorsiyonSec";
            cbxPorsiyonSec.Size = new Size(138, 28);
            cbxPorsiyonSec.TabIndex = 6;
            // 
            // dgvYiyecekİslemleri
            // 
            dgvYiyecekİslemleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYiyecekİslemleri.Location = new Point(231, 121);
            dgvYiyecekİslemleri.Margin = new Padding(3, 4, 3, 4);
            dgvYiyecekİslemleri.Name = "dgvYiyecekİslemleri";
            dgvYiyecekİslemleri.RowHeadersWidth = 51;
            dgvYiyecekİslemleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYiyecekİslemleri.Size = new Size(720, 296);
            dgvYiyecekİslemleri.TabIndex = 8;
            dgvYiyecekİslemleri.CellClick += dgvYiyecekİslemleri_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(231, 435);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(135, 57);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(521, 435);
            btnGuncelle.Margin = new Padding(3, 4, 3, 4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(151, 57);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(824, 435);
            btnSil.Margin = new Padding(3, 4, 3, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(127, 57);
            btnSil.TabIndex = 11;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(24, 121);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 168);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // nUd
            // 
            nUd.Location = new Point(641, 69);
            nUd.Margin = new Padding(3, 4, 3, 4);
            nUd.Name = "nUd";
            nUd.Size = new Size(137, 27);
            nUd.TabIndex = 13;
            // 
            // YiyecekİslemleriEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 610);
            Controls.Add(nUd);
            Controls.Add(pictureBox1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(dgvYiyecekİslemleri);
            Controls.Add(cbxPorsiyonSec);
            Controls.Add(cbxOgunSec);
            Controls.Add(cbxYiyecekSec);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "YiyecekİslemleriEkrani";
            Text = "YiyecekİslemleriEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvYiyecekİslemleri).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbxYiyecekSec;
        private ComboBox cbxOgunSec;
        private ComboBox cbxPorsiyonSec;
        private DataGridView dgvYiyecekİslemleri;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private PictureBox pictureBox1;
        private NumericUpDown nUd;
    }
}
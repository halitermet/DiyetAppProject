namespace _03DiyetProjesi.PL
{
    partial class PorsiyonEkranı
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
            btnPorsiyonGuncelle = new Button();
            btnPorsiyonSil = new Button();
            btnPorsiyonEkle = new Button();
            dgvPorsiyonEkrani = new DataGridView();
            lblTuru = new Label();
            txtporsiyonTuru = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyonEkrani).BeginInit();
            SuspendLayout();
            // 
            // btnPorsiyonGuncelle
            // 
            btnPorsiyonGuncelle.Location = new Point(474, 373);
            btnPorsiyonGuncelle.Name = "btnPorsiyonGuncelle";
            btnPorsiyonGuncelle.Size = new Size(130, 38);
            btnPorsiyonGuncelle.TabIndex = 15;
            btnPorsiyonGuncelle.Text = "GÜNCELLE";
            btnPorsiyonGuncelle.UseVisualStyleBackColor = true;
            btnPorsiyonGuncelle.Click += btnPorsiyonGuncelle_Click;
            // 
            // btnPorsiyonSil
            // 
            btnPorsiyonSil.Location = new Point(289, 373);
            btnPorsiyonSil.Name = "btnPorsiyonSil";
            btnPorsiyonSil.Size = new Size(130, 38);
            btnPorsiyonSil.TabIndex = 14;
            btnPorsiyonSil.Text = "SİL";
            btnPorsiyonSil.UseVisualStyleBackColor = true;
            btnPorsiyonSil.Click += btnPorsiyonSil_Click;
            // 
            // btnPorsiyonEkle
            // 
            btnPorsiyonEkle.Location = new Point(116, 373);
            btnPorsiyonEkle.Name = "btnPorsiyonEkle";
            btnPorsiyonEkle.Size = new Size(130, 38);
            btnPorsiyonEkle.TabIndex = 13;
            btnPorsiyonEkle.Text = "EKLE";
            btnPorsiyonEkle.UseVisualStyleBackColor = true;
            btnPorsiyonEkle.Click += btnPorsiyonEkle_Click;
            // 
            // dgvPorsiyonEkrani
            // 
            dgvPorsiyonEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPorsiyonEkrani.Location = new Point(116, 115);
            dgvPorsiyonEkrani.Name = "dgvPorsiyonEkrani";
            dgvPorsiyonEkrani.RowHeadersWidth = 51;
            dgvPorsiyonEkrani.Size = new Size(488, 222);
            dgvPorsiyonEkrani.TabIndex = 12;
            dgvPorsiyonEkrani.CellClick += dgvPorsiyonEkrani_CellClick;
            // 
            // lblTuru
            // 
            lblTuru.AutoSize = true;
            lblTuru.Location = new Point(116, 69);
            lblTuru.Name = "lblTuru";
            lblTuru.Size = new Size(100, 20);
            lblTuru.TabIndex = 17;
            lblTuru.Text = "Porsiyon Türü:";
            // 
            // txtporsiyonTuru
            // 
            txtporsiyonTuru.Location = new Point(234, 69);
            txtporsiyonTuru.Name = "txtporsiyonTuru";
            txtporsiyonTuru.Size = new Size(370, 27);
            txtporsiyonTuru.TabIndex = 16;
            // 
            // PorsiyonEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 485);
            Controls.Add(lblTuru);
            Controls.Add(txtporsiyonTuru);
            Controls.Add(btnPorsiyonGuncelle);
            Controls.Add(btnPorsiyonSil);
            Controls.Add(btnPorsiyonEkle);
            Controls.Add(dgvPorsiyonEkrani);
            Name = "PorsiyonEkranı";
            Text = "PorsiyonEkranı";
            ((System.ComponentModel.ISupportInitialize)dgvPorsiyonEkrani).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPorsiyonGuncelle;
        private Button btnPorsiyonSil;
        private Button btnPorsiyonEkle;
        private DataGridView dgvPorsiyonEkrani;
        private Label lblTuru;
        private TextBox txtporsiyonTuru;
    }
}
namespace _03DiyetProjesi.PL
{
    partial class TümKullanicilarEkrani
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
            dgvTumKullanicilar = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTumKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // dgvTumKullanicilar
            // 
            dgvTumKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumKullanicilar.Location = new Point(69, 86);
            dgvTumKullanicilar.Name = "dgvTumKullanicilar";
            dgvTumKullanicilar.RowHeadersWidth = 51;
            dgvTumKullanicilar.Size = new Size(1086, 515);
            dgvTumKullanicilar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 38);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 1;
            label1.Text = "Kayıtlı Olan Tüm Kullanıcılar :";
            // 
            // TümKullanicilarEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 654);
            Controls.Add(label1);
            Controls.Add(dgvTumKullanicilar);
            Name = "TümKullanicilarEkrani";
            Text = "TümKullanicilarEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvTumKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTumKullanicilar;
        private Label label1;
    }
}
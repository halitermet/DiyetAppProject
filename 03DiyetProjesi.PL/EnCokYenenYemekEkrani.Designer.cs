namespace _03DiyetProjesi.PL
{
    partial class EnCokYenenYemekEkrani
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
            cmbxyiyecek = new ComboBox();
            lblKisi1 = new Label();
            dgvEnCokYenenYemek = new DataGridView();
            label1 = new Label();
            lbxEnCok = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenYemek).BeginInit();
            SuspendLayout();
            // 
            // cmbxyiyecek
            // 
            cmbxyiyecek.FormattingEnabled = true;
            cmbxyiyecek.Location = new Point(169, 56);
            cmbxyiyecek.Name = "cmbxyiyecek";
            cmbxyiyecek.Size = new Size(241, 28);
            cmbxyiyecek.TabIndex = 11;
            cmbxyiyecek.SelectedIndexChanged += cmbxyiyecek_SelectedIndexChanged;
            // 
            // lblKisi1
            // 
            lblKisi1.AutoSize = true;
            lblKisi1.Location = new Point(40, 59);
            lblKisi1.Name = "lblKisi1";
            lblKisi1.Size = new Size(113, 20);
            lblKisi1.TabIndex = 10;
            lblKisi1.Text = "Yiyecek seçiniz :";
            // 
            // dgvEnCokYenenYemek
            // 
            dgvEnCokYenenYemek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnCokYenenYemek.Location = new Point(40, 90);
            dgvEnCokYenenYemek.Name = "dgvEnCokYenenYemek";
            dgvEnCokYenenYemek.RowHeadersWidth = 51;
            dgvEnCokYenenYemek.Size = new Size(516, 410);
            dgvEnCokYenenYemek.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(613, 64);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 13;
            label1.Text = "En çok yenen 3 yemek :";
            // 
            // lbxEnCok
            // 
            lbxEnCok.FormattingEnabled = true;
            lbxEnCok.Location = new Point(613, 90);
            lbxEnCok.Name = "lbxEnCok";
            lbxEnCok.Size = new Size(292, 404);
            lbxEnCok.TabIndex = 14;
            // 
            // EnCokYenenYemekEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 634);
            Controls.Add(lbxEnCok);
            Controls.Add(label1);
            Controls.Add(dgvEnCokYenenYemek);
            Controls.Add(cmbxyiyecek);
            Controls.Add(lblKisi1);
            Name = "EnCokYenenYemekEkrani";
            Text = "EnCokYenenYemekEkrani";
            ((System.ComponentModel.ISupportInitialize)dgvEnCokYenenYemek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbxyiyecek;
        private Label lblKisi1;
        private DataGridView dgvEnCokYenenYemek;
        private Label label1;
        private ListBox lbxEnCok;
    }
}
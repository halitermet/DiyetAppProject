namespace _03DiyetProjesi.PL
{
    partial class KıyaslaRaporuEkranı
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
            dgvKiyaslamaEkrani = new DataGridView();
            lblKisi1 = new Label();
            lblkisi2 = new Label();
            cmbxKisi1 = new ComboBox();
            cmbxKisi2 = new ComboBox();
            dgvKıyaslamaEkrani2 = new DataGridView();
            dtpKıyas = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyaslamaEkrani2).BeginInit();
            SuspendLayout();
            // 
            // dgvKiyaslamaEkrani
            // 
            dgvKiyaslamaEkrani.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKiyaslamaEkrani.Location = new Point(26, 90);
            dgvKiyaslamaEkrani.Name = "dgvKiyaslamaEkrani";
            dgvKiyaslamaEkrani.RowHeadersWidth = 51;
            dgvKiyaslamaEkrani.Size = new Size(438, 398);
            dgvKiyaslamaEkrani.TabIndex = 5;
            // 
            // lblKisi1
            // 
            lblKisi1.AutoSize = true;
            lblKisi1.Location = new Point(26, 53);
            lblKisi1.Name = "lblKisi1";
            lblKisi1.Size = new Size(47, 20);
            lblKisi1.TabIndex = 4;
            lblKisi1.Text = "Kişi 1:";
            // 
            // lblkisi2
            // 
            lblkisi2.AutoSize = true;
            lblkisi2.Location = new Point(540, 56);
            lblkisi2.Name = "lblkisi2";
            lblkisi2.Size = new Size(47, 20);
            lblkisi2.TabIndex = 7;
            lblkisi2.Text = "Kişi 2:";
            // 
            // cmbxKisi1
            // 
            cmbxKisi1.FormattingEnabled = true;
            cmbxKisi1.Location = new Point(88, 50);
            cmbxKisi1.Name = "cmbxKisi1";
            cmbxKisi1.Size = new Size(209, 28);
            cmbxKisi1.TabIndex = 9;
            // 
            // cmbxKisi2
            // 
            cmbxKisi2.FormattingEnabled = true;
            cmbxKisi2.Location = new Point(593, 53);
            cmbxKisi2.Name = "cmbxKisi2";
            cmbxKisi2.Size = new Size(243, 28);
            cmbxKisi2.TabIndex = 10;
            // 
            // dgvKıyaslamaEkrani2
            // 
            dgvKıyaslamaEkrani2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKıyaslamaEkrani2.Location = new Point(538, 89);
            dgvKıyaslamaEkrani2.Name = "dgvKıyaslamaEkrani2";
            dgvKıyaslamaEkrani2.RowHeadersWidth = 51;
            dgvKıyaslamaEkrani2.Size = new Size(452, 398);
            dgvKıyaslamaEkrani2.TabIndex = 11;
            // 
            // dtpKıyas
            // 
            dtpKıyas.Location = new Point(1016, 53);
            dtpKıyas.Name = "dtpKıyas";
            dtpKıyas.Size = new Size(242, 27);
            dtpKıyas.TabIndex = 12;
            dtpKıyas.ValueChanged += dtpKıyas_ValueChanged;
            // 
            // KıyaslaRaporuEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 578);
            Controls.Add(dtpKıyas);
            Controls.Add(dgvKıyaslamaEkrani2);
            Controls.Add(cmbxKisi2);
            Controls.Add(cmbxKisi1);
            Controls.Add(lblkisi2);
            Controls.Add(dgvKiyaslamaEkrani);
            Controls.Add(lblKisi1);
            Name = "KıyaslaRaporuEkranı";
            Text = "KıyaslaRaporuEkranı";
            Load += KıyaslaRaporuEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKiyaslamaEkrani).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKıyaslamaEkrani2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKiyaslamaEkrani;
        private Label lblKisi1;
        private Label lblkisi2;
        private ComboBox cmbxKisi1;
        private ComboBox cmbxKisi2;
        private DataGridView dgvKıyaslamaEkrani2;
        private DateTimePicker dtpKıyas;
    }
}
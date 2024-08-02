namespace _03DiyetProjesi.PL
{
    partial class KayitOlEkrani
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
            label6 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtYas = new TextBox();
            txtKilo = new TextBox();
            txtMail = new TextBox();
            txtSifre = new TextBox();
            label7 = new Label();
            rBtnErkek = new RadioButton();
            rBtnKadin = new RadioButton();
            btnKayitOl = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 55);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 82);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 2;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 113);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Kilo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 202);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 5;
            label6.Text = "Mail";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(101, 17);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(101, 47);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 7;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(101, 79);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(100, 23);
            txtYas.TabIndex = 8;
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(101, 110);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(100, 23);
            txtKilo.TabIndex = 9;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(100, 199);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(100, 23);
            txtMail.TabIndex = 10;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(100, 228);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 231);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 12;
            label7.Text = "Şifre";
            // 
            // rBtnErkek
            // 
            rBtnErkek.AutoSize = true;
            rBtnErkek.Location = new Point(82, 22);
            rBtnErkek.Name = "rBtnErkek";
            rBtnErkek.Size = new Size(58, 19);
            rBtnErkek.TabIndex = 13;
            rBtnErkek.Text = "ERKEK";
            rBtnErkek.UseVisualStyleBackColor = true;
            // 
            // rBtnKadin
            // 
            rBtnKadin.AutoSize = true;
            rBtnKadin.Checked = true;
            rBtnKadin.Location = new Point(16, 22);
            rBtnKadin.Name = "rBtnKadin";
            rBtnKadin.Size = new Size(60, 19);
            rBtnKadin.TabIndex = 14;
            rBtnKadin.TabStop = true;
            rBtnKadin.Text = "KADIN";
            rBtnKadin.UseVisualStyleBackColor = true;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(101, 277);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(75, 23);
            btnKayitOl.TabIndex = 15;
            btnKayitOl.Text = "Kayit Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnKadin);
            groupBox1.Controls.Add(rBtnErkek);
            groupBox1.Location = new Point(27, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 54);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // KayitOlEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 332);
            Controls.Add(groupBox1);
            Controls.Add(btnKayitOl);
            Controls.Add(label7);
            Controls.Add(txtSifre);
            Controls.Add(txtMail);
            Controls.Add(txtKilo);
            Controls.Add(txtYas);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KayitOlEkrani";
            Text = "KayitOlEkrani";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtYas;
        private TextBox txtKilo;
        private TextBox txtMail;
        private TextBox txtSifre;
        private Label label7;
        private RadioButton rBtnErkek;
        private RadioButton rBtnKadin;
        private Button btnKayitOl;
        private GroupBox groupBox1;
    }
}
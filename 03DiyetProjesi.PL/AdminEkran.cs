using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03DiyetProjesi.PL
{
    public partial class AdminEkran : Form
    {
        private int kullaniciId;
        public AdminEkran(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            
        }
        private void FormAc(Form gosterilecekForm)
        {

            gosterilecekForm.StartPosition = 0;

            if (!MdiChildren.Contains(gosterilecekForm))
                gosterilecekForm.MdiParent = this;

            foreach (var form in MdiChildren)
            {
                if (form.Text == gosterilecekForm.Text)
                    form.Show();
                else
                    form.Close();
            }
        }

        private void öğünEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new OgunEkrani());
        }

        private void yiyecekEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new YiyecekEkranı());
        }

        private void porsiyonEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new PorsiyonEkranı());

        }

        private void kıyaslamaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new KıyaslaRaporuEkranı());
        }

        private void enÇokYenenYemekEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new EnCokYenenYemekEkrani());
        }

        private void tümKullanıcılarEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new TümKullanicilarEkrani());
        }
    }
}

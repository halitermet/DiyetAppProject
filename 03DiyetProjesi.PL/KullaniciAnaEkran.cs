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
    public partial class KullaniciAnaEkran : Form
    {
        public int kullaniciId;
        public KullaniciAnaEkran(int kullaniciId)
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

        private void yiyecekİslemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new YiyecekİslemleriEkrani(kullaniciId));
        }

        private void günSonuKaloriRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAc(new GunSonuKaloriRaporEkrani(kullaniciId));
        }
    }
}

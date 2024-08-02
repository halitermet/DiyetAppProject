using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
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
    public partial class TümKullanicilarEkrani : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        public TümKullanicilarEkrani()
        {
            InitializeComponent();
            dgvTumKullanicilar.DataSource = kullaniciManager.GetAll().ToList();
            dgvTumKullanicilar.Columns[4].Visible = false;
            dgvTumKullanicilar.Columns[6].Visible = false;
            dgvTumKullanicilar.Columns[9].Visible = false;
        }
    }
}

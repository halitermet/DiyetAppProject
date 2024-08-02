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
    public partial class KıyaslaRaporuEkranı : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
        public KıyaslaRaporuEkranı()
        {
            InitializeComponent();
            cmbxKisi1.DataSource = kullaniciManager.GetAll();
            cmbxKisi2.DataSource = kullaniciManager.GetAll();

        }

        private void KıyaslaRaporuEkranı_Load(object sender, EventArgs e)
        {

        }

        private void dtpKıyas_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpKıyas.Value;
            dgvKiyaslamaEkrani.DataSource = Kıyaslama(selectedDate);
            dgvKıyaslamaEkrani2.DataSource = Kıyaslama2(selectedDate);
            dgvKiyaslamaEkrani.Columns[0].Visible = false;
            dgvKiyaslamaEkrani.Columns[1].Visible = false;
            dgvKiyaslamaEkrani.Columns[2].Visible = false;
            dgvKiyaslamaEkrani.Columns[3].Visible = false;
            dgvKiyaslamaEkrani.Columns[5].Visible = false;
  
            dgvKiyaslamaEkrani.Columns[7].Visible = false;
            dgvKiyaslamaEkrani.Columns[9].Visible = false;
            dgvKiyaslamaEkrani.Columns[10].Visible = false;
            dgvKıyaslamaEkrani2.Columns[0].Visible = false;
            dgvKıyaslamaEkrani2.Columns[1].Visible = false;
            dgvKıyaslamaEkrani2.Columns[2].Visible = false;
            dgvKıyaslamaEkrani2.Columns[3].Visible = false;
            dgvKıyaslamaEkrani2.Columns[5].Visible = false;

            dgvKıyaslamaEkrani2.Columns[7].Visible = false;
            dgvKıyaslamaEkrani2.Columns[9].Visible = false;
            dgvKıyaslamaEkrani2.Columns[10].Visible = false;



        }
        
        private List<DiyetTablosuViewModel> Kıyaslama(DateTime selectedDate)
        {
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            DiyetTablosuViewModel diyetTablosuViewModel = new DiyetTablosuViewModel();

            List<DiyetTablosuViewModel> kisi1 = diyetTablosuManager.GetAll()
                    .Where(dt => dt.YenilenGun == selectedDate && dt.KullaniciId == ((DiyetTablosuViewModel)cmbxKisi1.SelectedItem).KullaniciId)
                    .ToList();
            return kisi1;
        }
        private List<DiyetTablosuViewModel> Kıyaslama2(DateTime selectedDate)
        {
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            DiyetTablosuViewModel diyetTablosuViewModel = new DiyetTablosuViewModel();

            List<DiyetTablosuViewModel> kisi2 = diyetTablosuManager.GetAll()
                    .Where(dt => dt.YenilenGun == selectedDate && dt.KullaniciId == ((DiyetTablosuViewModel)cmbxKisi2.SelectedItem).KullaniciId)
                    .ToList();
            return kisi2;
        }
    }
}

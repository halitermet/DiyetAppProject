using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using Castle.Components.DictionaryAdapter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _03DiyetProjesi.PL
{
    public partial class YiyecekİslemleriEkrani : Form
    {
        OgunManager OgunManager = new OgunManager();
        YiyecekManager YiyecekManager = new YiyecekManager();
        PorsiyonManager PorsiyonManager = new PorsiyonManager();
        KullaniciManager KullaniciManager = new KullaniciManager();
        
        DiyetTablosuViewModel secilen;
        List<YiyecekViewModel> yiyecekler;
        List<KullaniciViewModel> kullanicilar;
        List<OgunViewModel> ogunler;
        List<PorsiyonViewModel> porsiyonlar;
        
        public int kullaniciId;
        public YiyecekİslemleriEkrani(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;
            Doldur();
            Goster();
        }
        private void Doldur()
        {
            yiyecekler = YiyecekManager.GetAll().ToList();
            ogunler = OgunManager.GetAll().ToList();
            porsiyonlar = PorsiyonManager.GetAll().ToList();
            kullanicilar = KullaniciManager.GetAll().ToList();
            cbxOgunSec.DataSource = ogunler;
            cbxYiyecekSec.DataSource = yiyecekler;
            cbxPorsiyonSec.DataSource = porsiyonlar;
        }
        private void Goster()
        {
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            List<DiyetTablosuViewModel> diyetTablosu = diyetTablosuManager
                .GetAll()
                .Where(dt => dt.KullaniciId == kullaniciId)
                .ToList();
            //WithInclude<DiyetTablosuViewModel>(p=> p.Kullanici, p=>p.Yiyecek, p=>p.Ogun, p=>p.Porsiyon)
            //.ToList();
            foreach (var d in diyetTablosu)
            {
                //d.Yiyecek = YiyecekManager.g;
                //d.Kullanici = kullanicilar.Where(k => k.Id == d.KullaniciId).FirstOrDefault();
                //d.Porsiyon = porsiyonlar.Where(p => p.Id == d.PorsiyonId).FirstOrDefault();
                //d.Ogun = ogunler.Where(o => o.Id == d.OgunId).FirstOrDefault();
            }
            dgvYiyecekİslemleri.DataSource = null;
            dgvYiyecekİslemleri.DataSource = diyetTablosu;
            dgvYiyecekİslemleri.Columns[0].Visible = false;
            dgvYiyecekİslemleri.Columns[1].Visible = false;
            dgvYiyecekİslemleri.Columns[3].Visible = false;
            dgvYiyecekİslemleri.Columns[5].Visible = false;
            dgvYiyecekİslemleri.Columns[7].Visible = false;

        }
        private void cbxYiyecekSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            YiyecekViewModel secilenYiyecek = (YiyecekViewModel)cbxYiyecekSec.SelectedItem;
            using (var ms = new MemoryStream(secilenYiyecek.Resim))
            {
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            DiyetTablosuViewModel diyetTablosu = new DiyetTablosuViewModel();
            diyetTablosu.OgunId = ((OgunViewModel)cbxOgunSec.SelectedItem).Id;
            diyetTablosu.YiyecekId = ((YiyecekViewModel)cbxYiyecekSec.SelectedItem).Id;
            diyetTablosu.PorsiyonId = ((PorsiyonViewModel)cbxPorsiyonSec.SelectedItem).Id;
            diyetTablosu.Birim = (int)nUd.Value;
            diyetTablosu.KullaniciId = kullaniciId;
            diyetTablosu.YenilenGun = DateTime.Now;
            diyetTablosuManager.Add(diyetTablosu);
            Goster();

        }

        private void dgvYiyecekİslemleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = (DiyetTablosuViewModel)dgvYiyecekİslemleri.SelectedRows[0].DataBoundItem;

            cbxOgunSec.SelectedItem = secilen;
            cbxPorsiyonSec.SelectedItem = secilen;
            cbxYiyecekSec.SelectedItem = secilen;
            nUd.Value = secilen.Birim;

            YiyecekViewModel secilenYiyecek = (YiyecekViewModel)cbxYiyecekSec.SelectedItem;
            
            if(secilenYiyecek != null)
            {
                MemoryStream ms = new MemoryStream(secilenYiyecek.Resim);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromStream(ms);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen != null)
                {
                    DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
                    secilen.OgunId = ((OgunViewModel)cbxOgunSec.SelectedItem).Id;
                    secilen.Birim = (int)nUd.Value;
                    secilen.YiyecekId = ((YiyecekViewModel)cbxYiyecekSec.SelectedItem).Id;
                    secilen.PorsiyonId = ((PorsiyonViewModel)cbxPorsiyonSec.SelectedItem).Id;
                    secilen.YenilenGun = DateTime.Now;

                    diyetTablosuManager.Update(secilen);
                    Goster();
                    secilen = null;
                    MessageBox.Show("Başarı ile güncellenmiştir");

                }
                else
                {
                    MessageBox.Show("Lutfen seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu " + ex.Message);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen != null)
                {
                    DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
                    diyetTablosuManager.Delete(secilen);
                    secilen = null;
                    Goster();
                    MessageBox.Show("Başarı ile silinmiştir");

                }
                else
                {
                    MessageBox.Show("Lutfen seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu " + ex.Message);

            }

        }
    }
}

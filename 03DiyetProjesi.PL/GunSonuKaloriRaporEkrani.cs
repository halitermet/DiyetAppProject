using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03DiyetProjesi.PL
{
    public partial class GunSonuKaloriRaporEkrani : Form
    {
        OgunManager OgunManager = new OgunManager();
        YiyecekManager YiyecekManager = new YiyecekManager();
        PorsiyonManager PorsiyonManager = new PorsiyonManager();
        KullaniciManager KullaniciManager = new KullaniciManager();
        DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();

        List<YiyecekViewModel> yiyecekler;
        List<KullaniciViewModel> kullanicilar;
        List<OgunViewModel> ogunler;
        List<PorsiyonViewModel> porsiyonlar;


        public int kullanıcıId;
        public GunSonuKaloriRaporEkrani(int kullaniciId)
        {
            InitializeComponent();
            this.kullanıcıId = kullaniciId;
            lblToplamKalori.Text = TumKalorileriGetir().ToString();
        }
        private void Doldur()
        {
            yiyecekler = YiyecekManager.GetAll().ToList();
            ogunler = OgunManager.GetAll().ToList();
            porsiyonlar = PorsiyonManager.GetAll().ToList();
            kullanicilar = KullaniciManager.GetAll().ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            dgvGunSonuKalori.DataSource = YemekleriListele(selectedDate);
            dgvGunSonuKalori.Columns[0].Visible = false;
            dgvGunSonuKalori.Columns[1].Visible = false;
            dgvGunSonuKalori.Columns[3].Visible = false;
            dgvGunSonuKalori.Columns[5].Visible = false;
            dgvGunSonuKalori.Columns[7].Visible = false;

        }
        //Gun parametresi alan kalori hesaplama fonksiyonu
        private List<DiyetTablosuViewModel> YemekleriListele(DateTime selectedDate)
        {
            Doldur();
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            try
            {
                List<DiyetTablosuViewModel> yemekler = diyetTablosuManager
                    .GetAll()
                    .Where(dt => dt.YenilenGun.Date == selectedDate.Date && dt.KullaniciId == kullanıcıId)
                    .ToList();

                float toplamKalori = 0;

                foreach (var d in yemekler)
                {
                    //d.Yiyecek = yiyecekler.Where(y => y.Id == d.YiyecekId).FirstOrDefault();
                    //d.Kullanici = kullanicilar.Where(k => k.Id == d.KullaniciId).FirstOrDefault();
                    //d.Porsiyon = porsiyonlar.Where(p => p.Id == d.PorsiyonId).FirstOrDefault();
                    //d.Ogun = ogunler.Where(o => o.Id == d.OgunId).FirstOrDefault();

                    if(d.Yiyecek != null)
                    {
                        toplamKalori += d.Birim * d.Yiyecek.Kalori;
                    }
                    else
                    {
                        toplamKalori = 0;
                    }
                    
                }
                lblGunSonuKalorisi.Text = toplamKalori.ToString();

                if (yemekler.Any())
                {
                    // Veri bulundu, işlemleri gerçekleştir
                    return yemekler;
                }
                else
                {
                    // Veri bulunamadı, kullanıcıya uyarı göster
                    MessageBox.Show("Seçtiğiniz tarihe ait veri bulunamadı.");
                    //Boş bir liste dön
                    return new List<DiyetTablosuViewModel>();
                }

            }

            catch (Exception ex) 
            {
                throw; 
            }
            
        }
        private float TumKalorileriGetir()
        {
            
            float toplamKalori = 0;
            Doldur();
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            try
            {
                List<DiyetTablosuViewModel> yemekler = diyetTablosuManager
                    .GetAll()
                    // buraya 
                    .Where(k => k.KullaniciId == kullanıcıId)
                    .ToList();

                foreach (var d in yemekler)
                {
                    //    d.Yiyecek = yiyecekler.Where(y => y.Id == d.YiyecekId).FirstOrDefault();
                    //    d.Kullanici = kullanicilar.Where(k => k.Id == d.KullaniciId).FirstOrDefault();
                    //    d.Porsiyon = porsiyonlar.Where(p => p.Id == d.PorsiyonId).FirstOrDefault();
                    //    d.Ogun = ogunler.Where(o => o.Id == d.OgunId).FirstOrDefault();

                    if (d.Yiyecek != null)
                    {
                        toplamKalori += d.Birim * d.Yiyecek.Kalori;
                    }
                    else
                    {
                        toplamKalori = 0;
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veri yoktur" + ex);
            }
            return toplamKalori;
        }
    }
}

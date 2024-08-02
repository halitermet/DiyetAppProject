using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using Microsoft.Identity.Client;
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
    public partial class EnCokYenenYemekEkrani : Form
    {
        YiyecekManager yiyecekManager = new YiyecekManager();
        KullaniciManager KullaniciManager = new KullaniciManager();
        OgunManager OgunManager = new OgunManager();

        List<DiyetTablosuViewModel> yenilenYiyecekler;
        List<KullaniciViewModel> kullanicilar;
        List<OgunViewModel> ogunler;
        public EnCokYenenYemekEkrani()
        {
            InitializeComponent();
            cmbxyiyecek.DataSource = yiyecekManager.GetAll().ToList();
        }
        private void Doldur()
        {
            DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
            ogunler = OgunManager.GetAll().ToList();
            kullanicilar = KullaniciManager.GetAll().ToList();

            List<DiyetTablosuViewModel> diyetTablolari = diyetTablosuManager.GetAll().ToList();
            var enCokYenilenYemekler = diyetTablolari
                .GroupBy(x => x.YiyecekId)
                .OrderByDescending(group => group.Count()).Take(3).Select(group => group.Key);

            lbxEnCok.DataSource = enCokYenilenYemekler.ToList();
        }
        public void Goster()
        {
            dgvEnCokYenenYemek.DataSource = yenilenYiyecekler.ToList();
            dgvEnCokYenenYemek.Refresh();
            dgvEnCokYenenYemek.Columns[0].Visible = false;
            dgvEnCokYenenYemek.Columns[1].Visible = false;
            dgvEnCokYenenYemek.Columns[3].Visible = false;
            dgvEnCokYenenYemek.Columns[4].Visible = false;
            dgvEnCokYenenYemek.Columns[5].Visible = false;
            dgvEnCokYenenYemek.Columns[7].Visible = false;
            dgvEnCokYenenYemek.Columns[8].Visible = false;
            dgvEnCokYenenYemek.Columns[9].Visible = false;
        }


        public void cmbxyiyecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doldur();
            if (cmbxyiyecek.SelectedItem != null)
            {
                DiyetTablosuViewModel viewModel = new DiyetTablosuViewModel();
                DiyetTablosuManager diyetTablosuManager = new DiyetTablosuManager();
                int selectedYiyecekId = ((YiyecekViewModel)cmbxyiyecek.SelectedItem).Id;

                List<DiyetTablosuViewModel> yiyecekler =  diyetTablosuManager.GetAll()
                    .Where(dt => dt.YiyecekId == selectedYiyecekId).ToList();
                foreach(var d in yiyecekler)
                {
                    //d.Kullanici = kullanicilar.Where(k => k.Id == d.KullaniciId).FirstOrDefault();
                    //d.Ogun = ogunler.Where(o => o.Id == d.OgunId).FirstOrDefault();
                }
                yenilenYiyecekler = yiyecekler;
                Goster();
            }
        }
    }
}

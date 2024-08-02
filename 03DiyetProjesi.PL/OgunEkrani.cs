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
    public partial class OgunEkrani : Form
    {
        
        OgunViewModel secilenOgun;

        public OgunEkrani()
        {
            InitializeComponent();
            Goster();
        }
        private void Goster()
        {
            dgvOgunEkrani.DataSource = null;
            dgvOgunEkrani.DataSource = OgunleriGetir();
            dgvOgunEkrani.Columns[2].Visible = false;
        }
        private List<OgunViewModel> OgunleriGetir()
        {
            OgunManager ogunManager = new OgunManager();
            try
            {
                List<OgunViewModel> ogunler = ogunManager.GetAll().Where(o=>o.Deleted==null).ToList();
                return ogunler;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                OgunManager ogunManager = new OgunManager();
                OgunViewModel ogun = new OgunViewModel();
                ogun.Ad = txtOgunAdi.Text;
                ogunManager.Add(ogun);
                MessageBox.Show("Öğün başarıyla eklenmiştir");
                Goster();

            }
            catch (Exception ex)
            {

                MessageBox.Show("hata oluştu" + ex.Message);

            }

        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (secilenOgun != null)
                {
                    OgunManager ogunManager = new OgunManager();
                    secilenOgun.Ad = txtOgunAdi.Text;
                    ogunManager.Update(secilenOgun);
                    Goster();
                }
                else
                    MessageBox.Show("Lütfen öğün seçiniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata oluştu" + ex.Message);
            }


        }

        private void dgvOgunEkrani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenOgun = (OgunViewModel)dgvOgunEkrani.SelectedRows[0].DataBoundItem;
            txtOgunAdi.Text = secilenOgun.Ad;
        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            if (secilenOgun != null)
            {
                OgunManager ogunManager = new OgunManager();
                ogunManager.Delete(secilenOgun);
                Goster();

                MessageBox.Show("Başarıyla silinmiştir");
                
            }
            else
                MessageBox.Show("Ogun seçiniz!");
        }
    }
}

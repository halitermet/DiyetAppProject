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
    public partial class PorsiyonEkranı : Form
    {
        PorsiyonViewModel secilenPorsiyon;
        public PorsiyonEkranı()
        {
            InitializeComponent();
            Goster();
        }
        private void dgvPorsiyonEkrani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenPorsiyon = (PorsiyonViewModel)dgvPorsiyonEkrani.SelectedRows[0].DataBoundItem;
            txtporsiyonTuru.Text = secilenPorsiyon.Tur;
        }
        private void Goster()
        {
            dgvPorsiyonEkrani.DataSource = null;
            dgvPorsiyonEkrani.DataSource = PorsiyonlariGetir();
        }

        private List<PorsiyonViewModel> PorsiyonlariGetir()
        {
            PorsiyonManager porsiyonManager = new PorsiyonManager();
            try
            {
                List<PorsiyonViewModel> porsiyonlar = porsiyonManager.GetAll().ToList();
                return porsiyonlar;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnPorsiyonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtporsiyonTuru != null)
                {
                    PorsiyonViewModel porsiyonViewModel = new PorsiyonViewModel();
                    PorsiyonManager porsiyonManager = new PorsiyonManager();
                    porsiyonViewModel.Tur = txtporsiyonTuru.Text;
                    porsiyonManager.Add(porsiyonViewModel);
                    Goster();
                    MessageBox.Show("Porsiyon eklendi");
                }
                else
                {
                    MessageBox.Show("Lutfen porsiyon türünü yazınız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }
        }

        private void btnPorsiyonSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenPorsiyon != null)
                {
                    PorsiyonManager porsiyonManager = new PorsiyonManager();
                    porsiyonManager.Delete(secilenPorsiyon);
                    secilenPorsiyon = null;
                    Goster();
                    MessageBox.Show("Başarı ile silinmiştir");
                }

                else
                {
                    MessageBox.Show("Lutfen porsiyon seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }

        }

        private void btnPorsiyonGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenPorsiyon != null)
                {
                    PorsiyonManager porsiyonManager = new PorsiyonManager();
                    
                    secilenPorsiyon.Tur = txtporsiyonTuru.Text;
                    porsiyonManager.Update(secilenPorsiyon);
                    Goster();
                    secilenPorsiyon = null;
                    MessageBox.Show("Başarı ile güncellendi.");
                }

                else
                {
                    MessageBox.Show("Lutfen porsiyon seçiniz");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }
        }
    }
}

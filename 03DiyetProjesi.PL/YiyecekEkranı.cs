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
    public partial class YiyecekEkranı : Form
    {
        YiyecekViewModel secilenYiyecek;

        public YiyecekEkranı()
        {
            InitializeComponent();
            Goster();
        }
        private void dgvYiyecekEkrani_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenYiyecek = (YiyecekViewModel)dgvYiyecekEkrani.SelectedRows[0].DataBoundItem;
            txtYiyecekAdi.Text = secilenYiyecek.Ad;
            txtKalori.Text = secilenYiyecek.Kalori.ToString();
            if(secilenYiyecek.Resim != null)
            {
                MemoryStream ms = new MemoryStream(secilenYiyecek.Resim);
                pbYiyecekResmi.SizeMode = PictureBoxSizeMode.Zoom;
                pbYiyecekResmi.Image = Image.FromStream(ms);
            }
        }
        private void Goster()
        {
            dgvYiyecekEkrani.DataSource = null;
            dgvYiyecekEkrani.DataSource = YiyecekleriGetir();
        }

        private List<YiyecekViewModel> YiyecekleriGetir()
        {
            YiyecekManager yiyecekManager = new YiyecekManager();
            try
            {
                List<YiyecekViewModel> yiyecekler = yiyecekManager.GetAll()
                    .ToList();
                return yiyecekler;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnYiyecekEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtYiyecekAdi.Text) && float.TryParse(txtKalori.Text, out float kaloriValue))
                {
                    YiyecekManager yiyecekManager = new YiyecekManager();
                    YiyecekViewModel yiyecekViewModel = new YiyecekViewModel();
                    yiyecekViewModel.Ad = txtYiyecekAdi.Text;
                    yiyecekViewModel.Kalori = kaloriValue;
                    using (OpenFileDialog openFileDialog = new OpenFileDialog())
                    {
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = openFileDialog.FileName;
                            byte[] imageData = File.ReadAllBytes(filePath);
                            yiyecekViewModel.Resim = imageData;
                        }
                    }
                    yiyecekManager.Add(yiyecekViewModel);
                    Goster();
                    MessageBox.Show("Yiyecek eklendi");
                }
                else
                {
                    MessageBox.Show("Lutfen yiyecek türünü yazınız ve geçerli bir kalori değerini giriniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata olustu" + ex.Message);
            }

        }

        private void btnYiyecekSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenYiyecek != null)
                {
                    YiyecekManager yiyecekManager = new YiyecekManager();
                    yiyecekManager.Delete(secilenYiyecek);
                    secilenYiyecek = null;
                    pbYiyecekResmi.Image = null;
                    Goster();
                    MessageBox.Show("Başarı ile silinmiştir");
                }

                else
                {
                    MessageBox.Show("Lutfen yiyecek seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu " + ex.Message);

            }

        }

        private void btnYiyecekGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilenYiyecek != null)
                {
                    if (!string.IsNullOrWhiteSpace(txtYiyecekAdi.Text) && float.TryParse(txtKalori.Text, out float kaloriValue))
                    {
                        YiyecekManager yiyecekManager = new YiyecekManager();
                        // TextBox'lara giriş yapıldı ve kalori bir sayıya dönüştürülebiliyor
                        secilenYiyecek.Ad = txtYiyecekAdi.Text;
                        secilenYiyecek.Kalori = kaloriValue;
                        yiyecekManager.Update(secilenYiyecek);
                        Goster();
                        secilenYiyecek = null;
                        MessageBox.Show("Başarı ile güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir yiyecek adı ve kalori değeri giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen yiyecek seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

        }
    }
}

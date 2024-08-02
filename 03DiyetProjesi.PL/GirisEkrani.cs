using _01DiyetProjesi.DAL.Context.EF;
using _01DiyetProjesi.DAL.Entities.Concrete;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using System.Security.Cryptography;
using System.Text;

namespace _03DiyetProjesi.PL
{
    public partial class GirisEkrani : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager();
              
        public GirisEkrani()
        {
            InitializeComponent();
        }
     

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
            kayitOlEkrani.Show();

        }
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciViewModel kullaniciViewModel = kullaniciManager.GetAll().FirstOrDefault(a => a.Email.Contains(txtMail.Text) && a.Sifre == sha256_hash(txtSifre.Text));

            if (kullaniciViewModel != null)
            {
                int kullaniciId = kullaniciViewModel.Id;
                if (!string.IsNullOrWhiteSpace(txtMail.Text))
                {
                    if (kullaniciViewModel.IsAdmin)
                    {
                        AdminEkran adminEkran = new AdminEkran(kullaniciId);
                        adminEkran.Show();
                    }
                    else
                    {
                        KullaniciAnaEkran kullaniciAnaEkran = new KullaniciAnaEkran(kullaniciId);
                        kullaniciAnaEkran.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kullanýcý bilgileri geçersiz. Lütfen kayýt yapýnýz.");
                KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
                kayitOlEkrani.Show();
            }
        }
    }
}
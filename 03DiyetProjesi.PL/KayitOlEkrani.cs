using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using _01DiyetProjesi.DAL.Enums;
using _02DiyetProjesi.BL.Manager.Concrete;
using _02DiyetProjesi.BL.Model;
using System.Windows.Forms;

namespace _03DiyetProjesi.PL
{
    public partial class KayitOlEkrani : Form
    {
        KullaniciViewModel kullaniciViewModel = new KullaniciViewModel();

        public KayitOlEkrani()
        {
            InitializeComponent();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            kullaniciViewModel.Ad = txtAd.Text;

            if (string.IsNullOrWhiteSpace(kullaniciViewModel.Ad))
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz");
                return;
            }

            kullaniciViewModel.Soyad = txtSoyad.Text;

            if (string.IsNullOrWhiteSpace(kullaniciViewModel.Soyad))
            {
                MessageBox.Show("Kullanıcı soyadı boş bırakılamaz");
                return;
            }

            kullaniciViewModel.Yas = Convert.ToByte(txtYas.Text);

            if (kullaniciViewModel.Yas <= 18)
            {
                MessageBox.Show("18 Yaşından küçükler kayıt yaptıramaz.");
                return;
            }

            if (!float.TryParse(txtKilo.Text, out float kilo) || kilo <= 0)
            {
                MessageBox.Show("Kilo geçerli bir sayı olmalı ve 0'dan büyük olmalıdır.");
                return;
            }

            kullaniciViewModel.Kilo = kilo;

            kullaniciViewModel.Cinsiyet = rBtnErkek.Checked ? Cinsiyet.Erkek : Cinsiyet.Kadın;

            kullaniciViewModel.Email = txtMail.Text;
            kullaniciViewModel.IsAdmin = txtMail.Text.Contains("@yonetici") ? true : false;
            if (string.IsNullOrWhiteSpace(kullaniciViewModel.Email))
            {
                MessageBox.Show("Email boş bırakılamaz");
                return;
            }
            if (!kullaniciViewModel.Email.Contains("@"))
            {
                MessageBox.Show("Lütfen mail adresi giriniz.");
            }

            string[] specialCharacters = { "*", "!", "+", "%", "/", "<", ">", "-", "{", "}", "(", ")", "?", "-", "_", "&", "^",".",","};

            kullaniciViewModel.Sifre = sha256_hash(txtSifre.Text);

            if (kullaniciViewModel.Sifre.Length <= 8)
            {
                MessageBox.Show("Şifre uzunluğu en az 8 karakter olmalıdır.");
                return;
            }
            else if (!txtSifre.Text.Any(char.IsUpper))
            {
                MessageBox.Show("En az 1 büyük harf giriniz.");
                return;
            }
            else if (!txtSifre.Text.Any(char.IsLower))
            {
                MessageBox.Show("En az 1 küçük harf giriniz.");
                return;
            }
            else if (!specialCharacters.Any(txtSifre.Text.Contains))
            {
                MessageBox.Show("En az 1 özel karakter giriniz");
                return;
            }

            KullaniciManager kullaniciManager = new KullaniciManager();
            kullaniciManager.Add(kullaniciViewModel);
            MessageBox.Show("Kullanıcı başarıyla kayıt olmuştur.");
            this.Close();
            
        }
        
    }
}




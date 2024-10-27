using AYS_BLL.Managers.Concrete;
using AYS_BLL.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AYS_UI
{
    public partial class GirisSayfasi : Form
    {
        private bool isVisiblePassword = false;
        public GirisSayfasi()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //�ifreyi hashler ve databasedeki ile uyumlu�ununa bakar.
        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        //Kullan�c� �ifreyi yazarken �ifrenin g�z�k�p g�z�kmemesini kontrol eder.
        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (!isVisiblePassword)
            {
                txt_sifre.PasswordChar = '\0';
                isVisiblePassword = true;
                btnShowHidePassword.Image = AYS_UI.Properties.Resources.resim__1_;
            }
            else
            {
                txt_sifre.PasswordChar = '*';
                isVisiblePassword = false;
                btnShowHidePassword.Image = AYS_UI.Properties.Resources.resim__2_;
            }
        }
        //Kay�t sayfas�na aktar�r.
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitSayfasics kayitsayfasi = new KayitSayfasics();
            kayitsayfasi.ShowDialog();
        }
        //E�le�en admin varsa y�netim sayfas�na aktar�r. Yoka gerekli hatay� verir.
        private void btn_girisyap_Click_1(object sender, EventArgs e)
        {
            string name = txt_ad.Text;
            string password = txt_sifre.Text;

            string hashedPassword = sha256_hash(password);

            AdminModel admin;
            using (AdminManager adminManager = new AdminManager())
            {
                admin = adminManager.Search(u => u.Name == name && u.Password == hashedPassword)
                             .FirstOrDefault();
                if (admin != null)
                {
                    YonetimSayfasi yonetimSayfasi = new YonetimSayfasi();
                    this.Hide();
                    yonetimSayfasi.ShowDialog();
                    this.Show();
                }
                else
                {
                    lbl_hataligiris.Visible = true;
                }
            }

        }
    }

}


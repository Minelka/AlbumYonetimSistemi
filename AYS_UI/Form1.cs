using AYS_BLL.Managers.Concrete;
using AYS_BLL.Models;
using System.Xml.Linq;

namespace AYS_UI
{
    public partial class Form1 : Form
    {
        private bool isVisiblePassword = false;
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            string name = txt_ad.Text;
            string password = txt_sifre.Text;

            AdminModel admin;
            using (AdminManager adminManager = new AdminManager())
            {
                admin = adminManager.Search(u => u.Name == Name && u.Password == password).FirstOrDefault();   //getallusers reportmanagerdan geliyor, username ise usermanagerdan gelmeli ama göremez.

                if (admin != null)
                {
                    YonetimSayfasi yonetimsayfasi = new YonetimSayfasi();
                    this.Hide();
                    YonetimSayfasi.ShowDialog();
                    this.Show();
                }
            }

            private void btnShowHidePassword_Click(object sender, EventArgs e)
            {

                if (!isVisiblePassword)
                {
                    txt_sifre.PasswordChar = '\0';
                    isVisiblePassword = true;
                    btnShowHidePassword.Image = AYS_UI.Properties.Resources.;
                }
                else
                {
                    txt_sifre.PasswordChar = '*';
                    isVisiblePassword = false;
                    btnShowHidePassword.Image = AYS_UI.Properties.Resources.eye_open;
                }
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitSayfasics kayitsayfasi = new KayitSayfasics();
            kayitsayfasi .ShowDialog();
        }
    }
}

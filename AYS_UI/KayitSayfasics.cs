using AYS_BLL.Managers.Concrete;
using AYS_BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AYS_UI
{
    public partial class KayitSayfasics : Form
    {
        private bool isVisiblePassword = false;
        public KayitSayfasics()
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

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(txt_ad.Text) || IsNameExists())  
            {
                lbl_sifreuyumsuz.Visible = true;
                lbl_sifreuyumsuz.Text = "Bu kullanıcı ismi kullanılmaktadır";
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(txt_sifre.Text)|| string.IsNullOrWhiteSpace(txt_sifretekrarı.Text) || !PasswordValid(txt_sifre.Text))
            {
                lbl_sifreuyumsuz.Visible = true;
                lbl_sifreuyumsuz.Text = "Şifreler uyumsuzdur";
                isValid = false;
            }
            if (isValid)
            {
                using (AdminManager adminManager = new AdminManager())
                {
                    AdminModel adminModel = new AdminModel();
                    adminModel.Name = txt_ad.Text;
                    adminModel.Password = sha256_hash(txt_sifre.Text);
                    adminModel.Created = DateTime.Now;


                    adminManager.Create(adminModel);

                    adminManager.Save();
                }
                this.Hide();
                GirisSayfasi form1 = new GirisSayfasi();
                form1.ShowDialog();
            }
        }
        private bool IsNameExists()
        {
            using (AdminManager adminManager = new AdminManager())
            {
                return adminManager.Search(am => am.Name == txt_ad.Text).Any();
            }
        }
        private bool PasswordValid(string text)
        {
            if (txt_sifre.Text.ToString().Equals(txt_sifretekrarı.Text.ToString())) 
            {
                if (text.Length < 8) return false;

                int upperCaseCount = 0;
                int lowerCaseCount = 0;
                int specialCharCount = 0;

                foreach (char c in text)
                {
                    if (char.IsUpper(c)) upperCaseCount++;
                    else if (char.IsLower(c)) lowerCaseCount++;
                    else if (!char.IsLetterOrDigit(c)) specialCharCount++;
                }
                if (upperCaseCount >= 2 && lowerCaseCount >= 3 && specialCharCount >= 2)
                {
                    return true;
                }

                return false;
            }
            else
            {
                lbl_sifreuyumsuz.Visible = true;
                return false;
            }
        }


        private void btn_gozKırp_Click(object sender, EventArgs e)
        {
            if (!isVisiblePassword)
            {
                txt_sifre.PasswordChar = '\0';
                isVisiblePassword = true;
                btn_gozKırp.Image = AYS_UI.Properties.Resources.resim__1_;
            }
            else
            {
                txt_sifre.PasswordChar = '*';
                isVisiblePassword = false;
                btn_gozKırp.Image = AYS_UI.Properties.Resources.resim__2_;
            }
        }


        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (!isVisiblePassword)
            {
                txt_sifretekrarı.PasswordChar = '\0';
                isVisiblePassword = true;
                btnShowHidePassword.Image = AYS_UI.Properties.Resources.resim__1_;
            }
            else
            {
                txt_sifretekrarı.PasswordChar = '*';
                isVisiblePassword = false;
                btnShowHidePassword.Image = AYS_UI.Properties.Resources.resim__2_;
            }
        }
    }
}


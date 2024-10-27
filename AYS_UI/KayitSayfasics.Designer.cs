namespace AYS_UI
{
    partial class KayitSayfasics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitSayfasics));
            txt_sifretekrarı = new TextBox();
            lbl_sifretekrari = new Label();
            lbl_sifreuyumsuz = new Label();
            txt_sifre = new TextBox();
            lbl_sifre = new Label();
            txt_ad = new TextBox();
            lbl_ad = new Label();
            gb_kayit = new GroupBox();
            btn_gozKırp = new Button();
            btnShowHidePassword = new Button();
            btn_kayitol = new Button();
            gb_kayit.SuspendLayout();
            SuspendLayout();
            // 
            // txt_sifretekrarı
            // 
            txt_sifretekrarı.Location = new Point(173, 129);
            txt_sifretekrarı.Margin = new Padding(3, 2, 3, 2);
            txt_sifretekrarı.Name = "txt_sifretekrarı";
            txt_sifretekrarı.PasswordChar = '*';
            txt_sifretekrarı.Size = new Size(110, 32);
            txt_sifretekrarı.TabIndex = 7;
            // 
            // lbl_sifretekrari
            // 
            lbl_sifretekrari.AutoSize = true;
            lbl_sifretekrari.BackColor = Color.Silver;
            lbl_sifretekrari.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifretekrari.Location = new Point(27, 131);
            lbl_sifretekrari.Name = "lbl_sifretekrari";
            lbl_sifretekrari.Size = new Size(118, 28);
            lbl_sifretekrari.TabIndex = 6;
            lbl_sifretekrari.Text = "Şifre Tekrarı:";
            // 
            // lbl_sifreuyumsuz
            // 
            lbl_sifreuyumsuz.AutoSize = true;
            lbl_sifreuyumsuz.BackColor = Color.SeaShell;
            lbl_sifreuyumsuz.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_sifreuyumsuz.ForeColor = Color.Maroon;
            lbl_sifreuyumsuz.Location = new Point(30, 182);
            lbl_sifreuyumsuz.Name = "lbl_sifreuyumsuz";
            lbl_sifreuyumsuz.Size = new Size(104, 24);
            lbl_sifreuyumsuz.TabIndex = 14;
            lbl_sifreuyumsuz.Text = "Geçersiz Giriş";
            lbl_sifreuyumsuz.Visible = false;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(173, 78);
            txt_sifre.Margin = new Padding(3, 2, 3, 2);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(110, 32);
            txt_sifre.TabIndex = 13;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Silver;
            lbl_sifre.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifre.Location = new Point(27, 78);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(78, 28);
            lbl_sifre.TabIndex = 12;
            lbl_sifre.Text = "Şifreniz:";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(173, 28);
            txt_ad.Margin = new Padding(3, 2, 3, 2);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(110, 32);
            txt_ad.TabIndex = 11;
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.BackColor = Color.Silver;
            lbl_ad.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_ad.Location = new Point(30, 26);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(75, 28);
            lbl_ad.TabIndex = 10;
            lbl_ad.Text = "Adınız: ";
            // 
            // gb_kayit
            // 
            gb_kayit.BackColor = Color.Silver;
            gb_kayit.Controls.Add(btn_gozKırp);
            gb_kayit.Controls.Add(btnShowHidePassword);
            gb_kayit.Controls.Add(btn_kayitol);
            gb_kayit.Controls.Add(lbl_ad);
            gb_kayit.Controls.Add(lbl_sifreuyumsuz);
            gb_kayit.Controls.Add(lbl_sifretekrari);
            gb_kayit.Controls.Add(txt_sifre);
            gb_kayit.Controls.Add(txt_sifretekrarı);
            gb_kayit.Controls.Add(lbl_sifre);
            gb_kayit.Controls.Add(txt_ad);
            gb_kayit.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gb_kayit.Location = new Point(159, 9);
            gb_kayit.Margin = new Padding(3, 2, 3, 2);
            gb_kayit.Name = "gb_kayit";
            gb_kayit.Padding = new Padding(3, 2, 3, 2);
            gb_kayit.Size = new Size(384, 283);
            gb_kayit.TabIndex = 15;
            gb_kayit.TabStop = false;
            gb_kayit.Text = "KAYIT OL";
            // 
            // btn_gozKırp
            // 
            btn_gozKırp.BackgroundImage = Properties.Resources.resim__1_;
            btn_gozKırp.BackgroundImageLayout = ImageLayout.Center;
            btn_gozKırp.Location = new Point(289, 78);
            btn_gozKırp.Margin = new Padding(3, 2, 3, 2);
            btn_gozKırp.Name = "btn_gozKırp";
            btn_gozKırp.Size = new Size(27, 27);
            btn_gozKırp.TabIndex = 17;
            btn_gozKırp.UseVisualStyleBackColor = true;
            btn_gozKırp.Click += btn_gozKırp_Click;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.BackgroundImage = Properties.Resources.resim__1_;
            btnShowHidePassword.BackgroundImageLayout = ImageLayout.Center;
            btnShowHidePassword.Location = new Point(289, 129);
            btnShowHidePassword.Margin = new Padding(3, 2, 3, 2);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(27, 25);
            btnShowHidePassword.TabIndex = 16;
            btnShowHidePassword.UseVisualStyleBackColor = true;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // btn_kayitol
            // 
            btn_kayitol.Location = new Point(258, 232);
            btn_kayitol.Margin = new Padding(3, 2, 3, 2);
            btn_kayitol.Name = "btn_kayitol";
            btn_kayitol.Size = new Size(104, 34);
            btn_kayitol.TabIndex = 15;
            btn_kayitol.Text = "Kayıt Ol";
            btn_kayitol.UseVisualStyleBackColor = true;
            btn_kayitol.Click += btn_kayitol_Click;
            // 
            // KayitSayfasics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 338);
            Controls.Add(gb_kayit);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KayitSayfasics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KayitSayfasics";
            gb_kayit.ResumeLayout(false);
            gb_kayit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_sifretekrarı;
        private Label lbl_sifretekrari;
        private Label lbl_sifreuyumsuz;
        private TextBox txt_sifre;
        private Label lbl_sifre;
        private TextBox txt_ad;
        private Label lbl_ad;
        private GroupBox gb_kayit;
        private Button btn_kayitol;
        private Button btn_gozKırp;
        private Button btnShowHidePassword;
    }
}
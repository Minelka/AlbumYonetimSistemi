namespace AYS_UI
{
    partial class GirisSayfasi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisSayfasi));
            lbl_ad = new Label();
            txt_ad = new TextBox();
            lbl_sifre = new Label();
            txt_sifre = new TextBox();
            btn_kayit = new Button();
            btn_girisyap = new Button();
            lbl_hataligiris = new Label();
            btnShowHidePassword = new Button();
            SuspendLayout();
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.BackColor = Color.Silver;
            lbl_ad.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_ad.Location = new Point(277, 239);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(75, 28);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Adınız: ";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(277, 279);
            txt_ad.Margin = new Padding(3, 2, 3, 2);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(110, 23);
            txt_ad.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Silver;
            lbl_sifre.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifre.Location = new Point(277, 319);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(78, 28);
            lbl_sifre.TabIndex = 2;
            lbl_sifre.Text = "Şifreniz:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(277, 365);
            txt_sifre.Margin = new Padding(3, 2, 3, 2);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(110, 23);
            txt_sifre.TabIndex = 3;
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = Color.Peru;
            btn_kayit.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_kayit.Location = new Point(381, 203);
            btn_kayit.Margin = new Padding(3, 2, 3, 2);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(107, 37);
            btn_kayit.TabIndex = 6;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = false;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // btn_girisyap
            // 
            btn_girisyap.BackColor = Color.Peru;
            btn_girisyap.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_girisyap.Location = new Point(381, 454);
            btn_girisyap.Margin = new Padding(3, 2, 3, 2);
            btn_girisyap.Name = "btn_girisyap";
            btn_girisyap.Size = new Size(107, 34);
            btn_girisyap.TabIndex = 7;
            btn_girisyap.Text = "Giriş Yap";
            btn_girisyap.UseVisualStyleBackColor = false;
            btn_girisyap.Click += btn_girisyap_Click_1;
            // 
            // lbl_hataligiris
            // 
            lbl_hataligiris.AutoSize = true;
            lbl_hataligiris.BackColor = Color.SeaShell;
            lbl_hataligiris.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_hataligiris.ForeColor = Color.Maroon;
            lbl_hataligiris.Location = new Point(277, 406);
            lbl_hataligiris.Name = "lbl_hataligiris";
            lbl_hataligiris.Size = new Size(90, 24);
            lbl_hataligiris.TabIndex = 8;
            lbl_hataligiris.Text = "Hatalı Giriş";
            lbl_hataligiris.Visible = false;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.BackgroundImage = Properties.Resources.resim__2_;
            btnShowHidePassword.BackgroundImageLayout = ImageLayout.Center;
            btnShowHidePassword.Location = new Point(393, 364);
            btnShowHidePassword.Margin = new Padding(3, 2, 3, 2);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(21, 23);
            btnShowHidePassword.TabIndex = 9;
            btnShowHidePassword.UseVisualStyleBackColor = true;
            btnShowHidePassword.Click += btnShowHidePassword_Click;
            // 
            // GirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(761, 653);
            Controls.Add(btnShowHidePassword);
            Controls.Add(lbl_hataligiris);
            Controls.Add(btn_girisyap);
            Controls.Add(btn_kayit);
            Controls.Add(txt_sifre);
            Controls.Add(lbl_sifre);
            Controls.Add(txt_ad);
            Controls.Add(lbl_ad);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ad;
        private TextBox txt_ad;
        private Label lbl_sifre;
        private TextBox txt_sifre;
        private Button btn_kayit;
        private Button btn_girisyap;
        private Label lbl_hataligiris;
        private Button btnShowHidePassword;
    }
}

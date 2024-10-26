namespace AYS_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_ad = new Label();
            txt_ad = new TextBox();
            lbl_sifre = new Label();
            txt_sifre = new TextBox();
            btn_kayit = new Button();
            btn_girisyap = new Button();
            btn_hataligiris = new Label();
            btnShowHidePassword = new Button();
            SuspendLayout();
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.BackColor = Color.Silver;
            lbl_ad.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_ad.Location = new Point(313, 277);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(93, 35);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Adınız: ";
            lbl_ad.Visible = false;
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(313, 331);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(125, 27);
            txt_ad.TabIndex = 1;
            txt_ad.Visible = false;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Silver;
            lbl_sifre.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifre.Location = new Point(313, 384);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(96, 35);
            lbl_sifre.TabIndex = 2;
            lbl_sifre.Text = "Şifreniz:";
            lbl_sifre.Visible = false;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(313, 446);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(125, 27);
            txt_sifre.TabIndex = 3;
            txt_sifre.Visible = false;
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = Color.Peru;
            btn_kayit.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_kayit.Location = new Point(661, 811);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(197, 48);
            btn_kayit.TabIndex = 6;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = false;
            btn_kayit.Click += btn_kayit_Click;
            // 
            // btn_girisyap
            // 
            btn_girisyap.BackColor = Color.Peru;
            btn_girisyap.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_girisyap.Location = new Point(435, 613);
            btn_girisyap.Name = "btn_girisyap";
            btn_girisyap.Size = new Size(122, 37);
            btn_girisyap.TabIndex = 7;
            btn_girisyap.Text = "Giriş Yap";
            btn_girisyap.UseVisualStyleBackColor = false;
            btn_girisyap.Click += btn_girisyap_Click;
            // 
            // btn_hataligiris
            // 
            btn_hataligiris.AutoSize = true;
            btn_hataligiris.BackColor = Color.SeaShell;
            btn_hataligiris.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_hataligiris.ForeColor = Color.Maroon;
            btn_hataligiris.Location = new Point(313, 514);
            btn_hataligiris.Name = "btn_hataligiris";
            btn_hataligiris.Size = new Size(111, 30);
            btn_hataligiris.TabIndex = 8;
            btn_hataligiris.Text = "Hatalı Giriş";
            btn_hataligiris.Visible = false;
            // 
            // btnShowHidePassword
            // 
            btnShowHidePassword.Location = new Point(444, 445);
            btnShowHidePassword.Name = "btnShowHidePassword";
            btnShowHidePassword.Size = new Size(24, 29);
            btnShowHidePassword.TabIndex = 9;
            btnShowHidePassword.Text = "*";
            btnShowHidePassword.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 871);
            Controls.Add(btnShowHidePassword);
            Controls.Add(btn_hataligiris);
            Controls.Add(btn_girisyap);
            Controls.Add(btn_kayit);
            Controls.Add(txt_sifre);
            Controls.Add(lbl_sifre);
            Controls.Add(txt_ad);
            Controls.Add(lbl_ad);
            Name = "Form1";
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
        private Label btn_hataligiris;
        private Button btnShowHidePassword;
    }
}

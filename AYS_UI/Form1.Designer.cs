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
            btn_hatasifre = new Label();
            lbl_hataisim = new Label();
            SuspendLayout();
            // 
            // lbl_ad
            // 
            lbl_ad.AutoSize = true;
            lbl_ad.BackColor = Color.Silver;
            lbl_ad.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_ad.Location = new Point(296, 237);
            lbl_ad.Name = "lbl_ad";
            lbl_ad.Size = new Size(93, 35);
            lbl_ad.TabIndex = 0;
            lbl_ad.Text = "Adınız: ";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(296, 291);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(125, 27);
            txt_ad.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.BackColor = Color.Silver;
            lbl_sifre.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifre.Location = new Point(296, 378);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(96, 35);
            lbl_sifre.TabIndex = 2;
            lbl_sifre.Text = "Şifreniz:";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(296, 431);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(125, 27);
            txt_sifre.TabIndex = 3;
            // 
            // btn_kayit
            // 
            btn_kayit.BackColor = Color.Peru;
            btn_kayit.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_kayit.Location = new Point(603, 663);
            btn_kayit.Name = "btn_kayit";
            btn_kayit.Size = new Size(197, 48);
            btn_kayit.TabIndex = 6;
            btn_kayit.Text = "Kayıt Ol";
            btn_kayit.UseVisualStyleBackColor = false;
            // 
            // btn_girisyap
            // 
            btn_girisyap.BackColor = Color.Peru;
            btn_girisyap.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_girisyap.Location = new Point(403, 507);
            btn_girisyap.Name = "btn_girisyap";
            btn_girisyap.Size = new Size(122, 37);
            btn_girisyap.TabIndex = 7;
            btn_girisyap.Text = "Giriş Yap";
            btn_girisyap.UseVisualStyleBackColor = false;
            // 
            // btn_hatasifre
            // 
            btn_hatasifre.AutoSize = true;
            btn_hatasifre.BackColor = Color.SeaShell;
            btn_hatasifre.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_hatasifre.ForeColor = Color.Maroon;
            btn_hatasifre.Location = new Point(296, 474);
            btn_hatasifre.Name = "btn_hatasifre";
            btn_hatasifre.Size = new Size(163, 30);
            btn_hatasifre.TabIndex = 8;
            btn_hatasifre.Text = "Hatalı Şifre Girişi";
            // 
            // lbl_hataisim
            // 
            lbl_hataisim.AutoSize = true;
            lbl_hataisim.BackColor = Color.SeaShell;
            lbl_hataisim.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_hataisim.ForeColor = Color.Maroon;
            lbl_hataisim.Location = new Point(296, 334);
            lbl_hataisim.Name = "lbl_hataisim";
            lbl_hataisim.Size = new Size(157, 30);
            lbl_hataisim.TabIndex = 9;
            lbl_hataisim.Text = "Hatalı İsim Girişi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 723);
            Controls.Add(lbl_hataisim);
            Controls.Add(btn_hatasifre);
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
        private Label btn_hatasifre;
        private Label lbl_hataisim;
    }
}

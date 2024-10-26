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
            SuspendLayout();
            // 
            // txt_sifretekrarı
            // 
            txt_sifretekrarı.Location = new Point(326, 231);
            txt_sifretekrarı.Name = "txt_sifretekrarı";
            txt_sifretekrarı.Size = new Size(125, 27);
            txt_sifretekrarı.TabIndex = 7;
            // 
            // lbl_sifretekrari
            // 
            lbl_sifretekrari.AutoSize = true;
            lbl_sifretekrari.BackColor = Color.Silver;
            lbl_sifretekrari.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lbl_sifretekrari.Location = new Point(326, 193);
            lbl_sifretekrari.Name = "lbl_sifretekrari";
            lbl_sifretekrari.Size = new Size(148, 35);
            lbl_sifretekrari.TabIndex = 6;
            lbl_sifretekrari.Text = "Şifre Tekrarı:";
            // 
            // KayitSayfasics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txt_sifretekrarı);
            Controls.Add(lbl_sifretekrari);
            Name = "KayitSayfasics";
            Text = "KayitSayfasics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_sifretekrarı;
        private Label lbl_sifretekrari;
    }
}
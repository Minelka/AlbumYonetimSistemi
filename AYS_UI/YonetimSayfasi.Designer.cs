namespace AYS_UI
{
    partial class YonetimSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetimSayfasi));
            dataGridView1 = new DataGridView();
            btn_tamami = new Button();
            gb_albumekleme = new GroupBox();
            btn_ekle = new Button();
            chc_status = new CheckBox();
            txt_artist = new TextBox();
            lbl_artist = new Label();
            txt_release = new TextBox();
            lbl_date = new Label();
            lbl_status = new Label();
            txt_discount = new TextBox();
            lbl_discount = new Label();
            txt_price = new TextBox();
            lbl_price = new Label();
            txt_name = new TextBox();
            lbl_name = new Label();
            btn_satisdurmus = new Button();
            btn_devam = new Button();
            btn_son = new Button();
            btn_indirim = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gb_albumekleme.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Chocolate;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 294);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(570, 136);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_tamami
            // 
            btn_tamami.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_tamami.Location = new Point(10, 452);
            btn_tamami.Margin = new Padding(3, 2, 3, 2);
            btn_tamami.Name = "btn_tamami";
            btn_tamami.Size = new Size(85, 32);
            btn_tamami.TabIndex = 1;
            btn_tamami.Text = "TAMAMI";
            btn_tamami.UseVisualStyleBackColor = true;
            // 
            // gb_albumekleme
            // 
            gb_albumekleme.BackColor = Color.Chocolate;
            gb_albumekleme.Controls.Add(btn_ekle);
            gb_albumekleme.Controls.Add(chc_status);
            gb_albumekleme.Controls.Add(txt_artist);
            gb_albumekleme.Controls.Add(lbl_artist);
            gb_albumekleme.Controls.Add(txt_release);
            gb_albumekleme.Controls.Add(lbl_date);
            gb_albumekleme.Controls.Add(lbl_status);
            gb_albumekleme.Controls.Add(txt_discount);
            gb_albumekleme.Controls.Add(lbl_discount);
            gb_albumekleme.Controls.Add(txt_price);
            gb_albumekleme.Controls.Add(lbl_price);
            gb_albumekleme.Controls.Add(txt_name);
            gb_albumekleme.Controls.Add(lbl_name);
            gb_albumekleme.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            gb_albumekleme.Location = new Point(140, 9);
            gb_albumekleme.Margin = new Padding(3, 2, 3, 2);
            gb_albumekleme.Name = "gb_albumekleme";
            gb_albumekleme.Padding = new Padding(3, 2, 3, 2);
            gb_albumekleme.Size = new Size(326, 280);
            gb_albumekleme.TabIndex = 2;
            gb_albumekleme.TabStop = false;
            gb_albumekleme.Text = "ALBÜM EKLEME EKRANI";
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(231, 236);
            btn_ekle.Margin = new Padding(3, 2, 3, 2);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(82, 33);
            btn_ekle.TabIndex = 13;
            btn_ekle.Text = "EKLE";
            btn_ekle.UseVisualStyleBackColor = true;
            // 
            // chc_status
            // 
            chc_status.AutoSize = true;
            chc_status.Location = new Point(154, 222);
            chc_status.Margin = new Padding(3, 2, 3, 2);
            chc_status.Name = "chc_status";
            chc_status.Size = new Size(15, 14);
            chc_status.TabIndex = 12;
            chc_status.UseVisualStyleBackColor = true;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(154, 60);
            txt_artist.Margin = new Padding(3, 2, 3, 2);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(110, 33);
            txt_artist.TabIndex = 11;
            // 
            // lbl_artist
            // 
            lbl_artist.AutoSize = true;
            lbl_artist.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_artist.Location = new Point(17, 60);
            lbl_artist.Name = "lbl_artist";
            lbl_artist.Size = new Size(100, 24);
            lbl_artist.TabIndex = 10;
            lbl_artist.Text = "Artist/Grup:";
            // 
            // txt_release
            // 
            txt_release.Location = new Point(154, 98);
            txt_release.Margin = new Padding(3, 2, 3, 2);
            txt_release.Name = "txt_release";
            txt_release.Size = new Size(110, 33);
            txt_release.TabIndex = 9;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_date.Location = new Point(17, 98);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(93, 24);
            lbl_date.TabIndex = 8;
            lbl_date.Text = "Çıkış Tarihi:";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_status.Location = new Point(17, 216);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(86, 24);
            lbl_status.TabIndex = 6;
            lbl_status.Text = "Satışta Mı:";
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(154, 172);
            txt_discount.Margin = new Padding(3, 2, 3, 2);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(110, 33);
            txt_discount.TabIndex = 5;
            // 
            // lbl_discount
            // 
            lbl_discount.AutoSize = true;
            lbl_discount.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_discount.Location = new Point(17, 172);
            lbl_discount.Name = "lbl_discount";
            lbl_discount.Size = new Size(122, 24);
            lbl_discount.TabIndex = 4;
            lbl_discount.Text = "İndirim Miktarı:";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(154, 135);
            txt_price.Margin = new Padding(3, 2, 3, 2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(110, 33);
            txt_price.TabIndex = 3;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_price.Location = new Point(17, 135);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(93, 24);
            lbl_price.TabIndex = 2;
            lbl_price.Text = "Satış Fiyatı:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(154, 22);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(110, 33);
            txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_name.Location = new Point(17, 22);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(90, 24);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Albüm Adı:";
            // 
            // btn_satisdurmus
            // 
            btn_satisdurmus.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_satisdurmus.Location = new Point(109, 439);
            btn_satisdurmus.Margin = new Padding(3, 2, 3, 2);
            btn_satisdurmus.Name = "btn_satisdurmus";
            btn_satisdurmus.Size = new Size(106, 58);
            btn_satisdurmus.TabIndex = 3;
            btn_satisdurmus.Text = "SATIŞI DURAN";
            btn_satisdurmus.UseVisualStyleBackColor = true;
            // 
            // btn_devam
            // 
            btn_devam.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_devam.Location = new Point(229, 439);
            btn_devam.Margin = new Padding(3, 2, 3, 2);
            btn_devam.Name = "btn_devam";
            btn_devam.Size = new Size(106, 58);
            btn_devam.TabIndex = 4;
            btn_devam.Text = "SATIŞI DEVAM ";
            btn_devam.UseVisualStyleBackColor = true;
            // 
            // btn_son
            // 
            btn_son.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_son.Location = new Point(349, 448);
            btn_son.Margin = new Padding(3, 2, 3, 2);
            btn_son.Name = "btn_son";
            btn_son.Size = new Size(92, 35);
            btn_son.TabIndex = 5;
            btn_son.Text = "SON 10";
            btn_son.UseVisualStyleBackColor = true;
            // 
            // btn_indirim
            // 
            btn_indirim.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_indirim.Location = new Point(455, 447);
            btn_indirim.Margin = new Padding(3, 2, 3, 2);
            btn_indirim.Name = "btn_indirim";
            btn_indirim.Size = new Size(150, 40);
            btn_indirim.TabIndex = 6;
            btn_indirim.Text = "İNDİRİMDEKİLER";
            btn_indirim.UseVisualStyleBackColor = true;
            // 
            // YonetimSayfasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(626, 506);
            Controls.Add(btn_indirim);
            Controls.Add(btn_son);
            Controls.Add(btn_devam);
            Controls.Add(btn_satisdurmus);
            Controls.Add(gb_albumekleme);
            Controls.Add(btn_tamami);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "YonetimSayfasi";
            Text = "YonetimSayfasi";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gb_albumekleme.ResumeLayout(false);
            gb_albumekleme.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_tamami;
        private GroupBox gb_albumekleme;
        private TextBox txt_name;
        private Label lbl_name;
        private TextBox txt_artist;
        private Label lbl_artist;
        private TextBox txt_release;
        private Label lbl_date;
        private Label lbl_status;
        private TextBox txt_discount;
        private Label lbl_discount;
        private TextBox txt_price;
        private Label lbl_price;
        private CheckBox chc_status;
        private Button btn_ekle;
        private Button btn_satisdurmus;
        private Button btn_devam;
        private Button btn_son;
        private Button btn_indirim;
    }
}
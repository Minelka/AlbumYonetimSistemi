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
            btn_sil = new Button();
            btn_guncelle = new Button();
            dtpDate = new DateTimePicker();
            btn_ekle = new Button();
            chc_status = new CheckBox();
            txt_artist = new TextBox();
            lbl_artist = new Label();
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
            dataGridView1.Location = new Point(202, 394);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(311, 181);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_tamami
            // 
            btn_tamami.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_tamami.Location = new Point(11, 603);
            btn_tamami.Name = "btn_tamami";
            btn_tamami.Size = new Size(97, 43);
            btn_tamami.TabIndex = 1;
            btn_tamami.Text = "TAMAMI";
            btn_tamami.UseVisualStyleBackColor = true;
            btn_tamami.Click += btn_tamami_Click;
            // 
            // gb_albumekleme
            // 
            gb_albumekleme.BackColor = Color.Chocolate;
            gb_albumekleme.Controls.Add(btn_sil);
            gb_albumekleme.Controls.Add(btn_guncelle);
            gb_albumekleme.Controls.Add(dtpDate);
            gb_albumekleme.Controls.Add(btn_ekle);
            gb_albumekleme.Controls.Add(chc_status);
            gb_albumekleme.Controls.Add(txt_artist);
            gb_albumekleme.Controls.Add(lbl_artist);
            gb_albumekleme.Controls.Add(lbl_date);
            gb_albumekleme.Controls.Add(lbl_status);
            gb_albumekleme.Controls.Add(txt_discount);
            gb_albumekleme.Controls.Add(lbl_discount);
            gb_albumekleme.Controls.Add(txt_price);
            gb_albumekleme.Controls.Add(lbl_price);
            gb_albumekleme.Controls.Add(txt_name);
            gb_albumekleme.Controls.Add(lbl_name);
            gb_albumekleme.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            gb_albumekleme.Location = new Point(168, 15);
            gb_albumekleme.Name = "gb_albumekleme";
            gb_albumekleme.Size = new Size(373, 373);
            gb_albumekleme.TabIndex = 2;
            gb_albumekleme.TabStop = false;
            gb_albumekleme.Text = "ALBÜM EKLEME EKRANI";
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(7, 331);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(94, 44);
            btn_sil.TabIndex = 15;
            btn_sil.Text = "SİL";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(125, 329);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(126, 44);
            btn_guncelle.TabIndex = 14;
            btn_guncelle.Text = "GUNCELLE";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(176, 132);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(143, 39);
            dtpDate.TabIndex = 7;
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(273, 329);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(94, 44);
            btn_ekle.TabIndex = 13;
            btn_ekle.Text = "EKLE";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // chc_status
            // 
            chc_status.AutoSize = true;
            chc_status.Location = new Point(176, 296);
            chc_status.Name = "chc_status";
            chc_status.Size = new Size(18, 17);
            chc_status.TabIndex = 12;
            chc_status.UseVisualStyleBackColor = true;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(176, 80);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(143, 39);
            txt_artist.TabIndex = 11;
            // 
            // lbl_artist
            // 
            lbl_artist.AutoSize = true;
            lbl_artist.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_artist.Location = new Point(19, 80);
            lbl_artist.Name = "lbl_artist";
            lbl_artist.Size = new Size(121, 30);
            lbl_artist.TabIndex = 10;
            lbl_artist.Text = "Artist/Grup:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_date.Location = new Point(19, 131);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(115, 30);
            lbl_date.TabIndex = 8;
            lbl_date.Text = "Çıkış Tarihi:";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_status.Location = new Point(19, 288);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(105, 30);
            lbl_status.TabIndex = 6;
            lbl_status.Text = "Satışta Mı:";
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(176, 229);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(143, 39);
            txt_discount.TabIndex = 5;
            // 
            // lbl_discount
            // 
            lbl_discount.AutoSize = true;
            lbl_discount.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_discount.Location = new Point(19, 229);
            lbl_discount.Name = "lbl_discount";
            lbl_discount.Size = new Size(151, 30);
            lbl_discount.TabIndex = 4;
            lbl_discount.Text = "İndirim Miktarı:";
            // 
            // txt_price
            // 
            txt_price.Location = new Point(176, 180);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(143, 39);
            txt_price.TabIndex = 3;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_price.Location = new Point(19, 180);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(114, 30);
            lbl_price.TabIndex = 2;
            lbl_price.Text = "Satış Fiyatı:";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(176, 29);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(143, 39);
            txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_name.Location = new Point(19, 29);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(109, 30);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Albüm Adı:";
            // 
            // btn_satisdurmus
            // 
            btn_satisdurmus.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_satisdurmus.Location = new Point(148, 586);
            btn_satisdurmus.Name = "btn_satisdurmus";
            btn_satisdurmus.Size = new Size(121, 77);
            btn_satisdurmus.TabIndex = 3;
            btn_satisdurmus.Text = "SATIŞI DURAN";
            btn_satisdurmus.UseVisualStyleBackColor = true;
            btn_satisdurmus.Click += btn_satisdurmus_Click;
            // 
            // btn_devam
            // 
            btn_devam.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_devam.Location = new Point(298, 585);
            btn_devam.Name = "btn_devam";
            btn_devam.Size = new Size(121, 77);
            btn_devam.TabIndex = 4;
            btn_devam.Text = "SATIŞI DEVAM ";
            btn_devam.UseVisualStyleBackColor = true;
            btn_devam.Click += btn_devam_Click;
            // 
            // btn_son
            // 
            btn_son.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_son.Location = new Point(436, 597);
            btn_son.Name = "btn_son";
            btn_son.Size = new Size(105, 47);
            btn_son.TabIndex = 5;
            btn_son.Text = "SON 10";
            btn_son.UseVisualStyleBackColor = true;
            btn_son.Click += btn_son_Click;
            // 
            // btn_indirim
            // 
            btn_indirim.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_indirim.Location = new Point(567, 594);
            btn_indirim.Name = "btn_indirim";
            btn_indirim.Size = new Size(171, 53);
            btn_indirim.TabIndex = 6;
            btn_indirim.Text = "İNDİRİMDEKİLER";
            btn_indirim.UseVisualStyleBackColor = true;
            btn_indirim.Click += btn_indirim_Click;
            // 
            // YonetimSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 751);
            Controls.Add(btn_indirim);
            Controls.Add(btn_son);
            Controls.Add(btn_devam);
            Controls.Add(btn_satisdurmus);
            Controls.Add(gb_albumekleme);
            Controls.Add(btn_tamami);
            Controls.Add(dataGridView1);
            Name = "YonetimSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
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
        private DateTimePicker dtpDate;
        private Button btn_sil;
        private Button btn_guncelle;
    }
}
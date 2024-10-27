using AYS_BLL.Managers.Concrete;
using AYS_BLL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AYS_UI
{
    public partial class YonetimSayfasi : Form
    {
        
        AlbumModel selectedAlbum;
        public YonetimSayfasi()
        {
            InitializeComponent();


            Getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Datagridde seçme işlemi yapıldığında textlere atama işlemini yapar.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                if (e.RowIndex >= 0)
                {
                    selectedAlbum = (AlbumModel)dataGridView1.SelectedRows[0].DataBoundItem;

                    if (selectedAlbum != null)
                    {
                        txt_name.Text = selectedAlbum.Name;
                        txt_artist.Text = selectedAlbum.Artist;
                        dtpDate.Value = selectedAlbum.ReleaseDate.ToDateTime(TimeOnly.MinValue);
                        txt_price.Text = selectedAlbum.Price.ToString();
                        txt_discount.Text = selectedAlbum.Discount.ToString();
                        chc_status.Checked = selectedAlbum.Status;
                    }
                }
            }
        }

        //Getir metotu datagride verileri getirir.
        private void Getir()
        {

            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetAllAlbums().ToList();

            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;

        }
        //Tüm albumleri getirir.
        private void btn_tamami_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetAllAlbums().ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;
        }

        //Satışı durmuş albümleri getirir.
        private void btn_satisdurmus_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetUnsoldAlbums().ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;
        }

        //Satışı devameden albümleri getirir.
        private void btn_devam_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetSoldingAlbums().ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;
        }

        //Son eklenen 10 albüm getirilir.
        private void btn_son_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetLast10Albums().ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;
        }

        //İndirimli albümleri getirir.
        private void btn_indirim_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetDiscountedAlbums().ToList();

            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                if (i > 1)
                    dataGridView1.Columns[i].Visible = false;
        }

        //Albüm ekler.
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {

                AlbumModel albumModel = new AlbumModel();
                albumModel.Name = txt_name.Text;
                albumModel.Artist = txt_artist.Text;
                albumModel.ReleaseDate = DateOnly.FromDateTime(dtpDate.Value);
                albumModel.Status = chc_status.Checked;
                decimal.TryParse(txt_price.Text, out decimal price);
                albumModel.Price = price;

                decimal.TryParse(txt_discount.Text, out decimal discount);
                albumModel.Discount = discount;

                albumManager.Create(albumModel);
                albumManager.Save();
                Getir();

            }
            txt_name.Clear();
            txt_artist.Clear();
            txt_price.Clear();
            txt_discount.Clear();
            chc_status.Checked = false;

        }

        //Var olan albümü günceller.
        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            if (selectedAlbum != null)
            {
                using (AlbumManager albumManager = new AlbumManager())
                {
                    selectedAlbum.Name = txt_name.Text;
                    selectedAlbum.Artist = txt_artist.Text;
                    selectedAlbum.ReleaseDate = DateOnly.FromDateTime(dtpDate.Value);
                    selectedAlbum.Price = Convert.ToDecimal(txt_price.Text);
                    selectedAlbum.Discount = Convert.ToDecimal(txt_discount.Text);
                    selectedAlbum.Status = chc_status.Checked;

                    albumManager.Update(selectedAlbum);
                    albumManager.Save();
                    selectedAlbum = null;
                }
            }
            Getir();
            txt_name.Clear();
            txt_artist.Clear();
            txt_price.Clear();
            txt_discount.Clear();
            chc_status.Checked = false;
        }

        //Var olan albümü siler.
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (selectedAlbum != null)
            {
                using (AlbumManager albumManager = new AlbumManager())
                {
                    selectedAlbum.Name = txt_name.Text;
                    selectedAlbum.Artist = txt_artist.Text;
                    selectedAlbum.ReleaseDate = DateOnly.FromDateTime(dtpDate.Value);
                    selectedAlbum.Price = Convert.ToDecimal(txt_price.Text);
                    selectedAlbum.Discount = Convert.ToDecimal(txt_discount.Text);
                    selectedAlbum.Status = chc_status.Checked;

                    albumManager.Remove(selectedAlbum);
                    albumManager.Save();
                    selectedAlbum = null;
                }
                Getir();
                txt_name.Clear();
                txt_artist.Clear();
                txt_price.Clear();
                txt_discount.Clear();
                chc_status.Checked = false;
            }
        }
    }
}

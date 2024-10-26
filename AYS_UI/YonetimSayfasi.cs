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
        public YonetimSayfasi()
        {
            InitializeComponent();


            //Getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void Getir()
        //{
        //    using (AlbumManager albumManager = new AlbumManager())
        //    {
        //        dataGridView1.DataSource = albumManager.GetDiscountedAlbums().ToList();

        //    }
        //}

        private void btn_tamami_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetAllAlbums().ToList();

            }
        }

        private void btn_satisdurmus_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetUnsoldAlbums().ToList();

            }
        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetSoldingAlbums().ToList();

            }
        }

        private void btn_son_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetLast10Albums().ToList();

            }
        }

        private void btn_indirim_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetDiscountedAlbums().ToList();

            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            using (AlbumManager albumManager = new AlbumManager())
            {

                AlbumModel albumModel = new AlbumModel();
                albumModel.Name = txt_name.Text;
                albumModel.Artist = txt_artist.Text;
                albumModel.ReleaseDate = DateOnly.FromDateTime(dtpDate.Value);
                albumModel.Price = Convert.ToDecimal(txt_price.Text);
                albumModel.Discount = Convert.ToDouble(txt_discount.Text);
                albumModel.Status = chc_status.Checked;


                albumManager.Create(albumModel);
                albumManager.Save();

            }
        }
    }
}

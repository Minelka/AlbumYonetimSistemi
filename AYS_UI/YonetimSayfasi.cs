using AYS_BLL.Managers.Concrete;
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
            //using (AlbumManager albumManager = new AlbumManager())
            //{
            //    dataGridView1.DataSource = albumManager.GetAllAlbums().ToList();

            //}


            Getir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Getir()
        {
            using (AlbumManager albumManager = new AlbumManager())
            {
                dataGridView1.DataSource = albumManager.GetDiscountedAlbums().ToList();

            }
        }

    }
}

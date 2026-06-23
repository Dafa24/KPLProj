using Main.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class HomepageUser : Form
    {
        public HomepageUser()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        // Ubah jadi async void
        private async void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear(); // Bersihkan data lama

            // GET dari API
            List<Barang> daftarBarang = await DataHelper.GetFromAPI<Barang>("barang");

            if (daftarBarang != null)
            {
                foreach (var barang in daftarBarang)
                {
                    dataGridView1.Rows.Add(barang.KodeBarang, barang.NamaBarang, barang.JumlahBarang, barang.HargaBarang);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bisa dibiarkan kosong sesuai kode asli
        }
    }
}
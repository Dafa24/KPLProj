using Main.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class TabelBarang : Form
    {
        public TabelBarang()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Nama", "Nama Barang");
            dataGridView1.Columns.Add("Kode", "Kode Barang");
            dataGridView1.Columns.Add("Jumlah", "Jumlah Stok");
            dataGridView1.Columns.Add("Harga", "Harga Barang");
            dataGridView1.Columns.Add("Status", "Status (Automata)");

            PopulateDataGridView();
        }

        // Ubah jadi async void
        private async void PopulateDataGridView()
        {
            dataGridView1.Rows.Clear();

            // GET data dari API
            List<Barang> daftarBarang = await DataHelper.GetFromAPI<Barang>("barang");

            if (daftarBarang != null)
            {
                foreach (var barang in daftarBarang)
                {
                    int rowIndex = dataGridView1.Rows.Add(
                        barang.NamaBarang,       
                        barang.KodeBarang,       
                        barang.JumlahBarang,     
                        barang.HargaBarang,      
                        barang.Status.ToString() 
                    );

                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    switch (barang.Status)
                    {
                        case StatusBarang.Habis:
                            row.DefaultCellStyle.BackColor = Color.LightCoral;
                            break;
                        case StatusBarang.BatasKritis:
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case StatusBarang.Tersedia:
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
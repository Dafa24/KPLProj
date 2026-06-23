using Main.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class DeleteBarang : Form
    {
        public DeleteBarang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Ubah jadi async void
        private async void button2_Click(object sender, EventArgs e)
        {
            string namabarang = inputNamaBarang.Text;

            if (string.IsNullOrEmpty(namabarang))
            {
                MessageBox.Show("Masukkan Nama Barang");
                return;
            }

            List<Barang> list = await DataHelper.GetFromAPI<Barang>("barang");
            bool isFound = false;

            foreach (var barang in list)
            {
                if (barang.NamaBarang.Equals(namabarang, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    // Tembak endpoint DELETE (asumsi routing API-nya nerima nama barang)
                    await DataHelper.DeleteFromAPI($"barang/{namabarang}");
                    MessageBox.Show("Barang berhasil dihapus dari Database!");
                    inputNamaBarang.Clear();
                    break;
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Barang tidak ditemukan.");
            }
        }
    }
}
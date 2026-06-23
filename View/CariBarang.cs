using Main.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class CariBarang : Form
    {
        public CariBarang()
        {
            InitializeComponent();
            namaBarangDisplay.ReadOnly = true;
            kodeBarangDisplay.ReadOnly = true;
            stokBarangDisplay.ReadOnly = true;
            hargaBarangDisplay.ReadOnly = true;
        }

        // Ubah jadi async void
        private async void cariBTN_Click(object sender, EventArgs e)
        {
            // Panggil API dengan endpoint "barang"
            List<Barang> list = await DataHelper.GetFromAPI<Barang>("barang");
            string namabarang = namaBarangInput.Text;
            Barang found = cariBarang(list, namabarang);

            if (found != null)
            {
                namaBarangDisplay.Text = found.NamaBarang;
                kodeBarangDisplay.Text = found.KodeBarang.ToString();
                stokBarangDisplay.Text = found.JumlahBarang.ToString();
                hargaBarangDisplay.Text = found.HargaBarang.ToString();
            }
            else
            {
                MessageBox.Show("Barang Tidak Ditemukan");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private Barang cariBarang(List<Barang> DataBarang, String namaBarang)
        {
            for (int i = 0; i < DataBarang.Count; i++)
            {
                if (DataBarang[i].NamaBarang.Equals(namaBarang, StringComparison.OrdinalIgnoreCase))
                {
                    return DataBarang[i];
                }
            }
            return null;
        }
    }
}
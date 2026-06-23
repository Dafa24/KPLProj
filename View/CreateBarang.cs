using Main.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class CreateBarang : Form
    {
        public CreateBarang()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // Ubah jadi async void
        private async void button1_Click(object sender, EventArgs e)
        {
            string namabarang = inputNamaBarang.Text;
            int kodebarang = int.Parse(inputKodeBarang.Text);
            int jumlahbarang = int.Parse(inputJumlahBarang.Text);
            int hargabarang = int.Parse(inputHargaBarang.Text);

            Boolean statusKodeBarang = await validateBarang(kodebarang);

            if (statusKodeBarang)
            {
                MessageBox.Show("Kode barang sudah ada di Database");
            }
            else
            {
                Barang newBarang = new Barang(namabarang, kodebarang, jumlahbarang, hargabarang);

                // POST ke API
                await DataHelper.PostToAPI<Barang>(newBarang, "barang");
                MessageBox.Show("Barang baru berhasil ditambahkan via API");
                this.Dispose(); // Tutup form setelah berhasil
            }
        }

        private async Task<Boolean> validateBarang(int kodeBarang)
        {
            List<Barang> dataBarang = await DataHelper.GetFromAPI<Barang>("barang");
            for (int i = 0; i < dataBarang.Count; i++)
            {
                if (dataBarang[i].KodeBarang.Equals(kodeBarang))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            string namabarang = inputNamaBarang.Text;
            int kodebarang = int.Parse(inputKodeBarang.Text);
            int jumlahbarang = int.Parse(inputJumlahBarang.Text);
            int hargabarang = int.Parse(inputHargaBarang.Text);

            List<Barang> dataBarang = ReadJSON();
            Boolean statusKodeBarang = validateBarang(kodebarang);
            if (statusKodeBarang)
            {
                MessageBox.Show("kode barang sudah ada");
            } else
            {
                Barang newBarang = new Barang(namabarang, kodebarang, jumlahbarang, hargabarang);
                dataBarang.Add(newBarang);
                WriteJSON(dataBarang);
                MessageBox.Show("Barang baru berhasil di tambahkan");
            }
        }

        public List<Barang> ReadJSON()
        {
            string filePathDataBarang = "D:\\GUI-KPL\\Main\\Data\\dataBarang.json";
            List<Barang> DataBarang = new List<Barang>();
            try
            {
                string configJsonData = File.ReadAllText(filePathDataBarang);
                DataBarang = JsonSerializer.Deserialize<List<Barang>>(configJsonData);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return DataBarang;

        }
        private void WriteJSON(List<Barang> newDataBarang)
        {
            string filePathDataBarang = "D:\\GUI-KPL\\Main\\Data\\dataBarang.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataBarang, options);
            File.WriteAllText(filePathDataBarang, jsonString);
        }

        private Boolean validateBarang(int kodeBarang)
        {
            List<Barang> dataBarang = ReadJSON();
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

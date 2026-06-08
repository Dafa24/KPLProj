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
using Main.Model;

namespace View
{
    public partial class HomepageUser : Form
    {
        public string fileDataPathBarang = "D:\\GUI-KPL\\Main\\Data\\dataBarang.json";

        public HomepageUser()
        {
            InitializeComponent();
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            List<Barang> daftarBarang = ReadJsonFile(fileDataPathBarang);

            foreach (var barang in daftarBarang)
            {
                dataGridView1.Rows.Add(barang.KodeBarang, barang.NamaBarang, barang.JumlahBarang, barang.HargaBarang);
            }
        }

        private List<Barang> ReadJsonFile(string filePath)
        {
            List<Barang> daftarBarang = new List<Barang>();

            try
            {
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentException("File path cannot be null or empty.", nameof(filePath));
                }

                string json;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    json = reader.ReadToEnd();
                }

                daftarBarang = JsonSerializer.Deserialize<List<Barang>>(json);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"File not found: {ex.Message}");
            }
            catch (JsonException ex)
            {
                MessageBox.Show($"Error parsing JSON file: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
            }

            return daftarBarang;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string namaBarang = row.Cells[1].Value.ToString();
                int kodeBarang = Convert.ToInt32(row.Cells[0].Value);
                int jumlahBarang = Convert.ToInt32(row.Cells[2].Value);
                int hargaBarang = Convert.ToInt32(row.Cells[3].Value);

                Barang barang = new Barang(namaBarang, kodeBarang, jumlahBarang, hargaBarang);


            }
        }


    }
}

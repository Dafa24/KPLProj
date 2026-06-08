using Main.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace View
{
    public partial class TabelBarang : Form
    {
        // Menggunakan relative path biar aman di-run di laptop mana aja
        public string fileDataPathBarang = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "dataBarang.json");

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

        private void PopulateDataGridView()
        {
            // Bersihkan baris data lama jika ada
            dataGridView1.Rows.Clear();

            List<Barang> daftarBarang = ReadJsonFile(fileDataPathBarang);

            if (daftarBarang != null)
            {
                foreach (var barang in daftarBarang)
                {
                    // 3. Masukkan data ke DataGridView sesuai urutan kolom baru di atas
                    int rowIndex = dataGridView1.Rows.Add(
                        barang.NamaBarang,       // Kolom 0 (Nama)
                        barang.KodeBarang,       // Kolom 1 (Kode)
                        barang.JumlahBarang,     // Kolom 2 (Jumlah)
                        barang.HargaBarang,      // Kolom 3 (Harga)
                        barang.Status.ToString() // Kolom 4 (Status Automata)
                    );

                    // 4. Visualisasi Transisi State (Memberi warna baris tabel)
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    switch (barang.Status)
                    {
                        case StatusBarang.Habis:
                            row.DefaultCellStyle.BackColor = Color.LightCoral; // Merah jika Habis
                            break;
                        case StatusBarang.BatasKritis:
                            row.DefaultCellStyle.BackColor = Color.LightYellow; // Kuning jika Kritis
                            break;
                        case StatusBarang.Tersedia:
                            row.DefaultCellStyle.BackColor = Color.LightGreen; // Hijau jika Tersedia
                            break;
                    }
                }
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

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File JSON tidak ditemukan. Membuat list kosong.");
                    return daftarBarang;
                }

                string json = File.ReadAllText(filePath);
                daftarBarang = JsonSerializer.Deserialize<List<Barang>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading JSON file: {ex.Message}");
            }

            return daftarBarang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // TAMBAHKAN INI UNTUK MENYEMBUHKAN EROR DESIGNER
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kosongkan saja, cuma buat syarat biar file Designer ga eror
        }
    }
}
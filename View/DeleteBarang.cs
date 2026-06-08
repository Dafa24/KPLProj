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

        private void button2_Click(object sender, EventArgs e)
        {
           List<Barang> list = ReadJSON();
           string namabarang = inputNamaBarang.Text;
            if (string.IsNullOrEmpty(namabarang))
            {
                MessageBox.Show("Masukkan Nama Barang");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (namabarang.Equals(list[i].NamaBarang))
                    {
                        list.Remove(list[i]);
                        WriteJSON(list);
                        MessageBox.Show("Barang terhapus!");
                        inputNamaBarang.Clear();
                    }
                }
            }
        }

        public List<Barang> ReadJSON()
        {
            string filePathDataBarang = "D:\\Tubes KPL GUI\\GUI-KPL\\Main\\Data\\dataBarang.json";
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
            string filePathDataBarang = "D:\\Tubes KPL GUI\\GUI-KPL\\Main\\Data\\dataBarang.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataBarang, options);
            File.WriteAllText(filePathDataBarang, jsonString);
        }
        private Barang validateBarang(string namaBarang)
        {
            List<Barang> dataBarang = ReadJSON();
            for (int i = 0; i < dataBarang.Count; i++)
            {
                if (dataBarang[i].NamaBarang.Equals(namaBarang))
                {
                    return dataBarang[i];
                }
            }
            return null;

        }
    }
}

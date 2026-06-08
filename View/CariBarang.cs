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

        private void cariBTN_Click(object sender, EventArgs e)
        {
           List<Barang> list =ReadJSON();
           string namabarang = namaBarangInput.Text;
            Barang found = cariBarang(list,namabarang);
            if(found != null)
            {
                namaBarangDisplay.Text = found.NamaBarang;
                kodeBarangDisplay.Text = found.KodeBarang.ToString();
                stokBarangDisplay.Text = found.KodeBarang.ToString();
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
        private Barang cariBarang(List<Barang> DataBarang,String namaBarang)
        {
            for(int i = 0; i < DataBarang.Count; i++)
            {
                if (DataBarang[i].NamaBarang.Equals(namaBarang))
                {
                    return DataBarang[i];
                }
            }
            return null;

        }

    }
}

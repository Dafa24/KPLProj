using Main.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Login : Form
    {
        // ======================================================================
        // IMPLEMENTASI TABLE-DRIVEN: Tabel Pemetaan Rute berdasarkan Role
        // ======================================================================
        private readonly Dictionary<string, Func<Form>> _roleRoutingTable = new Dictionary<string, Func<Form>>
        {
            { "Admin", () => new Homepage() },
            { "User", () => new HomepageUser() }
        };

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            string _username = textBox1.Text;
            string _password = textBox2.Text;

            // Menggunakan string.IsNullOrEmpty karena TextBox kosong di WinForms nilainya "" bukan null
            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!");
                return;
            }

            List<Akun> _dataAkun = ReadJSON();
            Akun _akunTerdaftar = ValidateUser(_dataAkun, _username, _password);

            if (_akunTerdaftar != null)
            {
                // EXECUTE TABLE-DRIVEN ROUTING:
                // Cari role di dalam tabel Dictionary, jika ketemu langsung jalankan fungsinya
                if (_roleRoutingTable.TryGetValue(_akunTerdaftar.Role, out Func<Form> createForm))
                {
                    Form nextForm = createForm(); 
                    nextForm.Show();
                    this.Hide(); // Sembunyikan form login setelah berhasil masuk
                }
                else
                {
                    MessageBox.Show("Role akun ini tidak memiliki hak akses halaman.");
                }
            }
            else
            {
                MessageBox.Show("Akun anda tidak terdaftar atau password salah");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register _register = new Register();
            _register.Show();
            this.Hide();
        }

        public List<Akun> ReadJSON()
        {
            string filePathDataAkun = "D:\\GUI-KPL\\Main\\Data\\dataAkun.json";
            List<Akun> dataAkun = new List<Akun>();
            try
            {
                if (File.Exists(filePathDataAkun))
                {
                    string configJsonData = File.ReadAllText(filePathDataAkun);
                    dataAkun = JsonSerializer.Deserialize<List<Akun>>(configJsonData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return dataAkun;
        }

        private Akun ValidateUser(List<Akun> newDataAkun, string username, string password)
        {
            for (int i = 0; i < newDataAkun.Count; i++)
            {
                if (newDataAkun[i].Password.Equals(password) && newDataAkun[i].Username.Equals(username))
                {
                    return newDataAkun[i];
                }
            }
            return null;
        }
    }
}
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
    public partial class Register : Form
    {
        // ======================================================================
        // IMPLEMENTASI TABLE-DRIVEN: Tabel Pemetaan Pesan Validasi / Error
        // ======================================================================
        private enum ValidationStatus
        {
            Success,
            EmptyInput,
            UsernameExists,
            InvalidPasswordLength
        }

        private readonly Dictionary<ValidationStatus, string> _validationMessages = new Dictionary<ValidationStatus, string>
        {
            { ValidationStatus.EmptyInput, "Username dan Password tidak boleh kosong." },
            { ValidationStatus.UsernameExists, "Akun gagal dibuat. Username sudah digunakan oleh orang lain!" },
            { ValidationStatus.InvalidPasswordLength, "Password harus berisi antara 6 sampai 10 karakter!" }
        };

        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) => this.Dispose();

        private void button2_Click(object sender, EventArgs e)
        {
            string _username = textBox2.Text;
            string _password = textBox3.Text;
            string _nama = textBox1.Text;
            string _role = "User"; // Default role untuk registrasi mandiri

            List<Akun> _dataAkun = ReadJSON();

            // 1. Jalankan fungsi pengecekan untuk mendapatkan Status
            ValidationStatus currentStatus = RunValidation(_username, _password, _dataAkun);

            // 2. Eksekusi aksi berdasarkan hasil akhir dari Table-Driven
            if (currentStatus == ValidationStatus.Success)
            {
                Akun newAkun = new Akun(_username, _password, _nama, _role);
                _dataAkun.Add(newAkun);
                WriteJSON(_dataAkun);

                MessageBox.Show("Akun berhasil dibuat!");

                // FIX MEMORY: Form login baru dibuat di sini saat beralih halaman (Lazy Initialization)
                Login _login = new Login();
                _login.Show();
                this.Dispose();
            }
            else
            {
                // TABLE-DRIVEN LOOKUP: Ambil pesan dari Dictionary tanpa if-else bercabang
                MessageBox.Show(_validationMessages[currentStatus]);
            }
        }

        // Fungsi Helper untuk menentukan status validasi
        private ValidationStatus RunValidation(string username, string password, List<Akun> dataAkun)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return ValidationStatus.EmptyInput;
            }

            // Memanggil fungsi fix bug duplikasi username
            if (IsUsernameTaken(dataAkun, username))
            {
                return ValidationStatus.UsernameExists;
            }

            if (password.Length < 6 || password.Length > 10)
            {
                return ValidationStatus.InvalidPasswordLength;
            }

            return ValidationStatus.Success;
        }

        // FIX BUG KRITIS: Validasi ini sekarang murni mengecek USERNAME saja agar tidak ada akun kembar di JSON
        private bool IsUsernameTaken(List<Akun> dataAkun, string username)
        {
            for (int i = 0; i < dataAkun.Count; i++)
            {
                if (dataAkun[i].Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
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

        // FIX TYPO: Nama parameter diganti dari "newDataBarang" menjadi "newDataAkun"
        private void WriteJSON(List<Akun> newDataAkun)
        {
            string filePathDataAkun = "D:\\GUI-KPL\\Main\\Data\\dataAkun.json";
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(newDataAkun, options);
            File.WriteAllText(filePathDataAkun, jsonString);
        }
    }
}
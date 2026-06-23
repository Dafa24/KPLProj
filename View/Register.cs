using Main.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class Register : Form
    {
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
            { ValidationStatus.UsernameExists, "Akun gagal dibuat. Username sudah digunakan!" },
            { ValidationStatus.InvalidPasswordLength, "Password harus berisi antara 6 sampai 10 karakter!" }
        };

        public Register()
        {
            InitializeComponent();

            // Mengubah karakter password menjadi titik-titik (•)
            textBox3.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Login _login = new Login();
            _login.Show();
            this.Dispose();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string _username = textBox2.Text;
            string _password = textBox3.Text;
            string _nama = textBox1.Text;
            string _role = "User";

            // Ambil data akun saat ini dari API untuk validasi username
            List<Akun> _dataAkun = await DataHelper.GetFromAPI<Akun>("akun");

            ValidationStatus currentStatus = RunValidation(_username, _password, _dataAkun);

            if (currentStatus == ValidationStatus.Success)
            {
                Akun newAkun = new Akun(_username, _password, _nama, _role);

                // POST Akun baru ke API
                await DataHelper.PostToAPI<Akun>(newAkun, "akun");

                MessageBox.Show("Akun berhasil dibuat!");

                Login _login = new Login();
                _login.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show(_validationMessages[currentStatus]);
            }
        }

        private ValidationStatus RunValidation(string username, string password, List<Akun> dataAkun)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return ValidationStatus.EmptyInput;
            }
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

        private bool IsUsernameTaken(List<Akun> dataAkun, string username)
        {
            if (dataAkun == null) return false;

            for (int i = 0; i < dataAkun.Count; i++)
            {
                if (dataAkun[i].Username.Equals(username, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
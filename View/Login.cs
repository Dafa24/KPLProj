using Main.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    public partial class Login : Form
    {
        private readonly Dictionary<string, Func<Form>> _roleRoutingTable = new Dictionary<string, Func<Form>>
        {
            { "Admin", () => new Homepage() },
            { "User", () => new HomepageUser() }
        };

        public Login()
        {
            InitializeComponent();

            // Mengubah karakter password menjadi titik-titik (•)
            textBox2.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private async void button1_Click(object sender, EventArgs e)
        {
            string _username = textBox1.Text;
            string _password = textBox2.Text;

            if (string.IsNullOrEmpty(_username) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Username atau Password tidak boleh kosong!");
                return;
            }

            // GET Akun dari API
            List<Akun> _dataAkun = await DataHelper.GetFromAPI<Akun>("akun");
            Akun _akunTerdaftar = ValidateUser(_dataAkun, _username, _password);

            if (_akunTerdaftar != null)
            {
                if (_roleRoutingTable.TryGetValue(_akunTerdaftar.Role, out Func<Form> createForm))
                {
                    Form nextForm = createForm();
                    nextForm.Show();
                    this.Hide();
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

        private Akun ValidateUser(List<Akun> newDataAkun, string username, string password)
        {
            if (newDataAkun == null) return null;

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
using System;
using System.Security.Cryptography;
using System.Text;

namespace View.Helper
{
    public static class SecurityHelper
    {
        // Fungsi untuk mengubah password asli menjadi kode hash SHA-256
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Ubah string password jadi kumpulan byte
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Ubah kembali byte menjadi string acak (hexadecimal)
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
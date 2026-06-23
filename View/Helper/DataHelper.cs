using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Helper
{
    public static class DataHelper
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<T>> GetFromAPI<T>(string endpoint) where T : class
        {
            List<T> dataList = new List<T>();
            try
            {
                string baseUrl = RuntimeConfig.Config.ApiBaseUrl;
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    dataList = JsonSerializer.Deserialize<List<T>>(jsonString, options);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal narik data dari API: {ex.Message}");
            }
            return dataList;
        }

        public static async Task PostToAPI<T>(T data, string endpoint) where T : class
        {
            try
            {
                string baseUrl = RuntimeConfig.Config.ApiBaseUrl;
                string jsonString = JsonSerializer.Serialize(data);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + endpoint, content);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Gagal mengirim data ke API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal koneksi ke API: {ex.Message}");
            }
        }

        public static async Task DeleteFromAPI(string endpoint)
        {
            try
            {
                string baseUrl = RuntimeConfig.Config.ApiBaseUrl;
                HttpResponseMessage response = await client.DeleteAsync(baseUrl + endpoint);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Gagal menghapus data di API: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal koneksi ke API: {ex.Message}");
            }
        }
    }
}
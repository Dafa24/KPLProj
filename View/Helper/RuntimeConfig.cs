using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace View.Helper
{
    // Bikin class AppConfig-nya di sini langsung biar nggak error
    public class AppConfig
    {
        public string ApiBaseUrl { get; set; }
        public string AppName { get; set; }
    }

    public static class RuntimeConfig
    {
        public static AppConfig Config { get; private set; }

        public static void Init()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            try
            {
                if (File.Exists(configPath))
                {
                    string jsonString = File.ReadAllText(configPath);
                    Config = JsonSerializer.Deserialize<AppConfig>(jsonString);
                }
                else
                {
                    // Fallback kalau file appsettings.json belum kebaca
                    Config = new AppConfig { ApiBaseUrl = "http://localhost:5118/api/", AppName = "GUI App" };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal load runtime configuration: {ex.Message}");
            }
        }
    }
}
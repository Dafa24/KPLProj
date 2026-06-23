using System;
using System.Windows.Forms;
using View.Helper;

namespace View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Eksekusi konfigurasi appsettings
            RuntimeConfig.Init();

            Application.Run(new Login());
        }
    }
}
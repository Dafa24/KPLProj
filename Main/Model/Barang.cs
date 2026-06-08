using System;
using System.Collections.Generic;

namespace Main.Model
{
    // Definisikan Himpunan State Automata
    public enum StatusBarang
    {
        Habis,
        BatasKritis,
        Tersedia
    }

    public class Barang
    {
        public string NamaBarang { get; set; }
        public int KodeBarang { get; set; }
        public int HargaBarang { get; set; }
        public int JumlahBarang { get; private set; }
        public StatusBarang Status { get; private set; }

        public Barang(string NamaBarang, int KodeBarang, int JumlahBarang, int HargaBarang)
        {
            this.NamaBarang = NamaBarang;
            this.KodeBarang = KodeBarang;
            this.HargaBarang = HargaBarang;
            UpdateStok(JumlahBarang);
        }

        public void UpdateStok(int stokBaru)
        {
            if (stokBaru < 0) stokBaru = 0;
            this.JumlahBarang = stokBaru;

            // Logika Transisi Automata
            if (this.JumlahBarang == 0)
            {
                this.Status = StatusBarang.Habis;
            }
            else if (this.JumlahBarang > 0 && this.JumlahBarang <= 5)
            {
                this.Status = StatusBarang.BatasKritis;
            }
            else
            {
                this.Status = StatusBarang.Tersedia;
            }
        }

        internal static void Add(Barang barang)
        {
            throw new NotImplementedException();
        }

        internal static void RemoveAt(int id)
        {
            throw new NotImplementedException();
        }
    }
}
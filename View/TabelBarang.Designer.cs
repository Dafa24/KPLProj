namespace View
{
    partial class TabelBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Nama = new DataGridViewTextBoxColumn();
            Kode = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            Harga = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nama, Kode, Jumlah, Harga });
            dataGridView1.Location = new Point(107, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(551, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nama
            // 
            Nama.HeaderText = "Nama";
            Nama.MinimumWidth = 6;
            Nama.Name = "Nama";
            Nama.Width = 125;
            // 
            // Kode
            // 
            Kode.HeaderText = "Kode";
            Kode.MinimumWidth = 6;
            Kode.Name = "Kode";
            Kode.Width = 125;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 6;
            Jumlah.Name = "Jumlah";
            Jumlah.Width = 125;
            // 
            // Harga
            // 
            Harga.HeaderText = "Harga";
            Harga.MinimumWidth = 6;
            Harga.Name = "Harga";
            Harga.Width = 125;
            // 
            // TabelBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "TabelBarang";
            Text = "TabelBarang";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nama;
        private DataGridViewTextBoxColumn Kode;
        private DataGridViewTextBoxColumn Jumlah;
        private DataGridViewTextBoxColumn Harga;
    }
}
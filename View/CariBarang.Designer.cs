namespace View
{
    partial class CariBarang
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            namaBarangInput = new TextBox();
            cariBTN = new Button();
            namaBarangDisplay = new TextBox();
            kodeBarangDisplay = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            stokBarangDisplay = new TextBox();
            hargaBarangDisplay = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(642, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 1;
            label1.Text = "Cari Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(228, 35);
            label2.TabIndex = 2;
            label2.Text = "Ketik Nama Barang";
            // 
            // namaBarangInput
            // 
            namaBarangInput.Location = new Point(268, 113);
            namaBarangInput.Name = "namaBarangInput";
            namaBarangInput.Size = new Size(341, 27);
            namaBarangInput.TabIndex = 3;
            // 
            // cariBTN
            // 
            cariBTN.Location = new Point(615, 111);
            cariBTN.Name = "cariBTN";
            cariBTN.Size = new Size(94, 29);
            cariBTN.TabIndex = 4;
            cariBTN.Text = "CARI";
            cariBTN.UseVisualStyleBackColor = true;
            cariBTN.Click += cariBTN_Click;
            // 
            // namaBarangDisplay
            // 
            namaBarangDisplay.Location = new Point(162, 191);
            namaBarangDisplay.Name = "namaBarangDisplay";
            namaBarangDisplay.Size = new Size(149, 27);
            namaBarangDisplay.TabIndex = 5;
            // 
            // kodeBarangDisplay
            // 
            kodeBarangDisplay.Location = new Point(162, 239);
            kodeBarangDisplay.Name = "kodeBarangDisplay";
            kodeBarangDisplay.Size = new Size(149, 27);
            kodeBarangDisplay.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 194);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 7;
            label3.Text = "Nama Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 246);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 8;
            label4.Text = "Kode Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 302);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "Stok Barang";
            // 
            // stokBarangDisplay
            // 
            stokBarangDisplay.Location = new Point(162, 295);
            stokBarangDisplay.Name = "stokBarangDisplay";
            stokBarangDisplay.Size = new Size(149, 27);
            stokBarangDisplay.TabIndex = 10;
            // 
            // hargaBarangDisplay
            // 
            hargaBarangDisplay.Location = new Point(162, 348);
            hargaBarangDisplay.Name = "hargaBarangDisplay";
            hargaBarangDisplay.Size = new Size(149, 27);
            hargaBarangDisplay.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 355);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 12;
            label6.Text = "Harga Barang";
            // 
            // CariBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(hargaBarangDisplay);
            Controls.Add(stokBarangDisplay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kodeBarangDisplay);
            Controls.Add(namaBarangDisplay);
            Controls.Add(cariBTN);
            Controls.Add(namaBarangInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CariBarang";
            Text = "CariBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox namaBarangInput;
        private Button cariBTN;
        private TextBox namaBarangDisplay;
        private TextBox kodeBarangDisplay;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox stokBarangDisplay;
        private TextBox hargaBarangDisplay;
        private Label label6;
    }
}
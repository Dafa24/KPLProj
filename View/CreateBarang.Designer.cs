namespace View
{
    partial class CreateBarang
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
            inputNamaBarang = new TextBox();
            buttonBack = new Button();
            labelNamabarang = new Label();
            label1 = new Label();
            inputKodeBarang = new TextBox();
            label2 = new Label();
            inputHargaBarang = new TextBox();
            label3 = new Label();
            inputJumlahBarang = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(15, 103);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(248, 27);
            inputNamaBarang.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(712, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(76, 29);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelNamabarang
            // 
            labelNamabarang.AutoSize = true;
            labelNamabarang.Location = new Point(15, 70);
            labelNamabarang.Name = "labelNamabarang";
            labelNamabarang.Size = new Size(100, 20);
            labelNamabarang.TabIndex = 2;
            labelNamabarang.Text = "Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 153);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 4;
            label1.Text = "Kode Barang";
            // 
            // inputKodeBarang
            // 
            inputKodeBarang.Location = new Point(15, 186);
            inputKodeBarang.Name = "inputKodeBarang";
            inputKodeBarang.Size = new Size(248, 27);
            inputKodeBarang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 315);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 8;
            label2.Text = "Harga Barang";
            // 
            // inputHargaBarang
            // 
            inputHargaBarang.Location = new Point(15, 348);
            inputHargaBarang.Name = "inputHargaBarang";
            inputHargaBarang.Size = new Size(248, 27);
            inputHargaBarang.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 232);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 6;
            label3.Text = "Jumlah Barang";
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(15, 265);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(248, 27);
            inputJumlahBarang.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(15, 396);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 14);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 10;
            label4.Text = "Add Barang";
            // 
            // CreateBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(inputHargaBarang);
            Controls.Add(label3);
            Controls.Add(inputJumlahBarang);
            Controls.Add(label1);
            Controls.Add(inputKodeBarang);
            Controls.Add(labelNamabarang);
            Controls.Add(buttonBack);
            Controls.Add(inputNamaBarang);
            Name = "CreateBarang";
            Text = "CreateBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNamaBarang;
        private Button buttonBack;
        private Label labelNamabarang;
        private Label label1;
        private TextBox inputKodeBarang;
        private Label label2;
        private TextBox inputHargaBarang;
        private Label label3;
        private TextBox inputJumlahBarang;
        private Button button1;
        private Label label4;
    }
}
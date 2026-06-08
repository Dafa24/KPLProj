namespace View
{
    partial class DeleteBarang
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(43, 159);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(452, 27);
            inputNamaBarang.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(544, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 124);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Nama Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 12);
            label2.Name = "label2";
            label2.Size = new Size(261, 37);
            label2.TabIndex = 3;
            label2.Text = "Delete Barang";
            // 
            // button2
            // 
            button2.Location = new Point(43, 204);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DeleteBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 285);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(inputNamaBarang);
            Name = "DeleteBarang";
            Text = "DeleteBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNamaBarang;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}
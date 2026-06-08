namespace View
{
    partial class Homepage
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
            labelHomepage = new Label();
            buttonAdd = new Button();
            buttonSearch = new Button();
            buttonDelete = new Button();
            lihatTabel = new Button();
            SuspendLayout();
            // 
            // labelHomepage
            // 
            labelHomepage.AutoSize = true;
            labelHomepage.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHomepage.Location = new Point(31, 21);
            labelHomepage.Name = "labelHomepage";
            labelHomepage.Size = new Size(376, 51);
            labelHomepage.TabIndex = 0;
            labelHomepage.Text = "Homepage Gudang";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(31, 98);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(143, 57);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add Barang";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(31, 185);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(143, 57);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search Barang";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(283, 185);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(143, 57);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete Barang";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // lihatTabel
            // 
            lihatTabel.Location = new Point(283, 98);
            lihatTabel.Name = "lihatTabel";
            lihatTabel.Size = new Size(143, 57);
            lihatTabel.TabIndex = 5;
            lihatTabel.Text = "Lihat Tabel Barang";
            lihatTabel.UseVisualStyleBackColor = true;
            lihatTabel.Click += lihatTabel_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 519);
            Controls.Add(lihatTabel);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            Controls.Add(labelHomepage);
            Name = "Homepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHomepage;
        private Button buttonAdd;
        private Button buttonSearch;
        private Button buttonDelete;
        private Button lihatTabel;
    }
}
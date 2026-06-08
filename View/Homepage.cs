using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateBarang createBarang = new CreateBarang();
            createBarang.Visible = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
             
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            CariBarang caribarang = new CariBarang();
            caribarang.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteBarang deleteBarang = new DeleteBarang();
            deleteBarang.Visible = true;
        }

        private void lihatTabel_Click(object sender, EventArgs e)
        {
            TabelBarang tabelBarang = new TabelBarang();
            tabelBarang.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace EaSystem
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.SearchProducts(this.txtSearchStock.Text);
        }

        private void Stocks_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.GetAllProducts().ToList();
        }
    }
}

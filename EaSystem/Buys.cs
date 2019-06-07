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
using DataAccess.Entities;

namespace EaSystem
{
    public partial class Buys : Form
    {
        public void AddProduct(Product product)
        {
            this.dtBuy.Rows.Add(product.ProductId, product.ProductName);
        }

        public Buys()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(this);
            viewProducts.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rows = this.dtBuy.SelectedRows;
            if (rows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar alguna línea a borrar");
                return;
            }
            foreach (DataGridViewRow item in this.dtBuy.SelectedRows)
            {
                this.dtBuy.Rows.RemoveAt(item.Index);
            }

        }
    }
}

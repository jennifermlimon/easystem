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
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            this._products.Add(product);
            this.dtBuy.DataSource = this._products;
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
            var rows = this.dtBuy.CurrentRow;
            if (rows != null)
            {
                var products = _products.Where(x => x.ProductId.Equals(new Guid(rows.Cells["ProductId"].Value.ToString())));
                _products.Remove(products.FirstOrDefault());
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }
    }
}

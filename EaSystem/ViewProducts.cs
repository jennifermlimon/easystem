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
    public partial class ViewProducts : Form
    {
        private readonly Buys _buys;

        public ViewProducts(Buys buy)
        {
            InitializeComponent();
            this._buys = buy;
        }

        #region Private Methods
        private void AddProductoToList(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var product = BusinessProduct.GetProductById(new Guid(rows.Cells["ProductId"].Value.ToString()));
            this._buys.AddProduct(product);
            this.Hide();
        }

        private void SearchProduct(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.SearchProducts(this.txtProductSearch.Text);
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.GetAllProducts().ToList();
        } 
        #endregion
    }
}

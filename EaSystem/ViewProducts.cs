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
        private readonly SellTickets _sells;

        public ViewProducts(Buys buy)
        {
            InitializeComponent();
            this._buys = buy;
        }
        public ViewProducts(SellTickets sell)
        {
            InitializeComponent();
            this._sells = sell;
        }

        #region Private Methods

        // Método que añade producto a la lista

        private void AddProductoToList(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var product = BusinessProduct.GetProductById(new Guid(rows.Cells["ProductId"].Value.ToString()));
            if (_buys == null)
            {
                this._sells.AddProduct(product);
            }
            else
            {
                this._buys.AddProduct(product);
            }            
            this.Hide();
        }

        // Método para buscar productos

        private void SearchProduct(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.SearchProducts(this.txtProductSearch.Text);
        }

        // Método que carga inicialmente los productos

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessProduct.GetAllProducts().ToList();
        } 
        #endregion
    }
}

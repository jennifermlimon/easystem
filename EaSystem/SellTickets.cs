using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaSystem
{
    public partial class SellTickets : Form
    {
        readonly List<Product> _products = new List<Product>();

        public SellTickets()
        {
            InitializeComponent();
        }

        #region Public Methods

        // Método para añadir producto

        public void AddProduct(Product product)
        {
            this.dtBuy.Rows.Add(product.ProductId, product.ProductName, product.Price);
            var amount = Convert.ToDecimal(this.txtInsertAmount.Text, CultureInfo.InvariantCulture) + product.Price;
            this.txtInsertAmount.Text = amount.ToString(CultureInfo.InvariantCulture);
            var total = amount * (decimal)1.21;
            this.txtInsertTotal.Text = total.ToString(CultureInfo.InvariantCulture);
            _products.Add(product);
        }

        // Método para añadir cliente

        public void AddSupplier(Client client)
        {
            this.txtInsertClient.Text = client.ClientName;
            this.ClientId.Text = client.ClientId.ToString();
            this.txtInsertClient.Enabled = false;
        }

        // Método para añadir usuario

        public void AddUser(User user)
        {
            this.txtInsertUser.Text = user.UserName;
            this.UserId.Text = user.UserId.ToString();
            this.txtInsertUser.Enabled = false;
        }
        #endregion

        private void btInsertBuy_Click(object sender, EventArgs e)
        {

        }

        private void btCleanInsert_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

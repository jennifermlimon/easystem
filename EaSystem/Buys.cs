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
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            this.dtBuy.Rows.Add(product.ProductId, product.ProductName);
            products.Add(product);
        }

        public void AddSupplier(Supplier supplier)
        {
            this.txtInsertSupplier.Text = supplier.SupplierName;
            this.SupplierId.Text = supplier.SupplierId.ToString();
            this.txtInsertSupplier.Enabled = false;
        }
        public void AddUser(User user)
        {
            this.txtInsertUser.Text = user.UserName;
            this.UserId.Text = user.UserId.ToString();
            this.txtInsertUser.Enabled = false;
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
                var productRemoved = item.Cells["ProductId"].Value.ToString();
                this.dtBuy.Rows.RemoveAt(item.Index);
                var getOfList = products.Where(x => x.ProductId.Equals(new Guid(productRemoved))).FirstOrDefault();
                products.Remove(getOfList);
            }

        }

        private void btSearchUser_Click(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser(this);
            viewUser.ShowDialog();
        }

        private void btSearchSupplier_Click(object sender, EventArgs e)
        {
            ViewSupplier viewSupplier = new ViewSupplier(this);
            viewSupplier.ShowDialog();
        }

        private void btInsertBuy_Click(object sender, EventArgs e)
        {
            bool isValid = true; // ValidateField();

            if (isValid)
            {
                BuyTicket buyTicket = new BuyTicket()
                {
                    Amount = Convert.ToDecimal(this.txtInsertAmount.Text),
                    Price = Convert.ToDecimal(this.txtInsertTotal.Text),
                    BuyTicketDate = DateTime.Parse(this.dtDateIn.Text),
                    BuyTicketId = Guid.NewGuid(),
                    Products = products,
                    SupplierId = new Guid(this.SupplierId.Text),                   
                    UserId = new Guid(this.UserId.Text)

                };

                bool hasBeenInserted = BussinesBuy.InsertTicket(buyTicket);

                if (hasBeenInserted)
                {                    
                    MessageBox.Show("Categoría insertada correctamente");                   
                }
                else
                {
                    MessageBox.Show("Error al insertar categoria");
                }
            }
        }
    }
}

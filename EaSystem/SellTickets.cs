using BusinessLogic;
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

        #region Private Methods
        // Método de validaciones

        private bool ValidateField()
        {
            int counter = 0;

            if (this.txtInsertUser.Text.Equals(string.Empty))
            {
                this.errorUser.SetError(this.txtInsertUser, "El campo usuario es requerido");
                MessageBox.Show("El campo usuario es requerido");
                return false;
            }

            if (this.txtInsertClient.Text.Equals(string.Empty))
            {
                this.errorClient.SetError(this.txtInsertClient, "El campo cliente es requerido");
                MessageBox.Show("El campo cliente es requerido");
                return false;
            }

            foreach (DataGridViewRow item in this.dtSell.Rows)
            {
                if (item.Cells["ProductId"].Value != null)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                this.errorProduct.SetError(this.dtSell, "Debe añadir productos");
                MessageBox.Show("Debe añadir productos");
                return false;
            }

            return true;
        }

        // Método para limpiar campos

        private void CleanFieldsInserted()
        {
            this.txtInsertUser.Text = string.Empty;
            this.txtInsertClient.Text = string.Empty;
            this.txtInsertAmount.Text = "0";
            this.txtInsertTotal.Text = string.Empty;
            this.dtDateIn.Text = DateTime.Now.ToString();
            this.dtSell.Rows.Clear();

        } 
        #endregion

        #region Public Methods

        // Método para añadir producto

        public void AddProduct(Product product)
        {
            if (product.Quantity > 0)
            {
                this.dtSell.Rows.Add(product.ProductId, product.ProductName, product.Price);
                var amount = Convert.ToDecimal(this.txtInsertAmount.Text, CultureInfo.InvariantCulture) + product.Price;
                this.txtInsertAmount.Text = amount.ToString(CultureInfo.InvariantCulture);
                var total = amount * (decimal)1.21;
                this.txtInsertTotal.Text = total.ToString(CultureInfo.InvariantCulture);
                _products.Add(product);
            }
            else
            {
                MessageBox.Show("No hay stock disponible de este producto");
                return;
            }
        }

        // Método para añadir cliente

        public void AddClient(Client client)
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

        // Método para insertar venta

        private void btInsertBuy_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                SellTicket sellTicket = new SellTicket()
                {
                    Amount = Convert.ToDecimal(this.txtInsertAmount.Text),
                    Price = Convert.ToDecimal(this.txtInsertTotal.Text),
                    SellTicketDate = DateTime.Parse(this.dtDateIn.Text),
                    SellTicketId = Guid.NewGuid(),
                    Products = _products,
                    ClientId = new Guid(this.ClientId.Text),
                    UserId = new Guid(this.UserId.Text)

                };

                bool hasBeenInserted = BusinessSell.InsertTicket(sellTicket);

                if (hasBeenInserted)
                {
                    CleanFieldsInserted();
                    MessageBox.Show("Venta insertada correctamente");
                    this.dtBuyTickets.DataSource = BusinessSell.GetAllSellTickets().ToList();

                }
                else
                {
                    MessageBox.Show("Error al insertar venta");
                }
            }
        }

        // Método para limpiar campos tras la inserción

        private void btCleanInsert_Click(object sender, EventArgs e)
        {
            CleanFieldsInserted();
        }

        // Método que abre la ventana de productos

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(this);
            viewProducts.ShowDialog();
        }

        // Método que borra de la lista un producto seleccionado

        private void button2_Click(object sender, EventArgs e)
        {
            var rows = this.dtSell.SelectedRows;
            if (rows.Count <= 0)
            {
                MessageBox.Show("Debe seleccionar alguna línea a borrar");
                return;
            }
            foreach (DataGridViewRow item in this.dtSell.SelectedRows)
            {
                var productRemoved = item.Cells["ProductId"].Value.ToString();
                this.dtSell.Rows.RemoveAt(item.Index);
                var getOfList = _products.FirstOrDefault(x => x.ProductId.Equals(new Guid(productRemoved)));
                _products.Remove(getOfList);
            }
        }

        // Método para borrar venta

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtBuyTickets.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessSell.DeleteSellTicket(new Guid(rows.Cells["SellTicketId"].Value.ToString()));

                if (isDeleted)
                {
                    this.dtBuyTickets.DataSource = BusinessSell.GetAllSellTickets().ToList();
                    MessageBox.Show("Venta borrada correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando venta");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }     
                

        // Método que abre la ventana de clientes

        private void btSearchSupplier_Click(object sender, EventArgs e)
        {
            ViewClient viewClient = new ViewClient(this);
            viewClient.ShowDialog();
        }

        // Método que abre la ventana de usuarios

        private void btSearchUser_Click_1(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser(this);
            viewUser.ShowDialog();
        }

        // Método para buscar venta

        private void searchTicket(object sender, EventArgs e)
        {
            this.dtBuyTickets.DataSource = BusinessSell.SearchSellTickets(this.txtSearchBuy.Text);
        }
    }
}

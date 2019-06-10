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
using BusinessLogic;
using DataAccess.Entities;

namespace EaSystem
{

    public partial class Buys : Form
    {
        readonly List<Product> _products = new List<Product>();

        public Buys()
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

        // Método para añadir proveedor

        public void AddSupplier(Supplier supplier)
        {
            this.txtInsertSupplier.Text = supplier.SupplierName;
            this.SupplierId.Text = supplier.SupplierId.ToString();
            this.txtInsertSupplier.Enabled = false;
        }

        // Método para añadir usuario

        public void AddUser(User user)
        {
            this.txtInsertUser.Text = user.UserName;
            this.UserId.Text = user.UserId.ToString();
            this.txtInsertUser.Enabled = false;
        }
        #endregion

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

            if (this.txtInsertSupplier.Text.Equals(string.Empty))
            {
                this.errorSupplier.SetError(this.txtInsertSupplier, "El campo proveedor es requerido");
                MessageBox.Show("El campo proveedor es requerido");
                return false;
            }

            foreach (DataGridViewRow item in this.dtBuy.Rows)
            {
                if (item.Cells["ProductId"].Value != null)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                this.errorAdd.SetError(this.dtBuy, "Debe añadir productos");
                MessageBox.Show("Debe añadir productos");
                return false;
            }

            return true;
        }

        // Método para limpiar campos de inserción

        private void CleanFieldsInserted()
        {
            this.txtInsertUser.Text = string.Empty;
            this.txtInsertSupplier.Text = string.Empty;
            this.txtInsertAmount.Text = "0";
            this.txtInsertTotal.Text = string.Empty;
            this.dtDateIn.Text = DateTime.Now.ToString();
            this.dtBuy.Rows.Clear();

        }
        #endregion

        #region Event Methods

        //Método que abre la ventana de productos

        private void button1_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(this);
            viewProducts.ShowDialog();
        }

        // Método que borra de la lista el producto seleccionado

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
                var getOfList = _products.FirstOrDefault(x => x.ProductId.Equals(new Guid(productRemoved)));
                _products.Remove(getOfList);
            }

        }

        // Método que abre la ventana de usuarios

        private void btSearchUser_Click(object sender, EventArgs e)
        {
            ViewUser viewUser = new ViewUser(this);
            viewUser.ShowDialog();
        }

        // Método que abre la ventana de proveedores

        private void btSearchSupplier_Click(object sender, EventArgs e)
        {
            ViewSupplier viewSupplier = new ViewSupplier(this);
            viewSupplier.ShowDialog();
        }

        // Método que inserta una compra

        private void btInsertBuy_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                BuyTicket buyTicket = new BuyTicket()
                {
                    Amount = Convert.ToDecimal(this.txtInsertAmount.Text),
                    Price = Convert.ToDecimal(this.txtInsertTotal.Text),
                    BuyTicketDate = DateTime.Parse(this.dtDateIn.Text),
                    BuyTicketId = Guid.NewGuid(),
                    Products = _products,
                    SupplierId = new Guid(this.SupplierId.Text),
                    UserId = new Guid(this.UserId.Text)

                };

                bool hasBeenInserted = BussinesBuy.InsertTicket(buyTicket);

                if (hasBeenInserted)
                {
                    CleanFieldsInserted();
                    MessageBox.Show("Compra insertada correctamente");
                    this.dtBuyTickets.DataSource = BussinesBuy.GetAllBuyTickets().ToList();

                }
                else
                {
                    MessageBox.Show("Error al insertar compra");
                }
            }
        }

        // Botón para eliminar una compra

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtBuyTickets.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BussinesBuy.DeleteBuyTicket(new Guid(rows.Cells["BuyTicketId"].Value.ToString()));

                if (isDeleted)
                {
                    this.dtBuyTickets.DataSource = BussinesBuy.GetAllBuyTickets().ToList();
                    MessageBox.Show("Compra borrada correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando compra");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        // Limpiar campos de la inserción

        private void btCleanInsert_Click(object sender, EventArgs e)
        {
            CleanFieldsInserted();
        }

        private void Buys_Load(object sender, EventArgs e)
        {
            this.dtBuyTickets.DataSource = BussinesBuy.GetAllBuyTickets().ToList();
        }

        private void SearchBuyTicket(object sender, EventArgs e)
        {
            this.dtBuyTickets.DataSource = BussinesBuy.SearchBuyTickets(this.txtSearchBuy.Text);
        } 
        #endregion
    }
}

using BusinessLogic;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EaSystem
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<Product> products = BusinessProduct.GetAllProducts().ToList();
            this.dtgridProduct.DataSource = products;
            for (int i = 0; i < dtgridProduct.Rows.Count; i++)
            {
                dtgridProduct.Rows[i].Cells["SubcategoryName"].Value = products[i].Subcategory.SubcategoryName;
            }

            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtProductName.Text = string.Empty;
            this.txtProductDescripcion.Text = string.Empty;
            this.txtPrecioProducto.Text = string.Empty;
            this.txtEarns.Text = string.Empty;
            this.comboProduct.Text = string.Empty;
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtProductName.Enabled = false;
            this.txtProductDescripcion.Enabled = false;
            this.txtPrecioProducto.Enabled = false;
            this.txtEarns.Enabled = false;
            this.comboProduct.Enabled = false;
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtProductName.Enabled = true;
            this.txtProductDescripcion.Enabled = true;
            this.txtPrecioProducto.Enabled = true;
            this.txtEarns.Enabled = true;
            this.comboProduct.Enabled = true;
        }


        // Método valida los campos al insertar

        private bool ValidateField()
        {

            if (this.txtInsertProduct.Text.Equals(string.Empty) || this.txtInsertProduct.Text.Length > 25 || this.txtInsertProduct.Text.Length < 1)
            {
                this.errorInsertProduct.SetError(this.txtInsertProduct, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo producto es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            if (this.txtInsertPDescription.Text.Equals(string.Empty))
            {
                this.errorInsertDescription.SetError(this.txtInsertPDescription, "El campo descripcion es requerido");
                MessageBox.Show("El campo descripcion es requerido");
                return false;
            }
            decimal price;
            bool isDecimal = decimal.TryParse(this.txtInsertPrize.Text, out price);

            if (this.txtInsertPrize.Text.Equals(string.Empty) || !isDecimal)
            {
                this.errorInsertPrice.SetError(this.txtInsertPrize, "El campo precio es requerido y debe ser un número");
                MessageBox.Show("El campo precio es requerido y debe ser un número");
                return false;
            }
            double earn;
            bool isDouble = double.TryParse(this.txtInsertEarns.Text, out earn);

            if (this.txtInsertEarns.Text.Equals(string.Empty) || !isDouble)
            {
                this.errorInsertEarns.SetError(this.txtInsertEarns, "El campo margen es requerido y debe ser un número");
                MessageBox.Show("El campo margen es requerido y debe ser un número");
                return false;
            }
            if (this.comboInsertSubcategory.Text.Equals(string.Empty))
            {
                this.errorInsertSubcategory.SetError(this.comboInsertSubcategory, "Debe elegir una subcategoría");
                MessageBox.Show("Debe elegir una subcategoría");
                return false;
            }
            return true;
        }

        // Método para validar campos al actualizar

        private bool ValidateFieldUpdate()
        {

            if (this.txtProductName.Text.Equals(string.Empty) || this.txtProductName.Text.Length > 25 || this.txtProductName.Text.Length < 1)
            {
                this.errorProduct.SetError(this.txtProductName, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo producto es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            if (this.txtProductDescripcion.Text.Equals(string.Empty))
            {
                this.errorDescription.SetError(this.txtProductDescripcion, "El campo descripcion es requerido");
                MessageBox.Show("El campo descripcion es requerido");
                return false;
            }
            decimal price;
            bool isDecimal = decimal.TryParse(this.txtPrecioProducto.Text, out price);

            if (this.txtPrecioProducto.Text.Equals(string.Empty) || !isDecimal)
            {
                this.errorPrice.SetError(this.txtInsertPrize, "El campo precio es requerido y debe ser un número");
                MessageBox.Show("El campo precio es requerido y debe ser un número");
                return false;
            }
            double earn;
            bool isDouble = double.TryParse(this.txtEarns.Text, out earn);

            if (this.txtEarns.Text.Equals(string.Empty) || !isDouble)
            {
                this.errorEarns.SetError(this.txtEarns, "El campo margen es requerido y debe ser un número");
                MessageBox.Show("El campo margen es requerido y debe ser un número");
                return false;
            }
            if (this.comboProduct.Text.Equals(string.Empty))
            {
                this.errorSubcategory.SetError(this.comboProduct, "Debe elegir una subcategoría");
                MessageBox.Show("Debe elegir una subcategoría");
                return false;
            }
            return true;
        }


        #endregion

        #region Event Methods

        // Método que carga campos

        private void Products_Load(object sender, EventArgs e)
        {

            RefreshDataGridView();
            IEnumerable<DataAccess.Entities.Subcategory> subcategories = BusinessSubcategory.GetAllSubcategories().ToList();
            comboInsertSubcategory.DataSource = subcategories;
            comboInsertSubcategory.DisplayMember = "SubcategoryName";
            comboInsertSubcategory.ValueMember = "SubcategoryId";

        }

        // Método que actualiza productos

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateFieldUpdate())
            {
                Product product = new Product
                {
                    ProductName = this.txtProductName.Text,
                    ProductDescription = this.txtProductDescripcion.Text,
                    ProductId = new Guid(this.lbId.Text),
                    Price = Convert.ToDecimal(this.txtPrecioProducto.Text),
                    Earns = Convert.ToDouble(this.txtEarns.Text),
                    SubcategoryId = new Guid(this.comboProduct.SelectedValue.ToString())
                };
                bool isUpdated = BusinessProduct.UpdateProduct(product);
                if (isUpdated)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Producto actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error actualizando los campos del producto");
                }
            }
        }

        // Método que elimina un producto

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtgridProduct.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessProduct.DeleteProduct(new Guid(rows.Cells["ProductId"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Producto borrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando producto");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        // Método que limpia los campos

        private void button2_Click(object sender, EventArgs e)
        {
            CleanFields();
            DisabledFields();
        }

        // Método que hace los campos editables

        private void ClickProduct(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            IEnumerable<DataAccess.Entities.Subcategory> subcategories = BusinessSubcategory.GetAllSubcategories().ToList();
            comboProduct.DataSource = subcategories;
            comboProduct.DisplayMember = "SubcategoryName";
            comboProduct.ValueMember = "SubcategoryId";
            var rows = this.dtgridProduct.CurrentRow;
            if (rows != null)
            {
                this.txtProductName.Text = rows.Cells["ProductName"].Value.ToString(); ;
                this.txtProductDescripcion.Text = rows.Cells["ProductDescription"].Value.ToString(); ;
                this.lbId.Text = rows.Cells["ProductId"].Value.ToString();
                this.txtEarns.Text = rows.Cells["Earns"].Value.ToString();
                this.txtPrecioProducto.Text = rows.Cells["Price"].Value.ToString();
                this.comboProduct.Text = rows.Cells["SubcategoryName"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        // Método que busca un producto

        private void SearchProduct(object sender, EventArgs e)
        {
            this.dtgridProduct.DataSource = BusinessProduct.SearchProducts(this.txtProductSearch.Text);
        }

        // Método para insertar un producto

        private void btInsertProduct_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                Product product = new Product
                {
                    ProductName = this.txtInsertProduct.Text,
                    ProductDescription = this.txtInsertPDescription.Text,
                    ProductId = Guid.NewGuid(),
                    Price = Convert.ToDecimal(this.txtInsertPrize.Text),
                    Earns = Convert.ToDouble(this.txtInsertEarns.Text),
                    SubcategoryId = new Guid(this.comboInsertSubcategory.SelectedValue.ToString())
                };

                bool hasBeenInserted = BusinessProduct.InsertProduct(product);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Producto insertado correctamente");
                    this.txtInsertProduct.Text = String.Empty;
                    this.txtInsertPDescription.Text = String.Empty;
                    this.txtInsertPrize.Text = String.Empty;
                    this.txtInsertEarns.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("Error al insertar producto");
                }

            }
        }

        // Método para insertar un producto

        private void btCleanProduct_Click(object sender, EventArgs e)
        {
            this.txtInsertProduct.Text = String.Empty;
            this.txtInsertPDescription.Text = String.Empty;
            this.txtInsertPrize.Text = String.Empty;
            this.txtInsertEarns.Text = String.Empty;
        }
        #endregion




    }
}

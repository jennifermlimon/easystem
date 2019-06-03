using BusinessLogic;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                dtgridProduct.Rows[i].Cells["Subcategory"].Value = products[i].Subcategory.SubcategoryName;
            }

            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtProductName.Text = string.Empty;
            this.txtProductDescripcion.Text = string.Empty;
            this.txtPrecioProducto.Text = string.Empty;
           // this.txtAmount.Text = string.Empty;
            this.txtEarns.Text = string.Empty;
            this.comboProduct.Text = string.Empty;
            //this.dtIn.Text = DateTime.Now.ToString();
            //this.dtOut.Text = DateTime.Now.ToString();
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtProductName.Enabled = false;
            this.txtProductDescripcion.Enabled = false;
            this.txtPrecioProducto.Enabled = false;
            //this.txtAmount.Enabled = false;
            this.txtEarns.Enabled = false;
            this.comboProduct.Enabled = false;
            //this.dtIn.Enabled = false;
           // this.dtOut.Enabled = false;
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtProductName.Enabled = true;
            this.txtProductDescripcion.Enabled = true;
            this.txtPrecioProducto.Enabled = true;
           // this.txtAmount.Enabled = true;
            this.txtEarns.Enabled = true;
            this.comboProduct.Enabled = true;
            //this.dtIn.Enabled = true;
            //this.dtOut.Enabled = true;
        }


        // Método valida los campos al insertar

        //private bool ValidateField()
        //{

        //    if (this.txt.Text.Equals(string.Empty) || this.txtInsertarSubcategoria.Text.Length > 25 || this.txtInsertarSubcategoria.Text.Length < 1)
        //    {
        //        this.errorInsertSubcategory.SetError(this.txtInsertarSubcategoria, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
        //        MessageBox.Show("El campo subcategoría es requerido y debe tener entre 1 y 25 caracteres");
        //        return false;
        //    }
        //    if (this.comboInsert.Text.Equals(string.Empty))
        //    {
        //        this.errorInsertCatSubcategory.SetError(this.comboInsert, "El campo nombre es requerido");
        //        MessageBox.Show("El campo categoría es requerido");
        //        return false;
        //    }
        //    return true;
        //}

        // Método para validar campos al actualizar

        //private bool ValidateFieldUpdate()
        //{

        //    if (this.txtSubcategoryName.Text.Equals(string.Empty) || this.txtSubcategoryName.Text.Length > 25 || this.txtSubcategoryName.Text.Length < 1)
        //    {
        //        this.errorSubcategoryName.SetError(this.txtSubcategoryName, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
        //        MessageBox.Show("El campo subcategoría es requerido y debe tener entre 1 y 25 caracteres");
        //        return false;
        //    }
        //    if (this.comboSubcategory.Text.Equals(string.Empty))
        //    {
        //        this.errorSubcategoryCategory.SetError(this.comboSubcategory, "El campo nombre es requerido");
        //        MessageBox.Show("El campo categoría es requerido");
        //        return false;
        //    }
        //    return true;
        //}


        #endregion

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
            bool isValid = true;// ValidateField();

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

        


    }
}

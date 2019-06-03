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

        private void Products_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }
    }
}

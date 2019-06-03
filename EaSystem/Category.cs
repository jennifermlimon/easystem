using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CategoryForm = DataAccess.Entities.Category;

namespace EaSystem
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<CategoryForm> categories = BusinessCategory.GetAllCategories().ToList();
            this.dtgridCatgory.DataSource = categories;
            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtCategoryName.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;            
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtCategoryName.Enabled = false;
            this.txtDescripcion.Enabled = false;           
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtCategoryName.Enabled = true;
            this.txtDescripcion.Enabled = true;           
        }

        // Método valida los campos al insertar

        private bool ValidateField()
        {

            if (this.txtInsertarCategoria.Text.Equals(string.Empty) || this.txtInsertarCategoria.Text.Length > 25 || this.txtInsertarCategoria.Text.Length < 1)
            {
                this.errorCategory.SetError(this.txtInsertarCategoria, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo categoría es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            return true;
        }

        private bool ValidateFieldUpdate()
        {

            if (this.txtCategoryName.Text.Equals(string.Empty) || this.txtCategoryName.Text.Length > 25 || this.txtCategoryName.Text.Length < 1)
            {
                this.errorCategoryUpdate.SetError(this.txtCategoryName, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo categoría es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            return true;
        }

        #endregion

        #region Event Methods

        // Método para actualizar categoría

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm
            {
                CategoryName = this.txtCategoryName.Text,
                CategoryDescription = this.txtDescripcion.Text,
                CategoryId = new Guid(this.lbId.Text),
            };
            bool isUpdated = BusinessCategory.UpdateCategory(category);
            if (isUpdated)
            {
                RefreshDataGridView();
                CleanFields();
                MessageBox.Show("Categoría actualizada correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error actualizando los campos de la categoría");
            }
        }

        // Método para eliminar categoría

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtgridCatgory.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessCategory.DeleteCategory(new Guid(rows.Cells["CategoryId"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Categoría borrada correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando categoría");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        // Método para limpiar y deshabilitar campos

        private void button2_Click(object sender, EventArgs e)
        {
            CleanFields();
            DisabledFields();
        }
        // Método para buscar categoría

        private void SearchCategory(object sender, EventArgs e)
        {
            this.dtgridCatgory.DataSource = BusinessCategory.SearchCategory(this.txtSearch.Text);
        }

        //Método para insertar categoría

        private void btInsert_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                CategoryForm category = new CategoryForm
                {
                    CategoryName = this.txtInsertarCategoria.Text,
                    CategoryDescription = this.txtInsertarDescripcion.Text,
                    CategoryId = Guid.NewGuid()
                };

                bool hasBeenInserted = BusinessCategory.InsertCategory(category);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Categoría insertada correctamente");

                }
                else
                {
                    MessageBox.Show("Error al insertar categoria");
                }
            }
        }

        // Método para limpiar campos

        private void btClean_Click(object sender, EventArgs e)
        {
            this.txtInsertarCategoria.Text = string.Empty;
            this.txtInsertarDescripcion.Text = string.Empty;
        }

        // Método para editar categoría

        private void EditCategory(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            var rows = this.dtgridCatgory.CurrentRow;
            if (rows != null)
            {
                this.txtCategoryName.Text = rows.Cells["CategoryName"].Value.ToString(); ;
                this.txtDescripcion.Text = rows.Cells["CategoryDescription"].Value.ToString(); ;               
                this.lbId.Text = rows.Cells["CategoryId"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        #endregion
    }
}

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
    public partial class Subcategories : Form
    {
        public Subcategories()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<Subcategory> subcategories = BusinessSubcategory.GetAllSubcategories().ToList();
            this.dtgridSubcatgory.DataSource = subcategories;
            for (int i = 0; i < dtgridSubcatgory.Rows.Count; i++)
            {
                dtgridSubcatgory.Rows[i].Cells["Category"].Value = subcategories[i].Category.CategoryName;                
            }

            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtSubcategoryName.Text = string.Empty;
            this.txtSubcategoryDescripcion.Text = string.Empty;
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtSubcategoryName.Enabled = false;
            this.txtSubcategoryDescripcion.Enabled = false;
            this.comboSubcategory.Enabled = false;
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtSubcategoryName.Enabled = true;
            this.txtSubcategoryDescripcion.Enabled = true;
            this.comboSubcategory.Enabled = true;
        }

        // Método valida los campos al insertar

        private bool ValidateField()
        {

            if (this.txtInsertarSubcategoria.Text.Equals(string.Empty) || this.txtInsertarSubcategoria.Text.Length > 25 || this.txtInsertarSubcategoria.Text.Length < 1)
            {
                this.errorInsertSubcategory.SetError(this.txtInsertarSubcategoria, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo subcategoría es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            if (this.comboInsert.Text.Equals(string.Empty))
            {
                this.errorInsertCatSubcategory.SetError(this.comboInsert, "El campo nombre es requerido");
                MessageBox.Show("El campo categoría es requerido");
                return false;
            }
            return true;
        }

        // Método para validar campos al actualizar

        private bool ValidateFieldUpdate()
        {

            if (this.txtSubcategoryName.Text.Equals(string.Empty) || this.txtSubcategoryName.Text.Length > 25 || this.txtSubcategoryName.Text.Length < 1)
            {
                this.errorSubcategoryName.SetError(this.txtSubcategoryName, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo subcategoría es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            if (this.comboSubcategory.Text.Equals(string.Empty))
            {
                this.errorSubcategoryCategory.SetError(this.comboSubcategory, "El campo nombre es requerido");
                MessageBox.Show("El campo categoría es requerido");
                return false;
            }
            return true;
        }

        #endregion

        #region Event Methods
        // Método para actualizar la subcategoría

        private void button1_Click(object sender, EventArgs e)
        {

            Subcategory subcategory = new Subcategory
            {

                SubcategoryName = this.txtSubcategoryName.Text,
                SubcategoryDescription = this.txtSubcategoryDescripcion.Text,
                SubcategoryId = new Guid(this.lbId.Text),
                CategoryId = new Guid(this.comboSubcategory.SelectedValue.ToString())
            };
            bool isUpdated = BusinessSubcategory.UpdateSubcategory(subcategory);
            if (isUpdated)
            {
                RefreshDataGridView();
                CleanFields();
                MessageBox.Show("Subcategoría actualizada correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error actualizando los campos de la subcategoría");
            }
        }

        // Método para eliminar subcategoría

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtgridSubcatgory.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessSubcategory.DeleteSubcategory(new Guid(rows.Cells["SubcategoryId"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Subcategoría borrada correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando subcategoría");
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

        // Método para buscar subcategoría

        private void SearchSucategory(object sender, EventArgs e)
        {
            this.dtgridSubcatgory.DataSource = BusinessSubcategory.SearchSubcategory(this.txtSubcatgorySearch.Text);
            List<Subcategory> subcategories = BusinessSubcategory.GetAllSubcategories().ToList();

            foreach (DataGridViewRow item in dtgridSubcatgory.Rows)
            {
                foreach (var subitem in subcategories)
                {
                    item.Cells["Category"].Value = subitem.Category.CategoryName;
                }
            }
        }

        // Método para editar una subcategoria

        private void SubcategoryClick(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            IEnumerable<DataAccess.Entities.Category> categories = BusinessCategory.GetAllCategories().ToList();
            comboSubcategory.DataSource = categories;
            comboSubcategory.DisplayMember = "CategoryName";
            comboSubcategory.ValueMember = "CategoryId";

            var rows = this.dtgridSubcatgory.CurrentRow;
            if (rows != null)
            {
                this.txtSubcategoryName.Text = rows.Cells["SubcategoryName"].Value.ToString();
                this.txtSubcategoryDescripcion.Text = rows.Cells["SubcategoryDescription"].Value.ToString();
                this.lbId.Text = rows.Cells["SubcategoryId"].Value.ToString();
                this.comboSubcategory.Text = rows.Cells["Category"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void Subcategories_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            IEnumerable<DataAccess.Entities.Category> categories = BusinessCategory.GetAllCategories().ToList();
            comboInsert.DataSource = categories;
            comboInsert.DisplayMember = "CategoryName";
            comboInsert.ValueMember = "CategoryId";
        }

        // Método para insertar subcategoría

        private void btInsertSubcategory_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                string categoryId = this.comboInsert.SelectedValue.ToString();
                Subcategory subcategory = new Subcategory
                {
                    SubcategoryName = this.txtInsertarSubcategoria.Text,
                    SubcategoryDescription = this.txtInsertarSubDescripcion.Text,
                    SubcategoryId = Guid.NewGuid(),
                    CategoryId = new Guid(categoryId)
                };

                bool hasBeenInserted = BusinessSubcategory.InsertSubcategory(subcategory);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    this.txtInsertarSubcategoria.Text = string.Empty;
                    this.txtInsertarSubDescripcion.Text = string.Empty;
                    MessageBox.Show("Subcategoría insertada correctamente");

                }
                else
                {
                    MessageBox.Show("Error al insertar subcategoria");
                }
            }
        }

        // Método para limpiar campos

        private void btCleanSubcatgory_Click(object sender, EventArgs e)
        {
            this.txtInsertarSubcategoria.Text = string.Empty;
            this.txtInsertarSubDescripcion.Text = string.Empty;
        } 
        #endregion

    }
}

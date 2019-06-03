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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<Supplier> supplier = BusinessSupplier.GetAllSuppliers().ToList();
            this.dtgridSupplier.DataSource = supplier;
            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanInsertFields()
        {
            this.txtInsertName.Text = string.Empty;
            this.txtInsertCif.Text = string.Empty;
            this.txtInsertPhone.Text = string.Empty;
            this.txtInsertMail.Text = string.Empty;
            this.txtInsertAddress.Text = string.Empty;
        }      
        private void CleanFields()
        {
            this.txtNameSupplier.Text = string.Empty;
            this.txtCIF.Text = string.Empty;
            this.txtAddressSupplier.Text = string.Empty;
            this.txtMailSupplier.Text = string.Empty;
            this.txtPhoneSupplier.Text = string.Empty;
            this.txtSearchSupplier.Text = string.Empty;
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtAddressSupplier.Enabled = false;
            this.txtCIF.Enabled = false;
            this.txtMailSupplier.Enabled = false;
            this.txtNameSupplier.Enabled = false;
            this.txtPhoneSupplier.Enabled = false;            
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtAddressSupplier.Enabled = true;
            this.txtCIF.Enabled = true;
            this.txtMailSupplier.Enabled = true;
            this.txtNameSupplier.Enabled = true;
            this.txtPhoneSupplier.Enabled = true;
        }

        // Método valida los campos al insertar o actualizar

        private bool ValidateField()
        {

            if (this.txtInsertName.Text.Equals(string.Empty) || this.txtInsertName.Text.Length > 25 || this.txtInsertName.Text.Length < 1)
            {
                this.errorName.SetError(this.txtInsertName, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }           
            if (this.txtInsertPhone.Text.Equals(string.Empty) || this.txtInsertPhone.Text.Length > 13 || this.txtInsertPhone.Text.Length < 9)
            {
                this.errorPhone.SetError(this.txtInsertPhone, "El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                MessageBox.Show("El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                return false;
            }
            if (this.txtInsertCif.Text.Equals(string.Empty) || this.txtInsertCif.Text.Length != 9)
            {
                this.errorCif.SetError(txtInsertCif, "Campo requerido de 9 caracteres");
                MessageBox.Show("El campo Cif es requerido y debe tener 9 caracteres");
                return false;
            }
            if (this.txtInsertMail.Text.Equals(string.Empty) || !this.txtInsertMail.Text.Contains("@") || this.txtInsertMail.Text.Length > 50 || this.txtInsertMail.Text.Length < 7)
            {
                this.errorEmail.SetError(this.txtInsertMail, "El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                MessageBox.Show("El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                return false;
            }
            if (this.txtInsertAddress.Text.Equals(string.Empty) || this.txtInsertAddress.Text.Length > 50 || this.txtInsertAddress.Text.Length < 1)
            {
                this.errorAddress.SetError(this.txtInsertAddress, "El campo dirección debe tener entre 1 y 50 caracteres");
                MessageBox.Show("El campo dirección debe tener entre 1 y 50 caracteres");
                return false;
            }
            return true;
        }
        private bool ValidateFieldUpdate()
        {
            if (this.txtNameSupplier.Text.Equals(string.Empty) || this.txtNameSupplier.Text.Length > 25 || this.txtNameSupplier.Text.Length < 1)
            {
                this.errorUpdateName.SetError(this.txtNameSupplier, "El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                MessageBox.Show("El campo nombre es requerido y debe tener entre 1 y 25 caracteres");
                return false;
            }
            if (this.txtPhoneSupplier.Text.Equals(string.Empty) || this.txtPhoneSupplier.Text.Length > 13 || this.txtPhoneSupplier.Text.Length < 9)
            {
                this.errorUpdatePhone.SetError(this.txtPhoneSupplier, "El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                MessageBox.Show("El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                return false;
            }
            if (this.txtCIF.Text.Equals(string.Empty) || this.txtCIF.Text.Length != 9)
            {
                this.errorUpdateCif.SetError(txtCIF, "Campo requerido de 9 caracteres");
                MessageBox.Show("El campo Cif es requerido y debe tener 9 caracteres");
                return false;
            }
            if (this.txtMailSupplier.Text.Equals(string.Empty) || !this.txtMailSupplier.Text.Contains("@") || this.txtMailSupplier.Text.Length > 50 || this.txtMailSupplier.Text.Length < 7)
            {
                this.errorUpdateEmail.SetError(this.txtMailSupplier, "El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                MessageBox.Show("El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                return false;
            }
            if (this.txtAddressSupplier.Text.Equals(string.Empty) || this.txtAddressSupplier.Text.Length > 50 || this.txtAddressSupplier.Text.Length < 1)
            {
                this.errorUpdateAddress.SetError(this.txtAddressSupplier, "El campo dirección debe tener entre 1 y 50 caracteres");
                MessageBox.Show("El campo dirección debe tener entre 1 y 50 caracteres");
                return false;
            }
            return true;

        }

        #endregion

        #region EventMethos

        //Evento de carga

        private void Suppliers_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }      

        //Método para actualizar proveedor

        private void btUpdateSupplier_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier()
            {
                SupplierName = this.txtNameSupplier.Text,
                SupplierCif = this.txtCIF.Text,
                SupplierEmail = this.txtMailSupplier.Text,
                SupplierAdress = this.txtAddressSupplier.Text,
                SupplierTelephone = this.txtPhoneSupplier.Text,
                SupplierId = new Guid(this.lbId.Text)
            };
            bool isUpdated = BusinessSupplier.UpdateSupplier(supplier);
            if (isUpdated)
            {
                RefreshDataGridView();
                CleanFields();
                MessageBox.Show("Proveedor actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error actualizando los campos del proveedor");
            }
        }

        //Método para borrar proveedor

        private void btDeleteSupplier_Click(object sender, EventArgs e)
        {
            var rows = this.dtgridSupplier.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessSupplier.DeleteSupplier(new Guid(rows.Cells["Id"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Proveedor borrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando proveedor");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        //Método para limpiar campos

        private void btCleanSupplier_Click(object sender, EventArgs e)
        {
            CleanFields();
            DisabledFields();
        }

        //Método para buscar proveedor

        private void searchSupplier(object sender, EventArgs e)
        {
            this.dtgridSupplier.DataSource = BusinessSupplier.SearchSupplier(this.txtSearchSupplier.Text);
        }

        //Método para insertar proveedor

        private void btInsert_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                Supplier supplier = new Supplier()
                {
                    SupplierName = this.txtInsertName.Text,
                    SupplierCif = this.txtInsertCif.Text,
                    SupplierEmail = this.txtInsertMail.Text,
                    SupplierAdress = this.txtInsertAddress.Text,
                    SupplierTelephone = this.txtInsertPhone.Text,
                    SupplierId = Guid.NewGuid()
                };
                var hasBeenInserted = BusinessSupplier.InsertSupplier(supplier);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Proveedor insertado correctamente");
                    CleanInsertFields();
                }
                else
                {
                    MessageBox.Show("Error al insertar proveedor");
                }
            }
        }

        //Método para limpiar campos de inserción

        private void btClean_Click(object sender, EventArgs e)
        {
            this.txtInsertName.Text = string.Empty;
            this.txtInsertCif.Text = string.Empty;
            this.txtInsertPhone.Text = string.Empty;
            this.txtInsertMail.Text = string.Empty;
            this.txtInsertAddress.Text = string.Empty;
        }

        //Método para asignar datos a los campos con doble click

        private void setSupplier(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            var rows = this.dtgridSupplier.CurrentRow;
            if (rows != null)
            {
                this.txtAddressSupplier.Text = rows.Cells["Address"].Value.ToString(); ;
                this.txtMailSupplier.Text = rows.Cells["Mail"].Value.ToString(); ;
                this.txtNameSupplier.Text = rows.Cells["SupplierName"].Value.ToString();
                this.txtCIF.Text = rows.Cells["Cif"].Value.ToString();
                this.txtPhoneSupplier.Text = rows.Cells["Phone"].Value.ToString();
                this.lbId.Text = rows.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        #endregion

    
    }
}

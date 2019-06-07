using BusinessLogic;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EaSystem
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<Client> customer = BusinessCustomer.GetAllCustomer().ToList();
            this.dtgridCustomer.DataSource = customer;
            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtAddress.Text = string.Empty;
            this.txtMail.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtNIF.Text = string.Empty;
            this.txtSurname1.Text = string.Empty;
            this.txtSurname2.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.dtBirthDate.Text = DateTime.Now.ToString();
        }

        private void CleanFieldsInserted()
        {
            this.txtInsertAddress.Text = string.Empty;
            this.txtInsertPhone.Text = string.Empty;
            this.txtInsertName.Text = string.Empty;
            this.txtInsertNif.Text = string.Empty;
            this.txtInsertMail.Text = string.Empty;
            this.txtInsertSurname1.Text = string.Empty;
            this.txtInsertSurname2.Text = string.Empty;
            this.dtBirthDate.Text = DateTime.Now.ToString();
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtAddress.Enabled = false;
            this.txtMail.Enabled = false;
            this.txtName.Enabled = false;
            this.txtNIF.Enabled = false;
            this.txtSurname1.Enabled = false;
            this.txtSurname2.Enabled = false;
            this.txtPhone.Enabled = false;
            this.dtBirthDate.Enabled = false;
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtAddress.Enabled = true;
            this.txtMail.Enabled = true;
            this.txtName.Enabled = true;
            this.txtNIF.Enabled = true;
            this.txtSurname1.Enabled = true;
            this.txtSurname2.Enabled = true;
            this.txtPhone.Enabled = true;
            this.dtBirthDate.Enabled = true;
        }

        // Método valida los campos al insertar

        private bool ValidateField()
        {

            if (this.txtInsertName.Text.Equals(string.Empty) || this.txtInsertName.Text.Length > 25 || this.txtInsertName.Text.Length < 3)
            {
                this.errorName.SetError(this.txtInsertName, "El campo nombre es requerido y debe tener entre 3 y 25 caracteres");
                MessageBox.Show("El campo nombre es requerido y debe tener entre 3 y 25 caracteres");              
                return false;
            }
            if (this.txtInsertSurname1.Text.Equals(string.Empty) || this.txtInsertSurname1.Text.Length > 25 || this.txtInsertSurname1.Text.Length < 3)
            {
                this.errorSurname.SetError(this.txtInsertSurname1, "El campo apellido es requerido y debe tener entre 3 y 25 caracteres");
                MessageBox.Show("El campo apellido es requerido y debe tener entre 3 y 25 caracteres");
                return false;
            }
            if (this.dtInsertBirthDate.Text.Equals(string.Empty))
            {                
                MessageBox.Show("El campo fecha de nacimiento es requerido");
                return false;
            }
            if (this.txtInsertPhone.Text.Equals(string.Empty) || this.txtInsertPhone.Text.Length > 13 || this.txtInsertPhone.Text.Length < 9)
            {
                this.errorPhone.SetError(this.txtInsertPhone, "El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                MessageBox.Show("El campo teléfono es requerido y debe tener entre 9 y 13 caracteres");
                return false;
            }
            if (this.txtInsertNif.Text.Equals(string.Empty) || this.txtInsertNif.Text.Length != 9)
            {
                this.errorNif.SetError(txtInsertNif, "Campo requerido de 9 caracteres");
                MessageBox.Show("El campo dni es requerido y debe tener 9 caracteres");               
                return false;
            }
            if (this.txtInsertMail.Text.Equals(string.Empty) || !this.txtInsertMail.Text.Contains("@") || this.txtInsertMail.Text.Length > 50 || this.txtInsertMail.Text.Length < 7)
            {
                this.errorMail.SetError(this.txtInsertMail, "El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                MessageBox.Show("El campo email es requerido, contener una @ y debe tener entre 7 y 50 caracteres");
                return false;
            }
            return true;
        }

        //TODO falta por hacer la validación de los campos cuando se actualiza

        #endregion

        #region Event Methods

        //Evento de carga

        private void Customer_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        // Evento del doble click al seleccionar un cliente

        private void EditCustomer(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            var rows = this.dtgridCustomer.CurrentRow;
            if (rows != null)
            {
                this.txtAddress.Text = rows.Cells["Address"].Value.ToString(); ;
                this.txtMail.Text = rows.Cells["Mail"].Value.ToString(); ;
                this.txtName.Text = rows.Cells["ClientName"].Value.ToString();
                this.txtNIF.Text = rows.Cells["dni"].Value.ToString();
                this.txtSurname1.Text = rows.Cells["Surname1"].Value.ToString();
                this.txtSurname2.Text = rows.Cells["Surname2"].Value.ToString();
                this.txtPhone.Text = rows.Cells["Phone"].Value.ToString();
                this.dtBirthDate.Text = rows.Cells["BirthDate"].Value.ToString();
                this.lbId.Text = rows.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }

        }

        // Evento para insertar un nuevo cliente

        private void btInsert_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                Client client = new Client
                {
                    ClientAdress = this.txtInsertAddress.Text,
                    ClientEmail = this.txtInsertMail.Text,
                    ClientName = this.txtInsertName.Text,
                    ClientNif = this.txtInsertNif.Text,
                    ClientSurname1 = this.txtInsertSurname1.Text,
                    ClientSurname2 = this.txtInsertSurname2.Text,
                    CLientTelephone = this.txtInsertPhone.Text,
                    ClientDateOfBirth = DateTime.Parse(this.dtInsertBirthDate.Text),
                    ClientId = Guid.NewGuid()
                };

                var hasBeenInserted = BusinessCustomer.InsertCustomer(client);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Cliente insertado correctamente");
                    CleanFieldsInserted();
                }
                else
                {
                    MessageBox.Show("Error al insertar cliente");
                }
            }
        }

        // Evento de botón para limpiar información de los campos

        private void btClean_Click(object sender, EventArgs e)
        {
            this.txtAddress.Text = string.Empty;
            this.txtMail.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtNIF.Text = string.Empty;
            this.txtSurname1.Text = string.Empty;
            this.txtSurname2.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.dtBirthDate.Text = DateTime.Now.ToString();
        }

        // Evento de botón actualizar un cliente

        private void button1_Click_1(object sender, EventArgs e)
        {
            Client client = new Client
            {
                ClientAdress = this.txtAddress.Text,
                ClientEmail = this.txtMail.Text,
                ClientName = this.txtName.Text,
                ClientNif = this.txtNIF.Text,
                ClientSurname1 = this.txtSurname1.Text,
                ClientSurname2 = this.txtSurname2.Text,
                CLientTelephone = this.txtPhone.Text,
                ClientDateOfBirth = DateTime.Parse(this.dtBirthDate.Text),
                ClientId = new Guid(this.lbId.Text),
            };
            bool isUpdated = BusinessCustomer.UpdateCustomer(client);
            if (isUpdated)
            {
                RefreshDataGridView();
                CleanFields();
                MessageBox.Show("Cliente actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error actualizando los campos del cliente");
            }
        }

        // Evento de botón eliminar un cliente

        private void button3_Click_1(object sender, EventArgs e)
        {
            var rows = this.dtgridCustomer.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessCustomer.DeleteCustomer(new Guid(rows.Cells["Id"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Cliente borrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando cliente");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        // Evento para limpiar campos

        private void button2_Click_1(object sender, EventArgs e)
        {
            CleanFields();
            DisabledFields();
        }

        // Evento cuando escribes en el buscador

        private void SearchByType(object sender, EventArgs e)
        {
            this.dtgridCustomer.DataSource = BusinessCustomer.SearchClient(this.txtSearch.Text);
        }

        #endregion

    }
}


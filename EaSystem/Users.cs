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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        #region Private Methods

        //Método para Refrescar la información de la tabla 

        private void RefreshDataGridView()
        {
            List<User> users = BusinessUser.GetAllUser().ToList();
            this.dtgridUser.DataSource = users;
            DisabledFields();
        }

        //Método para Limpiar la información de los campos de edición

        private void CleanFields()
        {
            this.txtUserName.Text = string.Empty;
            this.txtUserPassword.Text = string.Empty;
        }

        //Método para Limpiar la información de los campos de insercion

        private void CleanInsertFields()
        {
            this.txtUserName.Text = string.Empty;
            this.txtUserPassword.Text = string.Empty;
        }

        // Método que dehabilita los campos

        private void DisabledFields()
        {
            this.txtUserName.Enabled = false;
            this.txtUserPassword.Enabled = false;
        }

        // Método que habilita los campos

        private void EnabledFields()
        {
            this.txtUserName.Enabled = true;
            this.txtUserPassword.Enabled = true;
        }

        // Método valida los campos al insertar usuario

        private bool ValidateField()
        {

            if (this.txtInsertUser.Text.Equals(string.Empty) || this.txtInsertUser.Text.Length > 15 || this.txtInsertUser.Text.Length < 8)
            {
                this.errorUser.SetError(this.txtInsertUser, "El campo usuario es requerido y debe tener entre 8 y 15 caracteres");
                MessageBox.Show("El campo usuario es requerido y debe tener entre 8 y 15 caracteres");
                return false;
            }

            if (this.txtInsertPassword.Text.Equals(string.Empty) || this.txtInsertPassword.Text.Length > 14 || this.txtInsertPassword.Text.Length < 6)
            {
                this.errorPassword.SetError(this.txtInsertPassword, "El campo contraseña es requerido y debe tener entre 6 y 14 caracteres");
                MessageBox.Show("El campo contraseña es requerido y debe tener entre 6 y 14 caracteres");
                return false;
            }
            return true;
        }

        // Método valida los campos al actualizar usuario

        private bool ValidateFieldUpdate()
        {

            if (this.txtUserName.Text.Equals(string.Empty) || this.txtUserName.Text.Length > 15 || this.txtUserName.Text.Length < 8)
            {
                this.errorUpdateUser.SetError(this.txtUserName, "El campo usuario es requerido y debe tener entre 8 y 15 caracteres");
                MessageBox.Show("El campo usuario es requerido y debe tener entre 8 y 15 caracteres");
                return false;
            }
            if (this.txtUserPassword.Text.Equals(string.Empty) || this.txtUserPassword.Text.Length > 14 || this.txtUserPassword.Text.Length < 6)
            {
                this.errorUpdatePassword.SetError(this.txtUserPassword, "El campo contraseña es requerido y debe tener entre 6 y 14 caracteres");
                MessageBox.Show("El campo contraseña es requerido y debe tener entre 6 y 14 caracteres");
                return false;
            }
            return true;
        }

        #endregion

        // Método para actualizar usuario

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserId = new Guid(this.lbId.Text),
                UserName = this.txtUserName.Text,
                UserPassword = this.txtUserPassword.Text
            };
            bool isUpdated = BusinessUser.UpdateUser(user);
            if (isUpdated)
            {
                RefreshDataGridView();
                CleanFields();
                MessageBox.Show("Usuario actualizado correctamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error actualizando los campos del usuario");
            }
        }

        // Método para borrar usuario

        private void button3_Click(object sender, EventArgs e)
        {
            var rows = this.dtgridUser.CurrentRow;
            if (rows != null)
            {
                var isDeleted = BusinessUser.DeleteUser(new Guid(rows.Cells["UserId"].Value.ToString()));

                if (isDeleted)
                {
                    RefreshDataGridView();
                    CleanFields();
                    MessageBox.Show("Usuario borrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error borrando usuario");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila que borrar");
            }
        }

        // Método para limpiar campos usuario

        private void button2_Click(object sender, EventArgs e)
        {
            CleanFields();
            DisabledFields();
        }

        // Método para buscar usuario

        private void SearchUser(object sender, EventArgs e)
        {
            this.dtgridUser.DataSource = BusinessUser.Searchuser(this.txtUserSearch.Text);
        }

        // Método para seleccionar usuario

        private void ClickUser(object sender, DataGridViewCellEventArgs e)
        {
            EnabledFields();
            var rows = this.dtgridUser.CurrentRow;
            if (rows != null)
            {
                this.txtUserName.Text = rows.Cells["UserName"].Value.ToString();
                this.txtUserPassword.Text = rows.Cells["UserPassword"].Value.ToString();
                this.lbId.Text = rows.Cells["UserId"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            bool isValid = ValidateField();

            if (isValid)
            {
                User user = new User
                {
                    UserName = this.txtInsertUser.Text,
                    UserPassword = this.txtInsertPassword.Text,
                    UserId = Guid.NewGuid()
                };

                bool hasBeenInserted = BusinessUser.InsertUser(user);

                if (hasBeenInserted)
                {
                    RefreshDataGridView();
                    MessageBox.Show("Usuario insertado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al insertar usuario");
                }
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            this.txtInsertUser.Text = string.Empty;
            this.txtInsertPassword.Text = string.Empty;
        }

        private void Users_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}

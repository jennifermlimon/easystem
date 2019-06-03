using BusinessLogic;
using System;
using System.Windows.Forms;

namespace EaSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string userName = this.txtUser.Text;
            string password = this.txtPass.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ninguno de los campos puede estar vacío");
            }
            else
            {
                BusinessLogin bLogin = new BusinessLogin(userName, password);
                bool isUserTrue = bLogin.CheckUser();
                if (isUserTrue)
                {
                    MainPannel mPannel = new MainPannel();
                    mPannel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto, póngase en contacto con el administrador");
                    this.txtPass.Text = string.Empty;
                    this.txtUser.Text = string.Empty;

                }
            }          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category customer = new Category();
            customer.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Users suppliers = new Users();
            suppliers.Show();
        }
    }
}

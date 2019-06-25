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
            this.button3.Visible = true;
            this.button3.Enabled = false;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Ninguno de los campos puede estar vacío");
            }
            else
            {
                BusinessLogin bLogin = new BusinessLogin(userName, password);
                bLogin.CreateFirstUser();
                bool isUserTrue = bLogin.CheckUser();
                if (isUserTrue)
                {
                    ControlPanel mPannel = new ControlPanel();
                    mPannel.UserName = userName;
                    mPannel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario Incorrecto, póngase en contacto con el administrador");
                    this.txtPass.Text = string.Empty;
                    this.txtUser.Text = string.Empty;
                    this.button3.Visible = false;
                    this.button3.Enabled = true;
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
           Buys b = new Buys();
           b.Show();
        }
    }
}

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
    public partial class ControlPanel : Form
    {
        public string UserName { get; set; }
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            this.userName.Text = $@"Bienvenido: {UserName}";
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.MdiParent = this.MdiParent;
            user.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

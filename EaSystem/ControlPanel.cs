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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MdiParent = this.MdiParent;
            customer.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.MdiParent = this.MdiParent;
            category.Show();
        }

        private void subcategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subcategories subcategory = new Subcategories();
            subcategory.MdiParent = this.MdiParent;
            subcategory.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers();
            supplier.MdiParent = this.MdiParent;
            supplier.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            product.MdiParent = this.MdiParent;
            product.Show();
        }
    }
}

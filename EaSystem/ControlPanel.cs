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
            Users user = new Users {MdiParent = this.MdiParent};
            user.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer {MdiParent = this.MdiParent};
            customer.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category category = new Category {MdiParent = this.MdiParent};
            category.Show();
        }

        private void subcategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subcategories subcategory = new Subcategories {MdiParent = this.MdiParent};
            subcategory.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers {MdiParent = this.MdiParent};
            supplier.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products product = new Products
            {
                MdiParent = this.MdiParent
            };
            product.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buys buys = new Buys {MdiParent = this.MdiParent};
            buys.Show();
        }

        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stocks stock = new Stocks() {MdiParent  = this.MdiParent};
            stock.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellTickets sellTickets = new SellTickets() {MdiParent = this.MdiParent };
            sellTickets.Show();
        }

        private void nuevaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cashier cashier = BusinessCashier.OpenCashier();
                if (cashier == null) { MessageBox.Show("Error abriendo la caja"); }
                else
                {
                    CurrentCashier currentCashier = new CurrentCashier {MdiParent = this.MdiParent};
                    currentCashier.Show();
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(e.ToString());
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users { MdiParent = this.MdiParent };
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cashier cashier = BusinessCashier.OpenCashier();
                if (cashier == null) { MessageBox.Show("Error abriendo la caja"); }
                else
                {
                    CurrentCashier currentCashier = new CurrentCashier { MdiParent = this.MdiParent };
                    currentCashier.Show();
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers supplier = new Suppliers { MdiParent = this.MdiParent };
            supplier.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SellTickets sellTickets = new SellTickets() { MdiParent = this.MdiParent };
            sellTickets.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buys buys = new Buys { MdiParent = this.MdiParent };
            buys.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer { MdiParent = this.MdiParent };
            customer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stocks stock = new Stocks() { MdiParent = this.MdiParent };
            stock.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Hasta pronto, {UserName}");
            this.Close();
        }

        private void ToolUser(object sender, EventArgs e)
        {
            this.toolUser.Show("Usuarios", this.button1);
        }

        private void ToolCashier(object sender, EventArgs e)
        {
            this.toolCashier.Show("Caja Actual", this.button2);
        }

        private void ToolPartner(object sender, EventArgs e)
        {
            this.toolPartner.Show("Proveedores", this.button3);
        }

        private void ToolSales(object sender, EventArgs e)
        {
            this.toolSell.Show("Ventas", this.button4);
        }

        private void ToolBuys(object sender, EventArgs e)
        {
            this.toolBuys.Show("Compras", this.button5);
        }

        private void ToolCustomer(object sender, EventArgs e)
        {
            this.toolCustomer.Show("Clientes", this.button5);
        }

        private void ToolStock(object sender, EventArgs e)
        {
            this.toolStock.Show("Almacén Stock", this.button6);
        }

        private void ToolExit(object sender, EventArgs e)
        {
            this.toolExit.Show("Salir de la App", this.button7);
        }
    }
}

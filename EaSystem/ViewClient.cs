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

namespace EaSystem
{
    public partial class ViewClient : Form
    {
        SellTickets _sells;
        public ViewClient(SellTickets sellTickets)
        {
            InitializeComponent();
            _sells = sellTickets;
        }

        // Método para seleccionar cliente

        private void selectClient(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var client = BusinessCustomer.GetClientById(new Guid(rows.Cells["ClientId"].Value.ToString()));
            this._sells.AddClient(client);
            this.Hide();
        }

        private void ViewClient_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessCustomer.GetAllCustomer().ToList();
        }
    }
}

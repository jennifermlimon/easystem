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
    public partial class CurrentCashier : Form
    {
        public CurrentCashier()
        {
            InitializeComponent();
        }

        // Método que carga la caja actual

        private void CurrentCashier_Load(object sender, EventArgs e)
        {
            Cashier currentCashier = BusinessCashier.GetCurrentCashier();
            this.dtViewTickets.DataSource = BusinessSell.GetSellTicketsByCashierId(currentCashier.CashierId).ToList();
            this.txtAmount.Text = currentCashier.Amount.ToString();
            this.txtToBank.Text = currentCashier.ToBank.ToString();
            this.dateTimePicker1.Text = currentCashier.OpenDateTime.ToString();
            this.lbIdCashier.Text = currentCashier.CashierId.ToString();
        }
      
        // Método que cierra la caja

        private void button1_Click(object sender, EventArgs e)
        {
            bool isClosed = BusinessCashier.CloseCurrentCashier(new Guid(this.lbIdCashier.Text));
            if (isClosed)
            {
                MessageBox.Show("Caja cerrada correctamente");
                this.Close();
                return;
            }
            MessageBox.Show("Error al cerrar la caja");

        }
    }
}

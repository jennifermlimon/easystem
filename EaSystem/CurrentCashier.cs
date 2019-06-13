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

        private void CurrentCashier_Load(object sender, EventArgs e)
        {
            Cashier currentCashier = BusinessCashier.GetCurrentCashier();
            this.dtViewTickets.DataSource = BusinessSell.GetSellTicketsByCashierId(currentCashier.CashierId).ToList();
            this.txtAmount.Text = currentCashier.Amount.ToString();
            this.txtToBank.Text = currentCashier.ToBank.ToString();
            this.dateTimePicker1.Text = currentCashier.OpenDateTime.ToString();
        }

        private void sellTicketBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

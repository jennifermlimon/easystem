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
    public partial class AllCashiers : Form
    {
        public AllCashiers()
        {
            InitializeComponent();
        }

        // Mñetodo que busca una caja

        private void SearchCashier(object sender, EventArgs e)
        {
            this.dtBuyTickets.DataSource = BusinessCashier.SearchCashiers(this.txtSearchCashier.Text);
        }

        //Método que carga las cajas

        private void AllCashiers_Load(object sender, EventArgs e)
        {
            this.dtBuyTickets.DataSource = BusinessCashier.GetAllCashiers().ToList();
        }
    }
}

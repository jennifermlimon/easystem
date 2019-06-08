using BusinessLogic;
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
    public partial class ViewSupplier : Form
    {
        private readonly Buys _buys;
        public ViewSupplier(Buys buy)
        {
            InitializeComponent();
            this._buys = buy;
        }       

        #region Private Methods
        private void AddSuppliersToList(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var supplier = BusinessSupplier.GetSupplierById(new Guid(rows.Cells["SupplierId"].Value.ToString()));
            this._buys.AddSupplier(supplier);
            this.Hide();
        }

        private void SearchSupplier(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessSupplier.SearchSupplier(this.txtProductSearch.Text);
        }

        private void ViewSupplier_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessSupplier.GetAllSuppliers().ToList();
        }
        #endregion
    }
}

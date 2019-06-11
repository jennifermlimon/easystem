using BusinessLogic;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EaSystem
{
    public partial class ViewUser : Form
    {
        private readonly Buys _buys;
        private readonly SellTickets _sellTickets;
        public ViewUser(Buys buys)
        {
            InitializeComponent();
            _buys = buys;
        }
        public ViewUser(SellTickets sellTickets)
        {
            InitializeComponent();
            _sellTickets = sellTickets;
        }

        private void AddUser(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var user = BusinessUser.GetUserById(new Guid(rows.Cells["UserId"].Value.ToString()));
            if (_buys == null)
            {
                this._sellTickets.AddUser(user);
            }
            else
            {
                this._buys.AddUser(user);
            }
            this.Hide();
        }

        private void SearchUser(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessUser.Searchuser(this.txtUserSearch.Text);
        }

        private void FillUser(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = BusinessUser.GetAllUser().ToList();
        }
    }
}

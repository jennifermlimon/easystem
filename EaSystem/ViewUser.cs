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
    public partial class ViewUser : Form
    {
        private readonly Buys _buys;
        public ViewUser(Buys buys)
        {
            InitializeComponent();
            _buys = buys;
        }

        private void AddUser(object sender, DataGridViewCellEventArgs e)
        {
            var rows = this.dataGridView1.CurrentRow;
            if (rows == null) return;
            var user = BusinessUser.GetUserById(new Guid(rows.Cells["UserId"].Value.ToString()));
            this._buys.AddUser(user);
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

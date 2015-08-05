using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinPersonales
{
    public partial class frmAvailableUser : Form
    {
        private TextBox _txtUser;
        public frmAvailableUser(TextBox txtUser)
        {
            InitializeComponent();
            _txtUser = txtUser;
        }

        private void aspnet_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aspnet_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.DetalleUsuarios' table. You can move, or remove it, as needed.
            this.detalleUsuariosTableAdapter.Fill(this.finPersonalesDataSet.DetalleUsuarios);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);

        }

        private void aspnet_UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = aspnet_UsersDataGridView.CurrentCell.RowIndex;
            _txtUser.Text = aspnet_UsersDataGridView.Rows[index].Cells[2].Value.ToString();
            this.Close();
        }
    }
}

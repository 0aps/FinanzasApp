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
    public partial class frmUserManagment : Form
    {
        public frmUserManagment()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAdduserI = new frmAddUser();
            DialogResult result = frmAdduserI.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                frmUserManagment_Load(null, null);
            }
        }

        private void aspnet_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aspnet_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void frmUserManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.DetalleUsuarios' table. You can move, or remove it, as needed.
            this.detalleUsuariosTableAdapter.Fill(this.finPersonalesDataSet.DetalleUsuarios);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Membership' table. You can move, or remove it, as needed.
            this.aspnet_MembershipTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Membership);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);

        }

        private void aspnet_UsersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

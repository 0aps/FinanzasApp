using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Windows.Forms;

namespace FinPersonales
{
    public partial class frmRoleManagment : Form
    {
        public frmRoleManagment()
        {
            InitializeComponent();
        }

        private void frmRoleManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_UsersInRoles' table. You can move, or remove it, as needed.
            this.aspnet_UsersInRolesTableAdapter.Fill(this.finPersonalesDataSet.aspnet_UsersInRoles);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Roles' table. You can move, or remove it, as needed.
            this.aspnet_RolesTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Roles);

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            Roles.CreateRole(txtAddRole.Text);
            frmRoleManagment_Load(null, null);
            txtAddRole.Text = "";
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            Roles.DeleteRole(txtAddRole.Text);
            frmRoleManagment_Load(null, null);
            txtAddRole.Text = "";
        }

        private void btnAddInRole_Click(object sender, EventArgs e)
        {
            Roles.AddUserToRole(txtAddRoleUsr.Text, txtAddInRole.Text );
            frmRoleManagment_Load(null, null);
            txtAddRoleUsr.Text = ""; txtAddInRole.Text = "";
        }

        private void btnDelRoleUser_Click(object sender, EventArgs e)
        {
            Roles.RemoveUserFromRole(txtAddRoleUsr.Text, txtAddInRole.Text);
            frmRoleManagment_Load(null, null);
        }


        private void btnListUser_Click(object sender, EventArgs e)
        {
            frmAvailableUser frmAvailableUserI = new frmAvailableUser(txtAddRoleUsr);
            frmAvailableUserI.ShowDialog();
        }

        private void frmRoleManagment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aspnet_RolesDataGridView.DataSource = null;
            this.aspnet_UsersInRolesDataGridView.DataSource = null;
        }


        private void aspnet_RolesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = aspnet_RolesDataGridView.CurrentCell.RowIndex;
            frmEditRole editRoleI = new frmEditRole(index);
            DialogResult result = editRoleI.ShowDialog();
            frmRoleManagment_Load(null, null);
        }
    }
}

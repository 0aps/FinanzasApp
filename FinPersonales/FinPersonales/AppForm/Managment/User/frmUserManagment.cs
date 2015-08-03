using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinPersonales.AppData.FinPersonalesDataSetTableAdapters;
using System.Web.Security;

namespace FinPersonales
{
    public partial class frmUserManagment : Form
    {
        public frmUserManagment()
        {
            InitializeComponent();
        }

        private void Refresh(DialogResult result)
        {
           if (result == DialogResult.Cancel)
            {
                frmUserManagment_Load(null, null);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAdduserI = new frmAddUser();
            DialogResult result = frmAdduserI.ShowDialog();
            Refresh(result);
        }

        private void frmUserManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Membership' table. You can move, or remove it, as needed.
            this.aspnet_MembershipTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Membership);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.DetalleUsuarios' table. You can move, or remove it, as needed.
            this.detalleUsuariosTableAdapter.Fill(this.finPersonalesDataSet.DetalleUsuarios);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);
        }

        private void FindErrors()
        {
            if (this.finPersonalesDataSet.HasErrors)
            {
                foreach (DataTable table in this.finPersonalesDataSet.Tables)
                {
                    if (table.HasErrors)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (row.HasErrors)
                            {
                                // Process error here.
                            }
                        }
                    }
                }
            }
        }

        private void frmUserManagment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aspnet_UsersDataGridView.DataSource = null;
            FindErrors();
        }

        private void aspnet_UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = aspnet_UsersDataGridView.CurrentCell.RowIndex;
            frmListUser frmListUserI = new frmListUser(index);
            DialogResult result = frmListUserI.ShowDialog();
            Refresh(result);
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            frmListUser frmListUserI = new frmListUser();
            DialogResult result = frmListUserI.ShowDialog();
            Refresh(result);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Estás seguro que deseas borrar los usuarios seleccionados?",
                                     "Cuadro de Confirmación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow Row in aspnet_UsersDataGridView.Rows)
                {
                    if (Row.Selected)
                    {
                        String username = Row.Cells[2].Value.ToString();
                        Guid guid = getGuid(username);
                        detalleUsuariosTableAdapter.DeleteSingle(guid);
                        aspnet_UsersDataGridView.Rows.RemoveAt(Row.Index);
                        Membership.DeleteUser(username);
                        DeleteUserRoles(username);
                    }

                }

                this.Validate();
                this.detalleUsuariosBindingSource.EndEdit();
                this.aspnetMembershipBindingSource.EndEdit();
                this.aspnet_UsersBindingSource.EndEdit();
                aspnet_UsersDataGridView.Update();
                aspnet_UsersDataGridView.Refresh();
                // this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);
            }


        }
        private Guid getGuid(String username)
        {
            MembershipUser user = Membership.GetUser(username);
            Guid userId = (Guid)((user.ProviderUserKey));

            return userId;
        }
        void DeleteUserRoles(string username)
        {
            foreach (var role in Roles.GetRolesForUser(username))
                Roles.RemoveUserFromRole(username, role);
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinPersonales.AppData.FinPersonalesDataSetTableAdapters;

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
            frmListUser frmListUserI = new frmListUser();
            DialogResult result = frmListUserI.ShowDialog();
            Refresh(result);
        }

    }
}

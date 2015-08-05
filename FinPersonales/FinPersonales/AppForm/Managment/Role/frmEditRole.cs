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
    public partial class frmEditRole : Form
    {
        private int _index;
        public frmEditRole(int index)
        {
            _index = index;
            InitializeComponent();
        }

        private void aspnet_RolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aspnet_RolesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);
        }

        private void editRole_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Roles' table. You can move, or remove it, as needed.
            this.aspnet_RolesTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Roles);
            aspnet_RolesBindingNavigator.BindingSource.Position = _index;
            aspnet_RolesBindingNavigator.Visible = false;
        }

        private void btnUpdateRol_Click(object sender, EventArgs e)
        {
            aspnet_RolesBindingNavigatorSaveItem_Click(null, null);
            this.Close();
        }
    }
}

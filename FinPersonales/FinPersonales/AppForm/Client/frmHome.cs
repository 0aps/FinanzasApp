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
    public partial class frmHome : Form
    {
        public frmHome(string _username)
        {
            InitializeComponent();
            var User = userSingleton.getIntance();
            User.setUserName(_username);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Finanazas Personales\n\nProgramación con Tecnologia Propietaria I\n" +
                "Integrantes:\n\nAngel Piña - 20132338" +
                "\nMiguel Angel Martinez - 20132578",
                "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestiónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagment frmUserManagmentI = new frmUserManagment();
            DialogResult result = frmUserManagmentI.ShowDialog();
            Refresh(result);
        }

        private void gestiónDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoleManagment frmRoleManagmentI = new frmRoleManagment();
            DialogResult result =  frmRoleManagmentI.ShowDialog();
            Refresh(result);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transaccionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transaccionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            Guid userId = userSingleton.getIntance()._Id;

            // TODO: This line of code loads data into the 'finPersonalesDataSet.Servicio' table. You can move, or remove it, as needed.
            this.servicioTableAdapter.FillByPerUser(this.finPersonalesDataSet.Servicio, userId);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.Cuentas' table. You can move, or remove it, as needed.
            this.cuentasTableAdapter.FillByPerUser(this.finPersonalesDataSet.Cuentas, userId);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPersona' table. You can move, or remove it, as needed.
            this.tipoPersonaTableAdapter.Fill(this.finPersonalesDataSet.TipoPersona);
            
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPago' table. You can move, or remove it, as needed.
            this.tipoPagoTableAdapter.Fill(this.finPersonalesDataSet.TipoPago);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoTransaccion' table. You can move, or remove it, as needed.
            this.tipoTransaccionTableAdapter.Fill(this.finPersonalesDataSet.TipoTransaccion);   
            this.transaccionesTableAdapter.FillByPerUser(this.finPersonalesDataSet.Transacciones, userId);
            this.detalleUsuariosTableAdapter.FillByPerUser(this.finPersonalesDataSet.DetalleUsuarios, userId);
            this.lblUserName.Text = nombreLabel1.Text;
          //  if (!Roles.IsUserInRole(userSingleton.getIntance()._userName, "Administrator"))
           // {
            //    this.administraciónToolStripMenuItem.Visible = false;
            //}
            
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
       
            this.transaccionesDataGridView.DataSource = null;
        }
        private void Refresh(DialogResult result)
        {
            if (result == DialogResult.Cancel)
            {
                frmHome_Load(null, null);
            }
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetail frmUserDetailI = new frmUserDetail();
            DialogResult result = frmUserDetailI.ShowDialog();
            Refresh(result);
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddIncome frmAddIncomeI = new frmAddIncome();
            DialogResult result = frmAddIncomeI.ShowDialog();
            Refresh(result);
        }

    }
}

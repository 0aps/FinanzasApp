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
            frmUserManagmentI.ShowDialog();
        }

        private void gestiónDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoleManagment frmRoleManagmentI = new frmRoleManagment();
            frmRoleManagmentI.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

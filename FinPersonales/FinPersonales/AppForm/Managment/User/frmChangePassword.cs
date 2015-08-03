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
    public partial class frmChangePassword : Form
    {
        private string _username;

        public frmChangePassword(string username)
        {
            InitializeComponent();
            this._username = username;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !checkShowPass.Checked ? '*' : '\0';
            txtPasswordConfirm.PasswordChar = !checkShowPass.Checked ? '*' : '\0';
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            MembershipUser u = Membership.GetUser(_username);
            try
            {
                bool result = u.ChangePassword(u.ResetPassword(), txtPassword.Text);
                if (result)
                {
                    MessageBox.Show("¡Contraseña actualizada exitosamente!",
                           "Actualizar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("¡Ocurrio un error al actualizar la contraseña!",
                           "Actualizar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Stop);    
                throw;
            }

            
        }
    }
}

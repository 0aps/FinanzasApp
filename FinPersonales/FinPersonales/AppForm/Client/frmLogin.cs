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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //if (true)
            //{
            //    this.Hide();
            //    var form2 = new Form2("admin");
            //    form2.Closed += (s, args) => this.Close();
            //    form2.Show();
            //    return;
            //}

            bool result = Membership.ValidateUser(txtUser.Text, txtPassword.Text);
            if (result)
            {
                this.Hide();
                frmHome fromHomeI = new frmHome (txtUser.Text);
                fromHomeI.Closed += (s, args) => this.Clean(); ;
                fromHomeI.Show();

            }
            else
            {
                MessageBox.Show("Error al autenticarte. Revisa las credenciales.");
            }
        }

        private void Clean()
        {
            this.Show();
            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }
}

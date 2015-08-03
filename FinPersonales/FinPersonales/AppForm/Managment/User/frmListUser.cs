using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinPersonales
{
    public partial class frmListUser : Form
    {
        public frmListUser()
        {
            InitializeComponent();
        }


        private void aspnet_UsersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

            this.Validate();
            this.detalleUsuariosBindingSource.EndEdit();
            this.aspnet_MembershipBindingSource.EndEdit();
            this.aspnet_UsersBindingSource.EndEdit();

            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.DetalleUsuarios' table. You can move, or remove it, as needed.
            this.detalleUsuariosTableAdapter.Fill(this.finPersonalesDataSet.DetalleUsuarios);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Membership' table. You can move, or remove it, as needed.
            this.aspnet_MembershipTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Membership);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);

        }

        private void fotoPerfilPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            DialogResult result = open.ShowDialog();
            byte[] bimage;

            if (result == DialogResult.OK)
            {

                string image = open.FileName;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                fotoPerfilPictureBox.Image = Image.FromStream(new MemoryStream(bimage));
            }
            else if (result == DialogResult.Cancel)
            {
                fotoPerfilPictureBox.Image = null;
            }

            fotoPerfilPictureBox.Refresh();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePasswordI = new frmChangePassword(userNameTextBox.Text);
            frmChangePasswordI.ShowDialog();
            this.aspnet_MembershipTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Membership);
         
        }

    }
}

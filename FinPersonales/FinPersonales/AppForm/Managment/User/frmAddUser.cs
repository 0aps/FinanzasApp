using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Windows.Forms;
using System.IO;
using FinPersonales.AppData.FinPersonalesDataSetTableAdapters;

namespace FinPersonales
{
    public partial class frmAddUser : Form
    {
        private DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private byte[] bimage;

        public frmAddUser()
        {
            InitializeComponent();
            detalleUsuariosTableAdapter = new DetalleUsuariosTableAdapter();
            bimage = GetBytesOfImage(Properties.Resources.photo);
            pictureUser.Image = Properties.Resources.photo;
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MembershipUser user = Membership.CreateUser(txtUser.Text, txtPassword.Text, txtEmail.Text);
            Guid userId = (Guid)((user.ProviderUserKey));
            int limitOutCome = Int32.Parse(txtLimOutcome.Text);
            detalleUsuariosTableAdapter.Insert(userId, txtName.Text, txtLastName.Text, txtPhone.Text, limitOutCome, 1, true, bimage, limitOutCome);
            txtName.Text = ""; txtEmail.Text = ""; txtUser.Text = ""; txtPassword.Text = "";
            txtLimOutcome.Text = ""; txtPhone.Text = ""; txtLastName.Text = "";
            
        }

        private void pictureUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            DialogResult result = open.ShowDialog();
            bimage = null;

            if (result == DialogResult.OK)
            {

                string image = open.FileName;
                Bitmap bmp = new Bitmap(image);
                FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                bimage = new byte[fs.Length];
                fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                fs.Close();
                pictureUser.Image =  Image.FromStream(new MemoryStream(bimage));
            }
            else if (result == DialogResult.Cancel)
            {
                pictureUser.Image = null;
            }

            pictureUser.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static byte[] GetBytesOfImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }


    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = Membership.ValidateUser(textBox1.Text, textBox2.Text);
            if (result)
            {
                this.Hide();
                var form2 = new Form2(textBox1.Text);
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Error al autenticarte. Revisa las credenciales.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNombre.Text = "Esteban José De la Rosa García";
            txtLimiteMensual.Text = "2000";
            txtTotalEgresos.Text = "1999";
            var creditoRestante = Double.Parse(txtLimiteMensual.Text) - Double.Parse(txtTotalEgresos.Text);

            txtCreditoRestante.Text = creditoRestante.ToString();

            if (creditoRestante <= 0) {
                lbCondicion.Text = "Condición: \"Tu ta mal pana\"";
                lbCondicion.ForeColor = System.Drawing.Color.Red;
            }

            
        }

        
    }
}

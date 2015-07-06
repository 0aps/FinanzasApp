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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tipoIngresosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoIngresosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.Ingresos' table. You can move, or remove it, as needed.
            this.ingresosTableAdapter.Fill(this.finPersonalesDataSet.Ingresos);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoIngresos' table. You can move, or remove it, as needed.
            this.tipoIngresosTableAdapter.Fill(this.finPersonalesDataSet.TipoIngresos);

        }

        private void estadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

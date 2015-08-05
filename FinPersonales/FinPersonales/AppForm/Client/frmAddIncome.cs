using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinPersonales.AppData.FinPersonalesDataSetTableAdapters;

namespace FinPersonales
{
    public partial class frmAddIncome : Form
    {
        private TransaccionesTableAdapter transaccionesTableAdapter;
        public frmAddIncome()
        {
            transaccionesTableAdapter = new TransaccionesTableAdapter();
            InitializeComponent();
        }

        private void frmAddIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.QuienPaga' table. You can move, or remove it, as needed.
            this.quienPagaTableAdapter.Fill(this.finPersonalesDataSet.QuienPaga);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPago' table. You can move, or remove it, as needed.
            this.tipoPagoTableAdapter.Fill(this.finPersonalesDataSet.TipoPago);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoIngresos' table. You can move, or remove it, as needed.
            this.tipoIngresosTableAdapter.Fill(this.finPersonalesDataSet.TipoIngresos);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}

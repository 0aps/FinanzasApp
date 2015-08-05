using FinPersonales.AppData.FinPersonalesDataSetTableAdapters;
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
    public partial class frmAddOutCome : Form
    {
        private TransaccionesTableAdapter transaccionesTableAdapter;
        private EgresosTableAdapter egresosTableAdapter;

        public frmAddOutCome()
        {
            transaccionesTableAdapter = new TransaccionesTableAdapter();
            egresosTableAdapter = new EgresosTableAdapter();
            InitializeComponent();
        }

        private void frmAddOutCome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.CategoriaEgresos' table. You can move, or remove it, as needed.
            this.categoriaEgresosTableAdapter.Fill(this.finPersonalesDataSet.CategoriaEgresos);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPago' table. You can move, or remove it, as needed.
            this.tipoPagoTableAdapter.Fill(this.finPersonalesDataSet.TipoPago);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TiposEgresos' table. You can move, or remove it, as needed.
            this.tiposEgresosTableAdapter.Fill(this.finPersonalesDataSet.TiposEgresos);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String todayDate = DateTime.Today.ToString("MM'/'dd'/'yyyy HH':'mm':'ss");
            Decimal amount = Decimal.Parse(txtAmount.Text);
            egresosTableAdapter.InsertSingle((int)cbTypeOutCome.SelectedValue, (int)cbCategory.SelectedValue, "", true);
            int RefId = Int32.Parse(egresosTableAdapter.GetDataSingle().Rows[0][0].ToString());

            transaccionesTableAdapter.InsertSingle(2, userSingleton.getIntance()._Id, 2, todayDate, todayDate, amount, txtComment.Text, true, RefId);
        
        }
    }
}

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
    public partial class Form2 : Form
    {
        private String _username { get; set; }
        public Form2(string username)
        {
            this._username = username;
            InitializeComponent();
        }
        public void PerformRefresh()
        {

            this.Validate();
            this.transaccionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);
            this.transaccionesDataGridView.Refresh();
        }
        public void addRow(DataGridViewRow row, int tipo)
        {
            BindingSource bs = (BindingSource)this.transaccionesDataGridView.DataSource;
            int rowsSize = int.Parse(this.transaccionesDataGridView.Rows[this.transaccionesDataGridView.Rows.Count - 2].Cells[0].Value.ToString());
            DataRowView newRow = (DataRowView)bs.AddNew();
            
            newRow["No"] = ++rowsSize;
            newRow["Tipo"] = tipo;
            newRow["Usuario"] = Membership.GetUser(_username).ProviderUserKey;
            newRow["TipoPago"] = 1;
            newRow["FechaTransaccion"] = DateTime.Today;
            newRow["FechaRegistrada"] = DateTime.Today;
            newRow["Monto"] = row.Cells[2].Value;
            newRow["Comentario"] = "";
            newRow["Estado"] = row.Cells[4].Value;
            newRow.EndEdit();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPago' table. You can move, or remove it, as needed.
            this.tipoPagoTableAdapter.Fill(this.finPersonalesDataSet.TipoPago);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoTransaccion' table. You can move, or remove it, as needed.
            this.tipoTransaccionTableAdapter.Fill(this.finPersonalesDataSet.TipoTransaccion);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.aspnet_Users' table. You can move, or remove it, as needed.
            this.aspnet_UsersTableAdapter.Fill(this.finPersonalesDataSet.aspnet_Users);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.Transacciones' table. You can move, or remove it, as needed.
            this.transaccionesTableAdapter.Fill(this.finPersonalesDataSet.Transacciones);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.DetalleUsuarios' table. You can move, or remove it, as needed.
            this.detalleUsuariosTableAdapter.Fill(this.finPersonalesDataSet.DetalleUsuarios);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TipoPersona' table. You can move, or remove it, as needed.
            this.tipoPersonaTableAdapter.Fill(this.finPersonalesDataSet.TipoPersona);

        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.ShowDialog();
        }

        private void egresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4(this);
            form4.ShowDialog();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.ShowDialog();
        }

        private void transaccionesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

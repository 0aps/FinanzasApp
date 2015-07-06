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
    public partial class Form4 : Form
    {
        Form2 fromForm2;
        int numberIni;

        public Form4(Form2 form2)
        {
            this.fromForm2 = form2;
            InitializeComponent();
        }

        private void egresosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.egresosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.finPersonalesDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finPersonalesDataSet.CategoriaEgresos' table. You can move, or remove it, as needed.
            this.categoriaEgresosTableAdapter.Fill(this.finPersonalesDataSet.CategoriaEgresos);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.TiposEgresos' table. You can move, or remove it, as needed.
            this.tiposEgresosTableAdapter.Fill(this.finPersonalesDataSet.TiposEgresos);
            // TODO: This line of code loads data into the 'finPersonalesDataSet.Egresos' table. You can move, or remove it, as needed.
            this.egresosTableAdapter.Fill(this.finPersonalesDataSet.Egresos);
            this.numberIni = this.egresosDataGridView.Rows.Count;

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            int num = this.egresosDataGridView.Rows.Count;
            for (int i = numberIni - 1; i < num - 1; ++i)
            {
                DataGridViewRow row = egresosDataGridView.Rows[i];
                fromForm2.addRow(row, 2);
            }
            fromForm2.PerformRefresh();
        }

        private void egresosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}

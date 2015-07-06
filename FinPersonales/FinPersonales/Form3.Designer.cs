namespace FinPersonales
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tipoIngresosLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label quienPagaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.finPersonalesDataSet = new FinPersonales.FinPersonalesDataSet();
            this.tipoIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoIngresosTableAdapter = new FinPersonales.FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter();
            this.tableAdapterManager = new FinPersonales.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.ingresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingresosTableAdapter = new FinPersonales.FinPersonalesDataSetTableAdapters.IngresosTableAdapter();
            this.aspnet_ApplicationsTableAdapter1 = new FinPersonales.FinPersonalesDataSetTableAdapters.aspnet_ApplicationsTableAdapter();
            this.tipoIngresosTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.quienPagaTextBox = new System.Windows.Forms.TextBox();
            tipoIngresosLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            quienPagaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos";
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoIngresosBindingSource
            // 
            this.tipoIngresosBindingSource.DataMember = "TipoIngresos";
            this.tipoIngresosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // tipoIngresosTableAdapter
            // 
            this.tipoIngresosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aspnet_ApplicationsTableAdapter = this.aspnet_ApplicationsTableAdapter1;
            this.tableAdapterManager.aspnet_MembershipTableAdapter = null;
            this.tableAdapterManager.aspnet_PathsTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationAllUsersTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationPerUserTableAdapter = null;
            this.tableAdapterManager.aspnet_ProfileTableAdapter = null;
            this.tableAdapterManager.aspnet_RolesTableAdapter = null;
            this.tableAdapterManager.aspnet_SchemaVersionsTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersInRolesTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersTableAdapter = null;
            this.tableAdapterManager.aspnet_WebEvent_EventsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaEgresosTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.DetalleUsuariosTableAdapter = null;
            this.tableAdapterManager.EgresosTableAdapter = null;
            this.tableAdapterManager.IngresosTableAdapter = this.ingresosTableAdapter;
            this.tableAdapterManager.QuienPagaTableAdapter = null;
            this.tableAdapterManager.ServicioTableAdapter = null;
            this.tableAdapterManager.TipoIngresosTableAdapter = this.tipoIngresosTableAdapter;
            this.tableAdapterManager.TipoPagoTableAdapter = null;
            this.tableAdapterManager.TipoPersonaTableAdapter = null;
            this.tableAdapterManager.TiposEgresosTableAdapter = null;
            this.tableAdapterManager.TipoTransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinPersonales.FinPersonalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioCuentasTableAdapter = null;
            // 
            // ingresosBindingSource
            // 
            this.ingresosBindingSource.DataMember = "FK_Ingresos_TipoIngresos";
            this.ingresosBindingSource.DataSource = this.tipoIngresosBindingSource;
            // 
            // ingresosTableAdapter
            // 
            this.ingresosTableAdapter.ClearBeforeFill = true;
            // 
            // aspnet_ApplicationsTableAdapter1
            // 
            this.aspnet_ApplicationsTableAdapter1.ClearBeforeFill = true;
            // 
            // tipoIngresosLabel
            // 
            tipoIngresosLabel.AutoSize = true;
            tipoIngresosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoIngresosLabel.Location = new System.Drawing.Point(41, 167);
            tipoIngresosLabel.Name = "tipoIngresosLabel";
            tipoIngresosLabel.Size = new System.Drawing.Size(254, 42);
            tipoIngresosLabel.TabIndex = 1;
            tipoIngresosLabel.Text = "Tipo Ingresos:";
            // 
            // tipoIngresosTextBox
            // 
            this.tipoIngresosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingresosBindingSource, "TipoIngresos", true));
            this.tipoIngresosTextBox.Location = new System.Drawing.Point(349, 179);
            this.tipoIngresosTextBox.Name = "tipoIngresosTextBox";
            this.tipoIngresosTextBox.Size = new System.Drawing.Size(150, 31);
            this.tipoIngresosTextBox.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(43, 219);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(261, 51);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingresosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(349, 237);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(154, 31);
            this.descripcionTextBox.TabIndex = 4;
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.descripcionTextBox_TextChanged);
            // 
            // quienPagaLabel
            // 
            quienPagaLabel.AutoSize = true;
            quienPagaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quienPagaLabel.Location = new System.Drawing.Point(47, 284);
            quienPagaLabel.Name = "quienPagaLabel";
            quienPagaLabel.Size = new System.Drawing.Size(261, 51);
            quienPagaLabel.TabIndex = 5;
            quienPagaLabel.Text = "Quien Paga:";
            // 
            // quienPagaTextBox
            // 
            this.quienPagaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingresosBindingSource, "QuienPaga", true));
            this.quienPagaTextBox.Location = new System.Drawing.Point(349, 302);
            this.quienPagaTextBox.Name = "quienPagaTextBox";
            this.quienPagaTextBox.Size = new System.Drawing.Size(154, 31);
            this.quienPagaTextBox.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 693);
            this.Controls.Add(tipoIngresosLabel);
            this.Controls.Add(this.tipoIngresosTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(quienPagaLabel);
            this.Controls.Add(this.quienPagaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Registrar - Ingresos";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIngresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingresosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource tipoIngresosBindingSource;
        private FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter tipoIngresosTableAdapter;
        private FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FinPersonalesDataSetTableAdapters.IngresosTableAdapter ingresosTableAdapter;
        private System.Windows.Forms.BindingSource ingresosBindingSource;
        private FinPersonalesDataSetTableAdapters.aspnet_ApplicationsTableAdapter aspnet_ApplicationsTableAdapter1;
        private System.Windows.Forms.TextBox tipoIngresosTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox quienPagaTextBox;
    }
}
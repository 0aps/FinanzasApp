namespace FinPersonales
{
    partial class Form5
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label limiteEgresosLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.finPersonalesDataSet = new FinPersonales.FinPersonalesDataSet();
            this.tipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPersonaTableAdapter = new FinPersonales.FinPersonalesDataSetTableAdapters.TipoPersonaTableAdapter();
            this.tableAdapterManager = new FinPersonales.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleUsuariosTableAdapter = new FinPersonales.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.limiteEgresosTextBox = new System.Windows.Forms.TextBox();
            this.tipoPersonaComboBox = new System.Windows.Forms.ComboBox();
            nombreLabel = new System.Windows.Forms.Label();
            limiteEgresosLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalles Personales";
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoPersonaBindingSource
            // 
            this.tipoPersonaBindingSource.DataMember = "TipoPersona";
            this.tipoPersonaBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // tipoPersonaTableAdapter
            // 
            this.tipoPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aspnet_ApplicationsTableAdapter = null;
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
            this.tableAdapterManager.DetalleUsuariosTableAdapter = this.detalleUsuariosTableAdapter;
            this.tableAdapterManager.EgresosTableAdapter = null;
            this.tableAdapterManager.IngresosTableAdapter = null;
            this.tableAdapterManager.QuienPagaTableAdapter = null;
            this.tableAdapterManager.ServicioTableAdapter = null;
            this.tableAdapterManager.TipoIngresosTableAdapter = null;
            this.tableAdapterManager.TipoPagoTableAdapter = null;
            this.tableAdapterManager.TipoPersonaTableAdapter = this.tipoPersonaTableAdapter;
            this.tableAdapterManager.TiposEgresosTableAdapter = null;
            this.tableAdapterManager.TipoTransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinPersonales.FinPersonalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioCuentasTableAdapter = null;
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "FK_DetalleUsuarios_TipoPersona";
            this.detalleUsuariosBindingSource.DataSource = this.tipoPersonaBindingSource;
            // 
            // detalleUsuariosTableAdapter
            // 
            this.detalleUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(31, 148);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(160, 42);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Nombre", true));
            this.nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel1.Location = new System.Drawing.Point(328, 148);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(164, 58);
            this.nombreLabel1.TabIndex = 6;
            this.nombreLabel1.Text = "label2";
            // 
            // limiteEgresosLabel
            // 
            limiteEgresosLabel.AutoSize = true;
            limiteEgresosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            limiteEgresosLabel.Location = new System.Drawing.Point(31, 225);
            limiteEgresosLabel.Name = "limiteEgresosLabel";
            limiteEgresosLabel.Size = new System.Drawing.Size(274, 42);
            limiteEgresosLabel.TabIndex = 7;
            limiteEgresosLabel.Text = "Limite Egresos:";
            // 
            // limiteEgresosTextBox
            // 
            this.limiteEgresosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "LimiteEgresos", true));
            this.limiteEgresosTextBox.Location = new System.Drawing.Point(335, 237);
            this.limiteEgresosTextBox.Name = "limiteEgresosTextBox";
            this.limiteEgresosTextBox.Size = new System.Drawing.Size(121, 31);
            this.limiteEgresosTextBox.TabIndex = 8;
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoPersonaLabel.Location = new System.Drawing.Point(33, 296);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(251, 42);
            tipoPersonaLabel.TabIndex = 9;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // tipoPersonaComboBox
            // 
            this.tipoPersonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "TipoPersona", true));
            this.tipoPersonaComboBox.DataSource = this.tipoPersonaBindingSource;
            this.tipoPersonaComboBox.DisplayMember = "Descripcion";
            this.tipoPersonaComboBox.Enabled = false;
            this.tipoPersonaComboBox.FormattingEnabled = true;
            this.tipoPersonaComboBox.Location = new System.Drawing.Point(335, 308);
            this.tipoPersonaComboBox.Name = "tipoPersonaComboBox";
            this.tipoPersonaComboBox.Size = new System.Drawing.Size(121, 33);
            this.tipoPersonaComboBox.TabIndex = 10;
            this.tipoPersonaComboBox.ValueMember = "Id";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 611);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(limiteEgresosLabel);
            this.Controls.Add(this.limiteEgresosTextBox);
            this.Controls.Add(tipoPersonaLabel);
            this.Controls.Add(this.tipoPersonaComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Datos Personales";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource tipoPersonaBindingSource;
        private FinPersonalesDataSetTableAdapters.TipoPersonaTableAdapter tipoPersonaTableAdapter;
        private FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource detalleUsuariosBindingSource;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.TextBox limiteEgresosTextBox;
        private System.Windows.Forms.ComboBox tipoPersonaComboBox;
    }
}
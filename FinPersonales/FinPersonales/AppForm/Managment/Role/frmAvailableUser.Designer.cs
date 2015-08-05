namespace FinPersonales
{
    partial class frmAvailableUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.aspnet_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleUsuariosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista de Usuarios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aspnet_UsersBindingSource
            // 
            this.aspnet_UsersBindingSource.DataMember = "aspnet_Users";
            this.aspnet_UsersBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // aspnet_UsersTableAdapter
            // 
            this.aspnet_UsersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.aspnet_UsersTableAdapter = this.aspnet_UsersTableAdapter;
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
            this.tableAdapterManager.TipoPersonaTableAdapter = null;
            this.tableAdapterManager.TiposEgresosTableAdapter = null;
            this.tableAdapterManager.TipoTransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioCuentasTableAdapter = null;
            // 
            // aspnet_UsersDataGridView
            // 
            this.aspnet_UsersDataGridView.AllowUserToAddRows = false;
            this.aspnet_UsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aspnet_UsersDataGridView.AutoGenerateColumns = false;
            this.aspnet_UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aspnet_UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aspnet_UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aspnet_UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.Nombre});
            this.aspnet_UsersDataGridView.DataSource = this.aspnet_UsersBindingSource;
            this.aspnet_UsersDataGridView.Location = new System.Drawing.Point(38, 66);
            this.aspnet_UsersDataGridView.Name = "aspnet_UsersDataGridView";
            this.aspnet_UsersDataGridView.Size = new System.Drawing.Size(354, 278);
            this.aspnet_UsersDataGridView.TabIndex = 9;
            this.aspnet_UsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aspnet_UsersDataGridView_CellDoubleClick);
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "DetalleUsuarios";
            this.detalleUsuariosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // detalleUsuariosTableAdapter
            // 
            this.detalleUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ApplicationId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ApplicationId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoweredUserName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoweredUserName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MobileAlias";
            this.dataGridViewTextBoxColumn5.HeaderText = "MobileAlias";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsAnonymous";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsAnonymous";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastActivityDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "LastActivityDate";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "UserId";
            this.Nombre.DataSource = this.detalleUsuariosBindingSource;
            this.Nombre.DisplayMember = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.ValueMember = "Id";
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 375);
            this.Controls.Add(this.aspnet_UsersDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmListUser";
            this.Text = "Gestión de Roles - Listar Usuarios";
            this.Load += new System.EventHandler(this.frmListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource aspnet_UsersBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView aspnet_UsersDataGridView;
        private AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource detalleUsuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn Nombre;
    }
}
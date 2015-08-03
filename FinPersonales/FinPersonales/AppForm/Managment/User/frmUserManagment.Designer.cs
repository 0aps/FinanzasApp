namespace FinPersonales
{
    partial class frmUserManagment
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
            this.lblUserManagment = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListUser = new System.Windows.Forms.Button();
            this.lblActions = new System.Windows.Forms.Label();
            this.aspnet_UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.aspnetMembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_MembershipTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter();
            this.detalleUsuariosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetMembershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserManagment
            // 
            this.lblUserManagment.AutoSize = true;
            this.lblUserManagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserManagment.Location = new System.Drawing.Point(114, 21);
            this.lblUserManagment.Name = "lblUserManagment";
            this.lblUserManagment.Size = new System.Drawing.Size(250, 29);
            this.lblUserManagment.TabIndex = 6;
            this.lblUserManagment.Text = "Gestión de Usuarios";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(22, 18);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(81, 42);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Agregar";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 42);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnListUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(35, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 86);
            this.panel1.TabIndex = 10;
            // 
            // btnListUser
            // 
            this.btnListUser.Location = new System.Drawing.Point(160, 21);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(81, 42);
            this.btnListUser.TabIndex = 9;
            this.btnListUser.Text = "Listar";
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(48, 61);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(160, 20);
            this.lblActions.TabIndex = 11;
            this.lblActions.Text = "Acciones Disponibles";
            // 
            // aspnet_UsersDataGridView
            // 
            this.aspnet_UsersDataGridView.AllowUserToAddRows = false;
            this.aspnet_UsersDataGridView.AutoGenerateColumns = false;
            this.aspnet_UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aspnet_UsersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aspnet_UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aspnet_UsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Email,
            this.Password,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.UserIdL});
            this.aspnet_UsersDataGridView.DataSource = this.aspnet_UsersBindingSource;
            this.aspnet_UsersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aspnet_UsersDataGridView.Location = new System.Drawing.Point(0, 203);
            this.aspnet_UsersDataGridView.Name = "aspnet_UsersDataGridView";
            this.aspnet_UsersDataGridView.Size = new System.Drawing.Size(485, 220);
            this.aspnet_UsersDataGridView.TabIndex = 12;
            this.aspnet_UsersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aspnet_UsersDataGridView_CellDoubleClick);
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "DetalleUsuarios";
            this.detalleUsuariosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aspnetMembershipBindingSource
            // 
            this.aspnetMembershipBindingSource.DataMember = "aspnet_Membership";
            this.aspnetMembershipBindingSource.DataSource = this.finPersonalesDataSet;
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
            this.tableAdapterManager.aspnet_MembershipTableAdapter = this.aspnet_MembershipTableAdapter;
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
            // aspnet_MembershipTableAdapter
            // 
            this.aspnet_MembershipTableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn2.DataSource = this.detalleUsuariosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "UserId";
            this.Email.DataSource = this.aspnetMembershipBindingSource;
            this.Email.DisplayMember = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.ValueMember = "UserId";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "UserId";
            this.Password.DataSource = this.aspnetMembershipBindingSource;
            this.Password.DisplayMember = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.ValueMember = "UserId";
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
            // 
            // UserIdL
            // 
            this.UserIdL.DataPropertyName = "UserId";
            this.UserIdL.HeaderText = "UserIdL";
            this.UserIdL.Name = "UserIdL";
            this.UserIdL.Visible = false;
            // 
            // frmUserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 423);
            this.Controls.Add(this.aspnet_UsersDataGridView);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUserManagment);
            this.Name = "frmUserManagment";
            this.Text = "Administración - Gestión de Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserManagment_FormClosing);
            this.Load += new System.EventHandler(this.frmUserManagment_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetMembershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserManagment;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActions;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource aspnet_UsersBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource detalleUsuariosBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter aspnet_MembershipTableAdapter;
        private System.Windows.Forms.BindingSource aspnetMembershipBindingSource;
        private System.Windows.Forms.DataGridView aspnet_UsersDataGridView;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Email;
        private System.Windows.Forms.DataGridViewComboBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdL;
    }
}
namespace FinPersonales
{
    partial class frmRoleManagment
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
            this.aspnet_RolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_RolesTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_RolesTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_UsersInRolesTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersInRolesTableAdapter();
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.aspnetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnetRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnListUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.txtAddRole = new System.Windows.Forms.TextBox();
            this.Rol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelRoleUser = new System.Windows.Forms.Button();
            this.txtAddInRole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddRoleUsr = new System.Windows.Forms.TextBox();
            this.btnAddInRole = new System.Windows.Forms.Button();
            this.lblActions = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.aspnet_UsersInRolesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aspnet_UsersInRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_RolesDataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_RolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetRolesBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersInRolesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersInRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_RolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestion de Roles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aspnet_RolesBindingSource
            // 
            this.aspnet_RolesBindingSource.DataMember = "aspnet_Roles";
            this.aspnet_RolesBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // aspnet_RolesTableAdapter
            // 
            this.aspnet_RolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.aspnet_ApplicationsTableAdapter = null;
            this.tableAdapterManager.aspnet_MembershipTableAdapter = null;
            this.tableAdapterManager.aspnet_PathsTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationAllUsersTableAdapter = null;
            this.tableAdapterManager.aspnet_PersonalizationPerUserTableAdapter = null;
            this.tableAdapterManager.aspnet_ProfileTableAdapter = null;
            this.tableAdapterManager.aspnet_RolesTableAdapter = this.aspnet_RolesTableAdapter;
            this.tableAdapterManager.aspnet_SchemaVersionsTableAdapter = null;
            this.tableAdapterManager.aspnet_UsersInRolesTableAdapter = this.aspnet_UsersInRolesTableAdapter;
            this.tableAdapterManager.aspnet_UsersTableAdapter = this.aspnet_UsersTableAdapter;
            this.tableAdapterManager.aspnet_WebEvent_EventsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaEgresosTableAdapter = null;
            this.tableAdapterManager.CuentasTableAdapter = null;
            this.tableAdapterManager.DetalleUsuariosTableAdapter = null;
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
            // aspnet_UsersInRolesTableAdapter
            // 
            this.aspnet_UsersInRolesTableAdapter.ClearBeforeFill = true;
            // 
            // aspnet_UsersTableAdapter
            // 
            this.aspnet_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // aspnetUsersBindingSource
            // 
            this.aspnetUsersBindingSource.DataMember = "aspnet_Users";
            this.aspnetUsersBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // aspnetRolesBindingSource
            // 
            this.aspnetRolesBindingSource.DataMember = "aspnet_Roles";
            this.aspnetRolesBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnListUser);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(34, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(795, 189);
            this.panel4.TabIndex = 12;
            // 
            // btnListUser
            // 
            this.btnListUser.Location = new System.Drawing.Point(688, 6);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(94, 23);
            this.btnListUser.TabIndex = 12;
            this.btnListUser.Text = "Listar Usuarios";
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnListUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Roles";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAddRole);
            this.panel3.Controls.Add(this.btnDeleteRole);
            this.panel3.Controls.Add(this.txtAddRole);
            this.panel3.Controls.Add(this.Rol);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(22, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 103);
            this.panel3.TabIndex = 8;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(140, 65);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddRole.TabIndex = 9;
            this.btnAddRole.Text = "Agregar";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(223, 65);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRole.TabIndex = 8;
            this.btnDeleteRole.Text = "Eliminar";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // txtAddRole
            // 
            this.txtAddRole.Location = new System.Drawing.Point(108, 24);
            this.txtAddRole.Name = "txtAddRole";
            this.txtAddRole.Size = new System.Drawing.Size(190, 20);
            this.txtAddRole.TabIndex = 7;
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rol.Location = new System.Drawing.Point(38, 24);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(33, 20);
            this.Rol.TabIndex = 6;
            this.Rol.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Agregar Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuario - Role";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDelRoleUser);
            this.panel2.Controls.Add(this.txtAddInRole);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAddRoleUsr);
            this.panel2.Controls.Add(this.btnAddInRole);
            this.panel2.Location = new System.Drawing.Point(363, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 118);
            this.panel2.TabIndex = 9;
            // 
            // btnDelRoleUser
            // 
            this.btnDelRoleUser.Location = new System.Drawing.Point(259, 81);
            this.btnDelRoleUser.Name = "btnDelRoleUser";
            this.btnDelRoleUser.Size = new System.Drawing.Size(75, 23);
            this.btnDelRoleUser.TabIndex = 11;
            this.btnDelRoleUser.Text = "Eliminar";
            this.btnDelRoleUser.UseVisualStyleBackColor = true;
            this.btnDelRoleUser.Click += new System.EventHandler(this.btnDelRoleUser_Click);
            // 
            // txtAddInRole
            // 
            this.txtAddInRole.Location = new System.Drawing.Point(153, 51);
            this.txtAddInRole.Name = "txtAddInRole";
            this.txtAddInRole.Size = new System.Drawing.Size(181, 20);
            this.txtAddInRole.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            // 
            // txtAddRoleUsr
            // 
            this.txtAddRoleUsr.Location = new System.Drawing.Point(153, 22);
            this.txtAddRoleUsr.Name = "txtAddRoleUsr";
            this.txtAddRoleUsr.Size = new System.Drawing.Size(181, 20);
            this.txtAddRoleUsr.TabIndex = 9;
            // 
            // btnAddInRole
            // 
            this.btnAddInRole.Location = new System.Drawing.Point(175, 81);
            this.btnAddInRole.Name = "btnAddInRole";
            this.btnAddInRole.Size = new System.Drawing.Size(75, 23);
            this.btnAddInRole.TabIndex = 9;
            this.btnAddInRole.Text = "Agregar";
            this.btnAddInRole.UseVisualStyleBackColor = true;
            this.btnAddInRole.Click += new System.EventHandler(this.btnAddInRole_Click);
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(45, 46);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(160, 20);
            this.lblActions.TabIndex = 12;
            this.lblActions.Text = "Acciones Disponibles";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.aspnet_UsersInRolesDataGridView);
            this.panel5.Controls.Add(this.aspnet_RolesDataGridView);
            this.panel5.Location = new System.Drawing.Point(34, 284);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(795, 254);
            this.panel5.TabIndex = 13;
            // 
            // aspnet_UsersInRolesDataGridView
            // 
            this.aspnet_UsersInRolesDataGridView.AllowUserToAddRows = false;
            this.aspnet_UsersInRolesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aspnet_UsersInRolesDataGridView.AutoGenerateColumns = false;
            this.aspnet_UsersInRolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aspnet_UsersInRolesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aspnet_UsersInRolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aspnet_UsersInRolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aspnet_UsersInRolesDataGridView.DataSource = this.aspnet_UsersInRolesBindingSource;
            this.aspnet_UsersInRolesDataGridView.Location = new System.Drawing.Point(363, 22);
            this.aspnet_UsersInRolesDataGridView.Name = "aspnet_UsersInRolesDataGridView";
            this.aspnet_UsersInRolesDataGridView.Size = new System.Drawing.Size(415, 213);
            this.aspnet_UsersInRolesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UserId";
            this.dataGridViewTextBoxColumn6.DataSource = this.aspnetUsersBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "UserName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "UserId";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RoleId";
            this.dataGridViewTextBoxColumn7.DataSource = this.aspnetRolesBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "RoleName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Role";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "RoleId";
            // 
            // aspnet_UsersInRolesBindingSource
            // 
            this.aspnet_UsersInRolesBindingSource.DataMember = "FK__aspnet_Us__RoleI__797309D9";
            this.aspnet_UsersInRolesBindingSource.DataSource = this.aspnet_RolesBindingSource;
            // 
            // aspnet_RolesDataGridView
            // 
            this.aspnet_RolesDataGridView.AllowUserToAddRows = false;
            this.aspnet_RolesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aspnet_RolesDataGridView.AutoGenerateColumns = false;
            this.aspnet_RolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aspnet_RolesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.aspnet_RolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aspnet_RolesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.aspnet_RolesDataGridView.DataSource = this.aspnet_RolesBindingSource;
            this.aspnet_RolesDataGridView.Location = new System.Drawing.Point(22, 22);
            this.aspnet_RolesDataGridView.Name = "aspnet_RolesDataGridView";
            this.aspnet_RolesDataGridView.Size = new System.Drawing.Size(315, 213);
            this.aspnet_RolesDataGridView.TabIndex = 0;
            this.aspnet_RolesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aspnet_RolesDataGridView_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Detalles ";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoleId";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoleId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoleName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoweredRoleName";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoweredRoleName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmRoleManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.panel4);
            this.Name = "frmRoleManagment";
            this.Text = "Administración - Gestión de Roles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRoleManagment_FormClosing);
            this.Load += new System.EventHandler(this.frmRoleManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_RolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetRolesBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersInRolesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersInRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_RolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource aspnet_RolesBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_RolesTableAdapter aspnet_RolesTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersInRolesTableAdapter aspnet_UsersInRolesTableAdapter;
        private System.Windows.Forms.BindingSource aspnet_UsersInRolesBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private System.Windows.Forms.BindingSource aspnetUsersBindingSource;
        private System.Windows.Forms.BindingSource aspnetRolesBindingSource;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.TextBox txtAddRole;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelRoleUser;
        private System.Windows.Forms.TextBox txtAddInRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddRoleUsr;
        private System.Windows.Forms.Button btnAddInRole;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView aspnet_UsersInRolesDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridView aspnet_RolesDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
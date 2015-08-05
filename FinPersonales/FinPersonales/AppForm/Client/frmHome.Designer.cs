﻿namespace FinPersonales
{
    partial class frmHome
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeContenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.transaccionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aspnetUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transaccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lblActiveAccount = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transaccionesTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TransaccionesTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.tipoTransaccionTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoTransaccionTableAdapter();
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tipoPagoTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.cuentaToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.egresosToolStripMenuItem,
            this.serviciosToolStripMenuItem1});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresos";
            // 
            // egresosToolStripMenuItem
            // 
            this.egresosToolStripMenuItem.Name = "egresosToolStripMenuItem";
            this.egresosToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.egresosToolStripMenuItem.Text = "Egresos";
            // 
            // serviciosToolStripMenuItem1
            // 
            this.serviciosToolStripMenuItem1.Name = "serviciosToolStripMenuItem1";
            this.serviciosToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.serviciosToolStripMenuItem1.Text = "Servicios";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.listarServiciosToolStripMenuItem,
            this.listarCuentasToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.cuentaToolStripMenuItem.Text = "Cuentas";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            // 
            // listarServiciosToolStripMenuItem
            // 
            this.listarServiciosToolStripMenuItem.Name = "listarServiciosToolStripMenuItem";
            this.listarServiciosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listarServiciosToolStripMenuItem.Text = "Listar Servicios";
            // 
            // listarCuentasToolStripMenuItem
            // 
            this.listarCuentasToolStripMenuItem.Name = "listarCuentasToolStripMenuItem";
            this.listarCuentasToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listarCuentasToolStripMenuItem.Text = "Listar Cuentas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeUsuariosToolStripMenuItem,
            this.gestiónDeRolesToolStripMenuItem,
            this.gestiónDeContenidoToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestiónDeUsuariosToolStripMenuItem
            // 
            this.gestiónDeUsuariosToolStripMenuItem.Name = "gestiónDeUsuariosToolStripMenuItem";
            this.gestiónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeUsuariosToolStripMenuItem.Text = "Gestión de Usuarios";
            this.gestiónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeUsuariosToolStripMenuItem_Click);
            // 
            // gestiónDeRolesToolStripMenuItem
            // 
            this.gestiónDeRolesToolStripMenuItem.Name = "gestiónDeRolesToolStripMenuItem";
            this.gestiónDeRolesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeRolesToolStripMenuItem.Text = "Gestión de Roles";
            this.gestiónDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestiónDeRolesToolStripMenuItem_Click);
            // 
            // gestiónDeContenidoToolStripMenuItem
            // 
            this.gestiónDeContenidoToolStripMenuItem.Name = "gestiónDeContenidoToolStripMenuItem";
            this.gestiónDeContenidoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.gestiónDeContenidoToolStripMenuItem.Text = "Gestión de Contenido";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinPersonales.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(755, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bienvenido";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 244);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.transaccionesDataGridView);
            this.panel2.Location = new System.Drawing.Point(12, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 276);
            this.panel2.TabIndex = 14;
            // 
            // transaccionesDataGridView
            // 
            this.transaccionesDataGridView.AllowUserToAddRows = false;
            this.transaccionesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transaccionesDataGridView.AutoGenerateColumns = false;
            this.transaccionesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaccionesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.transaccionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transaccionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.transaccionesDataGridView.DataSource = this.transaccionesBindingSource;
            this.transaccionesDataGridView.Location = new System.Drawing.Point(16, 36);
            this.transaccionesDataGridView.Name = "transaccionesDataGridView";
            this.transaccionesDataGridView.Size = new System.Drawing.Size(746, 220);
            this.transaccionesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "No";
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.DataSource = this.tipoTransaccionBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Desripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            // 
            // tipoTransaccionBindingSource
            // 
            this.tipoTransaccionBindingSource.DataMember = "TipoTransaccion";
            this.tipoTransaccionBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn3.DataSource = this.aspnetUsersBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "UserName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "UserId";
            // 
            // aspnetUsersBindingSource
            // 
            this.aspnetUsersBindingSource.DataMember = "aspnet_Users";
            this.aspnetUsersBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoPago";
            this.dataGridViewTextBoxColumn4.DataSource = this.tipoPagoBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoPago";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            // 
            // tipoPagoBindingSource
            // 
            this.tipoPagoBindingSource.DataMember = "TipoPago";
            this.tipoPagoBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaTransaccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "FechaTransaccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FechaRegistrada";
            this.dataGridViewTextBoxColumn6.HeaderText = "FechaRegistrada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Monto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comentario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RefId";
            this.dataGridViewTextBoxColumn9.HeaderText = "RefId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // transaccionesBindingSource
            // 
            this.transaccionesBindingSource.DataMember = "Transacciones";
            this.transaccionesBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(532, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(260, 244);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(324, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 244);
            this.panel4.TabIndex = 14;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(350, 64);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(82, 20);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "userName";
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(24, 88);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(167, 20);
            this.lblUserDetails.TabIndex = 16;
            this.lblUserDetails.Text = "Detalles de Usuario";
            // 
            // lblActiveAccount
            // 
            this.lblActiveAccount.AutoSize = true;
            this.lblActiveAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveAccount.Location = new System.Drawing.Point(333, 88);
            this.lblActiveAccount.Name = "lblActiveAccount";
            this.lblActiveAccount.Size = new System.Drawing.Size(139, 20);
            this.lblActiveAccount.TabIndex = 17;
            this.lblActiveAccount.Text = "Cuentas Activas";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(545, 88);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(144, 20);
            this.lblServices.TabIndex = 18;
            this.lblServices.Text = "Servicios Activos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Últimas Transacciones";
            // 
            // transaccionesTableAdapter
            // 
            this.transaccionesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TransaccionesTableAdapter = this.transaccionesTableAdapter;
            this.tableAdapterManager.UpdateOrder = FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioCuentasTableAdapter = null;
            // 
            // tipoTransaccionTableAdapter
            // 
            this.tipoTransaccionTableAdapter.ClearBeforeFill = true;
            // 
            // aspnet_UsersTableAdapter
            // 
            this.aspnet_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tipoPagoTableAdapter
            // 
            this.tipoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.lblActiveAccount);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmHome";
            this.Text = "Finanzas Personales - Inicio";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnetUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeContenidoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Label lblActiveAccount;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label label2;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource transaccionesBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TransaccionesTableAdapter transaccionesTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView transaccionesDataGridView;
        private System.Windows.Forms.BindingSource tipoTransaccionBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoTransaccionTableAdapter tipoTransaccionTableAdapter;
        private System.Windows.Forms.BindingSource aspnetUsersBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private System.Windows.Forms.BindingSource tipoPagoBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter tipoPagoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
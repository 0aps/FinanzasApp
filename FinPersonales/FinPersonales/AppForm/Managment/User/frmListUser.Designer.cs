namespace FinPersonales
{
    partial class frmListUser
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label lastActivityDateLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label createDateLabel;
            System.Windows.Forms.Label lastLoginDateLabel;
            System.Windows.Forms.Label lastPasswordChangedDateLabel;
            System.Windows.Forms.Label failedPasswordAttemptCountLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label limiteEgresosLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label fotoPerfilLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListUser));
            System.Windows.Forms.Label label3;
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.aspnet_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_MembershipTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter();
            this.detalleUsuariosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.aspnet_UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aspnet_UsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.lastActivityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.aspnet_MembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastLoginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastPasswordChangedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.failedPasswordAttemptCountTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.limiteEgresosTextBox = new System.Windows.Forms.TextBox();
            this.tipoPersonaTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fotoPerfilPictureBox = new System.Windows.Forms.PictureBox();
            this.lblPanelDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPassword = new System.Windows.Forms.Button();
            this.chckLockState = new System.Windows.Forms.CheckBox();
            this.btnLockState = new System.Windows.Forms.Button();
            userIdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            lastActivityDateLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            createDateLabel = new System.Windows.Forms.Label();
            lastLoginDateLabel = new System.Windows.Forms.Label();
            lastPasswordChangedDateLabel = new System.Windows.Forms.Label();
            failedPasswordAttemptCountLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            limiteEgresosLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            fotoPerfilLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingNavigator)).BeginInit();
            this.aspnet_UsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_MembershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(30, 28);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(75, 13);
            userIdLabel.TabIndex = 3;
            userIdLabel.Text = "Id del Usuario:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(456, 36);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(46, 13);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "Usuario:";
            // 
            // lastActivityDateLabel
            // 
            lastActivityDateLabel.AutoSize = true;
            lastActivityDateLabel.Location = new System.Drawing.Point(378, 35);
            lastActivityDateLabel.Name = "lastActivityDateLabel";
            lastActivityDateLabel.Size = new System.Drawing.Size(72, 26);
            lastActivityDateLabel.TabIndex = 13;
            lastActivityDateLabel.Text = "Última Fecha \r\nde Actividad:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(456, 59);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(61, 13);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Contraseña";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(456, 85);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(30, 68);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(52, 26);
            createDateLabel.TabIndex = 39;
            createDateLabel.Text = "Fecha de\r\nCreación:";
            // 
            // lastLoginDateLabel
            // 
            lastLoginDateLabel.AutoSize = true;
            lastLoginDateLabel.Location = new System.Drawing.Point(378, 70);
            lastLoginDateLabel.Name = "lastLoginDateLabel";
            lastLoginDateLabel.Size = new System.Drawing.Size(69, 26);
            lastLoginDateLabel.TabIndex = 41;
            lastLoginDateLabel.Text = "Última Fecha\r\nde Acceso:";
            // 
            // lastPasswordChangedDateLabel
            // 
            lastPasswordChangedDateLabel.AutoSize = true;
            lastPasswordChangedDateLabel.Location = new System.Drawing.Point(30, 103);
            lastPasswordChangedDateLabel.Name = "lastPasswordChangedDateLabel";
            lastPasswordChangedDateLabel.Size = new System.Drawing.Size(79, 26);
            lastPasswordChangedDateLabel.TabIndex = 43;
            lastPasswordChangedDateLabel.Text = "Último Cambio\r\nde Contraseña:";
            // 
            // failedPasswordAttemptCountLabel
            // 
            failedPasswordAttemptCountLabel.AutoSize = true;
            failedPasswordAttemptCountLabel.Location = new System.Drawing.Point(378, 103);
            failedPasswordAttemptCountLabel.Name = "failedPasswordAttemptCountLabel";
            failedPasswordAttemptCountLabel.Size = new System.Drawing.Size(83, 26);
            failedPasswordAttemptCountLabel.TabIndex = 47;
            failedPasswordAttemptCountLabel.Text = "Intentos Fallidos\r\nde Acceso:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(227, 33);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 59;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(224, 62);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(52, 13);
            apellidoLabel.TabIndex = 61;
            apellidoLabel.Text = "Apellidos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(224, 88);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 63;
            telefonoLabel.Text = "Telefono:";
            // 
            // limiteEgresosLabel
            // 
            limiteEgresosLabel.AutoSize = true;
            limiteEgresosLabel.Location = new System.Drawing.Point(224, 114);
            limiteEgresosLabel.Name = "limiteEgresosLabel";
            limiteEgresosLabel.Size = new System.Drawing.Size(78, 13);
            limiteEgresosLabel.TabIndex = 65;
            limiteEgresosLabel.Text = "Limite Egresos:";
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Location = new System.Drawing.Point(12, 531);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(73, 13);
            tipoPersonaLabel.TabIndex = 67;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(12, 559);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 69;
            estadoLabel.Text = "Estado:";
            // 
            // fotoPerfilLabel
            // 
            fotoPerfilLabel.AutoSize = true;
            fotoPerfilLabel.Location = new System.Drawing.Point(68, 134);
            fotoPerfilLabel.Name = "fotoPerfilLabel";
            fotoPerfilLabel.Size = new System.Drawing.Size(83, 13);
            fotoPerfilLabel.TabIndex = 71;
            fotoPerfilLabel.Text = "Imagen de Perfil";
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
        
            // 
            // aspnet_MembershipTableAdapter
            // 
            this.aspnet_MembershipTableAdapter.ClearBeforeFill = true;
            // 
            // detalleUsuariosTableAdapter
            // 
            this.detalleUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // aspnet_UsersBindingNavigator
            // 
            this.aspnet_UsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aspnet_UsersBindingNavigator.BindingSource = this.aspnet_UsersBindingSource;
            this.aspnet_UsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aspnet_UsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aspnet_UsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aspnet_UsersBindingNavigatorSaveItem});
            this.aspnet_UsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aspnet_UsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aspnet_UsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aspnet_UsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aspnet_UsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aspnet_UsersBindingNavigator.Name = "aspnet_UsersBindingNavigator";
            this.aspnet_UsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aspnet_UsersBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.aspnet_UsersBindingNavigator.TabIndex = 0;
            this.aspnet_UsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aspnet_UsersBindingNavigatorSaveItem
            // 
            this.aspnet_UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aspnet_UsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aspnet_UsersBindingNavigatorSaveItem.Image")));
            this.aspnet_UsersBindingNavigatorSaveItem.Name = "aspnet_UsersBindingNavigatorSaveItem";
            this.aspnet_UsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aspnet_UsersBindingNavigatorSaveItem.Text = "Save Data";
            this.aspnet_UsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.aspnet_UsersBindingNavigatorSaveItem_Click_1);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_UsersBindingSource, "UserId", true));
            this.userIdTextBox.Location = new System.Drawing.Point(119, 28);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIdTextBox.TabIndex = 4;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_UsersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(569, 33);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userNameTextBox.TabIndex = 6;
            // 
            // lastActivityDateDateTimePicker
            // 
            this.lastActivityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_UsersBindingSource, "LastActivityDate", true));
            this.lastActivityDateDateTimePicker.Enabled = false;
            this.lastActivityDateDateTimePicker.Location = new System.Drawing.Point(493, 28);
            this.lastActivityDateDateTimePicker.Name = "lastActivityDateDateTimePicker";
            this.lastActivityDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastActivityDateDateTimePicker.TabIndex = 14;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(569, 58);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 20;
            // 
            // aspnet_MembershipBindingSource
            // 
            this.aspnet_MembershipBindingSource.DataMember = "FK__aspnet_Me__UserI__571DF1D5";
            this.aspnet_MembershipBindingSource.DataSource = this.aspnet_UsersBindingSource;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(569, 84);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 28;
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Enabled = false;
            this.createDateDateTimePicker.Location = new System.Drawing.Point(119, 62);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker.TabIndex = 40;
            // 
            // lastLoginDateDateTimePicker
            // 
            this.lastLoginDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "LastLoginDate", true));
            this.lastLoginDateDateTimePicker.Enabled = false;
            this.lastLoginDateDateTimePicker.Location = new System.Drawing.Point(493, 64);
            this.lastLoginDateDateTimePicker.Name = "lastLoginDateDateTimePicker";
            this.lastLoginDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastLoginDateDateTimePicker.TabIndex = 42;
            // 
            // lastPasswordChangedDateDateTimePicker
            // 
            this.lastPasswordChangedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "LastPasswordChangedDate", true));
            this.lastPasswordChangedDateDateTimePicker.Enabled = false;
            this.lastPasswordChangedDateDateTimePicker.Location = new System.Drawing.Point(119, 109);
            this.lastPasswordChangedDateDateTimePicker.Name = "lastPasswordChangedDateDateTimePicker";
            this.lastPasswordChangedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastPasswordChangedDateDateTimePicker.TabIndex = 44;
            // 
            // failedPasswordAttemptCountTextBox
            // 
            this.failedPasswordAttemptCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "FailedPasswordAttemptCount", true));
            this.failedPasswordAttemptCountTextBox.Location = new System.Drawing.Point(493, 109);
            this.failedPasswordAttemptCountTextBox.Name = "failedPasswordAttemptCountTextBox";
            this.failedPasswordAttemptCountTextBox.ReadOnly = true;
            this.failedPasswordAttemptCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.failedPasswordAttemptCountTextBox.TabIndex = 48;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(308, 33);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 60;
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "FK_DetalleUsuarios_aspnet_Users";
            this.detalleUsuariosBindingSource.DataSource = this.aspnet_UsersBindingSource;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(308, 59);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(104, 20);
            this.apellidoTextBox.TabIndex = 62;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(308, 85);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(104, 20);
            this.telefonoTextBox.TabIndex = 64;
            // 
            // limiteEgresosTextBox
            // 
            this.limiteEgresosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "LimiteEgresos", true));
            this.limiteEgresosTextBox.Location = new System.Drawing.Point(308, 111);
            this.limiteEgresosTextBox.Name = "limiteEgresosTextBox";
            this.limiteEgresosTextBox.Size = new System.Drawing.Size(104, 20);
            this.limiteEgresosTextBox.TabIndex = 66;
            // 
            // tipoPersonaTextBox
            // 
            this.tipoPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "TipoPersona", true));
            this.tipoPersonaTextBox.Location = new System.Drawing.Point(96, 528);
            this.tipoPersonaTextBox.Name = "tipoPersonaTextBox";
            this.tipoPersonaTextBox.Size = new System.Drawing.Size(104, 20);
            this.tipoPersonaTextBox.TabIndex = 68;
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.detalleUsuariosBindingSource, "Estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(96, 554);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoCheckBox.TabIndex = 70;
            this.estadoCheckBox.Text = "checkBox1";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chckLockState);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.fotoPerfilPictureBox);
            this.panel1.Controls.Add(fotoPerfilLabel);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(limiteEgresosLabel);
            this.panel1.Controls.Add(this.limiteEgresosTextBox);
            this.panel1.Controls.Add(tipoPersonaLabel);
            this.panel1.Controls.Add(this.tipoPersonaTextBox);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.estadoCheckBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Location = new System.Drawing.Point(27, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 383);
            this.panel1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Detalles del Sistema";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userIdTextBox);
            this.panel2.Controls.Add(createDateLabel);
            this.panel2.Controls.Add(this.createDateDateTimePicker);
            this.panel2.Controls.Add(lastLoginDateLabel);
            this.panel2.Controls.Add(this.lastLoginDateDateTimePicker);
            this.panel2.Controls.Add(this.lastActivityDateDateTimePicker);
            this.panel2.Controls.Add(lastPasswordChangedDateLabel);
            this.panel2.Controls.Add(this.lastPasswordChangedDateDateTimePicker);
            this.panel2.Controls.Add(lastActivityDateLabel);
            this.panel2.Controls.Add(failedPasswordAttemptCountLabel);
            this.panel2.Controls.Add(this.failedPasswordAttemptCountTextBox);
            this.panel2.Controls.Add(userIdLabel);
            this.panel2.Location = new System.Drawing.Point(28, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 165);
            this.panel2.TabIndex = 73;
            // 
            // fotoPerfilPictureBox
            // 
            this.fotoPerfilPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoPerfilPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.detalleUsuariosBindingSource, "fotoPerfil", true));
            this.fotoPerfilPictureBox.Location = new System.Drawing.Point(28, 23);
            this.fotoPerfilPictureBox.Name = "fotoPerfilPictureBox";
            this.fotoPerfilPictureBox.Size = new System.Drawing.Size(163, 104);
            this.fotoPerfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfilPictureBox.TabIndex = 72;
            this.fotoPerfilPictureBox.TabStop = false;
            this.fotoPerfilPictureBox.Click += new System.EventHandler(this.fotoPerfilPictureBox_Click);
            // 
            // lblPanelDescription
            // 
            this.lblPanelDescription.AutoSize = true;
            this.lblPanelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelDescription.Location = new System.Drawing.Point(41, 52);
            this.lblPanelDescription.Name = "lblPanelDescription";
            this.lblPanelDescription.Size = new System.Drawing.Size(177, 20);
            this.lblPanelDescription.TabIndex = 74;
            this.lblPanelDescription.Text = "Información del Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Detalles Personales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(725, 17);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(90, 38);
            this.btnPassword.TabIndex = 77;
            this.btnPassword.Text = "Cambiar Contraseña";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(456, 114);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 13);
            label3.TabIndex = 77;
            label3.Text = "Bloqueado:";
            // 
            // chckLockState
            // 
            this.chckLockState.AutoSize = true;
            this.chckLockState.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.aspnet_MembershipBindingSource, "IsLockedOut", true));
            this.chckLockState.Enabled = false;
            this.chckLockState.Location = new System.Drawing.Point(569, 114);
            this.chckLockState.Name = "chckLockState";
            this.chckLockState.Size = new System.Drawing.Size(15, 14);
            this.chckLockState.TabIndex = 78;
            this.chckLockState.UseVisualStyleBackColor = true;
            // 
            // btnLockState
            // 
            this.btnLockState.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.aspnet_MembershipBindingSource, "IsLockedOut", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.btnLockState.Location = new System.Drawing.Point(629, 17);
            this.btnLockState.Name = "btnLockState";
            this.btnLockState.Size = new System.Drawing.Size(90, 38);
            this.btnLockState.TabIndex = 78;
            this.btnLockState.Text = "Desbloquear";
            this.btnLockState.UseVisualStyleBackColor = true;
            this.btnLockState.Click += new System.EventHandler(this.btnLockState_Click);
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 465);
            this.Controls.Add(this.btnLockState);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPanelDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.aspnet_UsersBindingNavigator);
            this.Name = "frmListUser";
            this.Text = "Gestión de Usuarios - Listar ";
            this.Load += new System.EventHandler(this.frmListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingNavigator)).EndInit();
            this.aspnet_UsersBindingNavigator.ResumeLayout(false);
            this.aspnet_UsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_MembershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource aspnet_UsersBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aspnet_UsersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aspnet_UsersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.DateTimePicker lastActivityDateDateTimePicker;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter aspnet_MembershipTableAdapter;
        private System.Windows.Forms.BindingSource aspnet_MembershipBindingSource;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker createDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastLoginDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastPasswordChangedDateDateTimePicker;
        private System.Windows.Forms.TextBox failedPasswordAttemptCountTextBox;
        private AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource detalleUsuariosBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox limiteEgresosTextBox;
        private System.Windows.Forms.TextBox tipoPersonaTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.PictureBox fotoPerfilPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPanelDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.CheckBox chckLockState;
        private System.Windows.Forms.Button btnLockState;


    }
}
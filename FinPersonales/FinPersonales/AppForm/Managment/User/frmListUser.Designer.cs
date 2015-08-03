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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListUser));
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
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.aspnet_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.aspnet_UsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.lastActivityDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aspnet_MembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_MembershipTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.createDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastLoginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastPasswordChangedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.failedPasswordAttemptCountTextBox = new System.Windows.Forms.TextBox();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleUsuariosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.limiteEgresosTextBox = new System.Windows.Forms.TextBox();
            this.tipoPersonaTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.fotoPerfilPictureBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingNavigator)).BeginInit();
            this.aspnet_UsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_MembershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfilPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.UsuarioCuentasTableAdapter = null;
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
            this.aspnet_UsersBindingNavigator.Size = new System.Drawing.Size(604, 25);
            this.aspnet_UsersBindingNavigator.TabIndex = 0;
            this.aspnet_UsersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // aspnet_UsersBindingNavigatorSaveItem
            // 
            this.aspnet_UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aspnet_UsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aspnet_UsersBindingNavigatorSaveItem.Image")));
            this.aspnet_UsersBindingNavigatorSaveItem.Name = "aspnet_UsersBindingNavigatorSaveItem";
            this.aspnet_UsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.aspnet_UsersBindingNavigatorSaveItem.Text = "Save Data";
            this.aspnet_UsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.aspnet_UsersBindingNavigatorSaveItem_Click_1);
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(41, 59);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 3;
            userIdLabel.Text = "User Id:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_UsersBindingSource, "UserId", true));
            this.userIdTextBox.Location = new System.Drawing.Point(154, 56);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.userIdTextBox.TabIndex = 4;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(41, 85);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 5;
            userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_UsersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(154, 82);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.userNameTextBox.TabIndex = 6;
            // 
            // lastActivityDateLabel
            // 
            lastActivityDateLabel.AutoSize = true;
            lastActivityDateLabel.Location = new System.Drawing.Point(41, 114);
            lastActivityDateLabel.Name = "lastActivityDateLabel";
            lastActivityDateLabel.Size = new System.Drawing.Size(93, 13);
            lastActivityDateLabel.TabIndex = 13;
            lastActivityDateLabel.Text = "Last Activity Date:";
            // 
            // lastActivityDateDateTimePicker
            // 
            this.lastActivityDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_UsersBindingSource, "LastActivityDate", true));
            this.lastActivityDateDateTimePicker.Location = new System.Drawing.Point(154, 110);
            this.lastActivityDateDateTimePicker.Name = "lastActivityDateDateTimePicker";
            this.lastActivityDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastActivityDateDateTimePicker.TabIndex = 14;
            // 
            // aspnet_MembershipBindingSource
            // 
            this.aspnet_MembershipBindingSource.DataMember = "FK__aspnet_Me__UserI__571DF1D5";
            this.aspnet_MembershipBindingSource.DataSource = this.aspnet_UsersBindingSource;
            // 
            // aspnet_MembershipTableAdapter
            // 
            this.aspnet_MembershipTableAdapter.ClearBeforeFill = true;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(41, 137);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(154, 136);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 20;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(41, 163);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 27;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(154, 162);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 28;
            // 
            // createDateLabel
            // 
            createDateLabel.AutoSize = true;
            createDateLabel.Location = new System.Drawing.Point(41, 187);
            createDateLabel.Name = "createDateLabel";
            createDateLabel.Size = new System.Drawing.Size(67, 13);
            createDateLabel.TabIndex = 39;
            createDateLabel.Text = "Create Date:";
            // 
            // createDateDateTimePicker
            // 
            this.createDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "CreateDate", true));
            this.createDateDateTimePicker.Location = new System.Drawing.Point(278, 183);
            this.createDateDateTimePicker.Name = "createDateDateTimePicker";
            this.createDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.createDateDateTimePicker.TabIndex = 40;
            // 
            // lastLoginDateLabel
            // 
            lastLoginDateLabel.AutoSize = true;
            lastLoginDateLabel.Location = new System.Drawing.Point(41, 213);
            lastLoginDateLabel.Name = "lastLoginDateLabel";
            lastLoginDateLabel.Size = new System.Drawing.Size(85, 13);
            lastLoginDateLabel.TabIndex = 41;
            lastLoginDateLabel.Text = "Last Login Date:";
            // 
            // lastLoginDateDateTimePicker
            // 
            this.lastLoginDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "LastLoginDate", true));
            this.lastLoginDateDateTimePicker.Location = new System.Drawing.Point(278, 209);
            this.lastLoginDateDateTimePicker.Name = "lastLoginDateDateTimePicker";
            this.lastLoginDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastLoginDateDateTimePicker.TabIndex = 42;
            // 
            // lastPasswordChangedDateLabel
            // 
            lastPasswordChangedDateLabel.AutoSize = true;
            lastPasswordChangedDateLabel.Location = new System.Drawing.Point(41, 239);
            lastPasswordChangedDateLabel.Name = "lastPasswordChangedDateLabel";
            lastPasswordChangedDateLabel.Size = new System.Drawing.Size(151, 13);
            lastPasswordChangedDateLabel.TabIndex = 43;
            lastPasswordChangedDateLabel.Text = "Last Password Changed Date:";
            // 
            // lastPasswordChangedDateDateTimePicker
            // 
            this.lastPasswordChangedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aspnet_MembershipBindingSource, "LastPasswordChangedDate", true));
            this.lastPasswordChangedDateDateTimePicker.Location = new System.Drawing.Point(278, 235);
            this.lastPasswordChangedDateDateTimePicker.Name = "lastPasswordChangedDateDateTimePicker";
            this.lastPasswordChangedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastPasswordChangedDateDateTimePicker.TabIndex = 44;
            // 
            // failedPasswordAttemptCountLabel
            // 
            failedPasswordAttemptCountLabel.AutoSize = true;
            failedPasswordAttemptCountLabel.Location = new System.Drawing.Point(41, 271);
            failedPasswordAttemptCountLabel.Name = "failedPasswordAttemptCountLabel";
            failedPasswordAttemptCountLabel.Size = new System.Drawing.Size(157, 13);
            failedPasswordAttemptCountLabel.TabIndex = 47;
            failedPasswordAttemptCountLabel.Text = "Failed Password Attempt Count:";
            // 
            // failedPasswordAttemptCountTextBox
            // 
            this.failedPasswordAttemptCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "FailedPasswordAttemptCount", true));
            this.failedPasswordAttemptCountTextBox.Location = new System.Drawing.Point(278, 271);
            this.failedPasswordAttemptCountTextBox.Name = "failedPasswordAttemptCountTextBox";
            this.failedPasswordAttemptCountTextBox.Size = new System.Drawing.Size(200, 20);
            this.failedPasswordAttemptCountTextBox.TabIndex = 48;
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "FK_DetalleUsuarios_aspnet_Users";
            this.detalleUsuariosBindingSource.DataSource = this.aspnet_UsersBindingSource;
            // 
            // detalleUsuariosTableAdapter
            // 
            this.detalleUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(41, 313);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 59;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(125, 310);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(104, 20);
            this.nombreTextBox.TabIndex = 60;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(41, 339);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 61;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(125, 336);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(104, 20);
            this.apellidoTextBox.TabIndex = 62;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(41, 365);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 63;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(125, 362);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(104, 20);
            this.telefonoTextBox.TabIndex = 64;
            // 
            // limiteEgresosLabel
            // 
            limiteEgresosLabel.AutoSize = true;
            limiteEgresosLabel.Location = new System.Drawing.Point(41, 391);
            limiteEgresosLabel.Name = "limiteEgresosLabel";
            limiteEgresosLabel.Size = new System.Drawing.Size(78, 13);
            limiteEgresosLabel.TabIndex = 65;
            limiteEgresosLabel.Text = "Limite Egresos:";
            // 
            // limiteEgresosTextBox
            // 
            this.limiteEgresosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "LimiteEgresos", true));
            this.limiteEgresosTextBox.Location = new System.Drawing.Point(125, 388);
            this.limiteEgresosTextBox.Name = "limiteEgresosTextBox";
            this.limiteEgresosTextBox.Size = new System.Drawing.Size(104, 20);
            this.limiteEgresosTextBox.TabIndex = 66;
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Location = new System.Drawing.Point(41, 417);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(73, 13);
            tipoPersonaLabel.TabIndex = 67;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // tipoPersonaTextBox
            // 
            this.tipoPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "TipoPersona", true));
            this.tipoPersonaTextBox.Location = new System.Drawing.Point(125, 414);
            this.tipoPersonaTextBox.Name = "tipoPersonaTextBox";
            this.tipoPersonaTextBox.Size = new System.Drawing.Size(104, 20);
            this.tipoPersonaTextBox.TabIndex = 68;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(41, 445);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 69;
            estadoLabel.Text = "Estado:";
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.detalleUsuariosBindingSource, "Estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(125, 440);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.estadoCheckBox.TabIndex = 70;
            this.estadoCheckBox.Text = "checkBox1";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fotoPerfilLabel
            // 
            fotoPerfilLabel.AutoSize = true;
            fotoPerfilLabel.Location = new System.Drawing.Point(41, 470);
            fotoPerfilLabel.Name = "fotoPerfilLabel";
            fotoPerfilLabel.Size = new System.Drawing.Size(54, 13);
            fotoPerfilLabel.TabIndex = 71;
            fotoPerfilLabel.Text = "foto Perfil:";
            // 
            // fotoPerfilPictureBox
            // 
            this.fotoPerfilPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.detalleUsuariosBindingSource, "fotoPerfil", true));
            this.fotoPerfilPictureBox.Location = new System.Drawing.Point(125, 470);
            this.fotoPerfilPictureBox.Name = "fotoPerfilPictureBox";
            this.fotoPerfilPictureBox.Size = new System.Drawing.Size(314, 96);
            this.fotoPerfilPictureBox.TabIndex = 72;
            this.fotoPerfilPictureBox.TabStop = false;
            // 
            // frmListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 578);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(limiteEgresosLabel);
            this.Controls.Add(this.limiteEgresosTextBox);
            this.Controls.Add(tipoPersonaLabel);
            this.Controls.Add(this.tipoPersonaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckBox);
            this.Controls.Add(fotoPerfilLabel);
            this.Controls.Add(this.fotoPerfilPictureBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(createDateLabel);
            this.Controls.Add(this.createDateDateTimePicker);
            this.Controls.Add(lastLoginDateLabel);
            this.Controls.Add(this.lastLoginDateDateTimePicker);
            this.Controls.Add(lastPasswordChangedDateLabel);
            this.Controls.Add(this.lastPasswordChangedDateDateTimePicker);
            this.Controls.Add(failedPasswordAttemptCountLabel);
            this.Controls.Add(this.failedPasswordAttemptCountTextBox);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(lastActivityDateLabel);
            this.Controls.Add(this.lastActivityDateDateTimePicker);
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


    }
}
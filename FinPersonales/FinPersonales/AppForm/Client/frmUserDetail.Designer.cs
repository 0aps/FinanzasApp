namespace FinPersonales
{
    partial class frmUserDetail
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label limiteEgresosLabel;
            System.Windows.Forms.Label tipoPersonaLabel;
            System.Windows.Forms.Label fotoPerfilLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label emailLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.aspnet_MembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.detalleUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aspnet_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.limiteEgresosTextBox = new System.Windows.Forms.TextBox();
            this.tipoPersonaComboBox = new System.Windows.Forms.ComboBox();
            this.tipoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fotoPerfilPictureBox = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aspnet_UsersTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter();
            this.tableAdapterManager = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager();
            this.aspnet_MembershipTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter();
            this.detalleUsuariosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPassword = new System.Windows.Forms.Button();
            this.tipoPersonaTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoPersonaTableAdapter();
            userNameLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            limiteEgresosLabel = new System.Windows.Forms.Label();
            tipoPersonaLabel = new System.Windows.Forms.Label();
            fotoPerfilLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_MembershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfilPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(175, 39);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(46, 13);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Usuario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(39, 156);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(39, 182);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(39, 208);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Telefono:";
            // 
            // limiteEgresosLabel
            // 
            limiteEgresosLabel.AutoSize = true;
            limiteEgresosLabel.Location = new System.Drawing.Point(265, 152);
            limiteEgresosLabel.Name = "limiteEgresosLabel";
            limiteEgresosLabel.Size = new System.Drawing.Size(78, 13);
            limiteEgresosLabel.TabIndex = 8;
            limiteEgresosLabel.Text = "Limite Egresos:";
            // 
            // tipoPersonaLabel
            // 
            tipoPersonaLabel.AutoSize = true;
            tipoPersonaLabel.Location = new System.Drawing.Point(265, 178);
            tipoPersonaLabel.Name = "tipoPersonaLabel";
            tipoPersonaLabel.Size = new System.Drawing.Size(73, 13);
            tipoPersonaLabel.TabIndex = 10;
            tipoPersonaLabel.Text = "Tipo Persona:";
            // 
            // fotoPerfilLabel
            // 
            fotoPerfilLabel.AutoSize = true;
            fotoPerfilLabel.Location = new System.Drawing.Point(50, 124);
            fotoPerfilLabel.Name = "fotoPerfilLabel";
            fotoPerfilLabel.Size = new System.Drawing.Size(69, 13);
            fotoPerfilLabel.TabIndex = 12;
            fotoPerfilLabel.Text = "Foto de Perfil";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(175, 77);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(175, 107);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(passwordLabel);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Controls.Add(apellidoLabel);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(limiteEgresosLabel);
            this.panel1.Controls.Add(this.limiteEgresosTextBox);
            this.panel1.Controls.Add(tipoPersonaLabel);
            this.panel1.Controls.Add(this.tipoPersonaComboBox);
            this.panel1.Controls.Add(fotoPerfilLabel);
            this.panel1.Controls.Add(this.fotoPerfilPictureBox);
            this.panel1.Controls.Add(userNameLabel);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Location = new System.Drawing.Point(27, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 247);
            this.panel1.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(256, 104);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(127, 20);
            this.emailTextBox.TabIndex = 17;
            // 
            // aspnet_MembershipBindingSource
            // 
            this.aspnet_MembershipBindingSource.DataMember = "aspnet_Membership";
            this.aspnet_MembershipBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_MembershipBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(256, 74);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 15;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(123, 153);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBox.TabIndex = 3;
            // 
            // detalleUsuariosBindingSource
            // 
            this.detalleUsuariosBindingSource.DataMember = "FK_DetalleUsuarios_aspnet_Users";
            this.detalleUsuariosBindingSource.DataSource = this.aspnet_UsersBindingSource;
            // 
            // aspnet_UsersBindingSource
            // 
            this.aspnet_UsersBindingSource.DataMember = "aspnet_Users";
            this.aspnet_UsersBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(123, 179);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(121, 20);
            this.apellidoTextBox.TabIndex = 5;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(123, 205);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(121, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // limiteEgresosTextBox
            // 
            this.limiteEgresosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleUsuariosBindingSource, "LimiteEgresos", true));
            this.limiteEgresosTextBox.Location = new System.Drawing.Point(349, 149);
            this.limiteEgresosTextBox.Name = "limiteEgresosTextBox";
            this.limiteEgresosTextBox.Size = new System.Drawing.Size(73, 20);
            this.limiteEgresosTextBox.TabIndex = 9;
            // 
            // tipoPersonaComboBox
            // 
            this.tipoPersonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoPersonaBindingSource, "Id", true));
            this.tipoPersonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoPersonaBindingSource, "Descripcion", true));
            this.tipoPersonaComboBox.DataSource = this.tipoPersonaBindingSource;
            this.tipoPersonaComboBox.DisplayMember = "Descripcion";
            this.tipoPersonaComboBox.Enabled = false;
            this.tipoPersonaComboBox.FormattingEnabled = true;
            this.tipoPersonaComboBox.Location = new System.Drawing.Point(349, 175);
            this.tipoPersonaComboBox.Name = "tipoPersonaComboBox";
            this.tipoPersonaComboBox.Size = new System.Drawing.Size(73, 21);
            this.tipoPersonaComboBox.TabIndex = 11;
            this.tipoPersonaComboBox.ValueMember = "Id";
            // 
            // tipoPersonaBindingSource
            // 
            this.tipoPersonaBindingSource.DataMember = "TipoPersona";
            this.tipoPersonaBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // fotoPerfilPictureBox
            // 
            this.fotoPerfilPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.detalleUsuariosBindingSource, "fotoPerfil", true));
            this.fotoPerfilPictureBox.Location = new System.Drawing.Point(15, 26);
            this.fotoPerfilPictureBox.Name = "fotoPerfilPictureBox";
            this.fotoPerfilPictureBox.Size = new System.Drawing.Size(135, 95);
            this.fotoPerfilPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPerfilPictureBox.TabIndex = 13;
            this.fotoPerfilPictureBox.TabStop = false;
            this.fotoPerfilPictureBox.Click += new System.EventHandler(this.fotoPerfilPictureBox_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aspnet_UsersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(256, 39);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuración de Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detalles";
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(396, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(412, 7);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(77, 36);
            this.btnPassword.TabIndex = 78;
            this.btnPassword.Text = "Cambiar Contraseña";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // tipoPersonaTableAdapter
            // 
            this.tipoPersonaTableAdapter.ClearBeforeFill = true;
            // 
            // frmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 345);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUserDetail";
            this.Text = "Finanzas Personales - Configuración de Usuario";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_MembershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aspnet_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPerfilPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource aspnet_UsersBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_UsersTableAdapter aspnet_UsersTableAdapter;
        private AppData.FinPersonalesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox userNameTextBox;
        private AppData.FinPersonalesDataSetTableAdapters.DetalleUsuariosTableAdapter detalleUsuariosTableAdapter;
        private System.Windows.Forms.BindingSource detalleUsuariosBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox limiteEgresosTextBox;
        private System.Windows.Forms.ComboBox tipoPersonaComboBox;
        private System.Windows.Forms.PictureBox fotoPerfilPictureBox;
        private AppData.FinPersonalesDataSetTableAdapters.aspnet_MembershipTableAdapter aspnet_MembershipTableAdapter;
        private System.Windows.Forms.BindingSource aspnet_MembershipBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.BindingSource tipoPersonaBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoPersonaTableAdapter tipoPersonaTableAdapter;
    }
}
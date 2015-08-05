namespace FinPersonales
{
    partial class frmAddIncome
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.tipoIngresosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTypeIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagoTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter();
            this.quienPagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quienPagaTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.QuienPagaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quienPagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipoIngresosBindingSource;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(170, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Id";
            // 
            // tipoIngresosBindingSource
            // 
            this.tipoIngresosBindingSource.DataMember = "TipoIngresos";
            this.tipoIngresosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoIngresosTableAdapter
            // 
            this.tipoIngresosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.lblTypeIncome);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(24, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 316);
            this.panel1.TabIndex = 1;
            // 
            // lblTypeIncome
            // 
            this.lblTypeIncome.AutoSize = true;
            this.lblTypeIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeIncome.Location = new System.Drawing.Point(31, 95);
            this.lblTypeIncome.Name = "lblTypeIncome";
            this.lblTypeIncome.Size = new System.Drawing.Size(123, 20);
            this.lblTypeIncome.TabIndex = 1;
            this.lblTypeIncome.Text = "Tipo de Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrar Ingresos";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quienPagaBindingSource, "Descripcion", true));
            this.comboBox2.DataSource = this.quienPagaBindingSource;
            this.comboBox2.DisplayMember = "Descripcion";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(170, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Id";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(332, 362);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 171);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 125);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoPagoBindingSource, "Descripcion", true));
            this.comboBox3.DataSource = this.tipoPagoBindingSource;
            this.comboBox3.DisplayMember = "Descripcion";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(170, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Comentario:";
            // 
            // tipoPagoBindingSource
            // 
            this.tipoPagoBindingSource.DataMember = "TipoPago";
            this.tipoPagoBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // tipoPagoTableAdapter
            // 
            this.tipoPagoTableAdapter.ClearBeforeFill = true;
            // 
            // quienPagaBindingSource
            // 
            this.quienPagaBindingSource.DataMember = "QuienPaga";
            this.quienPagaBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // quienPagaTableAdapter
            // 
            this.quienPagaTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddIncome";
            this.Text = "Finanzas Personales - Registrar Ingreso";
            this.Load += new System.EventHandler(this.frmAddIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoIngresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quienPagaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource tipoIngresosBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter tipoIngresosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTypeIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource tipoPagoBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter tipoPagoTableAdapter;
        private System.Windows.Forms.BindingSource quienPagaBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.QuienPagaTableAdapter quienPagaTableAdapter;
    }
}
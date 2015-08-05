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
            this.cbTypeOfIncome = new System.Windows.Forms.ComboBox();
            this.tipoIngresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.tipoIngresosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeOfPay = new System.Windows.Forms.ComboBox();
            this.tipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.quienPagaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTypeIncome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tipoPagoTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter();
            this.quienPagaTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.QuienPagaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIngresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quienPagaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeOfIncome
            // 
            this.cbTypeOfIncome.DataSource = this.tipoIngresosBindingSource;
            this.cbTypeOfIncome.DisplayMember = "Descripcion";
            this.cbTypeOfIncome.FormattingEnabled = true;
            this.cbTypeOfIncome.Location = new System.Drawing.Point(170, 94);
            this.cbTypeOfIncome.Name = "cbTypeOfIncome";
            this.cbTypeOfIncome.Size = new System.Drawing.Size(129, 21);
            this.cbTypeOfIncome.TabIndex = 0;
            this.cbTypeOfIncome.ValueMember = "Id";
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
            this.panel1.Controls.Add(this.cbTypeOfPay);
            this.panel1.Controls.Add(this.txtComment);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbSource);
            this.panel1.Controls.Add(this.lblTypeIncome);
            this.panel1.Controls.Add(this.cbTypeOfIncome);
            this.panel1.Location = new System.Drawing.Point(24, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 316);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // cbTypeOfPay
            // 
            this.cbTypeOfPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoPagoBindingSource, "Descripcion", true));
            this.cbTypeOfPay.DataSource = this.tipoPagoBindingSource;
            this.cbTypeOfPay.DisplayMember = "Descripcion";
            this.cbTypeOfPay.FormattingEnabled = true;
            this.cbTypeOfPay.Location = new System.Drawing.Point(170, 62);
            this.cbTypeOfPay.Name = "cbTypeOfPay";
            this.cbTypeOfPay.Size = new System.Drawing.Size(129, 21);
            this.cbTypeOfPay.TabIndex = 6;
            this.cbTypeOfPay.ValueMember = "Id";
            // 
            // tipoPagoBindingSource
            // 
            this.tipoPagoBindingSource.DataMember = "TipoPago";
            this.tipoPagoBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(170, 171);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(192, 125);
            this.txtComment.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(170, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(129, 20);
            this.txtAmount.TabIndex = 4;
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
            // cbSource
            // 
            this.cbSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quienPagaBindingSource, "Descripcion", true));
            this.cbSource.DataSource = this.quienPagaBindingSource;
            this.cbSource.DisplayMember = "Descripcion";
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(170, 134);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(129, 21);
            this.cbSource.TabIndex = 2;
            this.cbSource.ValueMember = "Id";
            // 
            // quienPagaBindingSource
            // 
            this.quienPagaBindingSource.DataMember = "QuienPaga";
            this.quienPagaBindingSource.DataSource = this.finPersonalesDataSet;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // tipoPagoTableAdapter
            // 
            this.tipoPagoTableAdapter.ClearBeforeFill = true;
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

        private System.Windows.Forms.ComboBox cbTypeOfIncome;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource tipoIngresosBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoIngresosTableAdapter tipoIngresosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTypeIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeOfPay;
        private System.Windows.Forms.BindingSource tipoPagoBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter tipoPagoTableAdapter;
        private System.Windows.Forms.BindingSource quienPagaBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.QuienPagaTableAdapter quienPagaTableAdapter;
    }
}
namespace FinPersonales
{
    partial class frmAddOutCome
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeOfPay = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTypeOutCome = new System.Windows.Forms.Label();
            this.cbTypeOutCome = new System.Windows.Forms.ComboBox();
            this.finPersonalesDataSet = new FinPersonales.AppData.FinPersonalesDataSet();
            this.tiposEgresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiposEgresosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TiposEgresosTableAdapter();
            this.tipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoPagoTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.categoriaEgresosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaEgresosTableAdapter = new FinPersonales.AppData.FinPersonalesDataSetTableAdapters.CategoriaEgresosTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEgresosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaEgresosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registrar Egresos";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(330, 362);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Registrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.lblTypeOutCome);
            this.panel1.Controls.Add(this.cbTypeOutCome);
            this.panel1.Location = new System.Drawing.Point(22, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 316);
            this.panel1.TabIndex = 7;
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
            this.cbTypeOfPay.DataSource = this.tipoPagoBindingSource;
            this.cbTypeOfPay.DisplayMember = "Descripcion";
            this.cbTypeOfPay.FormattingEnabled = true;
            this.cbTypeOfPay.Location = new System.Drawing.Point(170, 62);
            this.cbTypeOfPay.Name = "cbTypeOfPay";
            this.cbTypeOfPay.Size = new System.Drawing.Size(129, 21);
            this.cbTypeOfPay.TabIndex = 6;
            this.cbTypeOfPay.ValueMember = "Id";
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
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Categoría:";
            // 
            // lblTypeOutCome
            // 
            this.lblTypeOutCome.AutoSize = true;
            this.lblTypeOutCome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOutCome.Location = new System.Drawing.Point(31, 95);
            this.lblTypeOutCome.Name = "lblTypeOutCome";
            this.lblTypeOutCome.Size = new System.Drawing.Size(120, 20);
            this.lblTypeOutCome.TabIndex = 1;
            this.lblTypeOutCome.Text = "Tipo de Egreso:";
            // 
            // cbTypeOutCome
            // 
            this.cbTypeOutCome.DataSource = this.tiposEgresosBindingSource;
            this.cbTypeOutCome.DisplayMember = "Descripcion";
            this.cbTypeOutCome.FormattingEnabled = true;
            this.cbTypeOutCome.Location = new System.Drawing.Point(170, 94);
            this.cbTypeOutCome.Name = "cbTypeOutCome";
            this.cbTypeOutCome.Size = new System.Drawing.Size(129, 21);
            this.cbTypeOutCome.TabIndex = 0;
            this.cbTypeOutCome.ValueMember = "Id";
            // 
            // finPersonalesDataSet
            // 
            this.finPersonalesDataSet.DataSetName = "FinPersonalesDataSet";
            this.finPersonalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tiposEgresosBindingSource
            // 
            this.tiposEgresosBindingSource.DataMember = "TiposEgresos";
            this.tiposEgresosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // tiposEgresosTableAdapter
            // 
            this.tiposEgresosTableAdapter.ClearBeforeFill = true;
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
            // cbCategory
            // 
            this.cbCategory.DataSource = this.categoriaEgresosBindingSource;
            this.cbCategory.DisplayMember = "Descripcion";
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(170, 134);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(129, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.ValueMember = "Id";
            // 
            // categoriaEgresosBindingSource
            // 
            this.categoriaEgresosBindingSource.DataMember = "CategoriaEgresos";
            this.categoriaEgresosBindingSource.DataSource = this.finPersonalesDataSet;
            // 
            // categoriaEgresosTableAdapter
            // 
            this.categoriaEgresosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddOutCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddOutCome";
            this.Text = "Finanzas Personales - Registrar Egreso";
            this.Load += new System.EventHandler(this.frmAddOutCome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.finPersonalesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiposEgresosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaEgresosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeOfPay;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeOutCome;
        private System.Windows.Forms.ComboBox cbTypeOutCome;
        private AppData.FinPersonalesDataSet finPersonalesDataSet;
        private System.Windows.Forms.BindingSource tiposEgresosBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TiposEgresosTableAdapter tiposEgresosTableAdapter;
        private System.Windows.Forms.BindingSource tipoPagoBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.TipoPagoTableAdapter tipoPagoTableAdapter;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.BindingSource categoriaEgresosBindingSource;
        private AppData.FinPersonalesDataSetTableAdapters.CategoriaEgresosTableAdapter categoriaEgresosTableAdapter;
    }
}
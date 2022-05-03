
namespace CapaPresentacion
{
    partial class frm_contabilizacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_contabilizacion));
            this.pnl_parametros = new System.Windows.Forms.Panel();
            this.btn_contabilizar = new System.Windows.Forms.Button();
            this.lbl_parametros = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.btn_preliminar = new System.Windows.Forms.Button();
            this.lbl_caja = new System.Windows.Forms.Label();
            this.txt_numeroPoliza = new System.Windows.Forms.TextBox();
            this.lbl_fechaI = new System.Windows.Forms.Label();
            this.cmb_tipoPoliza = new System.Windows.Forms.ComboBox();
            this.dt_fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaU = new System.Windows.Forms.Label();
            this.cmb_cajas = new System.Windows.Forms.ComboBox();
            this.dt_fechafinal = new System.Windows.Forms.DateTimePicker();
            this.lbl_numeroPoliza = new System.Windows.Forms.Label();
            this.cmb_empresa = new System.Windows.Forms.ComboBox();
            this.lbl_tipoPoliza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_dataContabilizacion = new System.Windows.Forms.DataGridView();
            this.helpText = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_debe = new System.Windows.Forms.Label();
            this.lbl_haber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataContabilizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_parametros
            // 
            this.pnl_parametros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_parametros.Controls.Add(this.btn_contabilizar);
            this.pnl_parametros.Controls.Add(this.lbl_parametros);
            this.pnl_parametros.Controls.Add(this.lbl_empresa);
            this.pnl_parametros.Controls.Add(this.btn_preliminar);
            this.pnl_parametros.Controls.Add(this.lbl_caja);
            this.pnl_parametros.Controls.Add(this.txt_numeroPoliza);
            this.pnl_parametros.Controls.Add(this.lbl_fechaI);
            this.pnl_parametros.Controls.Add(this.cmb_tipoPoliza);
            this.pnl_parametros.Controls.Add(this.dt_fechaInicial);
            this.pnl_parametros.Controls.Add(this.lbl_fechaU);
            this.pnl_parametros.Controls.Add(this.cmb_cajas);
            this.pnl_parametros.Controls.Add(this.dt_fechafinal);
            this.pnl_parametros.Controls.Add(this.lbl_numeroPoliza);
            this.pnl_parametros.Controls.Add(this.cmb_empresa);
            this.pnl_parametros.Controls.Add(this.lbl_tipoPoliza);
            this.pnl_parametros.Location = new System.Drawing.Point(21, 69);
            this.pnl_parametros.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_parametros.Name = "pnl_parametros";
            this.pnl_parametros.Size = new System.Drawing.Size(879, 202);
            this.pnl_parametros.TabIndex = 19;
            this.pnl_parametros.Tag = "";
            // 
            // btn_contabilizar
            // 
            this.btn_contabilizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contabilizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contabilizar.Location = new System.Drawing.Point(209, 144);
            this.btn_contabilizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_contabilizar.Name = "btn_contabilizar";
            this.btn_contabilizar.Size = new System.Drawing.Size(164, 36);
            this.btn_contabilizar.TabIndex = 18;
            this.btn_contabilizar.Text = "Contabilizar Ventas";
            this.btn_contabilizar.UseVisualStyleBackColor = true;
            this.btn_contabilizar.Click += new System.EventHandler(this.btn_contabilizar_Click_1);
            // 
            // lbl_parametros
            // 
            this.lbl_parametros.AutoSize = true;
            this.lbl_parametros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parametros.Location = new System.Drawing.Point(15, 14);
            this.lbl_parametros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_parametros.Name = "lbl_parametros";
            this.lbl_parametros.Size = new System.Drawing.Size(213, 16);
            this.lbl_parametros.TabIndex = 17;
            this.lbl_parametros.Text = "Datos para trasladar las ventas";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empresa.Location = new System.Drawing.Point(33, 60);
            this.lbl_empresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(52, 15);
            this.lbl_empresa.TabIndex = 2;
            this.lbl_empresa.Text = "Empresa";
            // 
            // btn_preliminar
            // 
            this.btn_preliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_preliminar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preliminar.Location = new System.Drawing.Point(19, 144);
            this.btn_preliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_preliminar.Name = "btn_preliminar";
            this.btn_preliminar.Size = new System.Drawing.Size(164, 36);
            this.btn_preliminar.TabIndex = 16;
            this.btn_preliminar.Text = "Vista preliminar";
            this.btn_preliminar.UseVisualStyleBackColor = true;
            this.btn_preliminar.Click += new System.EventHandler(this.btn_contabilizar_Click);
            // 
            // lbl_caja
            // 
            this.lbl_caja.AutoSize = true;
            this.lbl_caja.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caja.Location = new System.Drawing.Point(187, 60);
            this.lbl_caja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_caja.Name = "lbl_caja";
            this.lbl_caja.Size = new System.Drawing.Size(32, 15);
            this.lbl_caja.TabIndex = 3;
            this.lbl_caja.Text = "Caja";
            // 
            // txt_numeroPoliza
            // 
            this.txt_numeroPoliza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPoliza.Location = new System.Drawing.Point(719, 96);
            this.txt_numeroPoliza.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numeroPoliza.Name = "txt_numeroPoliza";
            this.txt_numeroPoliza.Size = new System.Drawing.Size(132, 21);
            this.txt_numeroPoliza.TabIndex = 15;
            this.helpText.SetToolTip(this.txt_numeroPoliza, "Formato para ingresar número de poliza: 22050201(año|mes|dia|caja)");
            // 
            // lbl_fechaI
            // 
            this.lbl_fechaI.AutoSize = true;
            this.lbl_fechaI.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaI.Location = new System.Drawing.Point(288, 60);
            this.lbl_fechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaI.Name = "lbl_fechaI";
            this.lbl_fechaI.Size = new System.Drawing.Size(76, 15);
            this.lbl_fechaI.TabIndex = 4;
            this.lbl_fechaI.Text = "Fecha Inicial";
            // 
            // cmb_tipoPoliza
            // 
            this.cmb_tipoPoliza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoPoliza.FormattingEnabled = true;
            this.cmb_tipoPoliza.Items.AddRange(new object[] {
            "PDV"});
            this.cmb_tipoPoliza.Location = new System.Drawing.Point(586, 94);
            this.cmb_tipoPoliza.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipoPoliza.Name = "cmb_tipoPoliza";
            this.cmb_tipoPoliza.Size = new System.Drawing.Size(108, 24);
            this.cmb_tipoPoliza.TabIndex = 14;
            this.cmb_tipoPoliza.Text = "Seleccione";
            // 
            // dt_fechaInicial
            // 
            this.dt_fechaInicial.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaInicial.Location = new System.Drawing.Point(288, 96);
            this.dt_fechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dt_fechaInicial.Name = "dt_fechaInicial";
            this.dt_fechaInicial.Size = new System.Drawing.Size(125, 21);
            this.dt_fechaInicial.TabIndex = 5;
            // 
            // lbl_fechaU
            // 
            this.lbl_fechaU.AutoSize = true;
            this.lbl_fechaU.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaU.Location = new System.Drawing.Point(444, 60);
            this.lbl_fechaU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaU.Name = "lbl_fechaU";
            this.lbl_fechaU.Size = new System.Drawing.Size(70, 15);
            this.lbl_fechaU.TabIndex = 6;
            this.lbl_fechaU.Text = "Fecha Final";
            // 
            // cmb_cajas
            // 
            this.cmb_cajas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cajas.FormattingEnabled = true;
            this.cmb_cajas.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_cajas.Location = new System.Drawing.Point(187, 93);
            this.cmb_cajas.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cajas.Name = "cmb_cajas";
            this.cmb_cajas.Size = new System.Drawing.Size(78, 24);
            this.cmb_cajas.TabIndex = 12;
            this.cmb_cajas.Text = "Seleccione";
            // 
            // dt_fechafinal
            // 
            this.dt_fechafinal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechafinal.Location = new System.Drawing.Point(444, 96);
            this.dt_fechafinal.Margin = new System.Windows.Forms.Padding(4);
            this.dt_fechafinal.Name = "dt_fechafinal";
            this.dt_fechafinal.Size = new System.Drawing.Size(125, 21);
            this.dt_fechafinal.TabIndex = 7;
            // 
            // lbl_numeroPoliza
            // 
            this.lbl_numeroPoliza.AutoSize = true;
            this.lbl_numeroPoliza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroPoliza.Location = new System.Drawing.Point(719, 60);
            this.lbl_numeroPoliza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numeroPoliza.Name = "lbl_numeroPoliza";
            this.lbl_numeroPoliza.Size = new System.Drawing.Size(102, 15);
            this.lbl_numeroPoliza.TabIndex = 11;
            this.lbl_numeroPoliza.Text = "Numero de poliza";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empresa.FormattingEnabled = true;
            this.cmb_empresa.Items.AddRange(new object[] {
            "1",
            "99"});
            this.cmb_empresa.Location = new System.Drawing.Point(33, 94);
            this.cmb_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Size = new System.Drawing.Size(127, 24);
            this.cmb_empresa.TabIndex = 10;
            this.cmb_empresa.Text = "Seleccione";
            this.helpText.SetToolTip(this.cmb_empresa, "Seleccione una empresa");
            // 
            // lbl_tipoPoliza
            // 
            this.lbl_tipoPoliza.AutoSize = true;
            this.lbl_tipoPoliza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoPoliza.Location = new System.Drawing.Point(586, 60);
            this.lbl_tipoPoliza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoPoliza.Name = "lbl_tipoPoliza";
            this.lbl_tipoPoliza.Size = new System.Drawing.Size(81, 15);
            this.lbl_tipoPoliza.TabIndex = 9;
            this.lbl_tipoPoliza.Text = "Tipo de poliza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Contabilización de ventas de punto de venta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_dataContabilizacion
            // 
            this.dgv_dataContabilizacion.AllowUserToAddRows = false;
            this.dgv_dataContabilizacion.AllowUserToDeleteRows = false;
            this.dgv_dataContabilizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataContabilizacion.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_dataContabilizacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dataContabilizacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dataContabilizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dataContabilizacion.Location = new System.Drawing.Point(21, 291);
            this.dgv_dataContabilizacion.Name = "dgv_dataContabilizacion";
            this.dgv_dataContabilizacion.ReadOnly = true;
            this.dgv_dataContabilizacion.RowTemplate.Height = 24;
            this.dgv_dataContabilizacion.Size = new System.Drawing.Size(879, 202);
            this.dgv_dataContabilizacion.TabIndex = 21;
            this.dgv_dataContabilizacion.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_dataContabilizacion_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Debe: ";
            // 
            // lbl_debe
            // 
            this.lbl_debe.AutoSize = true;
            this.lbl_debe.Location = new System.Drawing.Point(654, 513);
            this.lbl_debe.Name = "lbl_debe";
            this.lbl_debe.Size = new System.Drawing.Size(33, 17);
            this.lbl_debe.TabIndex = 23;
            this.lbl_debe.Text = "0.00";
            this.lbl_debe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_haber
            // 
            this.lbl_haber.AutoSize = true;
            this.lbl_haber.Location = new System.Drawing.Point(799, 513);
            this.lbl_haber.Name = "lbl_haber";
            this.lbl_haber.Size = new System.Drawing.Size(33, 17);
            this.lbl_haber.TabIndex = 25;
            this.lbl_haber.Text = "0.00";
            this.lbl_haber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Haber";
            // 
            // frm_contabilizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(925, 555);
            this.Controls.Add(this.lbl_haber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_debe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dataContabilizacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl_parametros);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_contabilizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contabilizacion de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_parametros.ResumeLayout(false);
            this.pnl_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataContabilizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_parametros;
        private System.Windows.Forms.Button btn_contabilizar;
        private System.Windows.Forms.Label lbl_parametros;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.Button btn_preliminar;
        private System.Windows.Forms.Label lbl_caja;
        private System.Windows.Forms.TextBox txt_numeroPoliza;
        private System.Windows.Forms.Label lbl_fechaI;
        private System.Windows.Forms.ComboBox cmb_tipoPoliza;
        private System.Windows.Forms.DateTimePicker dt_fechaInicial;
        private System.Windows.Forms.ComboBox cmb_cajas;
        private System.Windows.Forms.Label lbl_numeroPoliza;
        private System.Windows.Forms.ComboBox cmb_empresa;
        private System.Windows.Forms.Label lbl_tipoPoliza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_dataContabilizacion;
        private System.Windows.Forms.ToolTip helpText;
        private System.Windows.Forms.Label lbl_fechaU;
        private System.Windows.Forms.DateTimePicker dt_fechafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_debe;
        private System.Windows.Forms.Label lbl_haber;
        private System.Windows.Forms.Label label4;
    }
}


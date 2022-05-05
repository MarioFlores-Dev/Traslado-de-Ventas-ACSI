
namespace CapaPresentacion
{
    partial class frm_verificarTraslados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_verificarTraslados));
            this.pnl_parametros = new System.Windows.Forms.Panel();
            this.cmb_caja = new System.Windows.Forms.ComboBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.txt_anio = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_caja = new System.Windows.Forms.Label();
            this.lbl_parametros = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.lbl_fechaI = new System.Windows.Forms.Label();
            this.cmb_tipoPoliza = new System.Windows.Forms.ComboBox();
            this.lbl_fechaU = new System.Windows.Forms.Label();
            this.cmb_empresa = new System.Windows.Forms.ComboBox();
            this.dgv_verificarTraslados = new System.Windows.Forms.DataGridView();
            this.pnl_parametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verificarTraslados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_parametros
            // 
            this.pnl_parametros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_parametros.Controls.Add(this.cmb_caja);
            this.pnl_parametros.Controls.Add(this.btn_verificar);
            this.pnl_parametros.Controls.Add(this.txt_anio);
            this.pnl_parametros.Controls.Add(this.txt_mes);
            this.pnl_parametros.Controls.Add(this.label1);
            this.pnl_parametros.Controls.Add(this.lbl_caja);
            this.pnl_parametros.Controls.Add(this.lbl_parametros);
            this.pnl_parametros.Controls.Add(this.lbl_empresa);
            this.pnl_parametros.Controls.Add(this.lbl_fechaI);
            this.pnl_parametros.Controls.Add(this.cmb_tipoPoliza);
            this.pnl_parametros.Controls.Add(this.lbl_fechaU);
            this.pnl_parametros.Controls.Add(this.cmb_empresa);
            this.pnl_parametros.Location = new System.Drawing.Point(13, 13);
            this.pnl_parametros.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_parametros.Name = "pnl_parametros";
            this.pnl_parametros.Size = new System.Drawing.Size(937, 202);
            this.pnl_parametros.TabIndex = 20;
            this.pnl_parametros.Tag = "";
            // 
            // cmb_caja
            // 
            this.cmb_caja.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_caja.FormattingEnabled = true;
            this.cmb_caja.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmb_caja.Location = new System.Drawing.Point(692, 87);
            this.cmb_caja.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_caja.Name = "cmb_caja";
            this.cmb_caja.Size = new System.Drawing.Size(98, 24);
            this.cmb_caja.TabIndex = 5;
            this.cmb_caja.Text = "Seleccione";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verificar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.Location = new System.Drawing.Point(57, 141);
            this.btn_verificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(164, 36);
            this.btn_verificar.TabIndex = 6;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // txt_anio
            // 
            this.txt_anio.Location = new System.Drawing.Point(258, 89);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(98, 20);
            this.txt_anio.TabIndex = 2;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(399, 89);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(98, 20);
            this.txt_mes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo de poliza";
            // 
            // lbl_caja
            // 
            this.lbl_caja.AutoSize = true;
            this.lbl_caja.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_caja.Location = new System.Drawing.Point(692, 61);
            this.lbl_caja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_caja.Name = "lbl_caja";
            this.lbl_caja.Size = new System.Drawing.Size(84, 15);
            this.lbl_caja.TabIndex = 21;
            this.lbl_caja.Text = "Caja Contable";
            // 
            // lbl_parametros
            // 
            this.lbl_parametros.AutoSize = true;
            this.lbl_parametros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_parametros.Location = new System.Drawing.Point(15, 14);
            this.lbl_parametros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_parametros.Name = "lbl_parametros";
            this.lbl_parametros.Size = new System.Drawing.Size(263, 16);
            this.lbl_parametros.TabIndex = 17;
            this.lbl_parametros.Text = "Datos para verificar traslado de ventas";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empresa.Location = new System.Drawing.Point(99, 61);
            this.lbl_empresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(104, 15);
            this.lbl_empresa.TabIndex = 2;
            this.lbl_empresa.Text = "Empresa Contable";
            // 
            // lbl_fechaI
            // 
            this.lbl_fechaI.AutoSize = true;
            this.lbl_fechaI.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaI.Location = new System.Drawing.Point(258, 61);
            this.lbl_fechaI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaI.Name = "lbl_fechaI";
            this.lbl_fechaI.Size = new System.Drawing.Size(63, 15);
            this.lbl_fechaI.TabIndex = 4;
            this.lbl_fechaI.Text = "Año Fiscal";
            // 
            // cmb_tipoPoliza
            // 
            this.cmb_tipoPoliza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoPoliza.FormattingEnabled = true;
            this.cmb_tipoPoliza.Items.AddRange(new object[] {
            "PDV"});
            this.cmb_tipoPoliza.Location = new System.Drawing.Point(540, 87);
            this.cmb_tipoPoliza.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_tipoPoliza.Name = "cmb_tipoPoliza";
            this.cmb_tipoPoliza.Size = new System.Drawing.Size(109, 24);
            this.cmb_tipoPoliza.TabIndex = 4;
            this.cmb_tipoPoliza.Text = "Seleccione";
            // 
            // lbl_fechaU
            // 
            this.lbl_fechaU.AutoSize = true;
            this.lbl_fechaU.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechaU.Location = new System.Drawing.Point(399, 61);
            this.lbl_fechaU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fechaU.Name = "lbl_fechaU";
            this.lbl_fechaU.Size = new System.Drawing.Size(63, 15);
            this.lbl_fechaU.TabIndex = 6;
            this.lbl_fechaU.Text = "Mes Fiscal";
            // 
            // cmb_empresa
            // 
            this.cmb_empresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empresa.FormattingEnabled = true;
            this.cmb_empresa.Items.AddRange(new object[] {
            "1",
            "99"});
            this.cmb_empresa.Location = new System.Drawing.Point(99, 87);
            this.cmb_empresa.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_empresa.Name = "cmb_empresa";
            this.cmb_empresa.Size = new System.Drawing.Size(116, 24);
            this.cmb_empresa.TabIndex = 1;
            this.cmb_empresa.Text = "Seleccione";
            // 
            // dgv_verificarTraslados
            // 
            this.dgv_verificarTraslados.AllowUserToAddRows = false;
            this.dgv_verificarTraslados.AllowUserToDeleteRows = false;
            this.dgv_verificarTraslados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_verificarTraslados.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_verificarTraslados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_verificarTraslados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verificarTraslados.Location = new System.Drawing.Point(13, 223);
            this.dgv_verificarTraslados.Name = "dgv_verificarTraslados";
            this.dgv_verificarTraslados.ReadOnly = true;
            this.dgv_verificarTraslados.Size = new System.Drawing.Size(937, 249);
            this.dgv_verificarTraslados.TabIndex = 21;
            // 
            // frm_verificarTraslados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 499);
            this.Controls.Add(this.dgv_verificarTraslados);
            this.Controls.Add(this.pnl_parametros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_verificarTraslados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificacion de traslados";
            this.Load += new System.EventHandler(this.frm_verificarTraslados_Load);
            this.pnl_parametros.ResumeLayout(false);
            this.pnl_parametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verificarTraslados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_parametros;
        private System.Windows.Forms.Label lbl_parametros;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.Label lbl_fechaI;
        private System.Windows.Forms.ComboBox cmb_tipoPoliza;
        private System.Windows.Forms.Label lbl_fechaU;
        private System.Windows.Forms.ComboBox cmb_empresa;
        private System.Windows.Forms.TextBox txt_anio;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_caja;
        private System.Windows.Forms.DataGridView dgv_verificarTraslados;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.ComboBox cmb_caja;
    }
}
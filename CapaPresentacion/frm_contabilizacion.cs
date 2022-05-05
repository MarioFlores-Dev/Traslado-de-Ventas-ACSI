using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion { 
    public partial class frm_contabilizacion : Form {
        

        public frm_contabilizacion(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            btn_contabilizar.Enabled = false;
            dgv_dataContabilizacion.Enabled = false;
            CargarCombobox();
        }

        private void btn_contabilizar_Click(object sender, EventArgs e) {
            if (cmb_empresa.Text == "Seleccione" || cmb_cajas.Text == "Seleccione" || txt_numeroPoliza.Text == ""){
                MessageBox.Show("Debe de llenar los datos primero");
            }else
            {
                ProcesosContabilizacion(0);
            }
        }

        private void btn_contabilizar_Click_1(object sender, EventArgs e){
            ProcesosContabilizacion(1);
        }

        private double CalculoDebe(){
            double totalDebe=0.00;
                foreach (DataGridViewRow row in dgv_dataContabilizacion.Rows){
                    totalDebe += Convert.ToDouble(row.Cells[3].Value);
                }
            return totalDebe;
        }

        private double CalculoHaber(){
            double totalHaber = 0.00;
                foreach (DataGridViewRow row in dgv_dataContabilizacion.Rows){
                    totalHaber += Convert.ToDouble(row.Cells[4].Value);
                }
            return totalHaber;
        }

        private void ProcesosContabilizacion (int opcion){
            //Extracción de datos de la interfaz
            int empresa = int.Parse(cmb_empresa.SelectedValue.ToString());
            int caja = int.Parse(cmb_cajas.SelectedValue.ToString());
            String f1 = dt_fechaInicial.Text;
            String f2 = dt_fechafinal.Text;
            String tipoPoliza = cmb_tipoPoliza.Text;
            String numeroPoliza = txt_numeroPoliza.Text;
            DateTime fechaInicial = Convert.ToDateTime(f1);
            DateTime fechaFinal = Convert.ToDateTime(f2);
            dgv_dataContabilizacion.Enabled = true;
            if(opcion == 0){
                var datos = CapaNegocio.Traslados.rpt_Poliza_Ventas_PosFEL_Results(empresa, caja, fechaInicial, fechaFinal, 0, tipoPoliza, numeroPoliza);
                dgv_dataContabilizacion.DataSource = datos.ToList();

                dgv_dataContabilizacion.Columns[0].HeaderText = "Nombre Empresa";
                dgv_dataContabilizacion.Columns[1].HeaderText = "Cuenta Contable";
                dgv_dataContabilizacion.Columns[2].HeaderText = "Nombre Cuenta";
                dgv_dataContabilizacion.Columns[3].HeaderText = "Debe";
                dgv_dataContabilizacion.Columns[4].HeaderText = "Haber";

                dgv_dataContabilizacion.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_dataContabilizacion.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv_dataContabilizacion.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_dataContabilizacion.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                lbl_debe.Text = ("Q "+Convert.ToString(CalculoDebe()));
                lbl_haber.Text = ("Q "+Convert.ToString(CalculoHaber()));

                if (lbl_debe.Text == lbl_haber.Text)
                {
                    btn_contabilizar.Enabled = true;
                }
            }
            else if(opcion == 1){
                var datos = CapaNegocio.Traslados.rpt_Poliza_Ventas_PosFEL_Results(empresa, caja, fechaInicial, fechaFinal, 1, tipoPoliza, numeroPoliza);
                MessageBox.Show("Traslado exitoso");
                dgv_dataContabilizacion.Columns.Clear();
                lbl_debe.Text = (0.00).ToString();
                lbl_haber.Text = (0.00).ToString();
                txt_numeroPoliza.Text = ("");
                btn_contabilizar.Enabled = false;
            }

        }
        private void CargarCombobox(){
            //Datos a combobox de empresa
            cmb_empresa.DataSource = CapaNegocio.Empresas.GetEmpresas();
            cmb_empresa.DisplayMember = "Nombre_Empresa";
            cmb_empresa.ValueMember = "Id_Empresa";
            cmb_empresa.SelectedIndex = -1;
            //Datos a combobox de caja
            cmb_cajas.DataSource = CapaNegocio.Empresas.GetCajas();
            cmb_cajas.DisplayMember = "Observaciones";
            cmb_cajas.ValueMember = "Id_Caja";
            cmb_cajas.SelectedIndex = -1;
            //Datos a combobox Tipo de poliza
            cmb_tipoPoliza.Text = "PDV";
            cmb_tipoPoliza.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_dataContabilizacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_verificarTraslados frmTraslados = new frm_verificarTraslados();
            frmTraslados.Show();
        }
    }
}

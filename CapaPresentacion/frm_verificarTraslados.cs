using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frm_verificarTraslados : Form
    {
        public frm_verificarTraslados()
        {
            InitializeComponent();
        }

        private void frm_verificarTraslados_Load(object sender, EventArgs e)
        {

        }

        private void lbl_numeroPoliza_Click(object sender, EventArgs e)
        {

        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (cmb_empresa.Text == "Seleccione" || txt_anio.Text == "" || txt_mes.Text == "" || cmb_tipoPoliza.Text == "Seleccione" || cmb_tipoPoliza.Text == "Seleccione")
            {
                MessageBox.Show("Debe de llenar los datos primero");
            }
            else
            {
                VerificarTraslados();
            }
            
        }

        private void VerificarTraslados()
        {
            int idEmpresa = int.Parse(cmb_empresa.Text);
            string anio = txt_anio.Text;
            string mes = txt_mes.Text;
            string tipoPoliza = cmb_tipoPoliza.Text;
            string numeroCaja = cmb_caja.Text;
            
            var datos = CapaNegocio.VerificarTraslado.sp_VerificarTraslados(idEmpresa,anio,mes,tipoPoliza,numeroCaja);
            dgv_verificarTraslados.DataSource = datos.ToList();
            dgv_verificarTraslados.Columns[0].HeaderText = "EMPRESA";

        }
    }
}

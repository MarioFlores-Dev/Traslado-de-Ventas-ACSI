using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Traslados{

       public static List<CapaDatos.rpt_poliza_ventas_posFEL_Result> rpt_Poliza_Ventas_PosFEL_Results(int? idEmpresa, int? id_caja, DateTime? fechaInicial, 
           DateTime? fechaFinal, int? tipoReporte, string tipoPoliza, string numeroPoliza)
        {
            using (CapaDatos.db_inventario_Entities db = new CapaDatos.db_inventario_Entities())
            {
                var result = db.rpt_poliza_ventas_posFEL(idEmpresa, id_caja, fechaInicial, fechaFinal, tipoReporte, tipoPoliza, numeroPoliza);
                return result.ToList();
            }
        }
    }
}

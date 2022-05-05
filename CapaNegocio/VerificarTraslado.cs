using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio{
    public class VerificarTraslado{

        public static List<CapaDatos.sp_verificarTraslados_Result> sp_VerificarTraslados(int? idEmpresa, string anio, string mes,
             string tipoPoliza, string caja)
        {
            using (CapaDatos.db_inventario_Entities db = new CapaDatos.db_inventario_Entities())
            {
                var result = db.sp_verificarTraslados(idEmpresa, anio, mes, tipoPoliza,caja );
                return result.ToList();
            }
        }

    }
}

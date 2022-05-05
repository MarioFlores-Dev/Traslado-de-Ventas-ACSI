using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio{
    public class Empresas{

        public static List<CapaDatos.sp_getEmpresas_Result> GetEmpresas(){

            using (CapaDatos.db_inventario_Entities db = new CapaDatos.db_inventario_Entities())
            {
                return db.sp_getEmpresas().ToList();
            }
        }

        public static List<CapaDatos.Tbl_Cajas> GetCajas() {
            using (CapaDatos.db_inventario_Entities db = new CapaDatos.db_inventario_Entities())
            {
                var cajas = (from c in db.Tbl_Cajas
                             select c);
                return cajas.ToList();
            }
        }

    }
}

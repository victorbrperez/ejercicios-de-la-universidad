using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class AvanzadoOpcionesItem
    {
        public int IdItem { get; set; }
        public string DescripcionItem { get; set; }
        public string TipoItem { get; set; }
        public string RelacionItem { get; set; }
        //
        public bool InhabilitarItemSQL()
        {
            return Actualizar(0);
        }
        //
        public bool HabilitarItemSQL()
        {
            return Actualizar(1);
        }
        /// <summary>
        /// Eljecuta la sentencia de actualizacion
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        bool Actualizar(int op)
        {
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("UPDATE {0} SET Activo = {1} WHERE Id = {2} ",this.RelacionItem, op.ToString(),this.IdItem);
            //
            return sqlman.actualizar(sql.ToString());
        }
    }
}

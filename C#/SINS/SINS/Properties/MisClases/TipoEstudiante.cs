using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    class TipoEstudiante
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public float CostoHorasTeoricas { get; set; }
        public float CostoHorasLaboratorio { get; set; }
        public float CostoInscripcion { get; set; }
        public string Obaservaciones { get; set; }

        public List<TipoEstudiante> traerTodosBasico()
        {
            List<TipoEstudiante> liTipoEst = new List<TipoEstudiante>();
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT Id,Titulo from tblTipoEstudiante WHERE Activo = 1;");
            SqlMan sqlman = new SqlMan();
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                while (sqlman.reader.HasRows)
                {
                    while (sqlman.reader.Read())
                    {
                        TipoEstudiante te = new TipoEstudiante();
                        te.Id = Convert.ToInt32(sqlman.reader["Id"].ToString());
                        te.Titulo = sqlman.reader["Titulo"].ToString();
                        liTipoEst.Add(te);
                    }
                    sqlman.reader.NextResult();
                }
                sqlman.reader.Close();
            }
            return liTipoEst;
        }
    }
}

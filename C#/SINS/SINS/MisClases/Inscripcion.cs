using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINS.MisClases
{
    public class Inscripcion
    {
        public Inscripcion()
        {
            Id = 0;
            DetallesDeInscripcion = new List<DetalleInscripcion>();
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEstudiante { get; set; }
        public List<DetalleInscripcion> DetallesDeInscripcion { get; set; }
        //****************************************************************************************************************************************
        /// <summary>
        /// Registra una nueva inscripcion en la base de datos
        /// </summary>
        /// <returns></returns>
        public ParError Registrar()
        {
            ParError log = new ParError();
            AsignarId();
            asignarIdInscripcinDetalle();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("INSERT INTO tblInscripcion(Id,Fecha,IdEstudiante) VALUES({0},'{1}',{2})",this.Id,DateTime.Now.ToShortDateString(),this.IdEstudiante.ToString());
            //
            if (sqlman.insertar(sql.ToString()))
            {
                InscripcionActiva ia = new InscripcionActiva();
                ia.IdEstudiante = this.IdEstudiante;
                ia.IdInscripcion = this.Id;
                if (ia.Registrado())
                {
                    ia.Actualizar();
                }
                else
                    ia.Registrar();
                foreach (DetalleInscripcion item in DetallesDeInscripcion)
                {
                    item.Registrar();
                }
                //
                log.Error = false;
                log.Mensaje = "Se ha insertado el registro satisfactoriamente";
            }
            else
            {
                log.Error = false;
                log.Mensaje = "No she ha podido insertar el registro";
            }
            return log;
        }
        public List<Seccion> buscarSeccionesPorEstudiante()
        {
            List<Seccion> liSecciones = new List<Seccion>();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            if (this.IdEstudiante > 0)
            {
                sql.AppendFormat("SELECT IdSeccion FROM tblDetalleInscripcion WHERE IdInscripcion IN (SELECT IdInscripcion FROM tblInscripcionActiva WHERE IdEstudiante = {0})", this.IdEstudiante);
                //
                if (sqlman.cargarReader(sql.ToString()))
                {
                    while (sqlman.reader.HasRows)
                    {
                        while (sqlman.reader.Read())
                        {
                            Seccion sec = new Seccion();
                            sec.Id = Convert.ToInt32(sqlman.reader["IdSeccion"].ToString());
                            sec.buscarPorId(Utiles.DbOptionSelect.Basico);
                            liSecciones.Add(sec);
                        }
                        sqlman.reader.NextResult();
                    }
                    sqlman.reader.Close();
                }
            }
            return liSecciones;
        }
        /// <summary>
        /// 
        /// </summary>
        void asignarIdInscripcinDetalle()
        {
            if (DetallesDeInscripcion.Count > 0)
            {
                foreach (DetalleInscripcion item in DetallesDeInscripcion)
                {
                    item.IdInscripcion = this.Id;
                }
            }
        }
        /// <summary>
        /// Obtiene un nuevo Id para la inscripcion
        /// </summary>
        /// <returns></returns>
        public bool AsignarId()
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("SELECT MAX(Id) UltimaId FROM tblInscripcion");
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                if (sqlman.reader.HasRows)
                {
                    if (sqlman.reader.Read())
                    {
                        if (!sqlman.reader.IsDBNull(0))
                        {
                            this.Id = Convert.ToInt32(sqlman.reader["UltimaId"].ToString()) + 1;
                            r = true;
                        }
                        else this.Id = 1;
                    }
                }
                sqlman.reader.Close();
            }
            return r;
        }
        /// <summary>
        /// Obtiene un nuevo Id para la inscripcion
        /// </summary>
        /// <returns></returns>
        public bool buscarIdPorEstudiante()
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("SELECT IdInscripcion FROM tblInscripcionActiva WHERE IdEstudiante = {0}",this.IdEstudiante);
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                if (sqlman.reader.HasRows)
                {
                    if (sqlman.reader.Read())
                    {
                        this.Id = Convert.ToInt32(sqlman.reader["IdInscripcion"].ToString());
                    }
                }
                sqlman.reader.Close();
            }
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ParError Actualizar()
        {
            ParError log = new ParError();
            asignarIdInscripcinDetalle();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            Utiles.BorrarInscripcion(this.IdEstudiante);
            foreach (DetalleInscripcion item in DetallesDeInscripcion)
            {
                log = item.Registrar();

            }
            //
            return log;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SINS.MisClases
{
    public class Seccion
    {
        public Seccion()
        {
            Id = 0;
            Horarios = new List<Horario>();
        }
        //
        public int Id { get; set; }
        public int IdProfesor { get; set; }
        public int Capacidad { get; set; }
        public int Numero { get; set; }
        public int IdAsignatura { get; set; }
        public string Observaciones { get; set; }
        public List<Horario> Horarios { get; set; }
        private List<Horario> horariosEnConflictos;
        //
        public List<Horario> HorariosEnConflictos
        {
            get
            {
                return horariosEnConflictos;
            }
        }
        //
        //******METODOS MIEMBROS********************************************************************************************************
        /// <summary>
        /// Meetetodo que registra la seccion en la base de datos
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public ParError Registrar()
        {
            ParError error = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            this.asignarID();
            this.asignarIdSeccionHorarios();
            //
            if (validarNumeroSeccion())
            {
                if (!(validarConflictosHorarios().Count > 0))
                {
                    if (validarProfesorHorario().Count == 0)
                    {
                        sql.Append("INSERT INTO tblSeccion (Id,IdProfesor,Capacidad,Numero,IdAsignatura,Observaciones) ");
                        sql.AppendFormat("VALUES ({0},{1},{2},{3},{4},'{5}');", this.Id, this.IdProfesor.ToString(), this.Capacidad.ToString(), this.Numero.ToString(), this.IdAsignatura.ToString(), this.Observaciones);
                        //
                        if (sqlman.insertar(sql.ToString()))
                        {
                            foreach (Horario item in Horarios)
                            {
                                if (!(item.Registrar().Error))
                                {
                                    error.Error = false;
                                    error.Mensaje = "Se ha registrado una nueva sección satisfactoriamente";
                                }
                                else
                                {
                                    error.Error = true;
                                    error.Mensaje = "Error al insertar registro en la base de datos";
                                }
                            }
                        }
                        else
                        {
                            error.Error = true;
                            error.Mensaje = "Error al insertar registro en la base de datos";
                        }
                    }
                    else
                    {
                        error.Error = true;
                        error.Mensaje = "No se ha podido registrar la nueva sección por conflictos con otros horarios del mismo profesor seleccionado";
                    }    
                }
                else
                {
                    error.Error = true;
                    error.Mensaje = "No se ha podido registrar la nueva sección por conflictos con horarios de otras secciones";
                }
            }
            else
            {
                error.Error = true;
                error.Mensaje = "Ya existe este número de sección para ésta asignatura";
            }      
            return error;
        }
        /// <summary>
        /// 
        /// </summary>
        List<Horario> validarProfesorHorario()
        {
            List<Horario> liHorariosEnConflictos = new List<Horario>();
            //
            foreach (Horario item in Horarios)
            {
                List<Horario> liHorariosTmp = new List<Horario>();
                liHorariosTmp = item.obtenerPorDiaProfesor(this.IdProfesor);
                if (liHorariosTmp.Count > 0)
                {
                    foreach (Horario h in liHorariosTmp)
                    {
                        if (Utiles.hayConflictos(item,h))
                        {
                            liHorariosEnConflictos.Add(h);
                        }
                    }
                }
            }
            horariosEnConflictos = liHorariosEnConflictos;
            return liHorariosEnConflictos;
        }
        /// <summary>
        /// Obtiene los horarios para la seccion desde la base de datos
        /// </summary>
        public void ObtenerHorarios()
        { 
            HorarioSeccion hs = new HorarioSeccion();
            hs.IdSeccion = this.Id;
            Horarios = hs.obtenerHorariosPor(Utiles.DbOptionSelect.PorSeccion);
        }
        /// <summary>
        /// 
        /// </summary>
        void asignarIdSeccionHorarios()
        {
            foreach (Horario item in Horarios)
            {
                if (this.Id > 0)
                {
                    item.IdSeccion = this.Id;
                }
            }
        }
        /// <summary>
        /// Devuelve una lista con los horarios que estan en conflictos
        /// </summary>
        /// <returns></returns>
        private List<Horario> validarConflictosHorarios()
        {
            List<Horario> liHorariosEnConflictos = new List<Horario>();            
            //
            foreach (Horario item in Horarios)
            {
                List<Horario> liHorariosTmp = new List<Horario>();
                liHorariosTmp = item.obtenerHorariosPor(Utiles.DbOptionSelect.PorVarios);
                if (liHorariosTmp.Count > 0)
                {
                    foreach (Horario h in liHorariosTmp)
                    {
                        if (Utiles.hayConflictos(item,h))
                        {
                            liHorariosEnConflictos.Add(h);
                        }                       
                    }
                }
            }
            horariosEnConflictos = liHorariosEnConflictos;
            return liHorariosEnConflictos;
        }
        /// <summary>
        /// Determina si ya existe un numero de seccion para la asignatura seleccionada
        /// </summary>
        /// <returns></returns>
        private bool validarNumeroSeccion()
        {
            bool r = true;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //
            if (this.Numero > 0 && this.IdAsignatura > 0)
            {
                if (this.Id > 0)
                {
                    sql.AppendFormat("SELECT Id from tblSeccion WHERE IdAsignatura = {0} AND Numero = {1} AND NOT Id = {2}", this.IdAsignatura.ToString(), this.Numero.ToString(), this.Id.ToString());
                }
                else
                    sql.AppendFormat("SELECT Id from tblSeccion WHERE IdAsignatura = {0} AND Numero = {1};", this.IdAsignatura.ToString(),this.Numero.ToString());
                if (sqlman.cargarReader(sql.ToString()))
                {
                    if (sqlman.reader.HasRows)
                    {
                        r = false;
                    }
                    sqlman.reader.Close();
                }
            }
            return r;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool buscarPorId(Utiles.DbOptionSelect opcion)
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            if (opcion == Utiles.DbOptionSelect.Basico)
            {
                sql.AppendFormat("SELECT IdProfesor,Numero, IdAsignatura,Capacidad from tblSeccion WHERE Id = {0}  AND Activo = 1", this.Id);
            }
            else if (opcion == Utiles.DbOptionSelect.Todo)
            {
                sql.AppendFormat("SELECT IdProfesor, Capacidad, Numero, IdAsignatura, Observaciones from tblSeccion WHERE Id = {0} AND Activo = 1", this.Id);
            }   
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                if (sqlman.reader.HasRows)
                {
                    if (sqlman.reader.Read())
                    {
                        this.IdProfesor = Convert.ToInt32(sqlman.reader["IdProfesor"].ToString());
                        this.IdAsignatura = Convert.ToInt32(sqlman.reader["IdAsignatura"].ToString());
                        this.Numero = Convert.ToInt32(sqlman.reader["Numero"].ToString());
                        this.Capacidad = Convert.ToInt32(sqlman.reader["Capacidad"].ToString());
                        //
                        if (opcion == Utiles.DbOptionSelect.Todo)
                        {                          
                            this.Observaciones = sqlman.reader["Observaciones"].ToString();
                        }
                        this.ObtenerHorarios();
                        r = true;
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
        public bool asignarID()
        {
            bool r = false;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.Append("SELECT MAX(Id) UltimaId FROM tblSeccion");
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
        /// Busca asignaturas para las cuales hay secciones abiertas
        /// </summary>
        /// <returns></returns>
        public DataTable buscarAsignaturas(string palabra_clave)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT tblAsignatura.Clave, tblAsignatura.Descripcion, tblAsignatura.Creditos, tblSeccion.Numero AS Seccion, tblSeccion.Id as IdSeccion ");
            sql.Append("FROM tblAsignatura,tblSeccion ");
            sql.AppendFormat("WHERE (tblAsignatura.Clave LIKE '%{0}%' OR tblAsignatura.Descripcion LIKE '%{0}%') AND  tblAsignatura.Id = tblSeccion.IdAsignatura AND tblAsignatura.Activo = 1 AND tblSeccion.Activo = 1",palabra_clave);
            SqlMan sqlman = new SqlMan();
            return sqlman.ObtenerTabla(sql.ToString());      
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ParError Actualizar()
        {
            asignarIdSeccionHorarios();
            ParError error = new ParError();
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            //  
            error.Error = true;
            sql.AppendFormat("UPDATE tblSeccion SET IdProfesor = {0},Capacidad = {1},Numero = {2},IdAsignatura = {3},Observaciones = '{4}' WHERE Id = {5} ",this.IdProfesor.ToString(), this.Capacidad.ToString(), this.Numero.ToString(), this.IdAsignatura.ToString(), this.Observaciones,this.Id);
            //
            if (validarNumeroSeccion())
            {
                if (!(validarConflictosHorarios().Count > 0))
                {
                    if (validarProfesorHorario().Count == 0)
                    {
                        if (sqlman.actualizar(sql.ToString()))
                        {
                            Utiles.BorarHorarios(this.Id);
                            foreach (Horario item in Horarios)
                            {
                                if (!(item.Registrar().Error))
                                {
                                    error.Error = false;
                                    error.Mensaje = "Se han actualizado los datos de la sección satisfactoriamente";
                                }
                                else
                                {
                                    error.Mensaje = "Error al actualizar los datos de la sección";
                                }
                            }
                        }
                    }
                    else
                    {
                        error.Mensaje = "No se han podido actualizar los datos la sección por conflictos con otros horarios del mismo profesor seleccionado";
                    }                       
                }
                else
                {
                    error.Mensaje = "No se han podido actualizar los datos la sección por conflictos con horarios de otras secciones";
                }
            }
            else
            {
                error.Mensaje = "Ya existe este número de sección para ésta asignatura";
            }
            //
            return error;
        }
        /// <summary>
        /// Obtiene la cantidad de estudiantes inscritos en la seccion
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadInscritos()
        {
            int r = 0;
            StringBuilder sql = new StringBuilder();
            SqlMan sqlman = new SqlMan();
            sql.AppendFormat("SELECT COUNT(IdSeccion) AS CantInscritos FROM tblDetalleInscripcion WHERE IdSeccion = {0}",this.Id);
            //
            if (sqlman.cargarReader(sql.ToString()))
            {
                if (sqlman.reader.HasRows)
                {
                    if (sqlman.reader.Read())
                    {
                        r = Convert.ToInt32(sqlman.reader["CantInscritos"].ToString());
                    }
                }
                sqlman.reader.Close();
            }
            return r;
        }
    }
}

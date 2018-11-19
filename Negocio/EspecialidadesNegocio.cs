using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace Negocio
{
    public class EspecialidadesNegocio
    {
        AccesoDatos conexion = new AccesoDatos();
        Especialidades aux = new Especialidades();

        public void AgregarEspecialidad(string Especialidad_nueva) //agrega una nueva especialidad a la tabla
        {
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "insert into Especialidades (Especialidad, FechaAlta, IdAdminAlta, FechaModif, IdAdminModif, Estado) values ('" + Especialidad_nueva + "', GETDATE(), 1, GETDATE(), 1, 1)";
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                    conexion.cerrarConexion();
            }
        }

        public IList<Especialidades> listarEspecialidades(int IdProfesional)
        {
            conexion = null;
            IList<Especialidades> lista = new List<Especialidades>();
            try
            {
                conexion = new AccesoDatos();
                string consulta = "select e.idexp, e.IdProfesional, e.IdEspecialidad, e.MatriculaNac, e.VtoMatNac, e.MatriculaProv, e.VtoMatProv, e.FechaAlta, e.IdAdminAlta, e.FechaModif, e.IdAdminModif, e.FechaBaja, e.IdAdminBaja, e.Estado, esp.Especialidad from EspecialidadXProf as e inner join Especialidades as esp on e.IdEspecialidad=esp.IdEspecialidad where e.IdProfesional=" + IdProfesional;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Especialidades();
                    aux.IdEspXProf = (int)conexion.Lector[0];
                    aux.IdProfesional = (int)conexion.Lector[1];
                    aux.IdEspecialidad = (int)conexion.Lector[2];
                    if(!conexion.Lector.IsDBNull(3)) aux.MatriculaNac = conexion.Lector.GetString(3);
                    if(!conexion.Lector.IsDBNull(4))aux.FechaVtoNac = (DateTime)conexion.Lector[4];
                    if(!conexion.Lector.IsDBNull(5))aux.MatriculaProv = conexion.Lector.GetString(5);
                    if(!conexion.Lector.IsDBNull(6)) aux.FechaVtoProv = (DateTime)conexion.Lector[6];
                    aux.FechaAlta = (DateTime)conexion.Lector[7];
                    aux.IdUsuarioAlta = (int)conexion.Lector[8];
                    aux.FechaModif = (DateTime)conexion.Lector[9];
                    aux.IdUsuarioModif = (int)conexion.Lector[10];
                    if(!conexion.Lector.IsDBNull(11))aux.FechaBaja = (DateTime)conexion.Lector[11];
                    if(!conexion.Lector.IsDBNull(12)) aux.IdUsuarioBaja = (int)conexion.Lector[12];
                    aux.Estado = (bool)conexion.Lector[13];
                    aux.Especialidad = conexion.Lector.GetString(14);
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void AgregarEspecialidadProfesional(Especialidades aux) //agrega una especialidad al profesional
        {
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "insert into EspecialidadXProf (IdProfesional,IdEspecialidad,MatriculaNac,VtoMatNac,MatriculaProv,VtoMatProv,FechaAlta,IdAdminAlta,FechaModif,IdAdminModif,Estado) values(" + aux.IdProfesional + ", " + aux.IdEspecialidad;

                if (aux.MatriculaNac.Length > 0) consulta = consulta + ", '" + aux.MatriculaNac + "', '" + aux.FechaVtoNac.ToString("yyyy/MM/dd") + "'";
                else consulta = consulta + ", null, null";

                if (aux.MatriculaProv.Length > 0) consulta = consulta + ", '" + aux.MatriculaProv + "', '" + aux.FechaVtoProv.ToString("yyyy/MM/dd") + "'";
                else consulta = consulta + ", null, null";

                consulta = consulta + ", GETDATE(), 1, GETDATE(), 1, 1)";
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();
            }
        }

        public void ModificarEspecialidadProfesional(Especialidades X)
        {
            aux = X;
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "update EspecialidadXProf set MatriculaNac=";

                if (aux.MatriculaNac.Length > 0) consulta = consulta + "'" + aux.MatriculaNac + "', VtoMatNac='" + aux.FechaVtoNac.ToString("yyyy/MM/dd") + "', ";
                else consulta = consulta + "null, VtoMatNac=null, ";

                if (aux.MatriculaProv.Length > 0) consulta = consulta + "MatriculaProv='" + aux.MatriculaProv + "', VtoMatProv='" + aux.FechaVtoProv.ToString("yyyy/MM/dd") + "', ";
                else consulta = consulta + "MatriculaProv=null, VtoMatProv=null, ";

                consulta = consulta + "FechaModif=GETDATE(), IdAdminModif=1, estado=1 where IdExP=" + aux.IdEspXProf;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();
            }
        }

        public void EliminarEspecialidadProfesional(int IdEspecialidadProfesional)
        {
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "update EspecialidadXProf set FechaModif=GETDATE(), IdAdminModif=1, FechaBaja=GETDATE(), IdAdminBaja=1, Estado=0 where IdExP=" + IdEspecialidadProfesional;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion != null) conexion.cerrarConexion();
            }
        }
    }
}

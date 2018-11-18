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

        public void AgregarEspecialidad(string Especialidad_nueva)
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
                string consulta = "SELECT EP.IdExP, E.Especialidad, EP.Estado FROM EspecialidadXProf AS EP INNER JOIN Especialidades AS E ON EP.IdEspecialidad=E.IdEspecialidad WHERE EP.IdProfesional=" + IdProfesional;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {

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
    }
}

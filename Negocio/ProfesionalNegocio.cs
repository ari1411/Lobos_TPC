using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class ProfesionalNegocio
    {
        public Profesional VerificarExiste(int ID)
        {
            Profesional aux = new Profesional();
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "select * from Profesionales where IdPersona=" + ID;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    aux.IdProfesional = (Int32)conexion.Lector[0];
                    aux.FechaAlta = (DateTime)conexion.Lector[2];
                    aux.IdUsuarioAlta = (Int32)conexion.Lector[3];
                    aux.FechaModif = (DateTime)conexion.Lector[4];
                    aux.IdUsuarioModif = (Int32)conexion.Lector[5];
                    if (!conexion.Lector.IsDBNull(6)) { aux.FechaBaja = (DateTime)conexion.Lector[6]; }
                    if (!conexion.Lector.IsDBNull(7)) { aux.IdUsuarioBaja = (Int32)conexion.Lector[7]; }
                    aux.Estado = (bool)conexion.Lector[8];
                }
                return aux;
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

        public void AgregarFuncionProfesional(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into Profesionales (IdProfesional, IdPersona,FechaAlta, IdAdminAlta, FechaModif, IdAdminModif, Estado) values (" + ID + ", " + ID + ", getdate() ,1,getdate(),1,1)";
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

        public void ActivarFuncionProfesional(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Profesionales set FechaModif=GETDATE(), IdAdminModif=1, Estado=1 where IdProfesional=" + ID;
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

        public void EliminarFuncionProfesional(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Profesionales set FechaModif=GETDATE(), IdAdminModif=1, FechaBaja=GETDATE(), IdAdminBaja=1, Estado=0 where IdProfesional=" + ID;
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
    }
}

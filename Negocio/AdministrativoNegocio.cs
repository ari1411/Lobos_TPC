using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AdministrativoNegocio
    {
        public Administrativo VerificarExiste(int ID)
        {
            Administrativo aux=new Administrativo();
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "select * from Administrativos where IdPersona=" + ID;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    aux.IdAdministrativo = (Int32)conexion.Lector[0];
                    aux.IdCargo = (Int32)conexion.Lector[2];
                    aux.Sector = conexion.Lector.GetString(3);
                    aux.FechaAlta = (DateTime)conexion.Lector[4];
                    aux.IdUsuarioAlta = (Int32)conexion.Lector[5];
                    aux.FechaModif = (DateTime)conexion.Lector[6];
                    aux.IdUsuarioModif = (Int32)conexion.Lector[7];
                    if (!conexion.Lector.IsDBNull(8)) { aux.FechaBaja = (DateTime)conexion.Lector[8]; }
                    if (!conexion.Lector.IsDBNull(9)) { aux.IdUsuarioBaja = (Int32)conexion.Lector[9]; }
                    aux.Estado = (bool)conexion.Lector[10];
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

        public void AgregarFuncionAdministrativo(int ID, int idCargo, string Sector)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into Administrativos (IdAdmin, IdPersona, IdCargo, Sector, FechaAlta, IdAdminAlta, FechaModif, IdAdminModif, Estado) values (" + ID + ", " + ID + ", " + idCargo + ", '" + Sector.ToString() + "', getdate() ,1,getdate(),1,1)";

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
        /*
        public void EditarFuncionPaciente(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Pacientes set FechaModif=GETDATE(), IdAdminModif=1, Estado=1 where IdPaciente=" + ID;
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

        public void EliminarFuncionPaciente(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Pacientes set FechaModif=GETDATE(), IdAdminModif=1, FechaBaja=GETDATE(), IdAdminBaja=1, Estado=0 where IdPaciente=" + ID;
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
        }*/
    }
}

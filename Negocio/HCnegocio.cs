using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class HCnegocio
    {
        private HC aux;
        private IList<HC> lista = new List<HC>();

        public IList<HC> cargar(int paciente)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "select h.IdHistoriaClinica,h.IdRazonSocial, h.IdPaciente, h.NumAfiliado, h.FechaVtoCarnet, h.Motivo, h.FechaAlta, h.IdAdmAlta, h.FechaModif, h.IdAdmModif, h.FechaBaja, h.IdAdmBaja, h.IdEstado, p.Apellido, (select rs.RazonSocialPlan from RazonesSociales as rs where h.IdRazonSocial=rs.IdRazonSocial) from HistoriaClinica as h inner join Personas as p on h.IdAdmAlta=p.IdPersona where IdPaciente=" + paciente + " and p.estado=1 and h.Idestado=9";
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new HC();
                    aux.IdHC = (int)conexion.Lector[0];
                    aux.IdRazonSocial = (int)conexion.Lector[1];
                    aux.IdPaciente = (int)conexion.Lector[2];
                    if (!conexion.Lector.IsDBNull(3)) aux.NumeroAfiliado = conexion.Lector.GetString(3);
                    if (!conexion.Lector.IsDBNull(4)) aux.FechaVencimientoCarnet = (DateTime)conexion.Lector[4];
                    aux.DescripcionAccidente = conexion.Lector.GetString(5);
                    aux.FechaHrAlta = (DateTime)conexion.Lector[6];
                    aux.IdAdminAlta = (int)conexion.Lector[7];
                    aux.FechaHrModif = (DateTime)conexion.Lector[8];
                    aux.IdAdminModif = (int)conexion.Lector[9];
                    if (!conexion.Lector.IsDBNull(10)) aux.FechaHrBaja = (DateTime)conexion.Lector[10];
                    if (!conexion.Lector.IsDBNull(11)) aux.IdAdminBaja = (int)conexion.Lector[11];
                    aux.Estado = (int)conexion.Lector[12];
                    aux.Ingresante = conexion.Lector.GetString(13);
                    aux.RazonSocial = conexion.Lector.GetString(14);

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
                    conexion.cerrarConexion();
            }
        }

        public void editarHC(HC historiaClinicaEditada)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "update historiaclinica set IdRazonSocial=" + historiaClinicaEditada.IdRazonSocial + ",NumAfiliado='" + historiaClinicaEditada.NumeroAfiliado + "',FechaVtoCarnet='" + historiaClinicaEditada.FechaVencimientoCarnet.ToString("yyyy/MM/dd") + "',Motivo='" + historiaClinicaEditada.DescripcionAccidente + "',FechaModif=GETDATE(),IdAdmModif=1,IdEstado=" + historiaClinicaEditada.Estado + " where idhistoriaclinica=" + historiaClinicaEditada.IdHC;
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

        public void eliminar(int IdHC, int idAdminElimina)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update HistoriaClinica set FechaBaja=GETDATE(), IdAdmBaja=" + idAdminElimina + ", IdEstado=0 where IdHistoriaClinica=" + IdHC;
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

        public IList<HC> cargarHCactivas(int idpaciente)
        {
            try
            {
                AccesoDatos conexion = new AccesoDatos();
                string consulta = "select hc.IdHistoriaClinica, rs.RazonSocialPlan, hc.NumAfiliado, hc.FechaVtoCarnet , hc.Motivo, hc.FechaAlta, p.Apellido from HistoriaClinica as hc inner join RazonesSociales as rs on hc.IdRazonSocial=rs.IdRazonSocial inner join Personas as p on hc.IdAdmAlta=p.IdPersona where hc.IdPaciente=" + idpaciente + " and hc.IdEstado=9";
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    aux = new HC();
                    aux.IdHC = (int)conexion.Lector[0];
                    aux.RazonSocial = conexion.Lector.GetString(1);
                    aux.NumeroAfiliado = conexion.Lector.GetString(2);
                    aux.FechaVencimientoCarnet = (DateTime)conexion.Lector[3];
                    aux.DescripcionAccidente = conexion.Lector.GetString(4);
                    aux.FechaHrAlta = (DateTime)conexion.Lector[5];
                    aux.Ingresante = conexion.Lector.GetString(6);


                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

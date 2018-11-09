using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class HCnegocio
    {
        private HC aux;

        private IList<HC> lista=new List<HC>();

        public IList<HC> cargar(Paciente paciente)
        {
            AccesoDatos conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "select h.IdHistoriaClinica,h.IdRazonSocial, h.IdPaciente, h.NumAfiliado, h.FechaVtoCarnet, h.Motivo, h.FechaAlta, h.IdAdmAlta, h.FechaModif, h.IdAdmModif, h.FechaBaja, h.IdAdmBaja, h.Estado, p.Apellido from HistoriaClinica as h left join Personas as p on h.IdAdmAlta=p.IdPersona where IdPaciente=" + paciente.IdPaciente;
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
                    aux.Estado = (bool)conexion.Lector[12];
                    aux.Ingresante = conexion.Lector.GetString(13);

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class PacienteNegocio
    {

        public IList<Paciente> Listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            IList<Paciente> lista = new List<Paciente>();
            Paciente aux;

            try
            {
                conexion.ConnectionString = "initial catalog= LOBOS_DB; data source=.; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT P.IDPERSONA, P.DNI, P.APELLIDO, P.NOMBRE, P.SEXO, P.FechaNac, PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto, M.MUNICIPIO, M.CP, P.TelCelular, P.TelFijo, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado FROM Personas AS P LEFT JOIN Municipios AS M ON P.IDMUNICIPIO=M.IDMUNICIPIO LEFT JOIN Administrativos AS A ON P.IdPersona=A.IDPERSONA LEFT JOIN Paises AS PA ON P.Nacionalidad=PA.IdPais";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Paciente();
                    aux.Id = (Int32)lector[0];
                    aux.Dni = (Int32)lector[1];
                    aux.Apellido = lector.GetString(2);
                    aux.Nombre = lector.GetString(3);
                    aux.Sexo = (bool)lector[4];
                    aux.FechaNac = (DateTime)lector[5];
                    if (aux.Sexo) { aux.Nacionalidad = lector.GetString(6); } else { aux.Nacionalidad = lector.GetString(7); }
                    if (!lector.IsDBNull(8)) { aux.Calle = lector.GetString(8); }
                    if (!lector.IsDBNull(9)) { aux.Altura = (Int32)lector[9]; }
                    if (!lector.IsDBNull(10)) { aux.Piso = lector.GetString(10); }
                    if (!lector.IsDBNull(11)) { aux.Dpto = lector.GetString(11); }
                    if (!lector.IsDBNull(12)) { aux.Municipio = lector.GetString(12); }
                    if (!lector.IsDBNull(13)) { aux.CP = (Int32)lector[13]; }
                    if (!lector.IsDBNull(14)) { aux.TelCelular = (Int32)lector[14]; }
                    if (!lector.IsDBNull(15)) { aux.TelFijo = (Int32)lector[15]; }
                    aux.FechaAlta = (DateTime)lector[16];
                    aux.IdUsuarioAlta = (Int32)lector[17];
                    aux.FechaModif = (DateTime)lector[18];
                    aux.IdUsuarioModif = (Int32)lector[19];
                    if (!lector.IsDBNull(20)) { aux.FechaBaja = (DateTime)lector[20]; }
                    if (!lector.IsDBNull(21)) { aux.IdUsuarioBaja = (Int32)lector[21]; }
                    aux.Estado = (bool)lector[22];
                    
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
                lector = null;
                conexion.Close();
            }

        }
    }
}

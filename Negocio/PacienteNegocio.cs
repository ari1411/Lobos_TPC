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
                comando.CommandText = "Select P.IdPersona, P.DNI, P.Apellido, P.Nombre, S.Sexo, P.FechaNac, PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto,Part.Partido, M.Municipio, M.CP, P.TelCelular, P.TelFijo, P.Mail, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado, p.IdMunicipio, p.IdNacionalidad, PA.Nacionalidad, P.IDSEXO From Personas as P LEFT JOIN Municipios as M on P.IdMunicipio=M.IdMunicipio LEFT JOIN Administrativos as A on P.IdPersona=A.IdPersona LEFT JOIN Paises as PA on P.IdNacionalidad=PA.IdPais LEFT JOIN Partidos as PART on M.IdPartido=PART.IdPartido LEFT JOIN Sexo as S on P.IdSexo=S.IdSexo where P.Estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Paciente();
                    aux.Id = (Int32)lector[0];
                    aux.Dni = lector.GetString(1);
                    aux.Apellido = lector.GetString(2);
                    aux.Nombre = lector.GetString(3);
                    aux.Sexo = lector.GetString(4);
                    aux.IdSexo = (Int32)lector[28];
                    aux.FechaNacimiento = (DateTime)lector[5];
                    if (aux.IdSexo==1) { aux.Nacionalidad = lector.GetString(6); } else if (aux.IdSexo==2) { aux.Nacionalidad = lector.GetString(7); } else { aux.Nacionalidad = lector.GetString(27); }
                    if (!lector.IsDBNull(8)) { aux.Calle = lector.GetString(8); }
                    if (!lector.IsDBNull(9)) { aux.Altura = lector.GetString(9); }
                    if (!lector.IsDBNull(10)) { aux.Piso = lector.GetString(10); }
                    if (!lector.IsDBNull(11)) { aux.Dpto = lector.GetString(11); }
                    if (!lector.IsDBNull(12)) { aux.Partido = lector.GetString(12); }
                    if (!lector.IsDBNull(13)) { aux.Municipio = lector.GetString(13); }
                    if (!lector.IsDBNull(14)) { aux.CP = lector.GetString(14); }
                    if (!lector.IsDBNull(15)) { aux.TelCelular = lector.GetString(15); }
                    if (!lector.IsDBNull(16)) { aux.TelFijo = lector.GetString(16); }
                    if (!lector.IsDBNull(17)) { aux.Mail = lector.GetString(17); }
                    aux.FechaAlta = (DateTime)lector[18];
                    aux.IdUsuarioAlta = (Int32)lector[19];
                    aux.FechaModif = (DateTime)lector[20];
                    aux.IdUsuarioModif = (Int32)lector[21];
                    if (!lector.IsDBNull(22)) { aux.FechaBaja = (DateTime)lector[22]; }
                    if (!lector.IsDBNull(23)) { aux.IdUsuarioBaja = (Int32)lector[23]; }
                    aux.Estado = (bool)lector[24];
                    aux.IdMunicipio = (Int32)lector[25];
                    aux.IdNacionalidad = (Int32)lector[26];
                    
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

        public void Alta(Paciente nuevo)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            string valores = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "INSERT INTO Personas (DNI, APELLIDO, NOMBRE, IDSEXO, FECHANAC, IDNACIONALIDAD, CALLE, NUMERO, IDMUNICIPIO, ";
                valores = " values (" + nuevo.Dni + ",'" + nuevo.Apellido.ToString() + "','" + nuevo.Nombre.ToString() + "'," + nuevo.IdSexo + ",'" + nuevo.FechaNacimiento.ToString("yyyy/MM/dd") + "'," + nuevo.IdNacionalidad + ",'" + nuevo.Calle.ToString() + "'," + nuevo.Altura + "," + nuevo.IdMunicipio;

                if (nuevo.Piso.ToString() != "")
                {
                    consulta = consulta + "PISO, ";
                    valores = valores + ",'" + nuevo.Piso.ToString() + "'";
                }
                    
                if (nuevo.Dpto.ToString() != "")
                {
                    consulta = consulta + "DEPTO, ";
                    valores = valores + ",'" + nuevo.Dpto.ToString() + "'";
                }
                    
                if (nuevo.TelCelular.ToString() != "")
                {
                    consulta = consulta + "TELCELULAR, ";
                    valores = valores + ",'" + nuevo.TelCelular.ToString() + "'";
                }
                    
                if (nuevo.TelFijo.ToString() != "")
                {
                    consulta = consulta + "TELFIJO, ";
                    valores = valores + ",'" + nuevo.TelFijo.ToString() + "'";
                }
                    
                if (nuevo.Mail.ToString() != "")
                {
                    consulta = consulta + "MAIL, ";
                    valores = valores + ",'" + nuevo.Mail.ToString() + "'";
                }


                consulta = consulta + "FECHAALTA, IDADMINALTA, FECHAMODIF, IDADMINMODIF, ESTADO)";
                consulta = consulta + valores + ",GETDATE()," + nuevo.IdUsuarioAlta + ",GETDATE()," + nuevo.IdUsuarioModif + ",1)";

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

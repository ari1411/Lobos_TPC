﻿using System;
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

        public IList<Paciente> Buscar(string DNI, string APELLIDO="", string NOMBRE="")
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
                comando.CommandText = "Select P.IdPersona, P.DNI, P.Apellido, P.Nombre, S.Sexo, P.FechaNac, PA.NacionalidadM, PA.NacionalidadF, P.Calle, P.Numero, P.Piso, P.Depto,Part.Partido, M.Municipio, M.CP, P.TelCelular, P.TelFijo, P.Mail, P.FechaAlta, P.IdAdminAlta, P.FechaModif, P.IdAdminModif, P.FechaBaja, P. IdAdminBaja, P.Estado, p.IdMunicipio, p.IdNacionalidad, PA.Nacionalidad, P.IDSEXO From Personas as P INNER JOIN Municipios as M on P.IdMunicipio=M.IdMunicipio INNER JOIN Pacientes as pte on P.IdPersona=pte.IdPersona INNER JOIN Paises as PA on P.IdNacionalidad=PA.IdPais INNER JOIN Partidos as PART on M.IdPartido=PART.IdPartido INNER JOIN Sexo as S on P.IdSexo=S.IdSexo where P.DNI like '%" + DNI + "%' and P.Apellido like '%" + APELLIDO + "%' and P.Nombre like '%" + NOMBRE + "%' and P.Estado=1 and pte.Estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Paciente();
                    aux.Id = (Int32)lector[0];
                    aux.IdPaciente = (Int32)lector[0];
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
                valores = " values ('" + nuevo.Dni + "','" + nuevo.Apellido.ToString() + "','" + nuevo.Nombre.ToString() + "'," + nuevo.IdSexo + ",'" + nuevo.FechaNacimiento.ToString("yyyy/MM/dd") + "'," + nuevo.IdNacionalidad + ",'" + nuevo.Calle.ToString() + "'," + nuevo.Altura + "," + nuevo.IdMunicipio;

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
                consulta = consulta + valores + ",GETDATE()," + nuevo.IdUsuarioAlta + ",GETDATE()," + nuevo.IdUsuarioModif + ",1) SELECT CAST(scope_identity() AS int)";

                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                nuevo.Id = conexion.ejecutarAccionReturn();
                consulta = "insert into pacientes (IdPaciente, IdPersona,FechaAlta, IdAdminAlta, FechaModif, IdAdminModif, Estado) values (" + nuevo.Id + ", " + nuevo.Id + ", getdate() ,1,getdate(),1,1)";
                conexion.setearConsulta(consulta);
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

        public void Modificar(Paciente modif)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Personas set ";
                consulta = consulta + "dni='" + modif.Dni.ToString();
                consulta = consulta + "', apellido='" + modif.Apellido.ToString();
                consulta = consulta + "', nombre='" + modif.Nombre.ToString();
                consulta = consulta + "', idsexo=" + modif.IdSexo;
                consulta = consulta + ", fechanac='" + modif.FechaNacimiento.ToString("yyyy/MM/dd");
                consulta = consulta + "', idnacionalidad=" + modif.IdNacionalidad;
                consulta = consulta + ", calle='" + modif.Calle.ToString();
                consulta = consulta + "', numero='" + modif.Altura.ToString();
                consulta = consulta + "', idmunicipio=" + modif.IdMunicipio;
                
                if (modif.Piso.ToString() != "")
                {
                    consulta = consulta + ", piso='" + modif.Piso.ToString() + "'";
                }else consulta = consulta + ", piso=null";

                if (modif.Dpto.ToString() != "")
                {
                    consulta = consulta + ", depto='" + modif.Dpto.ToString() + "'";
                }else consulta = consulta + ", depto=null";

                if (modif.TelCelular.ToString() != "")
                {
                    consulta = consulta + ", telcelular='" + modif.TelCelular.ToString() + "'";
                }else consulta = consulta + ", telcelular=null";

                if (modif.TelFijo.ToString() != "")
                {
                    consulta = consulta + ", telfijo='" + modif.TelFijo.ToString() + "'";
                }else consulta = consulta + ", telfijo=null";

                if (modif.Mail.ToString() != "")
                {
                    consulta = consulta + ", mail='" + modif.Mail.ToString() + "'";
                }else consulta = consulta + ", mail=null";

                consulta = consulta + ", fechamodif=GETDATE(), IDADMINMODIF=" + modif.IdUsuarioModif + ", ESTADO=1";
                consulta = consulta + " where IdPersona=" + modif.Id;
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

        public void Eliminar(int ID, int IdAdminElimina)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "update Pacientes set FechaBaja=GETDATE(), IdAdminBaja=" + IdAdminElimina + ", Estado=0 where IdPaciente=" + ID;
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

        public Paciente VerificarExiste(int ID)
        {
            Paciente aux = new Paciente();
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "select * from Pacientes where IdPersona=" + ID;
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux.IdPaciente = (Int32)conexion.Lector[0];
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

        public void AgregarFuncionPaciente(int ID)
        {
            AccesoDatos conexion = null;
            string consulta = "";
            try
            {
                conexion = new AccesoDatos();
                consulta = "insert into pacientes (IdPaciente, IdPersona,FechaAlta, IdAdminAlta, FechaModif, IdAdminModif, Estado) values (" + ID + ", " + ID + ", getdate() ,1,getdate(),1,1)";

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
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EvolucionNegocio
    {
        AccesoDatos conexion = new AccesoDatos();
        Evolucion aux = new Evolucion();

        public IList<Evolucion> Buscar(int ModoEstado, int ModoBuscar, int idPte, int idHC, int idAdm, int idProf, int idEvol)
        {
            conexion = null;
            IList<Evolucion> lista = new List<Evolucion>();
            try
            {
                conexion = new AccesoDatos();
                string consulta = "select e.IdEvolucion, e.IdPaciente, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where e.IdPaciente = pers.idpersona), e.IdAdmin, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where e.IdAdmin = pers.idpersona), e.IdProfesional, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where e.IdProfesional = pers.idpersona), e.IdEspecialidad, esp.Especialidad, e.IdHistoriaClinica, e.IdTurno, e.Evolucion, e.FechaAlta, e.FechaModif, e.IdAdminModif, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where e.IdAdminModif = pers.idpersona), e.FechaBaja, e.IdAdminBaja, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where e.IdAdminBaja = pers.idpersona), e.Estado from Evoluciones as e inner join Especialidades as esp on e.IdEspecialidad=esp.IdEspecialidad where";

                if (ModoBuscar == 1)
                {
                    consulta = consulta + " e.IdPaciente=" + idPte;
                }
                else if (ModoBuscar == 2)
                {
                    consulta = consulta + " e.IdHistoriaClinica=" + idHC;
                }
                else if (ModoBuscar == 3)
                {
                    consulta = consulta + " e.IdAdmin=" + idAdm;
                }
                else if (ModoBuscar == 4)
                {
                    consulta = consulta + " e.IdProfesional=" + idProf;
                }
                else if (ModoBuscar == 5)
                {
                    consulta = consulta + " e.IdEvolucion=" + idEvol;
                }


                if (ModoBuscar > 0 & ModoEstado < 2) consulta += " and";


                if (ModoEstado == 0)
                {
                    consulta = consulta + " e.Estado=0";
                }
                else if (ModoEstado == 1)
                {
                    consulta = consulta + " e.Estado=1";
                }

                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Evolucion();
                    aux.IdEvolucion = (Int32)conexion.Lector[0];
                    aux.IdPaciente = (Int32)conexion.Lector[1];
                    aux.Paciente = conexion.Lector.GetString(2);
                    if (!conexion.Lector.IsDBNull(3)) aux.IdAdministrativo = (Int32)conexion.Lector[3];
                    if (!conexion.Lector.IsDBNull(4)) aux.Administrativo = conexion.Lector.GetString(4);
                    if (!conexion.Lector.IsDBNull(5)) aux.IdProfesional = (Int32)conexion.Lector[5];
                    if (!conexion.Lector.IsDBNull(6)) aux.Profesional = conexion.Lector.GetString(6);
                    if (!conexion.Lector.IsDBNull(7)) aux.IdEspecialidad = (Int32)conexion.Lector[7];
                    if (!conexion.Lector.IsDBNull(8)) aux.Especialidad = conexion.Lector.GetString(8);
                    aux.IdHC = (Int32)conexion.Lector[9];
                    aux.IdTurno = (Int32)conexion.Lector[10];
                    aux.evolucion = conexion.Lector.GetString(11);
                    aux.FechaHrAlta = (DateTime)conexion.Lector[12];
                    if (!conexion.Lector.IsDBNull(13)) aux.FechaHrModif = (DateTime)conexion.Lector[13];
                    if (!conexion.Lector.IsDBNull(14)) aux.IdAdminModif = (Int32)conexion.Lector[14];
                    if (!conexion.Lector.IsDBNull(15)) aux.AdminModif = conexion.Lector.GetString(15);
                    if (!conexion.Lector.IsDBNull(16)) aux.FechaHrBaja = (DateTime)conexion.Lector[16];
                    if (!conexion.Lector.IsDBNull(17)) aux.IdAdminBaja = (Int32)conexion.Lector[17];
                    if (!conexion.Lector.IsDBNull(18)) aux.AdminBaja = conexion.Lector.GetString(18);
                    aux.Estado = (bool)conexion.Lector[19];

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
                if (conexion != null) conexion.cerrarConexion();
            }
        }

        public void GrabarEvolucion(Evolucion X)
        {
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "insert into Evoluciones (IdPaciente, IdAdmin, IdProfesional, IdEspecialidad, IdHistoriaClinica, IdTurno, Evolucion, FechaAlta, Estado) values (" + X.IdPaciente + ", ";

                if (X.IdAdministrativo == 0)
                {
                    consulta = consulta + "null, ";
                }
                else consulta = consulta + X.IdAdministrativo + ", ";

                if (X.IdProfesional == 0)
                {
                    consulta = consulta + "null, null, ";
                }
                else consulta = consulta + X.IdProfesional + ", " + X.IdEspecialidad + ", ";

                consulta = consulta + X.IdHC + ", " + X.IdTurno + ", '" + X.evolucion + "', getdate(), 1)";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class TurnoNegocio
    {
        AccesoDatos conexion = new AccesoDatos();
        Turno aux = new Turno();
        
        public int crearAgenda(DateTime fechaHora, int cantidad, int min, int idProfesional, int idEspecialidad)
        {
            try
            {
                int creados = 0;

                while (cantidad > 0)
                {
                    crearTurno(fechaHora, idProfesional, idEspecialidad);
                    fechaHora = fechaHora.AddMinutes(min);
                    --cantidad;
                    ++creados;
                }
                return creados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int crearAgenda(DateTime fechaHora, DateTime HoraInicio, DateTime HoraFin, int min, int idProfesional, int idEspecialidad)
        {
            try
            {
                int creados = 0;

                while (HoraInicio < HoraFin)
                {
                    crearTurno(fechaHora, idProfesional, idEspecialidad);
                    HoraInicio = HoraInicio.AddMinutes(min); //mi intencion era hacerlo mas personalizado
                    fechaHora = fechaHora.AddMinutes(min);
                    ++creados;
                }
                return creados;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void crearTurno(DateTime fechaHoraTurno, int Profesional, int Especialidad)
        {
            conexion = null;
            try
            {
                conexion = new AccesoDatos();
                string consulta = "insert into Turnos (FechaHoraTurno, IdProfesional, idespecialidad, idestado) values('" + fechaHoraTurno.ToString("yyyy/MM/dd hh:MM:ss") + "'," + Profesional + "," + Especialidad + ",2)";
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

        public IList<Turno> buscar(DateTime fechaIni, DateTime fechaFin, int prof, int esp, int seleccion)
        {
            IList<Turno> listaTurno = new List<Turno>();
            conexion = null;
            fechaFin = fechaFin.AddDays(1);
            try
            {
                conexion = new AccesoDatos();
                string consulta = "select t.IdTurno, t.FechaHoraTurno, t.IdProfesional , (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdProfesional = pers.idpersona) as 'Profesional', t.IdEspecialidad, e.Especialidad, t.IdPaciente, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdPaciente = pers.idpersona) as 'Paciente', t.IdHistoriaClinica, t.FechaAsignado, t.IdAdminAsigna, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminAsigna = pers.idpersona) as 'Admin Alta', t.FechaLiberacion, t.IdAdminLibera, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminLibera = pers.idpersona) as 'Admin Libera', t.FechaCancelado, t.IdAdminCancela, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminCancela = pers.idpersona) as 'Adm Cancela', t.IdEstado, est.Estado from turnos as t inner join Profesionales as prof on t.IdProfesional=prof.IdProfesional inner join Especialidades as e on t.IdEspecialidad=e.IdEspecialidad inner join estados as est on est.idestado=t.IdEstado where '" + fechaIni.ToString("yyyy/MM/dd") + "'<=FechaHoraTurno and FechaHoraTurno<'" + fechaFin.ToString("yyyy/MM/dd") + "'";
                if (seleccion == 2)
                {
                    consulta = consulta + " and t.IdProfesional=" + prof;
                }else if (seleccion == 3)
                {
                    consulta = consulta + " and t.IdEspecialidad=" + esp;
                }
                conexion.setearConsulta(consulta);
                conexion.abrirConexion();
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    aux = new Turno();
                    aux.IdTurno = (Int32)conexion.Lector[0];
                    aux.FechaHoraTurno = (DateTime)conexion.Lector[1];
                    aux.IdProfesional = (Int32)conexion.Lector[2];
                    aux.Profesional = conexion.Lector.GetString(3);
                    aux.IdEspecialidad = (Int32)conexion.Lector[4];
                    aux.Especialidad = conexion.Lector.GetString(5);
                    if (!conexion.Lector.IsDBNull(6)) aux.IdPaciente = (Int32)conexion.Lector[6];
                    if (!conexion.Lector.IsDBNull(7)) aux.Paciente = conexion.Lector.GetString(7);
                    if (!conexion.Lector.IsDBNull(8)) aux.IdHC = (Int32)conexion.Lector[8];
                    if (!conexion.Lector.IsDBNull(9)) aux.FechaHoraAsignado = (DateTime)conexion.Lector[9];
                    if (!conexion.Lector.IsDBNull(10)) aux.IdUsuarioAsigna = (Int32)conexion.Lector[10];
                    if (!conexion.Lector.IsDBNull(11)) aux.UsuarioAsigna = conexion.Lector.GetString(11);
                    if (!conexion.Lector.IsDBNull(12)) aux.FechaHoraLiberado = (DateTime)conexion.Lector[12];
                    if (!conexion.Lector.IsDBNull(13)) aux.IdUsuarioLibera = (Int32)conexion.Lector[13];
                    if (!conexion.Lector.IsDBNull(14)) aux.UsuarioLibera = conexion.Lector.GetString(14);
                    if (!conexion.Lector.IsDBNull(15)) aux.FechaHoraCancelado = (DateTime)conexion.Lector[15];
                    if (!conexion.Lector.IsDBNull(16)) aux.IdUsuarioCancela = (Int32)conexion.Lector[16];
                    if (!conexion.Lector.IsDBNull(17)) aux.UsuarioCancela = conexion.Lector.GetString(17);
                    aux.IdEstado = (Int32)conexion.Lector[18];
                    aux.Estado = conexion.Lector.GetString(19);

                    listaTurno.Add(aux);
                }

                return listaTurno;
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

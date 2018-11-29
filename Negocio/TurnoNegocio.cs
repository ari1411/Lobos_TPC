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

        public IList<Turno> buscar(DateTime fechaIni, DateTime fechaFin, int prof, int esp, int seleccionRDB, int Estado = 0)
        {
            try
            {
                IList<Turno> listaTurno = new List<Turno>();
                conexion = null;
                fechaFin = fechaFin.AddDays(1);
                conexion = new AccesoDatos();
                string consulta = "select t.IdTurno, t.FechaHoraTurno, t.IdProfesional , (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdProfesional = pers.idpersona) as 'Profesional', t.IdEspecialidad, e.Especialidad, t.IdPaciente, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdPaciente = pers.idpersona) as 'Paciente', t.IdHistoriaClinica, t.Observaciones, t.FechaAsignado, t.IdAdminAsigna, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminAsigna = pers.idpersona) as 'Admin Asigna', t.FechaAdmitido, t.IdAdminAdmitio, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminAdmitio = pers.idpersona) as 'Admin Admitio', t.FechaLiberacion, t.IdAdminLibera, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminLibera = pers.idpersona) as 'Admin Libera', t.FechaCancelado, t.IdAdminCancela, (select pers.Apellido + ', ' + pers.Nombre from personas as pers where t.IdAdminCancela = pers.idpersona) as 'Adm Cancela', t.IdEstado, est.Estado, (select pers.DNI from personas as pers where t.IdPaciente = pers.idpersona) as 'dniPaciente', HC.Motivo, HC.FechaVtoCarnet, (select rs.RazonSocialPlan from RazonesSociales as rs where HC.IdRazonSocial=rs.IdRazonSocial) from turnos as t inner join Profesionales as prof on t.IdProfesional=prof.IdProfesional inner join Especialidades as e on t.IdEspecialidad=e.IdEspecialidad inner join estados as est on est.idestado=t.IdEstado left join HistoriaClinica as HC on t.IdHistoriaClinica=HC.IdHistoriaClinica where '" + fechaIni.ToString("yyyy/MM/dd") + "'<=FechaHoraTurno and FechaHoraTurno<'" + fechaFin.ToString("yyyy/MM/dd") + "'";
                if (seleccionRDB == 2)
                {
                    consulta = consulta + " and t.IdProfesional=" + prof;
                }
                else if (seleccionRDB == 3)
                {
                    consulta = consulta + " and t.IdEspecialidad=" + esp;
                }
                if (Estado != 0)
                {
                    consulta = consulta + " and t.IdEstado=" + Estado;
                }
                consulta = consulta + " order by t.FechaHoraTurno asc, 'profesional' asc, e.Especialidad asc";
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
                    if (!conexion.Lector.IsDBNull(9)) aux.Observaciones = conexion.Lector.GetString(9);
                    if (!conexion.Lector.IsDBNull(10)) aux.FechaHoraAsignado = (DateTime)conexion.Lector[10];
                    if (!conexion.Lector.IsDBNull(11)) aux.IdUsuarioAsigna = (Int32)conexion.Lector[11];
                    if (!conexion.Lector.IsDBNull(12)) aux.UsuarioAsigna = conexion.Lector.GetString(12);
                    if (!conexion.Lector.IsDBNull(13)) aux.FechaHoraAdmitido = (DateTime)conexion.Lector[13];
                    if (!conexion.Lector.IsDBNull(14)) aux.IdUsuarioAdmitio = (Int32)conexion.Lector[14];
                    if (!conexion.Lector.IsDBNull(15)) aux.UsuarioAdmitio = conexion.Lector.GetString(15);
                    if (!conexion.Lector.IsDBNull(16)) aux.FechaHoraLiberado = (DateTime)conexion.Lector[16];
                    if (!conexion.Lector.IsDBNull(17)) aux.IdUsuarioLibera = (Int32)conexion.Lector[17];
                    if (!conexion.Lector.IsDBNull(18)) aux.UsuarioLibera = conexion.Lector.GetString(18);
                    if (!conexion.Lector.IsDBNull(19)) aux.FechaHoraCancelado = (DateTime)conexion.Lector[19];
                    if (!conexion.Lector.IsDBNull(20)) aux.IdUsuarioCancela = (Int32)conexion.Lector[20];
                    if (!conexion.Lector.IsDBNull(21)) aux.UsuarioCancela = conexion.Lector.GetString(21);
                    aux.IdEstado = (Int32)conexion.Lector[22];
                    aux.Estado = conexion.Lector.GetString(23);
                    if (!conexion.Lector.IsDBNull(24)) aux.DNI = conexion.Lector.GetString(24);
                    if (!conexion.Lector.IsDBNull(25)) aux.MotivoHC = conexion.Lector.GetString(25);
                    if (!conexion.Lector.IsDBNull(26)) aux.FechaVtoCarnet = (DateTime)conexion.Lector[26];
                    if (!conexion.Lector.IsDBNull(27)) aux.RazonSocial_Plan = conexion.Lector.GetString(27);

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
                string consulta = "insert into Turnos (FechaHoraTurno, IdProfesional, idespecialidad, idestado) values('" + fechaHoraTurno.ToString("yyyy/MM/dd HH:mm:ss") + "'," + Profesional + "," + Especialidad + ",2)";
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

        public void asignarTurno(int idPaciente, int idHistoriaClinica, int idTurno, string Obs)
        {
            try
            {
                TurnoNegocio turnNeg = new TurnoNegocio();
                conexion = null;
                conexion = new AccesoDatos();
                string consulta = "update Turnos set IdPaciente=" + idPaciente + ", IdHistoriaClinica=" + idHistoriaClinica + ", Observaciones='" + Obs + "' , FechaAsignado=GETDATE(), IdAdminAsigna=1, IdEstado=3 where IdTurno=" + idTurno;
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
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void admisionar(int idTurno, string observ, int idAdmin)
        {
            try
            {
                conexion = null;
                conexion = new AccesoDatos();
                string consulta = "update Turnos set Observaciones='" + observ + "', FechaAdmitido=GETDATE(), IdAdminAdmitio=" + idAdmin + ", IdEstado=6 where IdTurno=" + idTurno;
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
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void cancelar(int idTurno, string observ, int idAdmin)
        {
            try
            {
                conexion = null;
                conexion = new AccesoDatos();
                string consulta = "update Turnos set Observaciones='" + observ + "', FechaCancelado=GETDATE(), IdAdminCancela=" + idAdmin + ", IdEstado=1 where IdTurno=" + idTurno;
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
                {
                    conexion.cerrarConexion();
                }
            }
        }

        public void liberar(int idTurno, string observ, int idAdmin) // En este momento lo estoy dejando en estado disponible. Para dejarlo en liberado debe estar en idEstado=4
        {
            try
            {
                conexion = null;
                conexion = new AccesoDatos();
                string consulta = "update Turnos set IdPaciente=null, IdHistoriaClinica=null, Observaciones='" + observ + "', FechaAsignado=null, IdAdminAsigna=null, FechaAdmitido=null, IdAdminAdmitio=null, FechaLiberacion=GETDATE(), IdAdminLibera=" + idAdmin + ", FechaCancelado=null, IdAdminCancela=null, IdEstado=2 where IdTurno=" + idTurno;
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
                {
                    conexion.cerrarConexion();
                }
            }
        }
    }
}

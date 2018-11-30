using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Turno
    {
        public Int32 IdTurno { set; get; }
        public DateTime FechaHoraTurno { set; get; }
        public Int32 IdProfesional { set; get; }
        public string Profesional { set; get; }
        public Int32 IdEspecialidad { set; get; }
        public string Especialidad { set; get; }
        public Int32 IdPaciente { set; get; }
        public string Paciente { set; get; }
        public string DNI { set; get; }
        public Int32 IdHC { set; get; }
        public string MotivoHC { set; get; }
        public DateTime FechaVtoCarnet { set; get; }
        public string RazonSocial_Plan { set; get; }
        public string Observaciones { set; get; }
        public DateTime FechaHoraAsignado { set; get; }
        public Int32 IdUsuarioAsigna { set; get; }
        public string UsuarioAsigna { set; get; }
        public DateTime FechaHoraAdmitido { set; get; }
        public Int32 IdUsuarioAdmitio { set; get; }
        public string UsuarioAdmitio { set; get; }
        public DateTime FechaHoraLiberado { set; get; }
        public Int32 IdUsuarioLibera { set; get; }
        public string UsuarioLibera { set; get; }
        public DateTime FechaHoraCancelado { set; get; }
        public Int32 IdUsuarioCancela { set; get; }
        public string UsuarioCancela { set; get; }
        public Int32 IdEstado { set; get; }
        public string Estado { set; get; }
    }
}

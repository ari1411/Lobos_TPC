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
        public Int32 IdAdministrativo { set; get; }
        public Int32 IdProfesional { set; get; }
        public Int32 IdPaciente { set; get; }
        public Int32 IdHC { set; get; }
        public DateTime FechaHoraTurno { set; get; }
        public DateTime FechaHoraAsignado { set; get; }
        public Int32 IdUsuarioAsigna { set; get; }
        public DateTime FechaHoraLiberado { set; get; }
        public Int32 IdUsuarioLibera { set; get; }
        public DateTime FechaHoraCancelado { set; get; }
        public Int32 IdUsuarioCancela { set; get; }
        public bool Disponible { set; get; }
        public bool Eliminado { set; get; }
    }
}

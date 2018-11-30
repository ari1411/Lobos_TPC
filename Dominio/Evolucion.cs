using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Evolucion
    {
        public Int32 IdEvolucion { set; get; }
        public DateTime FechaHrAlta { set; get; }
        public Int32 IdAdministrativo { set; get; }
        public string Administrativo { set; get; }
        public Int32 IdProfesional { set; get; }
        public string Profesional { set; get; }
        public Int32 IdEspecialidad { set; get; }
        public string Especialidad { set; get; }
        public Int32 IdPaciente { set; get; }
        public string Paciente { set; get; }
        public Int32 IdHC { set; get; }
        public Int32 IdTurno { set; get; }
        public string evolucion { set; get; }
        public DateTime FechaHrModif { set; get; }
        public Int32 IdAdminModif { set; get; }
        public string AdminModif { set; get; }
        public DateTime FechaHrBaja { set; get; }
        public Int32 IdAdminBaja { set; get; }
        public string AdminBaja { set; get; }
        public bool Estado { set; get; }
    }
}

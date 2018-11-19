using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Especialidades
    {
        public Int32 IdEspXProf { set; get; }
        public Int32 IdProfesional { set; get; }
        public Int32 IdEspecialidad { set; get; }
        public string Especialidad { set; get; }
        public string MatriculaNac { set; get; }
        public DateTime FechaVtoNac { set; get; }
        public string MatriculaProv { set; get; }
        public DateTime FechaVtoProv { set; get; }
        public DateTime FechaAlta { set; get; }
        public Int32 IdUsuarioAlta { set; get; }
        public DateTime FechaModif { set; get; }
        public Int32 IdUsuarioModif { set; get; }
        public DateTime FechaBaja { set; get; }
        public Int32 IdUsuarioBaja { set; get; }
        public bool Estado { set; get; }
    }
}

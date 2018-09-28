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
        public Int32 IdProfesional { set; get; }
        public Int32 IdAdministrativo { set; get; }
        public string Texto { set; get; }
        public DateTime FechaHrAlta { set; get; }
        public Int32 IdAdminAlta { set; get; }
        public DateTime FechaHrBaja { set; get; }
        public Int32 IdAdminBaja { set; get; }
        public bool Estado { set; get; }
    }
}

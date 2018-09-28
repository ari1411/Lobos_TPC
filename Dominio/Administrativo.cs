using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Administrativo:Persona
    {
        public Int32 IdAdministrativo { set; get; }
        public string Cargo { set; get; }
        public string Sector { set; get; }
        public char Permisos { set; get; }
        public char Horarios { set; get; }
    }
}

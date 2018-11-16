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
        public Int32 IdCargo { set; get; }
        public string Sector { set; get; }
    }
}

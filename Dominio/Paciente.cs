using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Paciente:Persona
    {
        public Int32 IdPaciente { set; get; }
        public IList<HC> IdHC { set; get; }
    }
}

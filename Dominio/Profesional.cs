using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Profesional:Persona
    {
        public string IdProfesional { set; get; }
        public char Especialidades { set; get; }
    }
}

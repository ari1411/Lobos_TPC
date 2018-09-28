using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public Int32 Dni { set; get; }
        public string Apellido { set; get; }
        public string Nombre { set; get; }
        public bool Masculino { set; get; }
        public DateTime FechaNac { set; get; }
        public string Nacionalidad { set; get; }
        public Direccion IdDireccion { set; get; }
        public Int32 TelFijo { set; get; }
        public Int32 TelCelular { set; get; }
        public DateTime FechaAlta { set; get; }
        public Int32 IdUsuarioAlta { set; get; }
        public DateTime FechaModif { set; get; }
        public Int32 IdUsuarioModif { set; get; }
        public DateTime FechaBaja { set; get; }
        public Int32 IdUsuarioBaja { set; get; }
        public bool Estado { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class RazonSocial
    {
        public Int32 IdRazonSocial { set; get; }
        public string Nombre { set; get; }
        public Int32 CUIT { set; get; }
        public DateTime FechaAlta { set; get; }
        public Int32 IdUsuarioAlta { set; get; }
        public DateTime FechaModif { set; get; }
        public Int32 IdUsuarioModif { set; get; }
        public DateTime FechaBaja { set; get; }
        public Int32 IdUsuarioBaja { set; get; }
        public bool Estado { set; get; }
    }
}
